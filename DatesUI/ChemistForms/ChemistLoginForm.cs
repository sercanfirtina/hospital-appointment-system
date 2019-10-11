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

namespace DatesUI.ChemistForms
{
    public partial class ChemistLoginForm : Form
    {
        public ChemistLoginForm()
        {
            InitializeComponent();
            _IChemistController = new ChemistController(new ChemistManagement());
        }
        IChemistController _IChemistController;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim().ToString();
            string password = txtPassword.Text.Trim().ToString();

            try
            {
                Chemist chemist = _IChemistController.LoginChemist(email, password);

                if (chemist != null)
                {
                    ChemistMainForm chemistMainForm = new ChemistMainForm();
                    chemistMainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Chemist is not Found in our registers.Try again or create new Chemist.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ChemistRegisterForm _ChemistRegisterForm = new ChemistRegisterForm(_IChemistController);

            _ChemistRegisterForm.ShowDialog();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm(_IChemistController);

            forgetPasswordForm.ShowDialog();
        }

        private void ChemistLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
