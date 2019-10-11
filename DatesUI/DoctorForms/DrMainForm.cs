using DatesBLL.Classes;
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
    public partial class DrMainForm : Form
    {
        public DrMainForm(IDoctorController _IdoctorController)
        {
            InitializeComponent();
            _doctorController = _IdoctorController;
        }
        IDoctorController _doctorController;

        public string Mail { get; set; }

        private void DrMainForm_Load(object sender, EventArgs e)
        {
            List<Doctor> doctors = _doctorController.SelectAllHours(Mail);

            foreach (Doctor item in doctors)
            {
                lstBoxDoctorDates.Items.Add(item.DoctorName);
            }
        }
    }
}
