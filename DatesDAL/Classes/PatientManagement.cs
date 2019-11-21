using DatesDAL.Interfaces;
using DatesDTOES;
using DatesDTOES.PatientDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DatesDAL
{
    public class PatientManagement : IPatientManagement
    {
        SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConn"].ConnectionString);
        SqlCommand _cmd;
        SqlDataReader _rdr;

        public void ConnectionSetting()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
            else
            {
                _con.Close();
            }
        }

        public Patient LoginPatient(string email, string pass)
        {
            using (_cmd = new SqlCommand("sp_LoginPatient", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@mail", email);
                _cmd.Parameters.AddWithValue("@password", pass);

                Patient responsedPatient = null;

                ConnectionSetting();
                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    responsedPatient = new Patient();

                    while (_rdr.Read())
                    {
                        responsedPatient.ID = Convert.ToInt32(_rdr["ID"]);
                        responsedPatient.Name = _rdr["Name"].ToString();
                        responsedPatient.Surname = _rdr["Surname"].ToString();
                        responsedPatient.Mail = _rdr["mail"].ToString();
                        responsedPatient.Password = _rdr["Password"].ToString();
                        responsedPatient.PhoneNumber = _rdr["PhoneNumber"].ToString();
                        responsedPatient.IsWomen = Convert.ToBoolean(_rdr["IsWomen"]);
                        responsedPatient.IdentificationNumber = _rdr["IdentificationNumber"].ToString();
                        responsedPatient.Birthdate = Convert.ToDateTime(_rdr["Birthdate"]);
                    }
                    ConnectionSetting();
                    return responsedPatient; // reader dan okumnan değer döndürürse bu geri döner
                }
                else
                {
                    ConnectionSetting();
                    return responsedPatient;//Reader dan satır gelmezse null döner
                }
            }
        }

        public bool AddPatient(Patient patient)
        {
            using (_cmd = new SqlCommand("sp_createPatient", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@idNumber", patient.IdentificationNumber);
                _cmd.Parameters.AddWithValue("@name", patient.Name);
                _cmd.Parameters.AddWithValue("@surname", patient.Surname);
                _cmd.Parameters.AddWithValue("@mail", patient.Mail);
                _cmd.Parameters.AddWithValue("@password", patient.Password);
                _cmd.Parameters.AddWithValue("@gender", patient.IsWomen);
                _cmd.Parameters.AddWithValue("@phoneNumber", patient.PhoneNumber);
                _cmd.Parameters.AddWithValue("@birthdate", patient.Birthdate);

                ConnectionSetting();
                int responseValue = _cmd.ExecuteNonQuery();

                if (responseValue < 0)
                {
                    ConnectionSetting();
                    return false;//kayıt eklenmedi
                }
                else
                {
                    ConnectionSetting();
                    return true;//kayıt eklendi .
                }
            }
        }

        public string FindEmail(string mail)
        {
            using (_cmd = new SqlCommand("sp_FindPatientMail", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@mail", mail);

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                string result = string.Empty;

                //result > 0 durumunda db de o mail adresi mevcut olduğunu gösterir.
                //Mevcut ise mail gönderebiliriz
                if (_rdr.HasRows)
                {
                    while (_rdr.Read())
                    {
                        result = _rdr[0].ToString();
                    }
                    ConnectionSetting();
                    return result;
                }
                else
                {
                    ConnectionSetting();
                    return result;
                }
            }
        }

        public void UpdatePatient(Patient updatePatient)
        {
            using (_cmd = new SqlCommand("sp_UpdatePatientInformation", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", updatePatient.ID);
                _cmd.Parameters.AddWithValue("@name", updatePatient.Name);
                _cmd.Parameters.AddWithValue("@surname", updatePatient.Surname);
                _cmd.Parameters.AddWithValue("@mail", updatePatient.Mail);
                _cmd.Parameters.AddWithValue("@password", updatePatient.Password);
                _cmd.Parameters.AddWithValue("@phoneNumber", updatePatient.PhoneNumber);

                ConnectionSetting();

                _cmd.ExecuteNonQuery();

                ConnectionSetting();

            }
        }

        public List<Prescription> GetAllPrescription(int id)
        {
            using (_cmd = new SqlCommand("sp_getAllPresscriptionByID", _con))
            {
                List<Prescription> prescriptionList = null;

                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", id);
                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    prescriptionList = new List<Prescription>();
                    while (_rdr.Read())
                    {
                        Prescription responsedPrescription = new Prescription();
                        responsedPrescription.DateID = Convert.ToInt16(_rdr["DateID"]);
                        responsedPrescription.PrescriptionDate = Convert.ToDateTime(_rdr["Date"]);
                        responsedPrescription.PrescriptionDescription = _rdr["Description"].ToString();
                        responsedPrescription.PrescriptionCode = _rdr["Code"].ToString();

                        prescriptionList.Add(responsedPrescription);
                    }
                    prescriptionList.TrimExcess();//listin kapasitesini gerçek boyutuna ayarlar.
                    ConnectionSetting();
                    return prescriptionList;
                }
                else
                {
                    ConnectionSetting();
                    return prescriptionList;
                }

            }


        }

        public List<ShowPatientDate> GetAllDateByPatientID(int PatienId)
        {

            using (_cmd = new SqlCommand("sp_getDateByPationID", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", PatienId);

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                List<ShowPatientDate> responseDateList = null;

                if (_rdr.HasRows)
                {
					responseDateList = new List<ShowPatientDate>();

					while (_rdr.Read())
                    {
                        ShowPatientDate newDate = new ShowPatientDate();
						newDate.PatientID = Convert.ToInt16(_rdr["PID"]);
                        newDate.DateID = Convert.ToInt16(_rdr["DID"]);
						newDate.Hour = _rdr["Time"].ToString();
                        newDate.IdentificationNumber = _rdr["PatIdentification"].ToString();
                        newDate.DoctorName = _rdr["DocName"].ToString();
                        newDate.DoctorSurname = _rdr["DocSurname"].ToString();
                        newDate.CityName = _rdr["CityName"].ToString();
                        newDate.DistrictName = _rdr["DistName"].ToString();
                        newDate.DatesDate = Convert.ToDateTime(_rdr["DAtesDate"]);
                        newDate.PolyClinicName = _rdr["PolyName"].ToString();
                        newDate.HospitalName = _rdr["HosName"].ToString();

                        responseDateList.Add(newDate);
                    }
                    ConnectionSetting();
                    return responseDateList;
                }
                else
                {
                    ConnectionSetting();
                    return responseDateList;
                }

            }
        }

		public List<City> GetAllCitis()
        {
            using (_cmd = new SqlCommand("sp_City", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                List<City> CityList = null;

                if (_rdr.HasRows)
                {
                    CityList = new List<City>();
                    while (_rdr.Read())
                    {
                        City city = new City();
                        city.ID = Convert.ToInt16(_rdr["CityID"]);
                        city.CityName = _rdr["Name"].ToString();

                        CityList.Add(city);
                    }

                    ConnectionSetting();
                    return CityList;
                }
                else
                {
                    ConnectionSetting();
                    return CityList;
                }
            }
        }

        public List<District> GetAllDistrict(int cityID)
        {
            using (_cmd = new SqlCommand("sp_GetAllDistrict", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@CtyID", cityID);

                ConnectionSetting();

                List<District> responedList = null;
                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    responedList = new List<District>();
                    while (_rdr.Read())
                    {

                        District district = new District();
                        district.ID = Convert.ToInt16(_rdr["DId"]);
                        district.CityID = cityID;
                        district.DistrictName = _rdr["DName"].ToString();

                        responedList.Add(district);
                    }
                    ConnectionSetting();
                    return responedList;
                }
                else
                {
                    ConnectionSetting();
                    return responedList;
                }
            }
        }

        public List<Hospital> GetAllHospitalsByDistrictID(int districtId)
        {
            using (_cmd = new SqlCommand("sp_GetHospitalByDistrictID", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@distID", districtId);

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                List<Hospital> hospitalList = null;

                if (_rdr.HasRows)
                {
                    hospitalList = new List<Hospital>();
                    while (_rdr.Read())
                    {
                        Hospital hospital = new Hospital();
                        hospital.ID = Convert.ToUInt16(_rdr["HospID"]);
                        hospital.DistrictID = districtId;
                        hospital.HospitalName = _rdr["HospName"].ToString();

                        hospitalList.Add(hospital);
                    }
                    ConnectionSetting();
                    return hospitalList;
                }
                else
                {
                    ConnectionSetting();
                    return hospitalList;
                }
            }
        }

        public List<PolyClinics> GetAllPolyclinicByHospitalID(int hospitalID)
        {
            //Sorun çıkarsa DTO ile çözmeyi deneyebiliriz.
            using (_cmd = new SqlCommand("sp_GetPolyclinicByHospitalID", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@hosID", hospitalID);

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                List<PolyClinics> polyClinicList = null;
                if (_rdr.HasRows)
                {
                    polyClinicList = new List<PolyClinics>();
                    while (_rdr.Read())
                    {
                        PolyClinics polyClinics = new PolyClinics();
                        polyClinics.ID = Convert.ToInt16(_rdr["PolyclinicID"]);
                        polyClinics.PolycilinicName = _rdr["PolyclicinName"].ToString();

                        polyClinicList.Add(polyClinics);
                    }
                    ConnectionSetting();
                    return polyClinicList;
                }
                else
                {
                    ConnectionSetting();
                    return polyClinicList;
                }

            }
        }

        public List<Doctor> GetAllDoctorByPolyClinicID(int polyClinicID)
        {
            using (_cmd = new SqlCommand("sp_GetDoctorByPolyclinicID", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@polyClncID", polyClinicID);

                if (_con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }

                List<Doctor> doctorList = null;
                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    doctorList = new List<Doctor>();

                    while (_rdr.Read())
                    {
                        Doctor doctor = new Doctor();
                        doctor.ID = Convert.ToInt16(_rdr["ID"]);
                        doctor.DoctorName = _rdr["DoctorName"].ToString();
                        doctor.DoctorSurname = _rdr["DoctorSurname"].ToString();
                        doctor.IdentificationNumber = _rdr["IdentificationNumber"].ToString();
                        doctor.Mail = _rdr["DoctorMail"].ToString();
                        doctor.Password = _rdr["DoctorPassword"].ToString();
                        doctor.PhoneNumber = _rdr["PhoneNumber"].ToString();
                        doctor.PolyClinicID = Convert.ToInt16(_rdr["HospitalPloyclinicID"]);

                        doctorList.Add(doctor);
                    }

                    ConnectionSetting();
                    return doctorList;
                }
                else
                {
                    ConnectionSetting();
                    return doctorList;
                }
            }


        }

        public List<Doctor> GetAllDoctorByHospitalId(int hospitalID)
        {
            using (_cmd = new SqlCommand("sp_getDoctorByHospitalID", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@hospID", hospitalID);

                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                List<Doctor> doctorList = null;

                if (_rdr.HasRows)
                {
                    doctorList = new List<Doctor>();
                    while (_rdr.Read())
                    {
                        Doctor doctor = new Doctor();
                        doctor.ID = Convert.ToInt16(_rdr["ID"]);
                        doctor.DoctorName = _rdr["DoctorName"].ToString();
                        doctor.DoctorSurname = _rdr["DoctorSurname"].ToString();
                        doctor.IdentificationNumber = _rdr["IdentificationNumber"].ToString();
                        doctor.Mail = _rdr["DoctorMail"].ToString();
                        doctor.Password = _rdr["DoctorPassword"].ToString();
                        doctor.PhoneNumber = _rdr["PhoneNumber"].ToString();
                        doctor.PolyClinicID = Convert.ToInt16(_rdr["HospitalPloyclinicID"]);

                        doctorList.Add(doctor);
                    }

                    ConnectionSetting();
                    return doctorList;
                }
                else
                {
                    ConnectionSetting();
                    return doctorList;
                }

            }
        }

        public List<HourDTO> GetAllHoursOfDoctor(int doctorID ,DateTime selectedDateTime)
        {
            using (_cmd = new SqlCommand("sp_GetAllHoursOfDoctor", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@doctorsID", doctorID);
				_cmd.Parameters.AddWithValue("@datesDate", selectedDateTime);

                ConnectionSetting();

                List<HourDTO> ListOfAllHours = null;

                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    ListOfAllHours = new List<HourDTO>();

                    while (_rdr.Read())
                    {
                        HourDTO hourDTO = new HourDTO();
                        hourDTO.HourID = Convert.ToInt16(_rdr["HourID"]);
                        hourDTO.DoctorTime = Convert.ToDateTime(_rdr["Time"]);
                        ListOfAllHours.Add(hourDTO);
                    }
                    ConnectionSetting();
                    return ListOfAllHours;
                }
                else
                {
                    ConnectionSetting();
                    return ListOfAllHours;
                }
            }
        }
		
		public void AddDate(InsertDateDTO insertDate)
		{
			using (_cmd = new SqlCommand("sp_AddDate",_con))
			{
				_cmd.CommandType = CommandType.StoredProcedure;
				_cmd.Parameters.AddWithValue("@PatID", insertDate.PatID);
				_cmd.Parameters.AddWithValue("@selectedDate", insertDate.selectedDate);
				_cmd.Parameters.AddWithValue("@selectedTimeID", insertDate.selectedTimeID);
				_cmd.Parameters.AddWithValue("@selectedCityID", insertDate.selectedCityID);
				_cmd.Parameters.AddWithValue("@selectedDistrictID", insertDate.selectedDistrictID);
				_cmd.Parameters.AddWithValue("@selectedHospitalID", insertDate.selectedHospitalID);
				_cmd.Parameters.AddWithValue("@selectedPolyclinicID", insertDate.selectedPolyclinicID);
				_cmd.Parameters.AddWithValue("@selectedDoctorID", insertDate.selectedDoctorID);

				ConnectionSetting();

				_cmd.ExecuteNonQuery();

				ConnectionSetting();
			}
		}

    }
}
