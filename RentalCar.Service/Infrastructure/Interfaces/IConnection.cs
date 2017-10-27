using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RentalCar.Service.Infrastructure.Interfaces
{
    public interface IConnection : IDisposable
    {
        IDbConnection GetConnection();
    }
}