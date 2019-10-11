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

namespace DatesUI.ChemistForms
{
    public partial class ChemistRegisterForm : Form
    {
        public ChemistRegisterForm(IChemistController _IChemistController)
        {
            InitializeComponent();
            _IChemistControllers = _IChemistController;
        }

        IChemistController _IChemistControllers;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtChemistName.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtChemistSurname.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtChemistMail.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtChemistPass.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtChemistRepass.Text.Trim().ToString()) && !string.IsNullOrEmpty(txtChemistPharmacy.Text.Trim().ToString()))
                {
                    if (txtChemistPass.Text.Trim().ToString().Equals(txtChemistRepass.Text.Trim().ToString()))
                    {
                        //Formdan gelen verilerle yeni bir kayıt eklenir ve bunu db ye gönderilir.
                        Chemist newChemist = new Chemist();

                        newChemist.Name = txtChemistName.Text.Trim().ToString();
                        newChemist.Surname = txtChemistSurname.Text.Trim().ToString();
                        newChemist.Mail = txtChemistMail.Text.Trim().ToString();
                        newChemist.Password = txtChemistPass.Text.Trim().ToString();
                        newChemist.PharmacyName = txtChemistPharmacy.Text.Trim().ToString();


                        //Veri tabanı içerisinden dönen değer eklenilip eklenmediği hakkında bilgi verir.Bu kısımda kontrol edilir.
                        bool result = _IChemistControllers.AddChemist(newChemist);
                        if (result == false)
                        {
                            MessageBox.Show("Chemist wasn't created.");
                        }
                        else
                        {
                            MessageBox.Show("Chemist created..");

                            this.Close();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Passwords must be same.");
                    }

                }
                else
                {
                    MessageBox.Show("There is/are empty control in form.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnChemistClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        public void ClearControls()
        {
            txtChemistName.Clear();
            txtChemistSurname.Clear();
            txtChemistPass.Clear();
            txtChemistMail.Clear();
            txtChemistRepass.Clear();
            txtChemistPharmacy.Clear();
        }
    }
}
