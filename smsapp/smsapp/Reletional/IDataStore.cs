using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace smsapp
{
    /// <summary>
    /// Stores and retrieves information about the client application 
    /// such as login credentials, messages, settings and so on
    /// </summary>
    public interface IDataStore
    {
        /// <summary>
        /// Makes sure the client data store is correctly set up
        /// </summary>
        /// <returns>Returns a task that will finish once setup is complete</returns>
        Task EnsureDataStoreAsync();



        /// <summary>
        /// Adds the user to users table int the local datase
        /// </summary>
        /// <param name="userToAdd">User to add</param>
        /// <returns></returns>
        Task AddUserAsync(User userToAdd);


        /// <summary>
        /// Gets all users from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<User> GetUsers();
    }
}
