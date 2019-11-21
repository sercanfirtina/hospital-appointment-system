using DatesBLL.Interfaces;
using DatesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatesUI.PatientForms
{
	public partial class PatientRegisterForm : Form
	{
		public PatientRegisterForm(IPatientController _IpatientController)
		{
			InitializeComponent();
			_patientController = _IpatientController;
		}
		IPatientController _patientController;

		public void ClearControls()
		{
			//txtIdentifyNumber.Clear();
			//txtMail.Clear();
			//txtName.Clear();
			//txtPassword.Clear();
			//txtRePassword.Clear();
			//txtSurname.Clear();
			mskPhoneNumber.Clear();
			rdBtnMan.Checked = false;
			rdBtnWoman.Checked = false;
			dateTimeBirthDate.Value = DateTime.Now;
		}


		private void btnRegister_Click(object sender, EventArgs e)
		{
			//Yeni hasta kaydı yapıldı.
			//Not kayıt edilirken tek tek kontrollere boş olup olmadığına dair bir kontrol yapılmadı.
			try
			{
				string identifyNumber = GeneralMetods.SpaceControl(txtIdentifyNumber.Text);
				string pass = GeneralMetods.SpaceControl(txtPassword.Text);
				string mailAddress = GeneralMetods.SpaceControl(txtMail.Text);
				string rePass = GeneralMetods.SpaceControl(txtRePassword.Text);
				string name = GeneralMetods.SpaceControl(txtName.Text); ;
				string surname = GeneralMetods.SpaceControl(txtSurname.Text); ;

				if (!string.IsNullOrEmpty(identifyNumber) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(mailAddress) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(rePass) && GeneralMetods.IsItMail(mailAddress))
				{
					if (pass.Equals(rePass))
					{
						//Formdan gelen verilerle yeni bir kayıt eklenir ve bunu db ye gönderilir.
						Patient newPatient = new Patient();
						newPatient.IdentificationNumber = identifyNumber;
						newPatient.Name = name;
						newPatient.Surname = surname;
						newPatient.Mail = mailAddress;
						newPatient.Password = pass;
						newPatient.IsWomen = rdBtnWoman.Checked ? true : false;
						newPatient.PhoneNumber = mskPhoneNumber.Text.ToString();
						newPatient.Birthdate = dateTimeBirthDate.Value;

						//Veri tabanı içerisinden dönen değer eklenilip eklenmediği hakkında bilgi verir.Bu kısımda kontrol edilir.
						bool result = _patientController.AddPatient(newPatient);
						if (result == false)
						{
							MessageBox.Show("Patient wasn't created.");
						}
						else
						{
							MessageBox.Show("Patiend created..");

							this.Close();
						}
					}

					else
					{
						MessageBox.Show("Passwords must be same.");
					}

				}
				else
				{
					MessageBox.Show("There is/are empty control in form.");
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearControls();
		}
	}
}
