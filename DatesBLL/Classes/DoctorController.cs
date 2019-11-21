using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesBLL.Interfaces;
using DatesDAL;
using DatesDAL.Interfaces;
using DatesDTOES.DoctorDTO;
using DatesEntities;

namespace DatesBLL.Classes
{
    public class DoctorController : IDoctorController
    {
		private IDoctorManagment _IdoctorManagement;

		public DoctorController(IDoctorManagment IdoctorManagment)
        {
			this._IdoctorManagement = IdoctorManagment;
		}

		public Doctor LoginDoctor(string email, string pass)
		{
			Doctor doctor = this._IdoctorManagement.LoginDoctor(email, pass);

			return doctor;
		}
		public bool AddDoctor(Doctor doctor)
		{
			bool result = this._IdoctorManagement.AddDoctor(doctor);

			return result;
		}
		public string FindDoctorEmail(string email)
		{
			return this._IdoctorManagement.FindDoctorEmail(email);
		}
		public void UpdateDoctor(Doctor updateDoctor)
		{
			_IdoctorManagement.UpdateDoctor(updateDoctor);
		}
		public void updateDoctor(Patient updateDoctor)
		{
			throw new NotImplementedException();
		}
		public List<DoctorHour> DoctorDatesHour(int DoctorID)
		{
			return this._IdoctorManagement.DoctorDatesHour(DoctorID);
		}

		public List<PolyClinics> ListOfPolyClinic()
		{
			return _IdoctorManagement.ListOfPolyClinic();
		}

		public List<Diagnosis> ListOfDiagnosis()
		{
			return _IdoctorManagement.ListOfDiagnosis();
		}

		public bool IsAddedPrescription(Prescription prescription)
		{
			return _IdoctorManagement.IsAddedPrescription(prescription);
		}

		public bool AddedDiagnosis(int PatientID, int DiagnosisID)
		{
			return _IdoctorManagement.AddedDiagnosis(PatientID, DiagnosisID);
		}
	}
}
