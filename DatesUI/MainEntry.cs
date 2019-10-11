using DatesUI.ChemistForms;
using DatesUI.DoctorForms;
using System;
using System.Windows.Forms;

namespace DatesUI
{
    public partial class MainEntry : Form
    {
        public MainEntry()
        {
            InitializeComponent();
        }

        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            PatientLoginForm patientLoginForm = new PatientLoginForm();

            patientLoginForm.ShowDialog();

        }

        private void MainEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnChemistLogin_Click(object sender, EventArgs e)
        {
            ChemistLoginForm _chemistForm = new ChemistLoginForm();

            _chemistForm.ShowDialog();
        }

        private void BtnDoctorLogin_Click(object sender, EventArgs e)
        {
            DoctorLoginForm _doctorLoginForm = new DoctorLoginForm();
            _doctorLoginForm.ShowDialog();
        }
    }
}
