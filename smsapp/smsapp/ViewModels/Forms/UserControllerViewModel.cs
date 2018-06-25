using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace smsapp
{
    /// <summary>
    /// View model for user controller
    /// </summary>
    public class UserControllerViewModel : BaseViewModel
    {
        #region Private members
        private User mCurrentUser;
        private bool mIsPopupVisible;


        /// <summary>
        /// The users list
        /// </summary>
        public ObservableCollection<User> Users { set; get; }

        #endregion

        /// <summary>
        /// User permissions
        /// </summary>
        private int Permission { set; get; }

        /// <summary>
        /// Usernmae
        /// </summary>
        public string Username { set; get; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { set; get; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// Flag to indicate whether the user is editing
        /// </summary>
        public bool IsEditing
        {

            get => mCurrentUser != null;
        }

        /// <summary>
        /// Permissions
        /// </summary>
        public bool CanAddUsers
        {
            set
            {
                if (value)
                    Permission += 1;
                else
                    Permission -= 1;
            }
            get
            {
                var temp = Convert.ToString(Permission, 2);
                if (temp.Length <= 1)
                    return false;
                return temp[1] == '1';
            }
        }
        /// <summary>
        /// Permissions
        /// </summary>
        public bool CanAddEntities
        {
            set
            {
                //NOTE: The value of CanAddEntities is 2
                if (value)
                    Permission += 2;
                else
                    Permission -= 2;
            }
            get
            {
                var temp = Convert.ToString(Permission, 2);
                if (temp.Length <= 0)
                    return false;
                return temp[0] == '1';
            }
        }

        /// <summary>
        /// Flag indicating whether the popup should be shown or not
        /// </summary>
        public bool IsPopupVisible
        {
            set
            {
                if (!value)
                    Users = IoC.Database.GetUsers();
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
        public UserControllerViewModel(User user)
        {
            mCurrentUser = user;
            if (user != null)
            {
                this.Username = user.Username;
                this.Password = user.Password;
                this.Email = user.Email;
                this.Permission = user.Permissions;
            }
            Initialize();
        }
        public UserControllerViewModel()
        {
            IsPopupVisible = false;
            mCurrentUser = null;
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
            Users = IoC.Database.GetUsers();
            AddUserCommand = new RelayCommand(async () =>
            {
                IsPopupVisible = true;
                PopupContent.PopupType = PopupType.Wait;
                await IoC.Database.AddUserAsync(new User
                {
                    ID = Guid.NewGuid().ToString(),
                    Username = this.Username,
                    Password = this.Password,
                    Email = this.Email,
                    Permissions = Permission,
                    CreateDate = DateTime.Now
                });
                PopupContent.PopupType = PopupType.Success;
            });
            SaveEditsCommand = new RelayCommand(async () =>
            {
                if (mCurrentUser == null)
                    return;
                //TODO: Use some better approach :)
                PopupContent.PopupType = PopupType.Wait;
                IsPopupVisible = true;
                mCurrentUser.Email = this.Email;
                mCurrentUser.Password = this.Password;
                mCurrentUser.Permissions = Permission;
                mCurrentUser.Username = this.Username;
                await IoC.Database.EditUser(mCurrentUser);
                await Task.Delay(2000);
                // Return everything to initial state
                PopupContent.PopupType = PopupType.Success;
            });
            CloseCommand = new RelayCommand(() =>
            {
                MainWindowViewModel.Instance.IsUserControllerVisible = !MainWindowViewModel.Instance.IsUserControllerVisible;
            });
            OkCommand = new RelayCommand(() =>
            {
                IsPopupVisible = false;
                MainWindowViewModel.Instance.IsUserControllerVisible = !MainWindowViewModel.Instance.IsUserControllerVisible;
            }
            );

        }
        #endregion
    }
}
