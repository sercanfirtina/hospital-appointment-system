using DatesBLL.Interfaces;
using DatesDAL;
using DatesDAL.Interfaces;
using DatesDTOES;
using DatesDTOES.PatientDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesBLL.Classes
{
    public class PatientController : IPatientController
    {
        private IPatientManagement _IpatientManagement;

        //IPatientManagement(DatesDAL) içindeki interface ondan türeyen sınıfları referans aldığı için formdan gelen referansı tutar ve gelen referans tipine göre işlemleri gerçekleştirir.
        public PatientController(IPatientManagement IpatientManagement)
        {
            this._IpatientManagement = IpatientManagement;
        }

        public bool AddPatient(Patient patient)
        {
            bool result = this._IpatientManagement.AddPatient(patient);

            return result;
        }

        public Patient LoginPatient(string email, string pass)
        {
            Patient patient = this._IpatientManagement.LoginPatient(email, pass);

            return patient;
        }

        public string FindEmail(string email)
        {
            return this._IpatientManagement.FindEmail(email);
        }

        public void UpdatePatient(Patient updatePatient)
        {
            _IpatientManagement.UpdatePatient(updatePatient);
        }

        public List<Prescription> GetAllPrescription(int id)
        {
            return _IpatientManagement.GetAllPrescription(id);
        }

        public List<ShowPatientDate> GetAllDateByPatientID(int PatienId)
        {
            return _IpatientManagement.GetAllDateByPatientID(PatienId);
        }

        public List<City> GetAllCitis()
        {
            return _IpatientManagement.GetAllCitis();
        }

        public List<District> GetAllDistrict(int cityID)
        {
            return _IpatientManagement.GetAllDistrict(cityID);
        }

        public List<Hospital> GetAllHospitalsByDistrictID(int districtId)
        {
            return _IpatientManagement.GetAllHospitalsByDistrictID(districtId);
        }

        public List<PolyClinics> GetAllPolyclinicByHospitalID(int hospitalID)
        {
            return _IpatientManagement.GetAllPolyclinicByHospitalID(hospitalID);
        }
        public List<Doctor> GetAllDoctorByPolyClinicID(int polyClinicID)
        {
            return _IpatientManagement.GetAllDoctorByPolyClinicID(polyClinicID);
        }

        public List<Doctor> GetAllDoctorByHospitalId(int hospitalID)
        {
            return _IpatientManagement.GetAllDoctorByHospitalId(hospitalID);
        }

		public List<HourDTO> GetAllHoursOfDoctor(int doctorID, DateTime selectedDateTime)
		{
			return _IpatientManagement.GetAllHoursOfDoctor(doctorID,selectedDateTime);
		}

		public void AddDate(InsertDateDTO insertDate)
		{
			_IpatientManagement.AddDate(insertDate);
		}
	}
}
