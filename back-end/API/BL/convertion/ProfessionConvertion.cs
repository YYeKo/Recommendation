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
        public static Professions professionToDal(ProfessionDTO profession)
        {
            return new Professions()
            {
                ProfessionId = profession.ProfessionId,
                ProfessionName = profession.ProfessionName,
                baseprofessionId = profession.BaseProfessionId
            };
        }
        public static ProfessionDTO professionToDTO(Professions profession)
        {
            return new ProfessionDTO()
            {
                ProfessionId = profession.ProfessionId,
                 ProfessionName= profession.ProfessionName,
                BaseProfessionId = profession.baseprofessionId,
                ProfessionBaseName = profession.Professions2.ProfessionName//להגדיר שיכול להיותNULL????? 
            };
        }

        public static List<Professions> professionsListToDal(List<ProfessionDTO> professions)
        {
            return professions.Select(u => professionToDal(u)).ToList();
        }
        public static List<ProfessionDTO> professionsListToDTO(List<Professions> professions)
        {
            return professions.Select(u => professionToDTO(u)).ToList();
        }
    }
}
