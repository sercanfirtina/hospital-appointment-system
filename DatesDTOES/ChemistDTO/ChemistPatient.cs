using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDTOES.ChemistDTO
{
    public class ChemistPatient
    {
        public int DateID { get; set; }
        public string PrescriptionCode { get; set; }
        public string PrescriptionDescription { get; set; }
        public DateTime PrescDate { get; set; }
        public string PatIdentificationNumber { get; set; }

    }
}
