using DatesBLL.Classes;
using DatesBLL.Interfaces;
using DatesDAL.Classes;
using DatesDTOES.ChemistDTO;
using DatesEntities;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatesUI.ChemistForms
{
    public partial class ChemistMainForm : Form
    {
        public ChemistMainForm()
        {
            InitializeComponent();
            _IchemistController = new ChemistController(new ChemistManagement());
        }
        IChemistController _IchemistController;
        private void TxtPrescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lstwievDrugs.Items.Clear();

            //gelendeğerin null olup olmadığını kontrol et 
            // null durumunda bir hata fırlat 
            //gelen text içindeki değeri kontrol et boşsa hata fırlat.
            //string code = GeneralMetods.SpaceControl(txtPrescription);

            ChemistPatient prescription = _IchemistController.FindDrugs(GeneralMetods.SpaceControl(txtPrescription.Text));
            try
            {
                if (!string.IsNullOrEmpty(txtPrescription.Text))
                {
                    //ChemistPatient returnedValueFromDB = _IchemistController.FindDrugs(txtPrescription.Text);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = prescription.PatIdentificationNumber;
                    lvi.SubItems.Add(prescription.PrescDate.ToShortDateString());
                    //lvi.SubItems.Add(prescription.);//Bu prescription sınıfında yok bu veriyi transfer etmemiz gerekiyor 
                    lvi.SubItems.Add(prescription.PrescriptionDescription.ToString());
                    lstwievDrugs.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Code cannot be empty");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in your prescription date or prescription code");
            }
        }
    }
}
