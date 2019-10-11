using DatesDAL.Interfaces;
using DatesDTOES;
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
			if(_con.State ==ConnectionState.Closed)
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

                    while(_rdr.Read())
                    {                       
                        responsedPatient.ID=Convert.ToInt32(_rdr["ID"]);
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
				int responseValue =_cmd.ExecuteNonQuery();

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
					while(_rdr.Read())
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
            using (_cmd=new SqlCommand("sp_UpdatePatientInformation", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id",updatePatient.ID);
                _cmd.Parameters.AddWithValue("@name",updatePatient.Name);
                _cmd.Parameters.AddWithValue("@surname",updatePatient.Surname);
                _cmd.Parameters.AddWithValue("@mail",updatePatient.Mail);
                _cmd.Parameters.AddWithValue("@password",updatePatient.Password);
                _cmd.Parameters.AddWithValue("@phoneNumber",updatePatient.PhoneNumber);

                ConnectionSetting();

                _cmd.ExecuteNonQuery();

                ConnectionSetting();

            }
        }

        public List<Prescription>GetAllPrescription(int id)
        {
            using (_cmd = new SqlCommand("sp_getAllPresscriptionByID", _con))
            {
                List<Prescription> prescriptionList = null;
                
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id",id);
                ConnectionSetting();

                _rdr = _cmd.ExecuteReader();

                if(_rdr.HasRows)
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
		
		public List<ShowPatientDate>GetAllDateByPatientID(int PatienId)
		{

			using (_cmd = new SqlCommand("sp_getDateByPationID", _con))
			{
				_cmd.CommandType = CommandType.StoredProcedure;
				_cmd.Parameters.AddWithValue("@id",PatienId);

				ConnectionSetting();

				_rdr = _cmd.ExecuteReader();

				List<ShowPatientDate> responseDateList = null;

				if(_rdr.HasRows)
				{
					while(_rdr.Read())
					{
						ShowPatientDate newDate = new ShowPatientDate();
						responseDateList = new List<ShowPatientDate>();
						newDate.PatientID = PatienId;//Gelen id zaten ilgili hastanın Id değeri
						newDate.DateID = Convert.ToInt16(_rdr["DID"]);
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
    }
}
