using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Core.Models
{
    public class Campervan : Vehicle
    {
        public bool? Toilet { get; set; }
        public int? NumberOfBeds { get; set; }

        public string Get_Equipment()
        {
            return string.Format("Toilet: {0}, Number of Beds: {1}", Toilet, NumberOfBeds);
        }
    }
}