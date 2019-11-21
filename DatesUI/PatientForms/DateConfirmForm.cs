using DatesBLL.Interfaces;
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
	public partial class DateConfirmForm : Form
	{
		public DateConfirmForm(DateConfirmationDTO dateConfirmation, IPatientController IpatientControllers)
		{
			InitializeComponent();
			_dateConfirmation = dateConfirmation;
			_IpatientController = IpatientControllers;
		}
		DateConfirmationDTO _dateConfirmation;
		IPatientController _IpatientController;

		private void DateConfirmForm_Load(object sender, EventArgs e)
		{
			txtDocName.Text = _dateConfirmation.DoctorName;
			txtDocSurname.Text =_dateConfirmation.DoctorSurname;
			txtDocMail.Text =_dateConfirmation.DoctorMail;
			txtCity.Text =_dateConfirmation.SelectedCityName;
			txtDate.Text =_dateConfirmation.SelectedDate.ToShortDateString();
			txtDateHour.Text =_dateConfirmation.SelectedTime;
			txtDistrict.Text =_dateConfirmation.SelectedDistrictName;
			txtHospitalName.Text =_dateConfirmation.SelectedHospitalName;
			txtPerAge.Text =_dateConfirmation.PersonBirthdate.ToShortDateString();//Doğum tarihini hesapla
			txtPerGender.Text = _dateConfirmation.PersonIsWomen ? "Women" : "Man";
			txtPerIdentity.Text =_dateConfirmation.PersonIdentificationNumber;
			txtPerMail.Text =_dateConfirmation.PersonMail;
			txtPerName.Text =_dateConfirmation.PersonName;
			txtPerPhoneNumber.Text =_dateConfirmation.PersonPhoneNumber;
			txtPerSurname.Text =_dateConfirmation.PersonSurname;
			txtPolyclinicName.Text =_dateConfirmation.SelectedPolycilinicName;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				InsertDateDTO insertDate = new InsertDateDTO
				{
					PatID = _dateConfirmation.PersonID,
					selectedTimeID = _dateConfirmation.SelectedHoursID,
					selectedCityID = _dateConfirmation.SelectedCityID,
					selectedDate = _dateConfirmation.SelectedDate,
					selectedDistrictID = _dateConfirmation.SelectedDistrictID,
					selectedDoctorID = _dateConfirmation.DoctorID,
					selectedHospitalID = _dateConfirmation.SelectedHospitalId,
					selectedPolyclinicID = _dateConfirmation.SelectedPolyclinicId
				};

				_IpatientController.AddDate(insertDate);

				MessageBox.Show("Date added successfully .","Added Message",MessageBoxButtons.OK);
				this.Close();
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			
		}
	}
}
