using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingCalculator.Web.Business
{
    public class ZipCodeRepo
    {
        private Dictionary<string, int> ZoneZipMap = new Dictionary<string, int>
        {
            {"55555", 4 },
            {"55556", 3 },
            {"55557", 9 },
        };
        public int GetZoneByZip(string zip)
        {
            if (!ZoneZipMap.ContainsKey(zip)) throw new Exception("Invalid zipcode");
            return ZoneZipMap[zip];
        }
    }
}
