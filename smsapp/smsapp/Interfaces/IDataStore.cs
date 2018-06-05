using System.Threading.Tasks;

namespace smsapp
{
    public interface IDataStore
    {
        /// <summary>
        /// Makes sure that database is created and set up
        /// </summary>
        /// <returns></returns>
        Task EnsureDataStoreAsync();        
    }
}
