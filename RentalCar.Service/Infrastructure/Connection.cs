using RentalCar.Service.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace RentalCar.Service.Infrastructure
{
    public class Connection : IConnection
    {
        #region Private Variables
        private bool disposedValue = false;
        #endregion

        public IDbConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["VehicleConnection"].ConnectionString);
        }

        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}