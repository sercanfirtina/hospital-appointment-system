using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class PolyClinics
    {
        public int ID { get; set; }
        public string PolycilinicName { get; set; }

        public override string ToString()
        {
            return this.PolycilinicName;
        }
    }
}
