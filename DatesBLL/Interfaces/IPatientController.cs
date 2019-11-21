using DatesDTOES;
using DatesDTOES.PatientDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesBLL.Interfaces
{
    public interface IPatientController
    {
        Patient LoginPatient(string email, string pass);
		bool AddPatient(Patient patient);
		string FindEmail(string email);
		void UpdatePatient(Patient updatePatient);
		List<Prescription> GetAllPrescription(int id);
		List<ShowPatientDate> GetAllDateByPatientID(int PatienId);
        List<City> GetAllCitis();
        List<District> GetAllDistrict(int cityID);
        List<Hospital> GetAllHospitalsByDistrictID(int districtId);
        List<PolyClinics> GetAllPolyclinicByHospitalID(int hospitalID);
        List<Doctor> GetAllDoctorByPolyClinicID(int polyClinicID);
        List<Doctor> GetAllDoctorByHospitalId(int hospitalID);
		List<HourDTO> GetAllHoursOfDoctor(int doctorID, DateTime selectedDateTime);
		void AddDate(InsertDateDTO insertDate);
	}
}
