using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class Date
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public DateTime DatesDate { get; set; }
        public int TimeID { get; set; }
        public int CityID { get; set; }
        public int DiscrictID { get; set; }
        public int HospitalID { get; set; }
        public int PolyClinicID { get; set; }
        public int DoctorID { get; set; }
        public bool IsActive { get; set; }
        public bool DidItCame { get; set; }
    }
}
