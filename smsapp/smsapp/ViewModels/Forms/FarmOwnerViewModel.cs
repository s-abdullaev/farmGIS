using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace smsapp
{
    /// <summary>
    /// View model for user controller
    /// </summary>
    public class FarmOwnerControllerViewModel : BaseViewModel
    {
        private FarmOwner mCurrentFarmOwner;

        #region Data
        /// <summary>
        /// User permissions
        /// </summary>
        private string PassportNumber { set; get; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { set; get; }
        /// <summary>
        /// LastNames
        /// </summary>
        public string LastName { set; get; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime DateOfBirth { set; get; }

        /// <summary>
        /// IsMale
        /// NOTE: 
        ///     if owner is male it is true (1)
        ///     else it is false(0)
        /// </summary>
        public bool Gender { set; get; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string MobilePhone1 { set; get; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string MobilePhone2 { set; get; }

        /// <summary>
        /// HomeNumber
        /// </summary>
        public string HomePhone1 { set; get; }

        /// <summary>
        /// HomeNumber
        /// </summary>
        public string HomePhone2 { set; get; }

        /// <summary>
        /// Adress
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// City of the farm owner
        /// </summary>
        public string City { set; get; }

        /// <summary>
        /// Region of the farm owner
        /// </summary>
        public string Region { set; get; }

        /// <summary>
        /// AdditionalNotes
        /// </summary>
        public string AdditionalNotes { set; get; }

        /// <summary>
        /// Url to the photo of farm owner
        /// </summary>
        public string PhotoUrl { set; get; }
        #endregion

        #region Control
        /// <summary>
        /// Flag to indicate whether the user is editing
        /// </summary>
        public bool IsEditing
        {
            set
            {

            }
            get
            {
                return mCurrentFarmOwner != null;
            }
        }
        /// <summary>
        /// Flag indicating whether the popup should be shown or not
        /// </summary>
        public bool IsPopupVisible { set; get; } = false;
        /// <summary>
        /// Type of the popup
        /// </summary>
        public PopupViewModel PopupContent { set; get; }

        public ObservableCollection<FarmOwner> FarmOwners { set; get; }
        #endregion
        
        #region Commands
        /// <summary>
        /// Adds the user
        /// </summary>
        public ICommand AddFarmOwnerCommand { set; get; }

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
        public FarmOwnerControllerViewModel(FarmOwner farmOwner)
        {
            mCurrentFarmOwner = farmOwner;
            if (farmOwner != null)
            {
                //this.Username = farmOwner.Username;
                //this.Password = farmOwner.Password;
                //this.Email = farmOwner.Email;
                //this.Permission = farmOwner.Permissions;
            }
            Initialize();
        }
        public FarmOwnerControllerViewModel()
        {
            IsPopupVisible = false;
            mCurrentFarmOwner = null;
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
            FarmOwners = IoC.Database.GetFarmOwners();
            AddFarmOwnerCommand = new RelayCommand(async () =>
            {
                IsPopupVisible = true;
                PopupContent.PopupType = PopupType.Wait;
                await IoC.Database.AddFarmOwnerAsync(new FarmOwner
                {
                    ID = Guid.NewGuid().ToString(),
                    LastName = LastName,
                    FirstName = FirstName,
                    PassportNumber = PassportNumber,
                    DateOfBirth = (DateTime)DateOfBirth,
                    MobilePhone1 = MobilePhone1,
                    MobilePhone2 = MobilePhone2,
                    HomePhone1 = HomePhone1,
                    HomePhone2 = HomePhone2,
                    Email = Email,
                    Address = Address,
                    City = City,
                    Region = Region,
                    AdditionalNotes = AdditionalNotes,
                    PhotoUrl = PhotoUrl,
                    Gender = Gender
                });
                PopupContent.PopupType = PopupType.Success;
            });
            SaveEditsCommand = new RelayCommand(async () =>
            {
                if (mCurrentFarmOwner == null)
                    return;
                mCurrentFarmOwner = new FarmOwner
                {
                    LastName = LastName,
                    FirstName = FirstName,
                    PassportNumber = PassportNumber,
                    DateOfBirth = (DateTime)DateOfBirth,
                    MobilePhone1 = MobilePhone1,
                    MobilePhone2 = MobilePhone2,
                    HomePhone1 = HomePhone1,
                    HomePhone2 = HomePhone2,
                    Email = Email,
                    Address = Address,
                    City = City,
                    Region = Region,
                    AdditionalNotes = AdditionalNotes,
                    PhotoUrl = PhotoUrl,
                    Gender = Gender
                };
                await IoC.Database.EditFarmOwner(mCurrentFarmOwner);
                // Return everything to initial state
                PopupContent.PopupType = PopupType.Success;
            });
            CloseCommand = new RelayCommand(() =>
            {
                MainWindowViewModel.Instance.IsFarmOwnerControllerVisible = !MainWindowViewModel.Instance.IsFarmOwnerControllerVisible;
            });
            OkCommand = new RelayCommand(() =>
            {
                IsPopupVisible = false;
                FarmOwners = IoC.Database.GetFarmOwners();
            }
            );

        }
        #endregion
    }
}
