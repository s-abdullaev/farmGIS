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



        #region User entity
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

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="userToDelete">User to delete</param>
        /// <returns></returns>
        Task DeleteUser(User userToDelete);

        /// <summary>
        /// Edit user
        /// </summary>
        /// <param name="userToDelete">User to edit</param>
        /// <returns></returns>
        Task EditUser(User userToEdit);
        #endregion

        #region FarmOwner entity
        /// <summary>
        /// Adds the FarmOwner to FarmOwners table in the local datase
        /// </summary>
        /// <param name="FarmOwnerToAdd">User to add</param>
        /// <returns></returns>
        Task AddFarmOwnerAsync(FarmOwner FarmOwnerToAdd);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<FarmOwner> GetFarmOwners();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="FarmOwnerToDelete">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteFarmOwner(FarmOwner FarmOwnerToDelete);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="FarmOwnerToEdit">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditFarmOwner(FarmOwner FarmOwnerToEdit);
        #endregion

        #region Farm entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Farm">User to add</param>
        /// <returns></returns>
        Task AddFarmAsync(Farm Farm);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Farm> GetFarms();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="FarmOwnerToDelete">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteFarm(Farm FarmOwnerToDelete);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="FarmToEdit">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditFarm(Farm FarmToEdit);
        #endregion

        #region Plant entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Disease">User to add</param>
        /// <returns></returns>
        Task AddPlantAsync(Plant Plant);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Plant> GetPlants();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="PlantToDelete">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeletePlant(Plant PlantToDelete);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="PlantToEidt">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditPlant(Plant PlantToEidt);
        #endregion

        #region Plant entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Contagion">User to add</param>
        /// <returns></returns>
        Task AddContagionAsync(Contagion Contagion);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Contagion> GetContagions();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="contagion">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteContagion(Contagion contagion);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="contagion">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditContagion(Contagion contagion);
        #endregion

        #region SoilReadings entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="SoilReadings">User to add</param>
        /// <returns></returns>
        Task AddSoilReadingsAsync(SoilReadings SoilReadings);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<SoilReadings> GetSoilReadings();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="SoilReadings">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteSoilReadings(SoilReadings SoilReadings);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="SoilReadings">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditSoilReadings(SoilReadings SoilReadings);
        #endregion

        #region Geoposiotions entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Plant">User to add</param>
        /// <returns></returns>
        Task AddGeopositionAsync(Geoposition Geopostion);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Geoposition> GetGeopositions();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="Geopostion">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteGeopostion(Geoposition Geopostion);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="Geopostion">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditGeopostion(Geoposition Geopostion);
        #endregion

        #region Pest entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Pest">User to add</param>
        /// <returns></returns>
        Task AddPestAsync(Pest Pest);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Pest> GetPests();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="Pest">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeletePest(Pest Pest);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="Pest">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditPest(Pest Pest);
        #endregion

        #region Disease entity
        /// <summary>
        /// Adds the Farm to Farm table in the local datase
        /// </summary>
        /// <param name="Disease">User to add</param>
        /// <returns></returns>
        Task AddDiseaseAsync(Disease Disease);


        /// <summary>
        /// Gets all FarmOwners from local database
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Disease> GetDiseases();

        /// <summary>
        /// Delete FarmOwner
        /// </summary>
        /// <param name="Disease">FarmOwner to delete</param>
        /// <returns></returns>
        Task DeleteDisease(Disease Disease);

        /// <summary>
        /// Edit FarmOwner
        /// </summary>
        /// <param name="Disease">FarmOwner to edit</param>
        /// <returns></returns>
        Task EditDisease(Disease Disease);
        #endregion

    }
}
