using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCar.Core.Models
{
    /// <summary>
    /// 2 wheel bike model used at the rental agency 
    /// </summary>
    public class V2WBike : Vehicle
    {
        public bool? Under21 { get; set; }

        public string Under21_Ok()
        {
            return string.Format("Under 21: {0}", Under21);
        }
    }
}