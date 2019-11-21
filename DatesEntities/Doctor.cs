using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesEntities
{
    public class Doctor
    {
        public int ID { get; set; }
        public string IdentificationNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int PolyClinicID { get; set; }


        public override string ToString()
        {
            return this.DoctorName + this.DoctorSurname;
        }
    }
}
