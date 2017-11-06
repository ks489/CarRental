using RentalCar.Core.Models;
using RentalCar.Service.Infrastructure;
using RentalCar.Service.Repositories;
using RentalCar.Service.Repositories.Interfaces;
using System.Collections.Generic;

namespace RentalCar.Service.Services
{
    /// <summary>
    /// All vehicle related service interactions. Any CRUD operations used on vehicles go here as well.
    /// </summary>
    public class VehicleService : IVehicleService
    {
        #region Private Variables
        private IVehicleRepository _vehicleRepository;
        #endregion

        #region Constructors
        public VehicleService()
        {
            _vehicleRepository = new VehicleRepository(new Connection());
        }
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        #endregion

        #region Service Methods
        /// <summary>
        /// Test method to make sure the application is up and running
        /// </summary>
        /// <returns></returns>
        public string Test() => "Hello World";
        /// <summary>
        /// This will create a new vehicle in the system
        /// </summary>
        /// <param name="vehicle">Vehicle Data Transfer Object of the new vehicle</param>
        /// <returns>The rows affected when inserting a new vehicle</returns>
        public int Create(VehicleDTO vehicle)
        {
            return _vehicleRepository.Create(vehicle);
        }
        /// <summary>
        /// Get a list of all vehicles available to rent
        /// </summary>
        /// <returns>A list of vehicles and their details</returns>
        public IEnumerable<VehicleDTO> GetAvailableVehicles()
        {
            return _vehicleRepository.GetAvailable();
        }
        /// <summary>
        /// Get a particular vehicle based on the number plate
        /// </summary>
        /// <param name="numberPlate">The vehicle's number plate</param>
        /// <returns>The vehicle object details</returns>
        public VehicleDTO GetVehicle(string numberPlate)
        {
            return _vehicleRepository.Get(numberPlate);
        }
        #endregion
    }
}
