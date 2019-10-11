namespace DatesUI
{
    partial class MainEntry
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChemistLogin = new System.Windows.Forms.Button();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChemistLogin);
            this.groupBox1.Controls.Add(this.btnPatientLogin);
            this.groupBox1.Controls.Add(this.btnDoctorLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(388, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Page ";
            // 
            // btnChemistLogin
            // 
            this.btnChemistLogin.Location = new System.Drawing.Point(115, 160);
            this.btnChemistLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChemistLogin.Name = "btnChemistLogin";
            this.btnChemistLogin.Size = new System.Drawing.Size(185, 57);
            this.btnChemistLogin.TabIndex = 3;
            this.btnChemistLogin.Text = "Chemist Login";
            this.btnChemistLogin.UseVisualStyleBackColor = true;
            this.btnChemistLogin.Click += new System.EventHandler(this.btnChemistLogin_Click);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(115, 34);
            this.btnPatientLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(185, 57);
            this.btnPatientLogin.TabIndex = 1;
            this.btnPatientLogin.Text = "Patient Login";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.BtnPatientLogin_Click);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.Location = new System.Drawing.Point(115, 97);
            this.btnDoctorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(185, 57);
            this.btnDoctorLogin.TabIndex = 2;
            this.btnDoctorLogin.Text = "Doctor Login";
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.BtnDoctorLogin_Click);
            // 
            // MainEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 293);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainEntry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChemistLogin;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnDoctorLogin;
    }
}

