using DatesBLL.Interfaces;
using DatesDTOES.PatientDTO;
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

		//doctorEmpty formunda seçien saatin Id bilgisini alır.
		public int selectedHourID;
		public string selectedHour;

		public DateConfirmationDTO dateConfirmation = new DateConfirmationDTO();


		private void PatientTakesDate_Load(object sender, EventArgs e)
		{
			FillCbxCities();

			dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
			dateTimePicker1.MaxDate = DateTime.Today.AddDays(15);

		}
		public void FillCbxCities()
		{
			cbxCities.Items.Clear();

			List<City> cityList = _IpatientController.GetAllCitis();

			foreach (City item in cityList)
			{
				cbxCities.Items.Add(item);
			}
		}

		private void CbxCities_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbxDistricts.Items.Clear();
			cbxDistricts.Enabled = true;

			int selectedCityID = ((City)cbxCities.SelectedItem).ID;

			//seçili şehire ait tüm bilgiler gider.
			dateConfirmation.SelectedCityName = ((City)cbxCities.SelectedItem).CityName;
			dateConfirmation.SelectedCityID = ((City)cbxCities.SelectedItem).ID;
			try
			{
				List<District> allDistrict = _IpatientController.GetAllDistrict(selectedCityID);

				if (allDistrict == null)
				{
					throw new Exception("Our System doesn't contains District in Selected City");
				}
				else
				{
					foreach (District item in allDistrict)
					{
						cbxDistricts.Items.Add(item);
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, "Not Found District", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CbxDistricts_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbxHospitals.Items.Clear();
			cbxHospitals.Enabled = true;

			int selectedId = ((District)cbxDistricts.SelectedItem).ID;

			//Seçili district bilgileri gider
			dateConfirmation.SelectedDistrictName = ((District)cbxDistricts.SelectedItem).DistrictName;
			dateConfirmation.SelectedDistrictID = ((District)cbxDistricts.SelectedItem).ID;
			try
			{
				List<Hospital> responsedHospitals = _IpatientController.GetAllHospitalsByDistrictID(selectedId);

				if (responsedHospitals == null)
				{
					throw new Exception("There is no Hospital in this District .");
				}
				else
				{
					foreach (Hospital item in responsedHospitals)
					{
						cbxHospitals.Items.Add(item);
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, "District Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}
		private void CbxHospitals_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbxPolyClinics.Items.Clear();
			cbxPolyClinics.Enabled = true;

			int selectedIndex = ((Hospital)cbxHospitals.SelectedItem).ID;

			//Seçili hastane bilgileri gelir.
			dateConfirmation.SelectedHospitalName = ((Hospital)cbxHospitals.SelectedItem).HospitalName;

			dateConfirmation.SelectedHospitalId = ((Hospital)cbxHospitals.SelectedItem).ID;

			try
			{
				List<PolyClinics> polyClinics = _IpatientController.GetAllPolyclinicByHospitalID(selectedIndex);

				if (polyClinics == null)
				{
					throw new Exception("There is no polyclinics ...");
				}
				else
				{
					foreach (PolyClinics item in polyClinics)
					{
						cbxPolyClinics.Items.Add(item);
					}
				}

				List<Doctor> doctorList = _IpatientController.GetAllDoctorByHospitalId(selectedIndex);

				foreach (Doctor item in doctorList)
				{
					cbxDoctors.Items.Add(item);
				}

			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, "Hospital not found ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}


		}
		private void CbxPolyClinics_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbxDoctors.Items.Clear();

			int selectedItemIndx = ((PolyClinics)cbxPolyClinics.SelectedItem).ID;

			//seçilen polyclinic bilgileri gelir.
			dateConfirmation.SelectedPolycilinicName = ((PolyClinics)cbxPolyClinics.SelectedItem).PolycilinicName;
			dateConfirmation.SelectedPolyclinicId = ((PolyClinics)cbxPolyClinics.SelectedItem).ID;
			try
			{
				List<Doctor> doctorList = _IpatientController.GetAllDoctorByPolyClinicID(selectedItemIndx);

				if (doctorList == null)
				{
					throw new Exception("Any Doctor not found");
				}
				else
				{
					foreach (Doctor item in doctorList)
					{
						cbxDoctors.Items.Add(item);
					}

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, "Hospital not found ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void BtnTakeDate_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime selectedDate = dateTimePicker1.Value.Date;

				//tarih bilgisi buradan Alınır.
				dateConfirmation.SelectedDate = selectedDate;

				int selectedDoctorID = ((Doctor)cbxDoctors.SelectedItem).ID;

				//Doctor seçildikten sonra alınan bilgiler
				dateConfirmation.DoctorID = ((Doctor)cbxDoctors.SelectedItem).ID;
				dateConfirmation.DoctorName = ((Doctor)cbxDoctors.SelectedItem).DoctorName;
				dateConfirmation.DoctorSurname=((Doctor)cbxDoctors.SelectedItem).DoctorSurname;
				dateConfirmation.DoctorMail = ((Doctor)cbxDoctors.SelectedItem).Mail;

				List<HourDTO> HoursOfDoctor = _IpatientController.GetAllHoursOfDoctor(selectedDoctorID, selectedDate);

				DoctorsEmptyTime doctorsEmptyTime = new DoctorsEmptyTime(HoursOfDoctor);
				doctorsEmptyTime.patientTakesDate = this;
				doctorsEmptyTime.ShowDialog();
				
				//Diğer sayfadan gelen saat id bilgileri
				dateConfirmation.SelectedHoursID = selectedHourID;
				//saat seçme ekrarnından sonra controlleri kilitleyebilirim
				dateConfirmation.SelectedTime = selectedHour;

				if( !String.IsNullOrEmpty(dateConfirmation.SelectedHoursID.ToString()) && !String.IsNullOrEmpty(dateConfirmation.SelectedTime = selectedHour))
				{
					button1.Enabled = true;
				}


			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			btnTakeDate.Enabled = true;
		}
		private void button1_Click(object sender, EventArgs e)
		{

			dateConfirmation.PersonID = _patient.ID;
			dateConfirmation.PersonIdentificationNumber = _patient.IdentificationNumber;
			dateConfirmation.PersonName = _patient.Name;
			dateConfirmation.PersonSurname = _patient.Surname;
			dateConfirmation.PersonBirthdate = _patient.Birthdate;
			dateConfirmation.PersonMail = _patient.Mail;
			dateConfirmation.PersonPhoneNumber = _patient.PhoneNumber;
			dateConfirmation.PersonIsWomen = _patient.IsWomen==true?true:false;
			
			DateConfirmForm dateConfirmForm = new DateConfirmForm(dateConfirmation,_IpatientController);

			dateConfirmForm.ShowDialog();

			this.Close();
		}
	}
}
