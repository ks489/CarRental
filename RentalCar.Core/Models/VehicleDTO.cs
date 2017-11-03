using RentalCar.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Core.Models
{
    [DataContract]
    public class VehicleDTO
    {
        [DataMember]
        public string VehicleID { get; set; }
        [DataMember]
        public string NumberPlate { get; set; }
        [DataMember]
        public double? CurrentMileage { get; set; }
        [DataMember]
        public decimal? RentalCharge { get; set; }
        [DataMember]
        public bool? Toilet { get; set; }
        [DataMember]
        public int? NumberOfBeds { get; set; }
        [DataMember]
        public bool? Under21 { get; set; }
        [DataMember]
        public RoadTypes? RoadType { get; set; }
        [DataMember]
        public VehicleTypes? VehicleType { get; set; }
    }
}
