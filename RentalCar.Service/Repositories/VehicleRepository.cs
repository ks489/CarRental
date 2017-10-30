using RentalCar.Service.Infrastructure.Interfaces;
using RentalCar.Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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
            VehicleDTO vehicle = null;
            using (IDbConnection db = _connection.GetConnection())
            {
                DynamicParameters parameter = new DynamicParameters();
                string query = "SELECT vehicleid, numberPlate, currentMileage, rentalCharge, vehicleType, toilet, numberOfBeds, roadType, under21 FROM vehicle WHERE numberPlate = @numberPlate";
                parameter.Add("@numberPlate", NumberPlate, DbType.String, ParameterDirection.Input);
                vehicle = db.QueryFirstOrDefault<VehicleDTO>(query, parameter);
                

            }

            return vehicle;
        }

        #endregion
    }
}