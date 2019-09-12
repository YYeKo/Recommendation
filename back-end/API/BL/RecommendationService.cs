using BL.convertion;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using BL.helpers;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RecommendationService
    {
        /// <summary>
        /// function for create a recommendation 
        /// if the ratings is null- put 50 on it
        /// take the date of today
        /// </summary>
        /// <param name="recommendation"></param>
        /// <returns></returns>
        public static bool CreateRecommendation(RecommendationsDTO recommendation)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                var rec = db.Recommendations.FirstOrDefault(r => r.Professional == recommendation.Professional && r.UserId == recommendation.UserId);
            if (rec != null)
                return false;
            recommendation.RateArrival = recommendation.RateArrival == null ? 50 : recommendation.RateArrival;
            recommendation.RatePrice = recommendation.RatePrice == null ? 50 : recommendation.RatePrice;
            recommendation.RateProfessionalism = recommendation.RateProfessionalism == null ? 50 : recommendation.RateProfessionalism;
            recommendation.RecommendationDate = DateTime.Now;
            
                db.Recommendations.Add(RecommendationConvertion.RecommendationToDal(recommendation));
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }

            }
        }
        /// <summary>
        /// search the recommendation of profesional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<RecommendationsDTO> GetRecommendationsOfProf(int id)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                List<RecommendationsDTO> p = RecommendationConvertion.RecommendationListToDTO(db.Recommendations.Where(r => r.Professional == id).ToList());
            return p;
            }
        }

        /// <summary>
        /// return list of profession filtered by profession and city
        /// </summary>
        /// <param name="profession"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public static List<RecForProf> GetFilteredProfessionals(int profession, int city)//google maps!!!!!!!!!!!!!!!!
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {
                List<Professionals> f = db.Professionals.ToList();
                List<ProfessionForProfessionalDTO> s = ProfForProfConvertion.ProfForProfListToDTO(db.ProfessionForProfessional.ToList());
                List<RecForProf> d = f.Where(p => p.Users.City == city &&
                profession == s.FirstOrDefault(e => e.Professional == p.Users.UserId)?.Profession).Select(p=>
                new RecForProf {
                    Professional =convertion.ProfessionalConvertion.ProfessionalToDTO(p),NumRec=p.Recommendations.Count
                    ,RateArrival=(int)p.Recommendations.ToList().Average(r=>r.RateArrival).Value
                    ,RatePrice=(int)p.Recommendations.ToList().Average(r=>r.RatePrice).Value
                    ,RateProfessionalism=(int)p.Recommendations.ToList().Average(r=>r.RateProfessionalism).Value
                }).ToList();
                return d;
            }
        }
        //    public static List<ProfessionalDTO> GetFilteredProfessionals(int profession, int city)
        //    {
        //        using (RecommendationsEntities2 db = new RecommendationsEntities2())
        //        {
        //            List<ProfessionalDTO> profByspec = ProfessionalConvertion.ProfessionalsListToDTO(db.Professionals.ToList());
        //            List<SpecializationsForProfessionalsDTO> specializations = SpecForProfConvertion.SpecForProfListToDTO(db.SpecializationsForProfessionals.ToList());
        //            profByspec = profByspec.Where(p => profession == specializations.FirstOrDefault(e => e.Professional == p.UserId)?.specialization).ToList();
        //            List<ProfessionalDTO> professionalResult = profByspec.Where(p => p.City == city).ToList();
        //            if (professionalResult.Count() == 0 && profByspec.Count() > 0)
        //            {
        //                professionalResult = ProfessionalConvertion.ProfessionalsListToDTO(ProfessionalConvertion.ProfessionalsListToDal(professionalResult).Where(p => p.Users.Cities.Area == GetAreaByCityId(city)).ToList());
        //            }
        //            return professionalResult;

        //        }
        //    }
        //    public static int GetAreaByCityId(int city)
        //    {
        //        using (RecommendationsEntities2 db = new RecommendationsEntities2())
        //        {
        //            List<CitiesDTO> cities = CitiesConvertion.CityListToDTO(db.Cities.ToList());
        //            return cities.Find(f => f.CityId == city).Area.Value;
        //        }
        //    }
        //}

        public static List<Cities> GetCitiesByArea(int area)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            {

                return db.Cities.Where(c => c.Area == area).ToList();
            }
        }
        public static List<Professionals> GetFilteredProfessionals(int letterForProf, int profession, int area, int city)
        {
            using (RecommendationsEntities3 db = new RecommendationsEntities3())
            { 
                List<string> profName = ProfessionsService.GetProfessionsByLetters(VoiceService.SelectedLetters(letterForProf));
            List<Cities> cities = GetCitiesByArea(area);
            int prof =ProfessionsService.GetProfessionbyName( profName[profession]);
            int c=cities[city].CityId;
            List<Professionals> professionals = db.Professionals.ToList();
            List<ProfessionForProfessional> specforProf = db.ProfessionForProfessional.ToList();
            List<Professionals> result = professionals.Where(p => p.Users.City == c && prof == specforProf.FirstOrDefault(s => s.Professional == p.ProfessionalId).Profession).ToList();

            return result;
            }
        }

    }
}
