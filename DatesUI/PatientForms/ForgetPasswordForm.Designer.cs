namespace DatesUI.PatientForms
{
	partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMailAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSendMail = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 398);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMailAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtMailAddress.HintText = "E-Mail";
            this.txtMailAddress.isPassword = false;
            this.txtMailAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMailAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMailAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMailAddress.LineThickness = 3;
            this.txtMailAddress.Location = new System.Drawing.Point(13, 71);
            this.txtMailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(370, 44);
            this.txtMailAddress.TabIndex = 2;
            this.txtMailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSendMail
            // 
            this.btnSendMail.ActiveBorderThickness = 1;
            this.btnSendMail.ActiveCornerRadius = 20;
            this.btnSendMail.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSendMail.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendMail.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSendMail.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMail.BackgroundImage")));
            this.btnSendMail.ButtonText = "Send Mail";
            this.btnSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSendMail.IdleBorderThickness = 1;
            this.btnSendMail.IdleCornerRadius = 20;
            this.btnSendMail.IdleFillColor = System.Drawing.Color.White;
            this.btnSendMail.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSendMail.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSendMail.Location = new System.Drawing.Point(99, 137);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(181, 41);
            this.btnSendMail.TabIndex = 3;
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 316);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtMailAddress);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForgetPasswordForm";
            this.Text = "ForgetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMailAddress;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendMail;
    }
}