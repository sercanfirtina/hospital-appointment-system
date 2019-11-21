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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEntry));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChemistLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDoctorLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPatientLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 630);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChemistLogin
            // 
            this.btnChemistLogin.ActiveBorderThickness = 1;
            this.btnChemistLogin.ActiveCornerRadius = 1;
            this.btnChemistLogin.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnChemistLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnChemistLogin.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnChemistLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnChemistLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChemistLogin.BackgroundImage")));
            this.btnChemistLogin.ButtonText = "Chemist Login";
            this.btnChemistLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChemistLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChemistLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnChemistLogin.IdleBorderThickness = 1;
            this.btnChemistLogin.IdleCornerRadius = 1;
            this.btnChemistLogin.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnChemistLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChemistLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnChemistLogin.Location = new System.Drawing.Point(266, 310);
            this.btnChemistLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnChemistLogin.Name = "btnChemistLogin";
            this.btnChemistLogin.Size = new System.Drawing.Size(226, 67);
            this.btnChemistLogin.TabIndex = 13;
            this.btnChemistLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChemistLogin.Click += new System.EventHandler(this.btnChemistLogin_Click_1);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.ActiveBorderThickness = 1;
            this.btnDoctorLogin.ActiveCornerRadius = 1;
            this.btnDoctorLogin.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnDoctorLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnDoctorLogin.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnDoctorLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorLogin.BackgroundImage")));
            this.btnDoctorLogin.ButtonText = "Doctor Login";
            this.btnDoctorLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDoctorLogin.IdleBorderThickness = 1;
            this.btnDoctorLogin.IdleCornerRadius = 1;
            this.btnDoctorLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnDoctorLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDoctorLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnDoctorLogin.Location = new System.Drawing.Point(266, 206);
            this.btnDoctorLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(226, 67);
            this.btnDoctorLogin.TabIndex = 12;
            this.btnDoctorLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click_1);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.ActiveBorderThickness = 1;
            this.btnPatientLogin.ActiveCornerRadius = 1;
            this.btnPatientLogin.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnPatientLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnPatientLogin.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnPatientLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientLogin.BackgroundImage")));
            this.btnPatientLogin.ButtonText = "Patiend Login";
            this.btnPatientLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPatientLogin.IdleBorderThickness = 1;
            this.btnPatientLogin.IdleCornerRadius = 20;
            this.btnPatientLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnPatientLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPatientLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnPatientLogin.Location = new System.Drawing.Point(266, 104);
            this.btnPatientLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(226, 69);
            this.btnPatientLogin.TabIndex = 11;
            this.btnPatientLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click_1);
            // 
            // MainEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 491);
            this.Controls.Add(this.btnChemistLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainEntry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChemistLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDoctorLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPatientLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

