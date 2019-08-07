using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CitiesDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> Area { get; set; }
        public string AreaName { get; set; }

    }
}
