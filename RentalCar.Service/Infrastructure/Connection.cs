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
    /// <summary>
    /// Connection Implementation of the data store being used.
    /// </summary>
    public class Connection : IConnection
    {
        #region Private Variables
        private bool disposedValue = false;
        #endregion

        #region Methods
        /// <summary>
        /// Gets the connection used according to the data store implementation used. This returns a mysql connection
        /// </summary>
        /// <returns>My SQL database connection</returns>
        public IDbConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["VehicleConnection"].ConnectionString);
        }
        #endregion

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