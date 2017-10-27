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
        public int Create(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> Get()
        {
            IEnumerable<Vehicle> list;
            using (IDbConnection db = _connection.GetConnection())
            {
                list = db.Query<Vehicle>("SELECT [TagID], [Name], [Colour], [Enabled], [Removed] FROM Tag ORDER BY LOWER([Name])");
            }

            return list;
        }

        public Vehicle Get(string NumberPlate)
        {
            IEnumerable<Vehicle> list;
            using (IDbConnection db = _connection.GetConnection())
            {
                list = db.Query<Vehicle>("SELECT [TagID], [Name], [Colour], [Enabled], [Removed] FROM Tag ORDER BY LOWER([Name])");
            }

            return list;
        }

        #endregion
    }
}