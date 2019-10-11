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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSendMail = new System.Windows.Forms.Button();
			this.txtMailAddress = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMailAddress);
			this.groupBox1.Controls.Add(this.btnSendMail);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(46, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 107);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Forget My Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "E-Mail : ";
			// 
			// btnSendMail
			// 
			this.btnSendMail.Location = new System.Drawing.Point(81, 54);
			this.btnSendMail.Name = "btnSendMail";
			this.btnSendMail.Size = new System.Drawing.Size(122, 33);
			this.btnSendMail.TabIndex = 1;
			this.btnSendMail.Text = "Send Mail";
			this.btnSendMail.UseVisualStyleBackColor = true;
			this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
			// 
			// txtMailAddress
			// 
			this.txtMailAddress.Location = new System.Drawing.Point(58, 28);
			this.txtMailAddress.Name = "txtMailAddress";
			this.txtMailAddress.Size = new System.Drawing.Size(177, 20);
			this.txtMailAddress.TabIndex = 2;
			// 
			// ForgetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 225);
			this.Controls.Add(this.groupBox1);
			this.Name = "ForgetPasswordForm";
			this.Text = "ForgetPasswordForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMailAddress;
		private System.Windows.Forms.Button btnSendMail;
		private System.Windows.Forms.Label label1;
	}
}