using DatesBLL.Classes;
using DatesBLL.Interfaces;
using DatesDAL;
using DatesEntities;
using DatesUI.PatientForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatesUI
{
    public partial class PatientLoginForm : Form
    {
        public PatientLoginForm()
        {
            InitializeComponent();
			
			//PatientManagement (DatesDAL içindeki) sınıfını kullanarak bu işlemleri gerçekleştireceğimi belirttim.
			_IpatientController = new PatientController(new PatientManagement());
        }
		public IPatientController _IpatientController;

		private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = GeneralMetods.SpaceControl(txtMail.Text);
                string password = GeneralMetods.SpaceControl(txtPassword.Text);

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) )
                {
                    Patient patient = _IpatientController.LoginPatient(email, password);

                    if (patient != null)
                    {
                        PatientMainForm patientMainForm = new PatientMainForm(patient);
                        patientMainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Patient is not Found in our registers.Try again or create new Patient.");
                    }
                }
                else
                {
                    throw new Exception("Neither Email nor Password mustn't be empty !");
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
			PatientRegisterForm _patientRegisterForm = new PatientRegisterForm(_IpatientController);

			_patientRegisterForm.ShowDialog();

        }

		private void btnForgetPassword_Click(object sender, EventArgs e)
		{
			ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm(_IpatientController);

			forgetPasswordForm.ShowDialog();
		}

        private void PatientLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
