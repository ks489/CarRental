using RentalCar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentalCar.Service.Services
{
    /// <summary>
    /// This provides an abstraction of all business processing and logic that calls various repositories
    /// </summary>
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
