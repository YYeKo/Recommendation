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
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                var prof = db.Professionals.Find(user.UserId);
            if(prof!=null)
            {               
                prof.UserSearch.Clear();
                prof.Recommendations.Clear();
                prof.ProfessionForProfessional.Clear();
                db.Professionals.Remove(prof);
            }
            if (user.CityName != null)
            {
                user.City = SetCityId(user.CityName);
            }
            
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

        public static bool RegisterProfessional(ProfessionalDTO professional)//??????profession
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
               
            if (professional.CityName != null)
            {
                professional.City = SetCityId(professional.CityName);
            }
            
                var prof = db.Professionals.Find(professional.ProfessionalId);
                var user = db.Users.Find(professional.UserId);
                //ProfessionsService.SetProfessionsToProfessional(professional);הוספת מקצועות לבעל מקצוע
                if (prof == null)
                {
                    if (user == null)
                        db.Professionals.Add(ProfessionalConvertion.ProfessionalToDal(professional));
                    else
                        db.Professionals.Add(ProfessionalConvertion.ProfessionalWithoutUserToDal(professional));
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
                    //prof.ProfessionForProfessional.Add.AddRange(professional.professions.Select(p => new ProfessionForProfessional { Profession = p.ProfessionId, Professional = professional.UserId }));
                    //לעשות הוספת מקצועות לבעל מקצוע בשתי האפשרויות :יצירה ועדכון
                }

                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
                
            }
        }

        public static bool IsExistsPassword(string password, int id)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                var a = db.Users.FirstOrDefault(p => p.UserPassword == password && p.UserId != id);
            return a != null;
            }
        }

        //get professional
        public static object GetProfessionalNameById(int id)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                return db.Professionals.Find(id).BussName;
            }
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

        public static List<ProfessionalDTO> GetProfessionalList()
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                return ProfessionalConvertion.ProfessionalsListToDTO(db.Professionals.ToList());
            }
        }

        //cities

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

        public static int SetCityId(string cityname)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                return db.Cities.FirstOrDefault(c => c.CityName == cityname).CityId;
            }
        }
    }
}