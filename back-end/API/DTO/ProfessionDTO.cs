using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ProfessionDTO
    {
        public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }
        public Nullable<int> BaseProfessionId { get; set; }
        public string ProfessionBaseName { get; set; }

    }
}
