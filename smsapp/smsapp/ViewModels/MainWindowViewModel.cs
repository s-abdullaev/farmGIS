using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace smsapp
{
    public class MainWindowViewModel : BaseViewModel
    {

        #region Private members
        private Window mWindow;
        /// <summary>
        /// Margin around the window to allow dropshadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// Window radius
        /// </summary>
        #endregion

        #region Public properties

        /// <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsUserControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsContagionControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsDiseaseControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsGeopositionControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsPestControllerVisible { set; get; }

        // <summary>
        /// Flag for indicating whether user controller is visible or not
        /// </summary>
        public bool IsSoilReadingsControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether farm controller is visible or not
        /// </summary>
        public bool IsFarmControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether farm owner controller is visible or not
        /// </summary>
        public bool IsFarmOwnerControllerVisible { set; get; }

        /// <summary>
        /// Flag for indicating whether farm owner controller is visible or not
        /// </summary>
        public bool IsPlantControllerVisible { set; get; }

        public UserControllerViewModel UserControllerViewModel { set; get; }
        public FarmOwnerControllerViewModel FarmOwnerControllerViewModel { set; get; }
        public FarmControllerViewModel FarmControllerViewModel { set; get; }
        public PlantControllerViewModel PlantControllerViewModel { set; get; }
        public ContagionControllerViewModel ContagionControllerViewModel { set; get; }
        public DiseaseControllerViewModel DiseaseControllerViewModel { set; get; }
        public GeopositionControllerViewModel GeopositionControllerViewModel { set; get; }
        public PestControllerViewModel PestControllerViewModel { set; get; }
        public SoilReadingsControllerViewModel SoilReadingsControllerViewModel { set; get; }


        /// <summary>
        /// Singletone instance
        /// </summary>
        public static MainWindowViewModel Instance { set; get; }

        #region Design Properties
        /// <summary>
        /// Smallest heigjht
        /// </summary>
        public double WindowMinimumHeight { get; set; }

        /// <summary>
        /// Smallest heigjht
        /// </summary>
        public double WindowMinimumWidth { get; set; }

        /// <summary>
        /// The size of the Resize border
        /// </summary>
        public int ResizeBorder { get { return Borderless ? 0 : 6; } set { } }

        /// <summary>
        /// Thickness of resize border
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// Inner padding of main content
        /// </summary>
        public int MainWindowInnerPadding { get; set; }

        /// <summary>
        /// Inner padding of main content
        /// </summary>
        public Thickness MainContentInnerPaddingThickness { get { return new Thickness(MainWindowInnerPadding); } }

        /// <summary>
        /// Margin around window to allow dropshadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set { OuterMarginSize = value; }
        }

        /// <summary>
        /// Margin around window to allow dropshadow
        /// </summary>
        public Thickness OuterMarginThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// Height of the region that can drag the form
        /// </summary>
        public int TitleHeight { set; get; }

        /// <summary>
        /// Title height grid length of Title
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        /// <summary>
        /// Represents that if the window maximized it should be borderless
        /// </summary>
        public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized); } set { } }
        #endregion

        #endregion

        #region Default constructor

        public MainWindowViewModel(Window mWindow)
        {
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(("ResizeBorder"));
                OnPropertyChanged(("ResizeBorderThickness"));
                OnPropertyChanged(("OuterMarginSize"));
                OnPropertyChanged(("OuterMarginThickness"));
                OnPropertyChanged(("WindowRadius"));
                OnPropertyChanged(("WindowCornerRadius"));
            };

            WindowMinimumWidth = 800;
            TitleHeight = 42;
            MainWindowInnerPadding = 0;
            WindowMinimumHeight = 400;

            //Users = IoC.Database.GetUsers();
            IsUserControllerVisible = false;
            Instance = this;
            UserControllerViewModel = null;
            InitializeCommands(mWindow);

        }
        #endregion

        #region Commands

        /// <summary>
        /// Command for minimizing the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// Command for Maximizing window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// Commnad for exiting from the application
        /// </summary>
        public ICommand CloseCommand { get; set; }


        /// <summary>
        /// Command for opening edit user view/controller to edit the user
        /// </summary>
        public ICommand AddFarmOwnerCommand { get; set; }

        /// <summary>
        /// Command for opening edit user view/controller to add the user
        /// </summary>
        public ICommand AddUserCommand { get; set; }


        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddFarmCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddPlantCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddContagionCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddDiseaseCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddGeopositionCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddPestCommand { get; set; }

        /// <summary>
        /// Command for opening edit farm view/controller to add the farm
        /// </summary>
        public ICommand AddSoilReadingsCommand { get; set; }

        /// <summary>
        /// Command to delete the user
        /// </summary>
        public ICommand DeleteUserCommand { set; get; }
        #endregion

        private void InitializeCommands(Window mWindow)
        {
            #region Initialize commands


            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            AddFarmOwnerCommand = new RelayParametrisedCommand((parameter) =>
            {
                IsFarmOwnerControllerVisible = !IsFarmOwnerControllerVisible;
                FarmOwnerControllerViewModel = new FarmOwnerControllerViewModel(parameter as FarmOwner);
            });

            DeleteUserCommand = new RelayParametrisedCommand(async (parameter) =>
            {
                await IoC.Database.DeleteUser(parameter as User);
                //Users = IoC.Database.GetUsers();
            });

            AddUserCommand = new RelayCommand(() =>
            {
                UserControllerViewModel = new UserControllerViewModel();
                IsUserControllerVisible = !IsUserControllerVisible;
            });

            AddFarmCommand = new RelayCommand(() =>
            {
                FarmControllerViewModel = new FarmControllerViewModel();
                IsFarmControllerVisible = !IsFarmControllerVisible;
            });

            AddPlantCommand = new RelayCommand(() =>
            {
                PlantControllerViewModel = new PlantControllerViewModel();
                IsPlantControllerVisible = !IsPlantControllerVisible;
            });

            AddContagionCommand = new RelayCommand(() =>
            {
                ContagionControllerViewModel = new ContagionControllerViewModel();
                IsContagionControllerVisible = !IsContagionControllerVisible;
            });

            AddDiseaseCommand = new RelayCommand(() =>
            {
                DiseaseControllerViewModel = new DiseaseControllerViewModel();
                IsDiseaseControllerVisible = !IsDiseaseControllerVisible;
            });

            AddGeopositionCommand = new RelayCommand(() =>
            {
                GeopositionControllerViewModel = new GeopositionControllerViewModel();
                IsGeopositionControllerVisible = !IsGeopositionControllerVisible;
            });

            AddPestCommand = new RelayCommand(() =>
            {
                PestControllerViewModel = new PestControllerViewModel();
                IsPestControllerVisible = !IsPestControllerVisible;
            });

            AddSoilReadingsCommand = new RelayCommand(() =>
            {
                SoilReadingsControllerViewModel = new SoilReadingsControllerViewModel();
                IsSoilReadingsControllerVisible = !IsSoilReadingsControllerVisible;
            });

            #endregion

        }

    }
}
