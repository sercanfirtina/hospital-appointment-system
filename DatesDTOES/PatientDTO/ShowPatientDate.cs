using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDTOES
{
	public class ShowPatientDate
	{
		public int PatientID { get; set; }
		public int DateID { get; set; }
		public string IdentificationNumber {get;set;}
		public string HospitalName { get; set; }
		public string DoctorName { get; set; }
		public string DoctorSurname { get; set; }
		public string CityName { get; set; }
		public string DistrictName { get; set; }
		public string PolyClinicName { get; set; }
		public DateTime DatesDate { get; set; }

    }
}
