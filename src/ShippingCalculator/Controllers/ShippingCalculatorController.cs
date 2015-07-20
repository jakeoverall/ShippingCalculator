using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShippingCalculator.Web.Controllers
{
    [Route("api/[controller]")]
    public class ShippingCalculatorController : Controller
    {
        private readonly Business.ShippingCalculator _shippingCalculator;
        public ShippingCalculatorController(Business.ShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        // GET api/values/5
        [HttpGet("{zip}/{weight}")]
        public decimal Get(string zip, decimal weight)
        {
            return _shippingCalculator.CalculateShippingCost(zip, weight);
        }

      
    }
}
