using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Core.Models
{
    public class Vehicle
    {
        public string NumberPlate { get; set; }
        public double CurrentMileage { get; set; }
        public decimal RentalCharge { get; set; } //My assumption around this is that this isn't a rate but rather a total, hence the data type used

        public string Get_Basic_Information()
        {
            return string.Format("Number Plate: {0}, Current Mileage: {1}, Rental Charge: {2}", NumberPlate, CurrentMileage, RentalCharge);
        }

    }
}