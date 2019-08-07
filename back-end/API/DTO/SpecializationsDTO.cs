using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SpecializationsDTO
    {
        public int specializationId { get; set; }
        public string specializationName { get; set; }
        public Nullable<int> Profession { get; set; }

        public Nullable<int> baseSpecializationId { get; set; }
        public string specializationBaseName { get; set; }

    }
}
