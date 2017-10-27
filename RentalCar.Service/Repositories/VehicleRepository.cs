using RentalCar.Service.Infrastructure.Interfaces;
using RentalCar.Service.Repositories.Interfaces;
using RentalCar.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentalCar.Core.Models;
using System.Data;
using Dapper;

namespace RentalCar.Service.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        #region Private Variables
        private IConnection _connection;
        #endregion

        #region Constructor
        public VehicleRepository(IConnection connection)
        {
            _connection = connection;
        }
        #endregion
        #region Repository Methods
        public int Create(VehicleDTO vehicle)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleDTO> GetAvailable()
        {
            IEnumerable<VehicleDTO> list;
            using (IDbConnection db = _connection.GetConnection())
            {
                string query = "SELECT vehicleid, numberPlate, currentMileage, rentalCharge, vehicleType, toilet, numberOfBeds, roadType, under21 FROM vehicle WHERE numberPlate NOT IN (SELECT numberPlate FROM rentals )";
                list = db.Query<VehicleDTO>(query);
            }
            return list;
        }

        public VehicleDTO Get(string NumberPlate)
        {
            //var res = conn.Query<dynamic>(query).Select(x => new Tuple<MyBase, MyDerived1, MyDerived2>(new MyBase() { BaseProp = x.BaseProp },
            //                                                                                               new MyDerived1() { Derived1Prop = x.Derived1Prop },
            //                                                                                               new MyDerived2() { Derived2Prop = x.Derived2Prop }));

            //IEnumerable<Vehicle> list;
            //using (IDbConnection db = _connection.GetConnection())
            //{
            //    list = db.Query<Vehicle>("SELECT [TagID], [Name], [Colour], [Enabled], [Removed] FROM Tag ORDER BY LOWER([Name])");
            //}

            //return list;
            return null;
        }

        #endregion
    }
}