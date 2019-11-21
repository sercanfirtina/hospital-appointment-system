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

namespace DatesUI.DoctorForms
{
    public partial class DoctorRegisterForm : Form
    {
        public DoctorRegisterForm(IDoctorController _IDoctorController)
        {
            InitializeComponent();
			_doctorController = _IDoctorController;
		}

		IDoctorController _doctorController;
		List<PolyClinics> allPolyClinics;

		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtIdNumber.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtEMail.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtPassword.Text.Trim().ToString()))
				{

					//Formdan gelen verilerle yeni bir kayıt eklenir ve bunu db ye gönderilir.
					Doctor newDoctor = new Doctor();
					newDoctor.IdentificationNumber = txtIdNumber.Text.Trim().ToString();
					newDoctor.DoctorName = txtName.Text.Trim().ToString();
					newDoctor.DoctorSurname = txtSurname.Text.Trim().ToString();
					newDoctor.Mail = txtEMail.Text.Trim().ToString();
					newDoctor.Password = txtPassword.Text.Trim().ToString();
					
					//Bu kısımda combdan ID alıyoruz
					int selectedPolyClinicID = ((PolyClinics)cmbxPolyClinics.SelectedItem).ID;
					newDoctor.PolyClinicID = selectedPolyClinicID;

					//Veri tabanı içerisinden dönen değer eklenilip eklenmediği hakkında bilgi verir.Bu kısımda kontrol edilir.
					bool result = _doctorController.AddDoctor(newDoctor);
					if (result == false)
					{
						MessageBox.Show("Doctor wasn't created.");
					}
					else
					{
						MessageBox.Show("Doctor created..");

						this.Close();
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

		private void DoctorRegisterForm_Load(object sender, EventArgs e)
		{
			fillCmbPolyclinic();
		}


		public void fillCmbPolyclinic()
		{
			cmbxPolyClinics.Items.Clear();

			allPolyClinics = _doctorController.ListOfPolyClinic();
			
			foreach(PolyClinics item in allPolyClinics)
			{
				cmbxPolyClinics.Items.Add(item);
			}
		}
	}
}
