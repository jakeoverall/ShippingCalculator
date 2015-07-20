using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingCalculator.Web.Models
{
    public class ShippingCost
    {
        public int Zone { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }

        public ShippingCost(int zone, decimal weight, decimal cost)
        {
            Zone = zone;
            Cost = cost;
            Weight = weight;
        }
    }
}
