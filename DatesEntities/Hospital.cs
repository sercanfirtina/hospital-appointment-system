using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class Hospital
    {
        public int ID { get; set; }
        public string HospitalName { get; set; }
        public int DistrictID { get; set; }

        public override string ToString()
        {
            return this.HospitalName;
        }
    }
}
