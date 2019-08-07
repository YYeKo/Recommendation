using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class RecommendationsDTO
    {
        public int recommendationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Professional { get; set; }
        public Nullable<System.DateTime> RecommendationDate { get; set; }
        public Nullable<bool> IsEnable { get; set; }
        public Nullable<int> RatePrice { get; set; }
        public Nullable<int> RateProfessionalism { get; set; }
        public Nullable<int> RateArrival { get; set; }
        public string Comments { get; set; }
    }
}
