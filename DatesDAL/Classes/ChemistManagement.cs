using DatesDAL.Interfaces;
using DatesDTOES.ChemistDTO;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDAL.Classes
{
    public class ChemistManagement : IChemistManagement
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
        public bool AddChemist(Chemist chemist)
        {
            using (_cmd = new SqlCommand("Sp_CreateChemist", _con))
            {

                _cmd.CommandType = CommandType.StoredProcedure;                
                _cmd.Parameters.AddWithValue("@name", chemist.Name);
                _cmd.Parameters.AddWithValue("@surname", chemist.Surname);
                _cmd.Parameters.AddWithValue("@mail", chemist.Mail);
                _cmd.Parameters.AddWithValue("@password", chemist.Password);
                _cmd.Parameters.AddWithValue("@pharmacyName", chemist.PharmacyName);
              
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
            using (_cmd = new SqlCommand("Sp_FindChemistMail", _con))
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

                    return result;
                }
                else
                {
                    return result;
                }
            }
        }

        public Chemist LoginChemist(string email, string pass)
        {
            using (_cmd = new SqlCommand("Sp_LoginChemist", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@mail", email);
                _cmd.Parameters.AddWithValue("@password", pass);

                Chemist responsedPatient = null;

                ConnectionSetting();
                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    responsedPatient = new Chemist();

                    while (_rdr.Read())
                    {

                        responsedPatient.ID = Convert.ToInt32(_rdr["ID"]);
                        responsedPatient.Name = _rdr["Name"].ToString();
                        responsedPatient.Surname = _rdr["Surname"].ToString();
                        responsedPatient.Mail = _rdr["mail"].ToString();
                        responsedPatient.Password = _rdr["Password"].ToString();
                        responsedPatient.PharmacyName= _rdr["PharmacyName"].ToString();

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

        public ChemistPatient FindDrugs(string prescriptionsCode)
        {
            using (_cmd = new SqlCommand("Sp_PrescriptionsCode", _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@code", prescriptionsCode);

                ChemistPatient responsedprescriptionsCode = null;

                ConnectionSetting();
                _rdr = _cmd.ExecuteReader();

                if (_rdr.HasRows)
                {
                    responsedprescriptionsCode = new ChemistPatient();

                    while (_rdr.Read())
                    {
                        responsedprescriptionsCode.DateID = Convert.ToInt16(_rdr["DateID"]);
                        responsedprescriptionsCode.PatIdentificationNumber=_rdr["IdentificationNumber"].ToString();
                        responsedprescriptionsCode.PrescriptionCode = _rdr["Code"].ToString();
                        responsedprescriptionsCode.PrescDate = Convert.ToDateTime(_rdr["Date"]);
                        responsedprescriptionsCode.PrescriptionDescription = _rdr["Description"].ToString();
                    }
                    ConnectionSetting();
                    return responsedprescriptionsCode; // reader dan okumnan değer döndürürse bu geri döner
                }
                else
                {
                    ConnectionSetting();
                    return responsedprescriptionsCode;//Reader dan satır gelmezse null döner
                }
            }
        }

    }

}
