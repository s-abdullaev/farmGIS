using System.Threading.Tasks;

namespace smsapp
{
    public interface IDataStore
    {
        /// <summary>
        /// Makes sure that database is created and set up
        /// </summary>
        /// <returns></returns>
        Task EnsureDataStoreAsyn();

        /// <summary>
        /// Gets the UserData
        /// </summary>
        /// <returns></returns>
        Task<User> GetUserData();

        /// <summary>
        /// Adds the user to the Database
        /// </summary>
        /// <param name="dataModel">The user to add</param>
        /// <returns></returns>
        Task AddUserData(User dataModel);
        
    }
}
