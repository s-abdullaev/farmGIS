﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace smsapp
{
    /// <summary>
    /// View model for user controller
    /// </summary>
    public class SoilReadingsControllerViewModel : BaseViewModel
    {
        #region Private members
        private bool mIsPopupVisible = false;


        #endregion

        /// <summary>
        /// The users list
        /// </summary>
        public ObservableCollection<SoilReadings> SoilReadings { set; get; }

        /// <summary>
        /// Current user
        /// </summary>
        public SoilReadings CurrentSoilReadings { set; get; }

        /// <summary>
        /// Flag for editing
        /// </summary>
        public bool IsEditing { set; get; }

        /// <summary>
        /// Flag indicating whether the popup should be shown or not
        /// </summary>
        public bool IsPopupVisible
        {
            set
            {
                if (!value)
                    SoilReadings = IoC.Database.GetSoilReadings();
                mIsPopupVisible = value;
            }
            get => mIsPopupVisible;
        }

        /// <summary>
        /// Type of the popup
        /// </summary>
        public PopupViewModel PopupContent { set; get; }

        #region Commands
        /// <summary>
        /// Adds the user
        /// </summary>
        public ICommand AddUserCommand { set; get; }

        /// <summary>
        /// The command to edit the user
        /// </summary>
        public ICommand EditUserCommand { set; get; }

        /// <summary>
        /// Save edits
        /// </summary>
        public ICommand SaveEditsCommand { set; get; }

        /// <summary>
        /// Close current window
        /// </summary>
        public ICommand CloseCommand { set; get; }

        /// <summary>
        /// Close current popup
        /// </summary>
        public ICommand OkCommand { set; get; }
        #endregion

        #region Constructors
        public SoilReadingsControllerViewModel(SoilReadings SoilReadings)
        {
            CurrentSoilReadings = SoilReadings;
            IsEditing = true;
            Initialize();
        }
        public SoilReadingsControllerViewModel()
        {
            CurrentSoilReadings = new SoilReadings();
            IsEditing = false;
            Initialize();
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Helper to initialize all commands
        /// </summary>
        private void Initialize()
        {
            PopupContent = new PopupViewModel();
            IsPopupVisible = false;
            SoilReadings = IoC.Database.GetSoilReadings();
            AddUserCommand = new RelayCommand(async () =>
            {
                IsPopupVisible = true;
                PopupContent.PopupType = PopupType.Wait;
                await IoC.Database.AddSoilReadingsAsync(CurrentSoilReadings);
                PopupContent.PopupType = PopupType.Success;
            });
            SaveEditsCommand = new RelayCommand(async () =>
            {
                if (CurrentSoilReadings == null)
                    return;
                //TODO: Use some better approach :)
                PopupContent.PopupType = PopupType.Wait;
                IsPopupVisible = true;
                await IoC.Database.EditSoilReadings(CurrentSoilReadings);
                // Return everything to initial state
                PopupContent.PopupType = PopupType.Success;
            });
            CloseCommand = new RelayCommand(() =>
            {
                MainWindowViewModel.Instance.IsSoilReadingsControllerVisible = !MainWindowViewModel.Instance.IsSoilReadingsControllerVisible;
            });
            OkCommand = new RelayCommand(() =>
            {
                IsPopupVisible = false;
                SoilReadings = IoC.Database.GetSoilReadings();
            });

        }
        #endregion
    }
}
