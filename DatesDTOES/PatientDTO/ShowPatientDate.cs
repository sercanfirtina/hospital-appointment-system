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

		private string _hour;//09:00 gibi bir formata soktum
		public string Hour
		{
			get
			{
				return this._hour;
			}
			set
			{
				if (value != null)
				{
					string date = value;
					date = date.ToString().Split(' ')[1];// 09:00:00.000
					_hour = date.Substring(0, date.LastIndexOf(':'));//09:00
				}
			}
		}

		public string IdentificationNumber { get; set; }
		public string HospitalName { get; set; }
		public string DoctorName { get; set; }
		public string DoctorSurname { get; set; }
		public string CityName { get; set; }
		public string DistrictName { get; set; }
		public string PolyClinicName { get; set; }
		public DateTime DatesDate { get; set; }

	}
}
