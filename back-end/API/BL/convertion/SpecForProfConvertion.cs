using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.convertion
{
    public class SpecForProfConvertion
    {
        public static ProfessionForProfessional SpecForProfToDal(SpecializationsForProfessionalsDTO specForProf)
        {
            return new ProfessionForProfessional()
            {
                ProfesForProfId = specForProf.SpecialForProfId,
                Profession = specForProf.specialization,
                Professional = specForProf.Professional
            };
        }
        public static SpecializationsForProfessionalsDTO SpecForProfToDTO(ProfessionForProfessional specForProf)
        {
            return new SpecializationsForProfessionalsDTO()
            {
                SpecialForProfId = specForProf.ProfesForProfId,
                Professional = specForProf.Professional,
                specialization = specForProf.Profession
            };
        }
        public static List<ProfessionForProfessional> SpecForProfListToDal(List<SpecializationsForProfessionalsDTO> specForProf)
        {
            return specForProf.Select(u => SpecForProfToDal(u)).ToList();
        }
        public static List<SpecializationsForProfessionalsDTO> SpecForProfListToDTO(List<ProfessionForProfessional> specForProf)
        {
            return specForProf.Select(u => SpecForProfToDTO(u)).ToList();
        }
    }
}
