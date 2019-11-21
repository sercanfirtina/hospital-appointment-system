using DatesBLL.Classes;
using DatesBLL.Interfaces;
using DatesDTOES.DoctorDTO;
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
        public DrMainForm(IDoctorController _IdoctorController, Doctor doc)
        {
            InitializeComponent();
			_doctorController = _IdoctorController;
			this._doctor = doc;
		}

		IDoctorController _doctorController;
		Doctor _doctor;
		List<DoctorHour> dates;
		public string Mail { get; set; }
		
        private void DrMainForm_Load(object sender, EventArgs e)
        {
			try
			{
				dates = _doctorController.DoctorDatesHour(_doctor.ID);

				foreach (DoctorHour item in dates)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = item.Name + ' ' + item.Surname;
					if (item.IsWomen == true)
					{
						lvi.SubItems.Add("Woman");
					}
					else
					{
						lvi.SubItems.Add("Man");
					}

					lvi.Tag = item.DateID;
					lvi.SubItems.Add(item.Age.ToString());
					lvi.SubItems.Add(item.DatesDate.ToShortDateString());
					lvi.SubItems.Add(item.Time.ToShortTimeString());
					lstDoctorHour.Items.Add(lvi);
				}
			}
			catch(Exception exc)
			{
				
			}
			
		}

		private void lstDoctorHour_DoubleClick(object sender, EventArgs e)
		{
			int selectedItemId = Convert.ToInt16(lstDoctorHour.SelectedItems[0].Tag);
			DoctorHour selectedItem = (from value in dates where value.DateID == selectedItemId select value).FirstOrDefault();

			ExaminationForm ef = new ExaminationForm(_doctorController, selectedItem);

			ef.ShowDialog();
		}

	}
}
