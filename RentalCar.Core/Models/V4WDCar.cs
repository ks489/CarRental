using RentalCar.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RentalCar.Core.Models
{
    public class V4WDCar : Vehicle
    {
        [DataMember]
        public RoadTypes RoadType { get; set; }

        public string Which_Road()
        {
            return string.Format("Road: {0}", RoadType.ToString());
        }
    }
}