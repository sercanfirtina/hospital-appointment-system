using DatesBLL.Interfaces;
using DatesEntities;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatesUI.PatientForms
{
	public partial class ForgetPasswordForm : Form
	{
		public ForgetPasswordForm(IPatientController _IpatientController)
		{
			InitializeComponent();
			_patientController = _IpatientController;
		}
		IPatientController _patientController;

		private void btnSendMail_Click(object sender, EventArgs e)
		{
            //Mail adresi kontrol edilecek oyle bir mail adresi varsa mail gonderilecek aksi durumda mail adresi bulunmuyor hatası döndürülecek.

            string mail = GeneralMetods.SpaceControl(txtMailAddress.Text);
			try
			{
				if (!string.IsNullOrEmpty(mail))
				{
					string returnedValueFromDB = _patientController.FindEmail(mail);

					if (!string.IsNullOrEmpty(returnedValueFromDB))
					{
						//Mail gönderme metodum
						bool IsSentMAil = GeneralMetods.SendMail(returnedValueFromDB, mail);//2.Parametre ile hedef mail belirtilir

                        if(IsSentMAil == true)//Mail gonderildiyse
                        {
                            MessageBox.Show("Mail has been sent ...");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mail hasn't been sent");
                        }

					}
					else
					{
						//Uyarı ile mail bulunmadığını söyle
						throw new Exception("Records don't included this email .");
					}
				}
				else
				{
					throw new Exception("Email mustn't be empty !");
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
	}
}
