using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }

        public override string ToString()
        {
            return this.CityName;
        }
    }
}
