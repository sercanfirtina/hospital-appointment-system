using DatesBLL.Classes;
using DatesBLL.Interfaces;
using DatesDAL.Classes;
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
    public partial class DoctorLoginForm : Form
    {
        public DoctorLoginForm()
        {
            InitializeComponent();
            _IdoctorController = new DoctorController(new DoctorManagement());
        }
        IDoctorController _IdoctorController;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = GeneralMetods.SpaceControl(txtEMail.Text);
            string password = GeneralMetods.SpaceControl(txtPassword.Text);
            try
            {
                Doctor doctor = _IdoctorController.LoginDoctor(email, password);

                if (doctor != null)
                {
                    DrMainForm doctorMainForm = new DrMainForm(_IdoctorController);
                    doctorMainForm.Mail = email;
                    doctorMainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Doctor is not Found in our registers.Try again or create new Doctor.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            DoctorRegisterForm doctorRegisterForm = new DoctorRegisterForm();

            doctorRegisterForm.Show();
        }
    }
}
