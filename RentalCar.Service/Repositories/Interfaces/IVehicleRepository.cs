using RentalCar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Service.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> Get();
        Vehicle Get(string NumberPlate);
        int Create(Vehicle vehicle);

    }
}