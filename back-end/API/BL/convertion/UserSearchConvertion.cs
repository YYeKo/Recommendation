using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.convertion
{
   public class UserSearchConvertion
    {
        public static UserSearch UserSearchToDal(UserSearchDTO userSearch)
        {
            return new UserSearch()
            {
              UserSearchId=userSearch.UserSearchId,
              SearchDate=userSearch.SearchDate,
              Professional=userSearch.Professional,
              UserId=userSearch.UserId
            };
        }
        public static UserSearchDTO UserSearchToDTO(UserSearch userSearch)
        {
            return new UserSearchDTO()
            {
                UserSearchId=userSearch.UserSearchId,
                UserId=userSearch.UserId,
                Professional=userSearch.Professional,
                SearchDate=userSearch.SearchDate
            };
        }
        public static List<UserSearch> UserSearchListToDal(List<UserSearchDTO> userSearch)
        {
            return userSearch.Select(u => UserSearchToDal(u)).ToList();
        }
        public static List<UserSearchDTO> UserSearchListToDTO(List<UserSearch> userSearch)
        {
            return userSearch.Select(u => UserSearchToDTO(u)).ToList();
        }
    }
}
