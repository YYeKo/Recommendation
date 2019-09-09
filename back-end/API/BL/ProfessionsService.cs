using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL.convertion;

namespace BL
{
    public class ProfessionsService
    {
        public static List<ProfessionDTO> GetProfessions()
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())//??????????????????????????????????
            {
                //להחזיר מייד רשימה של מקצועות וגם התמחויות או להחזיר רשימה של מקצועות וכאשר יבחר מקצוע תתבצע שוב קריאה לשרת ע"מ לקבל את רשימת ההתמחויות?????? 
                return ProfessionConvertion.professionsListToDTO(db.Professions.ToList());
            }
        }

        public static List<string> GetProfessionsByLetters(string str)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                List<string> profName = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                profName.AddRange( db.Professions.ToList().Where(p => p.ProfessionName[0] == str[i]).Select(n => n.ProfessionName).ToList());
            }
            return profName;
            }
        }

       
        //get profession id by profession name
        public static int GetProfessionbyName(string name)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                return db.Professions.FirstOrDefault(p => p.ProfessionName == name).ProfessionId;
            }
        }
    }
}


    