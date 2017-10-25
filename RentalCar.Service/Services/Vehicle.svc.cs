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
    public class Vehicle : IVehicle
    {
        public IEnumerable<Vehicle> GetAllVehicle()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(string numberPlate)
        {
            throw new NotImplementedException();
        }

        int IVehicle.Vehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
