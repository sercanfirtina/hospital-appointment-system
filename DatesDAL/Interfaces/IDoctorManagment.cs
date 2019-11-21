using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesDTOES.DoctorDTO;
using DatesEntities;

namespace DatesDAL.Interfaces
{
    public  interface IDoctorManagment
    {
		Doctor LoginDoctor(string email, string pass);
		bool AddDoctor(Doctor doctor);
		string FindDoctorEmail(string email);
		void UpdateDoctor(object updateDoctor);
		List<DoctorHour> DoctorDatesHour(int DoctorID);

		List<PolyClinics> ListOfPolyClinic();
		List<Diagnosis> ListOfDiagnosis();

		bool IsAddedPrescription(Prescription prescription);
		bool AddedDiagnosis(int PatientID, int DiagnosisID);

	}
}
