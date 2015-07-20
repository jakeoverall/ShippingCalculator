using ShippingCalculator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingCalculator.Web.Business
{
    public class ShippingCostRepo
    {
        //HARD CODED VALUES
        public IEnumerable<ShippingCost> GetShippingCosts()
        {
            yield return new ShippingCost(4, 1, 1.25m);
            yield return new ShippingCost(4, 1.5m, 2);
            yield return new ShippingCost(4, 2, 3.25m);
            yield return new ShippingCost(3, 1, 1.25m);
            yield return new ShippingCost(3, 1.5m, 2.25m);
        }
    }
}
