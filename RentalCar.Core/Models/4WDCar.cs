using RentalCar.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Core.Models
{
    public class _4WDCar : Vehicle
    {
        public RoadTypes Road { get; set; }

        public string Which_Road()
        {
            return string.Format("Road: {0}", Road.ToString());
        }
    }
}