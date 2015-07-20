using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingCalculator.Web.Business
{
    public class ShippingCalculator
    {
        private readonly ShippingCostRepo _shippingCostRepo;
        private readonly ZipCodeRepo _zipCodeRepo;

        public ShippingCalculator(ShippingCostRepo shippingCostRepo, ZipCodeRepo zipCodeRepo)
        {
            _shippingCostRepo = shippingCostRepo;
            _zipCodeRepo = zipCodeRepo;
        }

        public decimal CalculateShippingCost(string zip, decimal weight) {
            var zone = _zipCodeRepo.GetZoneByZip(zip);
            var shippingCost = _shippingCostRepo.GetShippingCosts().Where(x => x.Zone == zone && x.Weight == weight).FirstOrDefault();
            if (shippingCost == null) {
                throw new Exception($"Invalid weight of {weight} to this zip {zip}");
            }
            return shippingCost.Cost;
        }
    }
}