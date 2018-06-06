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

    }
}
