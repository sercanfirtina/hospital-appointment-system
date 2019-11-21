using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDTOES.PatientDTO
{
	public class InsertDateDTO
	{
		public int PatID { get; set; }
		public DateTime selectedDate { get; set; }
		public int selectedTimeID { get; set; }
		public int selectedCityID { get; set; }
		public int selectedDistrictID { get; set; }
		public int selectedHospitalID { get; set; }
		public int selectedPolyclinicID { get; set; }
		public int selectedDoctorID { get; set; }
	}
}
