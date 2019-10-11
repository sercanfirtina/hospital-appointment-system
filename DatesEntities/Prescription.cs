using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class Prescription
    {
        public int DateID { get; set; }
        public string PrescriptionDescription { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string PrescriptionCode { get; set; }

    }
}
