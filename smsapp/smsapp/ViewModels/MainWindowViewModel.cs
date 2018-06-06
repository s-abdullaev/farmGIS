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

        /// <summary>
        /// The users list
        /// </summary>
        public ObservableCollection<User> Users { set; get; }
        #endregion
        #region Default constructor

        public MainWindowViewModel()
        {
            Users = IoC.Database.GetUsers();

            AddUserCommand = new RelayCommand(async () => {
                await IoC.Database.AddUserAsync(new User
                {
                    ID = Guid.NewGuid().ToString(),
                    Username = this.Username,
                    Password = this.Password,
                    Email = this.Email,
                    Permissions = int.Parse(this.Permission),
                    CreateDate = DateTime.Now
                });
            });

        }
        #endregion
        #region Commands

        public ICommand AddUserCommand { set; get; } 

        #endregion
    }
}
