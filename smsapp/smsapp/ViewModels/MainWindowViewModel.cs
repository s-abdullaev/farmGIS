using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace smsapp
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// These should be copied to user control
        /// </summary>
        public string Username { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public string Permission { set; get; }
        public bool IsEditing { set; get; } = false;
        private User mCurrentUser;
        /// <summary>
        /// The users list
        /// </summary>
        public ObservableCollection<User> Users { set; get; }
        #endregion
        #region Default constructor

        public MainWindowViewModel()
        {
            Users = IoC.Database.GetUsers();

            AddUserCommand = new RelayCommand(async () =>
            {
                await IoC.Database.AddUserAsync(new User
                {
                    ID = Guid.NewGuid().ToString(),
                    Username = this.Username,
                    Password = this.Password,
                    Email = this.Email,
                    Permissions = int.Parse(this.Permission),
                    CreateDate = DateTime.Now
                });
                Users = IoC.Database.GetUsers();
            });

            DeleteUserCommand = new RelayParametrisedCommand(async (parameter) =>
            {
                await IoC.Database.DeleteUser(parameter as User);
                Users = IoC.Database.GetUsers();
            });

            EditUserCommand = new RelayParametrisedCommand((parameter)=>
            {
                //TODO: Use some better approach :)
                var user = parameter as User;
                this.Username = user.Username;
                this.Password = user.Password;
                this.Permission = user.Permissions.ToString();
                this.Email = user.Email;
                mCurrentUser = user;
                IsEditing = true;
            });

            SaveEditsCommand = new RelayCommand(async () =>
            {
                if (mCurrentUser == null)
                    return;
                //TODO: Use some better approach :)
                mCurrentUser.Email = this.Email;
                mCurrentUser.Password = this.Password;
                mCurrentUser.Permissions = int.Parse(this.Permission);
                mCurrentUser.Username = this.Username;
                await IoC.Database.EditUser(mCurrentUser);
                // Return everything to initial state
                IsEditing = false;
                mCurrentUser = null;
                Users = IoC.Database.GetUsers();
            });

        }
        #endregion
        #region Commands

        /// <summary>
        /// Adds the user
        /// </summary>
        public ICommand AddUserCommand { set; get; }

        /// <summary>
        /// Command to delete the user
        /// </summary>
        public ICommand DeleteUserCommand { set; get; }

        /// <summary>
        /// The command to edit the user
        /// </summary>
        public ICommand EditUserCommand { set; get; }

        public ICommand SaveEditsCommand { set; get; }

        #endregion

    }
}
