using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.convertion
{
   public class CitiesConvertion
    {
        public static Cities CityToDal(CitiesDTO city)
        {
            return new Cities()
            {
                 CityId=city.CityId,
                 CityName=city.CityName,
                 Area=city.Area                 
            };
        }
        public static CitiesDTO CityToDTO(Cities city)
        {
            return new CitiesDTO()
            {
                CityId = city.CityId,
                 CityName=city.CityName,
                  Area=city.Area,
                   AreaName=city.Areas.AreaName
            };
        }
        public static List<Cities> CityListToDal(List<CitiesDTO> cities)
        {
            return cities.Select(u => CityToDal(u)).ToList();
        }

        public static List<CitiesDTO> CityListToDTO(List<Cities> cities)
        {
            return cities.Select(u => CityToDTO(u)).ToList();
        }
    }
}
