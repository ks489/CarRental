using RentalCar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentalCar.Service.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVehicle" in both code and config file together.
    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        string Test();
        [OperationContract]
        VehicleDTO GetVehicle(string numberPlate);
        [OperationContract]
        IEnumerable<VehicleDTO> GetAvailableVehicles();
        [OperationContract]
        int Create(VehicleDTO vehicle);
    }
}
