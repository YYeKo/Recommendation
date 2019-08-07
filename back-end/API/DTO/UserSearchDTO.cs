using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class UserSearchDTO
    {
        public int UserSearchId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Professional { get; set; }
        public Nullable<System.DateTime> SearchDate { get; set; }

    }
}
