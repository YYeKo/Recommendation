using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.convertion
{
    public class AreasConvertion
    {
        public static Areas AreaToDal(AreasDTO area)
        {
            return new Areas()
            {
                AreaId = area.AreaId,
                AreaName = area.AreaName
            };
        }
        public static AreasDTO AreaToDTO(Areas area)
        {
            return new AreasDTO()
            {
                AreaId = area.AreaId,
                AreaName = area.AreaName
            };
        }        
        public static List<Areas> AreaListToDal(List<AreasDTO> areas)
        {
            return areas.Select(u => AreaToDal(u)).ToList();
        }
        public static List<AreasDTO> AreaListToDTO(List<Areas> areas)
        {
            return areas.Select(u => AreaToDTO(u)).ToList();
        }
    }
}
