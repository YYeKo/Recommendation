using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SpecializationsForProfessionalsDTO
    {
        public int SpecialForProfId { get; set; }
        public Nullable<int> Professional { get; set; }
        public Nullable<int> specialization { get; set; }

    }
}
