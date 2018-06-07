using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace smsapp
{
    /// <summary>
    /// Stores and retrieves information about the client application 
    /// such as login credentials, messages, settings and so on
    /// in an SQLite database
    /// </summary>
    public class DataStore : IDataStore
    {
        #region Protected Members

        /// <summary>
        /// The database context for the client data store
        /// </summary>
        protected ApplicationDbContext mDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext">The database to use</param>
        public DataStore(ApplicationDbContext dbContext)
        {
            // Set local member
            mDbContext = dbContext;
        }

        #endregion

        #region Interface Implementation


        /// <summary>
        /// Makes sure the client data store is correctly set up
        /// </summary>
        /// <returns>Returns a task that will finish once setup is complete</returns>
        public async Task EnsureDataStoreAsync()
        {
            // Make sure the database exists and is created
            await mDbContext.Database.EnsureCreatedAsync();
        }

        public async Task AddUserAsync(User user)
        {
            mDbContext.Users.Add(user);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }


        /// <summary>
        /// Gets all users from local database
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<User> GetUsers()
        {
            var obj = new ObservableCollection<User>(mDbContext.Users);
            return obj;
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="userToDelete">User to delete</param>
        /// <returns></returns>
        public async Task DeleteUser(User userToDelete)
        {
            mDbContext.Users.Remove(userToDelete);
            await mDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Edit user
        /// </summary>
        /// <param name="userToDelete">User to edit</param>
        /// <returns></returns>
        public async Task EditUser(User userToEdit)
        {
            mDbContext.Users.Update(userToEdit);
            await mDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
