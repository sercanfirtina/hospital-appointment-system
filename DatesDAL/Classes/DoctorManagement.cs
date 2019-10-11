using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatesDAL.Interfaces;
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
                sqlCommand.Parameters.AddWithValue("@idNumber", doctor.IdentificationNumber);
                sqlCommand.Parameters.AddWithValue("@name", doctor.DoctorName);
                sqlCommand.Parameters.AddWithValue("@surname", doctor.DoctorSurname);
                sqlCommand.Parameters.AddWithValue("@mail", doctor.Mail);
                sqlCommand.Parameters.AddWithValue("@password", doctor.Password);
                sqlCommand.Parameters.AddWithValue("@polyClinicId", doctor.PolyClinicID);


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

                Doctor doctor=null;
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


    }
}
