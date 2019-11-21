using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDTOES.DoctorDTO
{
	public class DoctorHour
	{
		public int DateID { get; set; }

		public int ID { get; set; }

		public string DoctorName { get; set; }

		public string DoctorSurname { get; set; }

		public string IdentificationNumber { get; set; }

		public bool IsWomen { get; set; }

		public bool IsCame { get; set; }

		public int PatientID { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public int Age { get; set; }

		public DateTime DatesDate { get; set; }

		public DateTime Time { get; set; }
	}
}
