using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesDTOES.DoctorDTO;
using DatesEntities;

namespace DatesBLL.Interfaces
{
    public interface IDoctorController
    {
		Doctor LoginDoctor(string email, string pass);

		bool AddDoctor(Doctor doctor);

		string FindDoctorEmail(string email);

		void updateDoctor(Patient updateDoctor);

		List<DoctorHour> DoctorDatesHour(int DoctorID);

		List<PolyClinics> ListOfPolyClinic();

		List<Diagnosis> ListOfDiagnosis();
		bool IsAddedPrescription(Prescription prescription);
		bool AddedDiagnosis(int PatientID, int DiagnosisID);
	}
}
