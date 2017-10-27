using RentalCar.Core.Models;
using RentalCar.Service.Infrastructure;
using RentalCar.Service.Repositories;
using RentalCar.Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentalCar.Service.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Vehicle" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Vehicle.svc or Vehicle.svc.cs at the Solution Explorer and start debugging.
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
        public string Test()
        {
            return "Hello World";
        }
        public int Create(VehicleDTO vehicle)
        {
            return _vehicleRepository.Create(vehicle);
        }

        public IEnumerable<VehicleDTO> GetAvailableVehicles()
        {
            return _vehicleRepository.GetAvailable();
        }

        public VehicleDTO GetVehicle(string numberPlate)
        {
            return _vehicleRepository.Get(numberPlate);
        }
        #endregion
    }
}
