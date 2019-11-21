using DatesDTOES.PatientDTO;
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
	public partial class DoctorsEmptyTime : Form
	{
		public DoctorsEmptyTime(List<HourDTO> HoursOfDoctors)
		{
			InitializeComponent();
			HoursOfDoctor = HoursOfDoctors;
		}
		List<HourDTO> HoursOfDoctor;
		int genislik = 10;
		int yukseklik = 30;

		public PatientTakesDate patientTakesDate;

		private void DoctorsEmptyTime_Load(object sender, EventArgs e)
		{
			if (HoursOfDoctor == null)
			{
				MessageBox.Show("You should doctor to look doctor's available time ...");
			}
			else
			{
				foreach (HourDTO item in HoursOfDoctor)
				{
					//1900-01-01 09:00:00.000
					Button btnHours = new Button();
					string date = item.DoctorTime.ToString().Split(' ')[1];// 09:00:00.000

					btnHours.Text = date.Substring(0, date.LastIndexOf(':'));//09:00

					btnHours.Name = item.HourID.ToString();//btnName kısımlarında idler tutuldu.
					btnHours.BackColor = Color.LightGreen;
					btnHours.Enabled = true;
					btnHours.Width = 70;
					btnHours.Height = 40;

					if (genislik > pnlDoctorHours.Width - 40)
					{
						genislik = 10;
						yukseklik += 50;
					}

					btnHours.Location = new Point(genislik, yukseklik);
					genislik += btnHours.Width;
					pnlDoctorHours.Controls.Add(btnHours);

					//her butona ilgili metot aktarılır.
					btnHours.Click += new EventHandler(myEvent);
				}
			}
		}

		//Butona tıklandığında saat ID si alınır.
		private void myEvent(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			int btnDateOk = Convert.ToInt16(btn.Name);
			patientTakesDate.selectedHourID = btnDateOk;
			patientTakesDate.selectedHour = btn.Text;

			btnHoursSelect.Visible = true;
		}

		private void btnHoursSelect_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
