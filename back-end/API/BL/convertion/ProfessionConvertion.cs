using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.convertion
{
    public class ProfessionConvertion
    {
        public static Professions SpecializationToDal(SpecializationsDTO specialization)
        {
            return new Professions()
            {
                ProfessionId = specialization.specializationId,
                ProfessionName = specialization.specializationName,
                baseprofessionId = specialization.baseSpecializationId
            };
        }
        public static SpecializationsDTO SpecializationToDTO(Professions specialization)
        {
            return new SpecializationsDTO()
            {
                specializationId = specialization.ProfessionId,
                specializationName = specialization.ProfessionName,
                baseSpecializationId = specialization.baseprofessionId,
                specializationBaseName = specialization.Professions2.ProfessionName//להגדיר שיכול להיותNULL????? 
            };
        }

        public static List<Professions> SpecializationsListToDal(List<SpecializationsDTO> specializations)
        {
            return specializations.Select(u => SpecializationToDal(u)).ToList();
        }
        public static List<SpecializationsDTO> SpecializationsListToDTO(List<Professions> specializations)
        {
            return specializations.Select(u => SpecializationToDTO(u)).ToList();
        }
    }
}
