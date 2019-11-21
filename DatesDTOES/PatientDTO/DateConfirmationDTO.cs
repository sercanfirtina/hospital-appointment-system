using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatesDTOES.PatientDTO
{
	public class DateConfirmationDTO
	{
		public int PersonID { get; set; }
		public string PersonIdentificationNumber { get; set; }
		public string PersonName { get; set; }
		public string PersonSurname { get; set; }
		public DateTime PersonBirthdate { get; set; }
		public string PersonMail { get; set; }
		public string PersonPhoneNumber { get; set; }
		public bool PersonIsWomen { get; set; }

		public int DoctorID { get; set; }
		public string DoctorName { get; set; }
		public string DoctorSurname { get; set; }
		public string DoctorMail { get; set; }

		public string SelectedCityName { get; set; }
		public int SelectedCityID { get; set; }

		public int SelectedDistrictID { get; set; }
		public string SelectedDistrictName { get; set; }

		public int SelectedHospitalId { get; set; }
		public string SelectedHospitalName { get; set; }

		public int SelectedPolyclinicId { get; set; }
		public string SelectedPolycilinicName { get; set; }

		public DateTime SelectedDate { get; set; }

		public int SelectedHoursID { get; set; }
		public string SelectedTime { get; set; }
	}
}
