using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
     public class District
    {
        public int ID { get; set; }
        public string DistrictName { get; set; }
        public  int CityID { get; set; }
    }
}
