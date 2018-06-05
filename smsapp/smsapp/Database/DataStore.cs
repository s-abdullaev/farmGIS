using System.Threading.Tasks;

namespace smsapp
{
    public class DataStore : IDataStore
    {

        ApplicationDbContext mDatabase;

        // Create/Read/Update/Delete
        public Task EnsureDataStoreAsync()
        {
            return Task.FromResult(mDatabase.Database.EnsureCreatedAsync());
        }

        public DataStore(ApplicationDbContext database)
        {
            mDatabase = database;
        }
    }
}
