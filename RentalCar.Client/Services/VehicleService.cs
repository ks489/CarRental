using RentalCar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Client.Services
{
    public class VehicleService
    {
        #region Private Variables
        MyVehicleService.IVehicleService _vehicleService;
        #endregion

        #region Constructors
        public VehicleService()
        {
            _vehicleService = new MyVehicleService.VehicleServiceClient();
        }
        #endregion

        #region Service Methods
        public IEnumerable<VehicleDTO> GetAvailableVehicles()
        {
            return _vehicleService.GetAvailableVehicles();
        }
        #endregion
    }
}
