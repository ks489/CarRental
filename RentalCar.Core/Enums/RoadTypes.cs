using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Core.Enums
{
    /// <summary>
    /// Type of roads 4 wheel drive cars are allowed to travel on
    /// </summary>
    public enum RoadTypes
    {
        NULL,
        OFF_ROAD = 1,
        DIRT_ROAD = 2,
        NORMAL_ROAD = 3
    }
}
