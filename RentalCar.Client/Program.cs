using RentalCar.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleService service = new VehicleService();
            var items = service.GetAvailableVehicles();
            Console.ReadKey();
        }
    }
}
