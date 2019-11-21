using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesDAL.Interfaces;
using DatesDTOES.DoctorDTO;
using DatesEntities;

namespace DatesDAL.Classes
{
	public class DoctorManagement : IDoctorManagment
	{
		SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConn"].ConnectionString);
		SqlCommand sqlCommand;
		SqlDataReader reader;

		public void ConnectionSetting()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
			else
			{
				connection.Close();
			}
		}

		public Doctor LoginDoctor(string email, string pass)
		{
			using (sqlCommand = new SqlCommand("sp_LoginDoctor", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@mail", email);
				sqlCommand.Parameters.AddWithValue("@password", pass);

				Doctor responsedDoctor = null;

				ConnectionSetting();
				reader = sqlCommand.ExecuteReader();

				if (reader.HasRows)
				{
					responsedDoctor = new Doctor();

					while (reader.Read())
					{
						responsedDoctor.ID = Convert.ToInt16(reader["ID"]);
						responsedDoctor.DoctorName = reader["DoctorName"].ToString();
						responsedDoctor.DoctorSurname = reader["DoctorSurname"].ToString();
						responsedDoctor.Mail = reader["DoctorMail"].ToString();
						responsedDoctor.Password = reader["DoctorPassword"].ToString();
						responsedDoctor.PolyClinicID = Convert.ToInt16(reader["HospitalPloyclinicID"]);
					}
					ConnectionSetting();
					return responsedDoctor; // reader dan okumnan değer döndürürse bu geri döner
				}
				else
				{
					ConnectionSetting();
					return responsedDoctor;//Reader dan satır gelmezse null döner
				}
			}
		}
		public bool AddDoctor(Doctor doctor)
		{
			using (sqlCommand = new SqlCommand("sp_CreateDoctor", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@DocIdentificationNumber", doctor.IdentificationNumber);
				sqlCommand.Parameters.AddWithValue("@Docname", doctor.DoctorName);
				sqlCommand.Parameters.AddWithValue("@Docsurname", doctor.DoctorSurname);
				sqlCommand.Parameters.AddWithValue("@DocMails", doctor.Mail);
				sqlCommand.Parameters.AddWithValue("@DocPassword", doctor.Password);
				sqlCommand.Parameters.AddWithValue("@DocPolyID", doctor.PolyClinicID);


				ConnectionSetting();
				int responseValue = sqlCommand.ExecuteNonQuery();

				if (responseValue < 0)
				{
					ConnectionSetting();
					return false;   //kayıt eklenmedi
				}
				else
				{
					ConnectionSetting();
					return true;    //kayıt eklendi .
				}
			}
		}
		public string FindDoctorEmail(string email)
		{
			using (sqlCommand = new SqlCommand("sp_findMail", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@mail", email);

				ConnectionSetting();

				reader = sqlCommand.ExecuteReader();

				string result = string.Empty;

				//result > 0 durumunda db de o mail adresi mevcut olduğunu gösterir.
				//Mevcut ise mail gönderebiliriz
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						result = reader[0].ToString();
					}

					return result;
				}
				else
				{
					return result;
				}
			}
		}
		public void UpdateDoctor(object updateDoctor)
		{
			using (sqlCommand = new SqlCommand("sp_UpdateDoctorInformation", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				//sqlCommand.Parameters.AddWithValue("@id", updateDoctor.ID);
				//sqlCommand.Parameters.AddWithValue("@idNumber", updateDoctor.IdentificationNumber);
				//sqlCommand.Parameters.AddWithValue("@Doctorname", updateDoctor.DoctorName);
				//sqlCommand.Parameters.AddWithValue("@surname", updateDoctor.DoctorSurname);
				//sqlCommand.Parameters.AddWithValue("@mail", updateDoctor.DoctorMail);
				//sqlCommand.Parameters.AddWithValue("@password", updateDoctor.DoctorPassword);
				//sqlCommand.Parameters.AddWithValue("@phoneNumber", updateDoctor.DoctorPhoneNumber);

				ConnectionSetting();

				sqlCommand.ExecuteNonQuery();

				ConnectionSetting();

			}
		}
		public List<Doctor> SelectAllHours(string email)
		{
			using (sqlCommand = new SqlCommand("sp_DoctorHour", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@mail", email);

				ConnectionSetting();

				reader = sqlCommand.ExecuteReader();

				Doctor doctor = null;
				List<Doctor> doctors = new List<Doctor>();
				while (reader.Read())
				{
					doctor = new Doctor()
					{
						IdentificationNumber = reader["IdentificationNumber"].ToString(),
						DoctorName = reader["doctorName"].ToString(),
						DoctorSurname = reader["doctorSurname"].ToString(),
						Password = reader["doctorPassword"].ToString(),
						Mail = reader["doctorMail"].ToString(),
						PhoneNumber = reader["PhoneNumber"].ToString(),
						PolyClinicID = Convert.ToInt16(reader["HospitalPloyclinicID"]),


					};

					doctors.Add(doctor);
				}

				ConnectionSetting();

				return doctors;
			}
		}
		public List<DoctorHour> DoctorDatesHour(int DoctorID)
		{
			using (sqlCommand = new SqlCommand("sp_DoctorHour", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@DoctorsID", DoctorID);

				List<DoctorHour> responsedDates = null;

				ConnectionSetting();
				reader = sqlCommand.ExecuteReader();

				if (reader.HasRows)
				{
					responsedDates = new List<DoctorHour>();

					while (reader.Read())
					{
						DoctorHour doctorHour = new DoctorHour();

						doctorHour.DateID = Convert.ToInt16(reader["DatID"]);
						doctorHour.ID = Convert.ToInt16(reader["ID"]);
						doctorHour.DoctorName = reader["DoctorName"].ToString();
						doctorHour.DoctorSurname = reader["DoctorSurname"].ToString();
						doctorHour.PatientID = Convert.ToInt16(reader["PatID"]);
						doctorHour.Name = (reader["Name"]).ToString();
						doctorHour.Surname = reader["Surname"].ToString();
						doctorHour.IdentificationNumber = reader["PatIdentify"].ToString();
						doctorHour.IsWomen = Convert.ToBoolean(reader["IsWomen"]);
						doctorHour.Age = Convert.ToInt16(reader["Age"]);
						doctorHour.DatesDate = Convert.ToDateTime(reader["DatesDate"]);
						doctorHour.Time = Convert.ToDateTime(reader["Time"]);
						responsedDates.Add(doctorHour);
					}
					ConnectionSetting();
					return responsedDates; // reader dan okumnan değer döndürürse bu geri döner
				}
				else
				{
					ConnectionSetting();
					return responsedDates;//Reader dan satır gelmezse null döner
				}
			}

		}

		//Son sayfa için dateleri çektik elimizde tüm idler geldi
		public Date GetDateByDateAndPatientID(int id)
		{
			using (sqlCommand = new SqlCommand("sp_GetDateByDateID", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@DatID", id);

				ConnectionSetting();

				reader = sqlCommand.ExecuteReader();

				if (reader.HasRows)
				{
					Date returnedDate = new Date();
					while (reader.Read())
					{
						returnedDate.CityID = Convert.ToInt16(reader["CityID"]);
						returnedDate.DatesDate = Convert.ToDateTime(reader["DatesDate"]);
						returnedDate.DidItCame = Convert.ToBoolean(reader["DidItCame"]);
						returnedDate.DiscrictID = Convert.ToInt16(reader["DistrictID"]); ;
						returnedDate.DoctorID = Convert.ToInt16(reader["DoctorID"]); ;
						returnedDate.HospitalID = Convert.ToInt16(reader["HospitalID"]); ;
						returnedDate.ID = Convert.ToInt16(reader["Id"]); ;
						returnedDate.IsActive = Convert.ToBoolean(reader["IsActive"]);
						returnedDate.PatientID = Convert.ToInt16(reader["PatientID"]); ;
						returnedDate.PolyClinicID = Convert.ToInt16(reader["PolyclinicID"]); ;
						returnedDate.TimeID = Convert.ToInt16(reader["TimeID"]); ;
					}

					ConnectionSetting();
					return returnedDate;
				}
				ConnectionSetting();
				return null;
			}

		}

		public List<PolyClinics> ListOfPolyClinic()
		{
			using (sqlCommand = new SqlCommand("sp_GetAllPolyclinic", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;

				ConnectionSetting();

				reader = sqlCommand.ExecuteReader();

				List<PolyClinics> PolyClinicList = null;
				if (reader.HasRows)
				{
					PolyClinicList = new List<PolyClinics>();
					while (reader.Read())
					{
						PolyClinics polyClinic = new PolyClinics()
						{
							ID = Convert.ToInt16(reader["id"]),
							PolycilinicName = reader["PolyName"].ToString()
						};

						PolyClinicList.Add(polyClinic);
					}
					ConnectionSetting();
					return PolyClinicList;
				}
				else
				{
					ConnectionSetting();
					return PolyClinicList;
				}

			}
		}
		public List<Diagnosis> ListOfDiagnosis()
		{
			using (sqlCommand = new SqlCommand("sp_getAllDiagnosis", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				ConnectionSetting();
				reader = sqlCommand.ExecuteReader();

				List<Diagnosis> diagnosesList = null;
				if (reader.HasRows)
				{
					diagnosesList = new List<Diagnosis>();
					while (reader.Read())
					{
						Diagnosis diagnosis = new Diagnosis()
						{
							ID = Convert.ToInt16(reader["ID"]),
							DiagnosisName = reader["DiagName"].ToString(),
							DiagnosisDescription = reader["DiagDescrip"].ToString()
						};
						diagnosesList.Add(diagnosis);
					}
					ConnectionSetting();
					return diagnosesList;
				}
				else
				{
					ConnectionSetting();
					return diagnosesList;
				}
			}
		}


		public bool IsAddedPrescription(Prescription prescription)
		{
			using (sqlCommand = new SqlCommand("sp_InsertPresscription", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@PresDateID", prescription.DateID);
				sqlCommand.Parameters.AddWithValue("@PresDesc", prescription.PrescriptionDescription);
				sqlCommand.Parameters.AddWithValue("@presCode", prescription.PrescriptionCode);
				sqlCommand.Parameters.AddWithValue("@presDATE", prescription.PrescriptionDate);
				
				ConnectionSetting();
				int isAdd = sqlCommand.ExecuteNonQuery();

				if(isAdd >0)
				{
					ConnectionSetting();
					return true;
				}
				else
				{
					ConnectionSetting();
					return false;
				}
			}
		}

		public bool AddedDiagnosis(int PatientID,int DiagnosisID)
		{
			using (sqlCommand = new SqlCommand("sp_AddDiagnosisToPatient", connection))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.AddWithValue("@PatID", PatientID);
				sqlCommand.Parameters.AddWithValue("@DiagID", DiagnosisID);

				ConnectionSetting();

				int IsAdded = sqlCommand.ExecuteNonQuery();

				if(IsAdded > 0)
				{
					ConnectionSetting();
					return true;
				}
				else
				{
					ConnectionSetting();
					return false;
				}
			}
		}
	}
}
