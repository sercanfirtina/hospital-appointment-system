namespace DatesUI.PatientForms
{
	partial class PatientRegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegisterForm));
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdBtnMan = new System.Windows.Forms.RadioButton();
            this.rdBtnWoman = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentifyNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRePassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(584, 205);
            this.dateTimeBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(288, 22);
            this.dateTimeBirthDate.TabIndex = 17;
            // 
            // rdBtnMan
            // 
            this.rdBtnMan.AutoSize = true;
            this.rdBtnMan.Location = new System.Drawing.Point(790, 435);
            this.rdBtnMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnMan.Name = "rdBtnMan";
            this.rdBtnMan.Size = new System.Drawing.Size(56, 21);
            this.rdBtnMan.TabIndex = 15;
            this.rdBtnMan.TabStop = true;
            this.rdBtnMan.Text = "Man";
            this.rdBtnMan.UseVisualStyleBackColor = true;
            // 
            // rdBtnWoman
            // 
            this.rdBtnWoman.AutoSize = true;
            this.rdBtnWoman.Location = new System.Drawing.Point(652, 435);
            this.rdBtnWoman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnWoman.Name = "rdBtnWoman";
            this.rdBtnWoman.Size = new System.Drawing.Size(77, 21);
            this.rdBtnWoman.TabIndex = 14;
            this.rdBtnWoman.TabStop = true;
            this.rdBtnWoman.Text = "Woman";
            this.rdBtnWoman.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 435);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthdate : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 669);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentifyNumber
            // 
            this.txtIdentifyNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentifyNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdentifyNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdentifyNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdentifyNumber.HintText = "Identify Number";
            this.txtIdentifyNumber.isPassword = false;
            this.txtIdentifyNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIdentifyNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdentifyNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIdentifyNumber.LineThickness = 3;
            this.txtIdentifyNumber.Location = new System.Drawing.Point(502, 13);
            this.txtIdentifyNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentifyNumber.Name = "txtIdentifyNumber";
            this.txtIdentifyNumber.Size = new System.Drawing.Size(370, 44);
            this.txtIdentifyNumber.TabIndex = 2;
            this.txtIdentifyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(502, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 44);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurname.HintText = "SurName";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSurname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(502, 140);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(370, 44);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail.HintText = "E-Mail";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMail.LineThickness = 3;
            this.txtMail.Location = new System.Drawing.Point(502, 250);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(370, 44);
            this.txtMail.TabIndex = 18;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(502, 302);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 44);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRePassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtRePassword.HintText = "RePassword";
            this.txtRePassword.isPassword = false;
            this.txtRePassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRePassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRePassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRePassword.LineThickness = 3;
            this.txtRePassword.Location = new System.Drawing.Point(502, 368);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(370, 44);
            this.txtRePassword.TabIndex = 20;
            this.txtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(653, 482);
            this.mskPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(219, 22);
            this.mskPhoneNumber.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 482);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Phone Number : ";
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClear.IdleForecolor = System.Drawing.Color.Gray;
            this.btnClear.IdleLineColor = System.Drawing.Color.Gray;
            this.btnClear.Location = new System.Drawing.Point(584, 575);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(209, 41);
            this.btnClear.TabIndex = 29;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "SAVE";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnRegister.IdleForecolor = System.Drawing.Color.Gray;
            this.btnRegister.IdleLineColor = System.Drawing.Color.Gray;
            this.btnRegister.Location = new System.Drawing.Point(584, 527);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(209, 41);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // PatientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 621);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.mskPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.rdBtnMan);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.rdBtnWoman);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdentifyNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientRegisterForm";
            this.Text = "PatientRegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
		private System.Windows.Forms.RadioButton rdBtnMan;
		private System.Windows.Forms.RadioButton rdBtnWoman;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdentifyNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRePassword;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
    }
}