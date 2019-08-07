using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string CityName { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<bool> IsManager { get; set; }
    }
}
