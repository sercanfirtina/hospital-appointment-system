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
	public partial class ExaminationForm : Form
	{
		public ExaminationForm(IDoctorController _IdoctorControllers, DoctorHour doctorHour)
		{
			InitializeComponent();
			_IdoctorController = _IdoctorControllers;
			_doctorHour = doctorHour;
		}
		IDoctorController _IdoctorController;
		DoctorHour _doctorHour;

		private void ExaminationForm_Load(object sender, EventArgs e)
		{
			fillComboboxDiagnosis();
			fillControl();
		}

		public void fillControl()
		{
			txtNameSrnmae.Text = _doctorHour.Name + " " + _doctorHour.Surname;
			txtIdentify.Text = _doctorHour.IdentificationNumber.ToString();
			txtDoctorName.Text = _doctorHour.DoctorName + " " + _doctorHour.DoctorSurname;
		}

		public void fillComboboxDiagnosis()
		{
			cmbDiagnoises.Items.Clear();
			foreach(Diagnosis item in _IdoctorController.ListOfDiagnosis())
			{
				cmbDiagnoises.Items.Add(item);
			}
		}

		private void btnGrpBoxDate_Click(object sender, EventArgs e)
		{
			grbxCreateNewDate.Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult dRpress = MessageBox.Show("Do you want to Add Prescription ?","Are you Sure ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(dRpress == DialogResult.Yes)
			{
				AddPrescription();
			}
			
			DialogResult dRpressDiagnosis = MessageBox.Show("Do you want to Add diagnosis ?", "Are you Sure ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (dRpressDiagnosis == DialogResult.Yes)
			{
				AddDiagnosis();
			}


			this.Close();
		}

		public void AddPrescription()
		{
			Guid guid = Guid.NewGuid();
			string guidPartial = guid.ToString().Substring(0, 7);
			string prescriptCode = guidPartial;
			int responsedDateID = _doctorHour.DateID;
			string prescriptionDescription = txtPresscription.Text.Trim();
			string prescriptDate = DateTime.Now.ToShortDateString();

			//Git Prescrption tablosuna ekle !!

			Prescription prescription = new Prescription();
			prescription.DateID = responsedDateID;
			prescription.PrescriptionCode = prescriptCode;
			prescription.PrescriptionDate = Convert.ToDateTime(prescriptDate);
			prescription.PrescriptionDescription = prescriptionDescription;

			bool isAdd = _IdoctorController.IsAddedPrescription(prescription);

			if (isAdd)
			{
				MessageBox.Show("Prescription was Added ");

				
				MessageBox.Show("Prescription Code : (You should write !)"+ prescriptCode, "Prescription Code",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("Presscription wasn't added", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void AddDiagnosis()
		{
			int selectedPAtientID = _doctorHour.PatientID;
			int selectedDiagID = ((Diagnosis)cmbDiagnoises.SelectedItem).ID;

			bool isAddedDiagnosis = _IdoctorController.AddedDiagnosis(selectedPAtientID, selectedDiagID);

			if(isAddedDiagnosis)
			{
				MessageBox.Show("Recorded..");
			}
			else
			{
				MessageBox.Show("Some error occured ... ");
			}

		}

		private void cmbDiagnoises_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnSave.Enabled = true;
		}
	}
}
