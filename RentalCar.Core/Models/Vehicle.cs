using System.Runtime.Serialization;

namespace RentalCar.Core.Models
{
    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public string VehicleID { get; set; }
        [DataMember]
        public string NumberPlate { get; set; }
        [DataMember]
        public double? CurrentMileage { get; set; }
        [DataMember]
        public decimal? RentalCharge { get; set; } //My assumption around this is that this isn't a rate but rather a total, hence the data type used        
        public string Get_Basic_Information()
        {
            return string.Format("Number Plate: {0}, Current Mileage: {1}, Rental Charge: {2}", NumberPlate, CurrentMileage, RentalCharge);
        }

    }

}