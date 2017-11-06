using RentalCar.Core.Enums;
using System.Runtime.Serialization;

namespace RentalCar.Core.Models
{
    /// <summary>
    /// 4 Wheel Car used at the rental agency
    /// </summary>
    public class V4WDCar : Vehicle
    {
        [DataMember]
        public RoadTypes? RoadType { get; set; }

        public string Which_Road()
        {
            return string.Format("Road: {0}", RoadType.ToString());
        }
    }
}