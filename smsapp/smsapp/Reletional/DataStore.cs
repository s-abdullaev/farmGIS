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

        public async Task AddFarmOwnerAsync(FarmOwner FarmOwnerToAdd)
        {
            mDbContext.FarmOwners.Add(FarmOwnerToAdd);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<FarmOwner> GetFarmOwners()
        {
            return new ObservableCollection<FarmOwner>(mDbContext.FarmOwners);
        }

        public async Task DeleteFarmOwner(FarmOwner FarmOwnerToDelete)
        {
            mDbContext.FarmOwners.Remove(FarmOwnerToDelete);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditFarmOwner(FarmOwner FarmOwnerToEdit)
        {
            mDbContext.FarmOwners.Update(FarmOwnerToEdit);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddFarmAsync(Farm Farm)
        {
            mDbContext.Farms.Add(Farm);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Farm> GetFarms()
        {
            return new ObservableCollection<Farm>(mDbContext.Farms);
        }

        public async Task DeleteFarm(Farm Farm)
        {
            mDbContext.Farms.Remove(Farm);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditFarm(Farm FarmToEdit)
        {
            mDbContext.Farms.Update(FarmToEdit);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddPlantAsync(Plant Plant)
        {
            mDbContext.Plants.Add(Plant);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Plant> GetPlants()
        {
            return new ObservableCollection<Plant>(mDbContext.Plants);
        }

        public async Task DeletePlant(Plant PlantToDelete)
        {
            mDbContext.Plants.Remove(PlantToDelete);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditPlant(Plant PlantToEidt)
        {
            mDbContext.Plants.Update(PlantToEidt);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddContagionAsync(Contagion Contagion)
        {
            mDbContext.Contagions.Add(Contagion);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Contagion> GetContagions()
        {
            return new ObservableCollection<Contagion>(mDbContext.Contagions);
        }

        public async Task DeleteContagion(Contagion contagion)
        {
            mDbContext.Contagions.Remove(contagion);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditContagion(Contagion contagion)
        {
            mDbContext.Contagions.Update(contagion);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddSoilReadingsAsync(SoilReadings SoilReadings)
        {
            mDbContext.SoilReadings.Add(SoilReadings);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<SoilReadings> GetSoilReadings()
        {
            return new ObservableCollection<SoilReadings>(mDbContext.SoilReadings);
        }

        public async Task DeleteSoilReadings(SoilReadings SoilReadings)
        {
            mDbContext.SoilReadings.Remove(SoilReadings);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditSoilReadings(SoilReadings SoilReadings)
        {
            mDbContext.SoilReadings.Update(SoilReadings);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddGeopositionAsync(Geoposition Geopostion)
        {
            mDbContext.Geopositions.Add(Geopostion);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Geoposition> GetGeopositions()
        {
            return new ObservableCollection<Geoposition>(mDbContext.Geopositions);
        }

        public async Task DeleteGeopostion(Geoposition Geopostion)
        {
            mDbContext.Geopositions.Remove(Geopostion);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditGeopostion(Geoposition Geopostion)
        {
            mDbContext.Geopositions.Update(Geopostion);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddPestAsync(Pest Pest)
        {
            mDbContext.Pests.Add(Pest);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Pest> GetPests()
        {
            return new ObservableCollection<Pest>(mDbContext.Pests);
        }

        public async Task DeletePest(Pest Pest)
        {
            mDbContext.Pests.Remove(Pest);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditPest(Pest Pest)
        {
            mDbContext.Pests.Update(Pest);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task AddDiseaseAsync(Disease Disease)
        {
            mDbContext.Diseases.Add(Disease);
            //Save
            await mDbContext.SaveChangesAsync();
        }

        public ObservableCollection<Disease> GetDiseases()
        {
            return new ObservableCollection<Disease>(mDbContext.Diseases);
        }

        public async Task DeleteDisease(Disease Disease)
        {
            mDbContext.Diseases.Remove(Disease);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        public async Task EditDisease(Disease Disease)
        {
            mDbContext.Diseases.Update(Disease);
            //Save changes to database
            await mDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
