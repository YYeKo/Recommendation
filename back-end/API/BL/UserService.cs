using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.convertion;
using DAL;
using DTO;

namespace BL
{
    public class UserService
    {
        private static RecommendationsEntities3 db = new RecommendationsEntities3();
        /// <summary>
        /// function for user login 
        /// check if the user exists in the DB
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public static int LogIn(string userName, string userPassword)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                Users user = db.Users.FirstOrDefault(u => u.UserPassword == userPassword && u.UserName == userName);
                if (user!=null)
                return user.UserId;
                return 0;
            }
        }

        /// <summary>
        /// function for user register
        /// add the user to users table in the DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool RegisterUser(UsersDTO user)
        {
            if (user.CityName != null)
            {
                user.City = SetCityId(user.CityName);
            }
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                var u = db.Users.Find(user.UserId);
                if(u==null)
                {
                    db.Users.Add(UsersConvertion.UserToDal(user));
                }
                else
                {
                    u.UserName = user.UserName;
                    u.UserPassword = user.UserPassword;
                    u.UserPhone = user.UserPhone;
                    u.UserEmail = user.UserEmail;
                    u.IsManager = user.IsManager;
                    u.City = user.City;
                }
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch  { return false; } 

                }
        }

        public static object GetProfessionalNameById(int id)
        {
            return db.Professionals.Find(id).BussName;
        }

        public static UsersDTO GetProfessionalById(int id)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                var p = db.Users.Find(id);
                if(p.Professionals!=null)
                return ProfessionalConvertion.ProfessionalToDTO(p.Professionals);
                return UsersConvertion.UserToDTO(p);
            }
        }

        public static bool RegisterProfessional(ProfessionData professionalData)//??????profession
        {
            ProfessionalDTO professional = professionalData.professional;
            int profession = professionalData.profession;
            if (professional.CityName != null)
            {
                professional.City = SetCityId(professional.CityName);
            }
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                var prof = db.Professionals.Find(professional.ProfessionalId);
                if (prof == null)
                {

                    db.Professionals.Add(ProfessionalConvertion.ProfessionalToDal(professional));
                    
                }
                else
                {
                    prof.FirstName = professional.FirstName;
                    prof.LastName = professional.LastName;
                    prof.BussName = professional.BussName;
                    prof.NumHouse = professional.NumHouse;
                    prof.Street = professional.Street;
                    prof.DescriptionOn = professional.DescriptionOn;
                    prof.Users.City = professional.City;
                    prof.Users.IsManager = professional.IsManager;
                    prof.Users.UserPassword = professional.UserPassword;
                    prof.Users.UserPhone = professional.UserPhone;
                    prof.Users.UserName = professional.UserName;
                }
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        /// <summary>
        /// get list of cities
        /// </summary>
        /// <returns></returns>
        public static List<CitiesDTO> GetCitiyList()
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                return CitiesConvertion.CityListToDTO(db.Cities.ToList());
            }
        }

        public static List<ProfessionalDTO> GetProfessionalList()
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                return ProfessionalConvertion.ProfessionalsListToDTO(db.Professionals.ToList());
            }
        }
        public static bool IsExistsPassword(string password,int id)
        {
            return db.Users.FirstOrDefault(p => p.UserPassword == password&&p.UserId!=id) != null;
        }
        public static int SetCityId(string cityname)
        {
            return db.Cities.FirstOrDefault(c => c.CityName == cityname).CityId;
        }


    }
}