using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProfessionalDTO:UsersDTO
    {
        public int ProfessionalId { get; set; }
        public string BussName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public Nullable<int> NumHouse { get; set; }
        public string DescriptionOn { get; set; }
        public List<ProfessionDTO> professions { get; set; }
    }

    
}
