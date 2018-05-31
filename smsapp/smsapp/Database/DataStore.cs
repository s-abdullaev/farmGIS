using System.Threading.Tasks;

namespace smsapp
{
    public class DataStore : IDataStore
    {



        #region Interface Implementations

        /// <summary>
        /// Adds the user to the Database
        /// </summary>
        /// <param name="dataModel">The user to add</param>
        /// <returns></returns>
        public Task AddUserData(UserDataModel dataModel)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Makes sure that database is created and set up
        /// </summary>
        /// <returns></returns>
        public Task EnsureDataStoreAsyn()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the UserData
        /// </summary>
        /// <returns></returns>
        public Task<UserDataModel> GetUserData()
        {
            throw new System.NotImplementedException();
        } 
        #endregion
    }
}
