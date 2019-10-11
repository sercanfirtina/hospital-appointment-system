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
    public partial class PatientTakesDate : Form
    {
        public PatientTakesDate(Patient patient, IPatientController IpatientController)
        {
            InitializeComponent();

            _patient = patient;
            _IpatientController = IpatientController;
        }
        Patient _patient;
        public IPatientController _IpatientController;

        private void PatientTakesDate_Load(object sender, EventArgs e)
        {
            FillCbxCities();
        }

        public void FillCbxCities()
        {
            cbxCities.Items.Clear();

            List<City> cityList = _IpatientController.GetAllCitis();

            foreach(City item in cityList)
            {
                cbxCities.Items.Add(item);
            }
        }
    }
}
