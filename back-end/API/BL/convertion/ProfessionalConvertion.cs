using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.convertion
{
   public class ProfessionalConvertion
    {
        public static Professionals ProfessionalToDal(ProfessionalDTO professional)
        {
           return new Professionals()
            {
               BussName=professional.BussName,
                ProfessionalId = professional.ProfessionalId,
                FirstName = professional.FirstName,
                LastName = professional.LastName,
                DescriptionOn = professional.DescriptionOn,
                Street = professional.Street,
                NumHouse = professional.NumHouse,
                Users = new Users
                {
                    UserPhone=professional.UserPhone,
                    UserEmail = professional.UserEmail,
                     City=professional.City,
                     IsManager=professional.IsManager,
                     UserPassword=professional.UserPassword,
                     UserName=professional.UserName,
                     UserId=professional.UserId
                }
           
        };
            
          

        }
        public static ProfessionalDTO ProfessionalToDTO(Professionals professional)
        {

            return new ProfessionalDTO()
            {
                ProfessionalId = professional.ProfessionalId,
                BussName=professional.BussName,
                FirstName = professional.FirstName,
                LastName = professional.LastName,
                DescriptionOn = professional.DescriptionOn,
                Street = professional.Street,
                NumHouse = professional.NumHouse,
                UserId = professional.Users.UserId,
                City = professional.Users.City,
                CityName = professional.Users.Cities.CityName,
                IsManager = professional.Users.IsManager,
                UserEmail = professional.Users.UserEmail,
                UserName = professional.Users.UserName,
                UserPassword = professional.Users.UserPassword,
                UserPhone = professional.Users.UserPhone
              
            };
        }
        public static List<Professionals> ProfessionalsListToDal(List<ProfessionalDTO> professionals)
        {
            return professionals.Select(u => ProfessionalToDal(u)).ToList();
        }
        public static List<ProfessionalDTO> ProfessionalsListToDTO(List<Professionals> professionals)
        {
            return professionals.Select(u => ProfessionalToDTO(u)).ToList();
        }
    }
}
