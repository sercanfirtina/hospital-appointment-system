namespace DatesUI
{
    partial class PatientLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnForgetPassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(341, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Don\'t have on account? Creat on.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(337, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Login";
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
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnRegister.IdleForecolor = System.Drawing.Color.Gray;
            this.btnRegister.IdleLineColor = System.Drawing.Color.Gray;
            this.btnRegister.Location = new System.Drawing.Point(356, 352);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(209, 41);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Gray;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(356, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 41);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "PASSWORD";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(344, 233);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 44);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail.HintText = "E-MAIL";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMail.LineThickness = 3;
            this.txtMail.Location = new System.Drawing.Point(344, 162);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(252, 44);
            this.txtMail.TabIndex = 24;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.ActiveBorderThickness = 1;
            this.btnForgetPassword.ActiveCornerRadius = 20;
            this.btnForgetPassword.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnForgetPassword.ActiveForecolor = System.Drawing.Color.White;
            this.btnForgetPassword.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnForgetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnForgetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForgetPassword.BackgroundImage")));
            this.btnForgetPassword.ButtonText = "Forget Password";
            this.btnForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnForgetPassword.IdleBorderThickness = 1;
            this.btnForgetPassword.IdleCornerRadius = 20;
            this.btnForgetPassword.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.IdleForecolor = System.Drawing.Color.Gray;
            this.btnForgetPassword.IdleLineColor = System.Drawing.Color.Gray;
            this.btnForgetPassword.Location = new System.Drawing.Point(356, 402);
            this.btnForgetPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(209, 41);
            this.btnForgetPassword.TabIndex = 27;
            this.btnForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-296, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 562);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // PatientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientLoginForm";
            this.Text = "PatientLoginForm";
            this.Load += new System.EventHandler(this.PatientLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
		private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
		private Bunifu.Framework.UI.BunifuThinButton2 btnForgetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}