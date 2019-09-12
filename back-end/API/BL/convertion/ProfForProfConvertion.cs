using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.convertion
{
    public class ProfForProfConvertion
    {
        public static ProfessionForProfessional ProfForProfToDal(ProfessionForProfessionalDTO profForProf)
        {
            return new ProfessionForProfessional()
            {
                ProfesForProfId = profForProf.ProfesForProfId,
                Profession = profForProf.Profession,
                Professional = profForProf.Professional
            };
        }
        public static ProfessionForProfessionalDTO ProfForProfToDTO(ProfessionForProfessional profForProf)
        {
            return new ProfessionForProfessionalDTO()
            {
                ProfesForProfId = profForProf.ProfesForProfId,
                Professional = profForProf.Professional,
                Profession = profForProf.Profession
            };
        }
        public static List<ProfessionForProfessional> ProfForProfListToDal(List<ProfessionForProfessionalDTO> profForProf)
        {
            return profForProf.Select(u => ProfForProfToDal(u)).ToList();
        }
        public static List<ProfessionForProfessionalDTO> ProfForProfListToDTO(List<ProfessionForProfessional> profForProf)
        {
            return profForProf.Select(u => ProfForProfToDTO(u)).ToList();
        }
    }
}
