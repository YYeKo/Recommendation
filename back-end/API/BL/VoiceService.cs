using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL
{
    
    public class VoiceService
    {       
        public static string SelectedLetters(int a)
        {
            string str1 = "אבגדה";
            string str2 = "וזחטיכ";
            string str3 = "למנסעפ";
            string str4 = "צקרשת";
            if (a == 1)
                return str1;
            else if (a == 2)
                return str2;
            else if (a == 3)
                return str3;
            else
                return str4;

        }
       
        public static string SelectedProfByLetters(string str)
        {
            string result = "";
            int i = 1;
            List<string> professions = ProfessionsService.GetProfessionsByLetters(str);
            professions.ForEach(c => { result += $"למקצוע {c} הקש {i++}"; });
            return result;
        }
        public static string selectedAreas()
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                string result = "";
            int i = 1;
            db.Areas.ToList().ForEach(a => { result += $"לאיזור{a.AreaName}הקש{i++}"; });
            return result;
            }
        }
        public static string selectedCities(int area)
        {
            string result = "";
            int i = 1;
            List<Cities> cities = RecommendationService.GetCitiesByArea(area);
            cities.ForEach(c => { result += $"לעיר{c.CityName}הקש{i++}"; });
            return result;
        }
        public static string selectedRecommended(int letterForProf,int profession, int area, int city)
        {
            string result = "";
            List<Professionals> Professionals = RecommendationService.GetFilteredProfessionals(letterForProf,profession, area, city);
            int i = 1;
            Professionals.ForEach(c => { result += $"מומלץ{i++}{c.FirstName}{c.LastName}כתובת{c.Street}{c.NumHouse}{c.Users.City}טלפון{c.Users.UserPhone}מייל{c.Users.UserEmail}"; });
            return result;
        }
    }
}
