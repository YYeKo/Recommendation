using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.convertion
{
    public class RecommendationConvertion
    {
        public static Recommendations RecommendationToDal(RecommendationsDTO recommendation)
        {
            return new Recommendations()
            {
                recommendationId = recommendation.recommendationId,
                Professional = recommendation.Professional,
                RecommendationDate = recommendation.RecommendationDate,
                UserId = recommendation.UserId,
                IsEnable = recommendation.IsEnable,
                Comments = recommendation.Comments,
                RateArrival = recommendation.RateArrival,
                RatePrice = recommendation.RatePrice,
                RateProfessionalism = recommendation.RateProfessionalism

            };
        }
        public static RecommendationsDTO RecommendationToDTO(Recommendations recommendation)
        {
            return new RecommendationsDTO()
            {
                recommendationId = recommendation.recommendationId,
                Professional = recommendation.Professional,
                RecommendationDate = recommendation.RecommendationDate,
                UserId = recommendation.UserId,
                IsEnable = recommendation.IsEnable,
                Comments = recommendation.Comments,
                RateArrival = recommendation.RateArrival,
                RatePrice = recommendation.RatePrice,
                RateProfessionalism = recommendation.RateProfessionalism
            };
        }
        public static List<Recommendations> RecommendationListToDal(List<RecommendationsDTO> recommendations)
        {
            return recommendations.Select(u => RecommendationToDal(u)).ToList();
        }
        public static List<RecommendationsDTO> RecommendationListToDTO(List<Recommendations> recommendations)
        {
            return recommendations.Select(u => RecommendationToDTO(u)).ToList();
        }
    }
}
