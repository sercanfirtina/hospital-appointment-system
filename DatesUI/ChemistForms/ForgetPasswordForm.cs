using DatesBLL.Interfaces;
using DatesEntities;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatesUI.ChemistForms
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm(IChemistController _IChemistController)
        {
            InitializeComponent();
            _IChemistControllers = _IChemistController;
        }

        IChemistController _IChemistControllers;

        private void btnSendMail_Click(object sender, EventArgs e)
        {

            //Mail adresi kontrol edilecek oyle bir mail adresi varsa mail gonderilecek aksi durumda mail adresi bulunmuyor hatası döndürülecek.

            string mail = txtMailAddress.Text.Trim().ToString();
            try
            {
                if (!string.IsNullOrEmpty(mail))
                {
                    string returnedValueFromDB = _IChemistControllers.FindEmail(mail);

                    if (!string.IsNullOrEmpty(returnedValueFromDB))
                    {
                        //Mail gönderme metodum GeneralMetods altında bulunuyor orada tanımlı 3 formda kullanılacağı için ortak bir alana ekledim ?
                        bool IsSentMAil = GeneralMetods.SendMail(returnedValueFromDB, mail);//2.Parametre ile hedef mail belirtilir

                        if (IsSentMAil == true)//Mail gonderildiyse
                        {
                            MessageBox.Show("Mail has been sent ...");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mail hasn't been sent");
                        }

                    }
                    else
                    {
                        //Uyarı ile mail bulunmadığını söyle
                        throw new Exception("Records don't included this email .");
                    }
                }
                else
                {
                    throw new Exception("Email mustn't be empty !");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        
    }
}
