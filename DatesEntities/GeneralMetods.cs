using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace DatesEntities
{
    public static class GeneralMetods
    {
        //herhangi bir girişteki tüm boşlukları siler düz metin haline getirir.
        public static string SpaceControl(object inputString)
        {
            string inputStr = inputString.ToString();

            if (inputStr.Contains(' '))
            {
                string returnedValue="";
                inputStr.Trim();
                for(int i=0;i< inputStr.Length;i++)
                {
                    if (inputStr[i] !=' ')
                    {
                        returnedValue += inputStr[i];
                    }
                }
                
                return returnedValue;
            }
            else
            {
                return inputStr;
            }
        }
        public static bool SendMail(string returnedValueFromDB, string toMail)
        {
            try
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("hospitalProjectMail@gmail.com");//parametre olarak mail adresi verilir.
                ePosta.To.Add(toMail);
                ePosta.Sender = new MailAddress("hospitalProjectMail@gmail.com");
                ePosta.Subject = "Remember Password.";
                ePosta.Body = "Denmemeler You should change your password,When you see this mail.\nYour Password is : " + returnedValueFromDB;
                ePosta.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("hospitalProjectMail@gmail.com", "Hospital123");
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;//sunucu ssl isterse true olur
                smtp.Send(ePosta);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }

        }


    }
}
