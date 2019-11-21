using DatesBLL.Classes;
using DatesBLL.Interfaces;
using DatesDAL;
using DatesDTOES;
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
	public partial class PatientMainForm : Form
	{
		public PatientMainForm(Patient patient)
		{
			InitializeComponent();
			_patient = patient;

			_IpatientController = new PatientController(new PatientManagement());
		}
		Patient _patient;
		List<Prescription> prescriptionList = null;
		public IPatientController _IpatientController;

		#region Gropbox kapama kontrolleri bu range içerisinde gerçekleştiriliyor
		private void BtnCloseGroupBox_Click(object sender, EventArgs e)
		{
			grpBoxDateLists.Visible = false;
			grpBxAllPrescription.Visible = false;
			if (grpBoxMYInfo.Visible == false)
			{
				panelAdvertisment.Visible = true;
			}
		}
		private void BtnGrpBxAllPressClose_Click(object sender, EventArgs e)
		{
			grpBxAllPrescription.Visible = false;
		}
		private void BtnInformationsClose_Click(object sender, EventArgs e)
		{
			grpBoxMYInfo.Visible = false;
			if (grpBoxDateLists.Visible == false)
			{
				panelAdvertisment.Visible = true;
			}
		}

		private void BtnShowAllDates_Click(object sender, EventArgs e)
		{
			grpBoxDateLists.BringToFront();
			panelAdvertisment.Visible = false;
			grpBoxMYInfo.Visible = false;
			grpBxAllPrescription.Visible = false;
			grpBoxDateLists.Visible = true;

			List<ShowPatientDate> listOfdatesByPatientID = null;
			try
			{
				lstViewPatientDates.Items.Clear();
				listOfdatesByPatientID = _IpatientController.GetAllDateByPatientID(_patient.ID);

				if (listOfdatesByPatientID == null)
				{
					throw new Exception("Date not found ...");
				}
				else
				{
					foreach (ShowPatientDate item in listOfdatesByPatientID)
					{
						ListViewItem lstItem = new ListViewItem();
						lstItem.Text = item.IdentificationNumber;
						lstItem.Tag = item.DateID;
						lstItem.SubItems.Add(item.DatesDate.ToLongDateString());
						lstItem.SubItems.Add(item.DoctorName);
						lstItem.SubItems.Add(item.DoctorSurname);
						lstItem.SubItems.Add(item.HospitalName);
						lstItem.SubItems.Add(item.PolyClinicName);
						lstItem.SubItems.Add(item.CityName);
						lstItem.SubItems.Add(item.DistrictName);
						lstItem.SubItems.Add(item.Hour);//Sınıf içinde set işlemi ile formatı değiştirdim

						lstViewPatientDates.Items.Add(lstItem);
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}


		}

		#endregion

		#region Temizleme ve Doldurma metodları bu region içinde gereklidir.
		private void BtnMyInfo_Click(object sender, EventArgs e)
		{
			grpBoxMYInfo.BringToFront();
			panelAdvertisment.Visible = false;
			grpBoxDateLists.Visible = false;
			grpBxAllPrescription.Visible = false;
			grpBoxMYInfo.Visible = true;

			//Bu kısımda butona tıklandıktan sonra veriler gösterilecek.Gerekli bilgiler üzer,nde değişklikleryapılacaktır.

			fillControlls();
		}

		#endregion
		public void fillControlls()
		{
			if (_patient != null)
			{
				txtIDNumber.Text = _patient.IdentificationNumber;
				txtName.Text = _patient.Name;
				txtSurname.Text = _patient.Surname;
				txtPassword.Text = _patient.Password;
				txtrePassword.Text = _patient.Password;
				txtMail.Text = _patient.Mail;
				maskedTxtPhoneNumber.Text = _patient.PhoneNumber;

				if (_patient.IsWomen == true)
				{
					rdBtnWoman.Checked = true;
				}
				else
				{
					rdBtnMan.Checked = true;
				}

				dateTimeBirthDate.Value = (DateTime)_patient.Birthdate;

			}
			else
			{
				MessageBox.Show("Any User Information wasn't came to form.");
			}
		}
		private void PatientMainForm_Load(object sender, EventArgs e)
		{
		}
		private void BtnReset_Click(object sender, EventArgs e)
		{
			fillControlls();//Clear dedikten sonra tüm controller ilk değerlerini alıcak.
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{

			try
			{
				if (_patient != null)
				{

					//Boş geçilemez olarak ayarlanılacak

					string newUserName = GeneralMetods.SpaceControl(txtName.Text);
					string newUserSurname = GeneralMetods.SpaceControl(txtSurname.Text);
					string newUserPassword = GeneralMetods.SpaceControl(txtPassword.Text);
					string newRePassword = GeneralMetods.SpaceControl(txtrePassword.Text);
					string newMailAddres = GeneralMetods.SpaceControl(txtMail.Text);
					string newPhoneNumber = GeneralMetods.SpaceControl(maskedTxtPhoneNumber.Text);

					if (!string.IsNullOrEmpty(newMailAddres) && !string.IsNullOrEmpty(newUserPassword) && GeneralMetods.IsItMail(newMailAddres))
					{
						if (newUserPassword == newRePassword)//şifreler de aynıysa bu ekrana girer
						{
							Patient updatePation = new Patient();
							updatePation.ID = _patient.ID;
							updatePation.Name = newUserName;
							updatePation.Surname = newUserSurname;
							updatePation.Mail = newMailAddres;
							updatePation.Password = newUserPassword;
							updatePation.PhoneNumber = newPhoneNumber;

							DialogResult dresult = MessageBox.Show("Are you sure to Change Informations ?", "Update Informations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (dresult == DialogResult.Yes)//Dresulttan yes gelirse update işlemini gerçekleştirir.
							{
								_IpatientController.UpdatePatient(updatePation);
								MessageBox.Show("Your Informations were changed . You should re-login ");
							}
							else//Messagebox no denirse iptal edildi güncelleme işlemi
							{
								MessageBox.Show("Operation was canceled ");
							}

						}
						else//Değişiklik ekranında girilen şifreler farklıysa
						{
							MessageBox.Show("Passwords aren't same");
						}
					}
					else//update ekranında bir veya daha fazla kontrolde boşluk varsa
					{
						MessageBox.Show("There is/are empty controll.");
					}
				}
				else
				{
					MessageBox.Show("There is no patient record .");
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void BtnAllPrescription_Click(object sender, EventArgs e)
		{
			grpBxAllPrescription.BringToFront();
			lstViewPrescription.Items.Clear();
			grpBxAllPrescription.Visible = true;
			grpBoxDateLists.Visible = false;
			grpBoxMYInfo.Visible = false;

			try
			{
				prescriptionList = _IpatientController.GetAllPrescription(_patient.ID);

				if (prescriptionList == null)
				{
					throw new Exception("There is no prescription ...");
				}
				else
				{
					foreach (Prescription item in prescriptionList)
					{
						//DateID değerini tag içerisine koyarız ve bu id yi ileride kullanabiliriz.
						ListViewItem lstItem = new ListViewItem();
						lstItem.Text = item.PrescriptionCode;
						lstItem.Tag = item.DateID;
                        lstItem.SubItems.Add(item.PrescriptionDate.ToString().Split(' ')[0].Trim());
                        lstItem.SubItems.Add(item.PrescriptionDescription);

						lstViewPrescription.Items.Add(lstItem);
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void BtnTakeDate_Click(object sender, EventArgs e)
		{
			PatientTakesDate patientTakesDate = new PatientTakesDate(_patient, _IpatientController);

			patientTakesDate.ShowDialog();
		}
	}
}
