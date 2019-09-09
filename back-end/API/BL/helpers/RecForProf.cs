using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BL.helpers
{
   public class RecForProf
    {
        public ProfessionalDTO Professional { get; set; }
        public Nullable<int> RatePrice { get; set; }
        public Nullable<int> RateProfessionalism { get; set; }
        public Nullable<int> RateArrival { get; set; }
        public int NumRec { get; set; }


    }
}
