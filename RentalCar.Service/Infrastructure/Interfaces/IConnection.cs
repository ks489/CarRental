using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RentalCar.Service.Infrastructure.Interfaces
{
    /// <summary>
    /// Generic Data Store Connection
    /// </summary>
    public interface IConnection : IDisposable
    {
        IDbConnection GetConnection();
    }
}