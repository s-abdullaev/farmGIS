using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace smsapp
{
    /// <summary>
    /// View model for user controller
    /// </summary>
    public class ContagionControllerViewModel : BaseViewModel
    {
        #region Private members
        private bool mIsPopupVisible = false;


        #endregion

        /// <summary>
        /// The users list
        /// </summary>
        public ObservableCollection<Contagion> Contagions { set; get; }

        /// <summary>
        /// Current user
        /// </summary>
        public Contagion CurrentContagion { set; get; }

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
                    Contagions = IoC.Database.GetContagions();
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
        public ContagionControllerViewModel(Contagion contagion)
        {
            CurrentContagion = contagion;
            IsEditing = true;
            Initialize();
        }
        public ContagionControllerViewModel()
        {
            CurrentContagion = new Contagion();
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
            Contagions = IoC.Database.GetContagions();
            AddUserCommand = new RelayCommand(async () =>
            {
                IsPopupVisible = true;
                PopupContent.PopupType = PopupType.Wait;
                await IoC.Database.AddContagionAsync(CurrentContagion);
                PopupContent.PopupType = PopupType.Success;
            });
            SaveEditsCommand = new RelayCommand(async () =>
            {
                if (CurrentContagion == null)
                    return;
                //TODO: Use some better approach :)
                PopupContent.PopupType = PopupType.Wait;
                IsPopupVisible = true;
                await IoC.Database.EditContagion(CurrentContagion);
                // Return everything to initial state
                PopupContent.PopupType = PopupType.Success;
            });
            CloseCommand = new RelayCommand(() =>
            {
                MainWindowViewModel.Instance.IsContagionControllerVisible = !MainWindowViewModel.Instance.IsContagionControllerVisible;
            });
            OkCommand = new RelayCommand(() =>
            {
                IsPopupVisible = false;
                Contagions = IoC.Database.GetContagions();
            });

        }
        #endregion
    }
}
