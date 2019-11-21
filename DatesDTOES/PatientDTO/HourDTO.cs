using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDTOES.PatientDTO
{
    public class HourDTO
    {
        public int HourID { get; set; }
        public DateTime DoctorTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
