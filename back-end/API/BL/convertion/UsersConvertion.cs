using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL.convertion
{
   public class UsersConvertion
    {
        public static Users UserToDal(UsersDTO user)
        {
            return new Users(){City=user.City,IsManager=user.IsManager,UserId=user.UserId, UserEmail=user.UserEmail, UserPassword=user.UserPassword, UserPhone=user.UserPhone, UserName=user.UserName };
        }
        public static UsersDTO UserToDTO(Users user)
        {
            return new UsersDTO() { City=user.City,CityName=user.Cities.CityName, UserName=user.UserName, UserPhone=user.UserPhone, UserPassword=user.UserPassword, UserEmail=user.UserEmail, UserId=user.UserId, IsManager=user.IsManager};
        }
        public static List< Users >UserListToDal(List< UsersDTO> users)
        {
            return users.Select(u => UserToDal(u)).ToList();
        }
        public static List<UsersDTO> UserListToDTO(List<Users> users)
        {
            return users.Select(u=> UserToDTO(u)).ToList();
        }
    }
}