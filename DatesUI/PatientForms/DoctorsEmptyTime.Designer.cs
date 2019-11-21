namespace DatesUI.PatientForms
{
	partial class DoctorsEmptyTime
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
			this.pnlDoctorHours = new System.Windows.Forms.Panel();
			this.btnHoursSelect = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.pnlDoctorHours.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDoctorHours
			// 
			this.pnlDoctorHours.Controls.Add(this.btnHoursSelect);
			this.pnlDoctorHours.Controls.Add(this.label9);
			this.pnlDoctorHours.Location = new System.Drawing.Point(12, 12);
			this.pnlDoctorHours.Name = "pnlDoctorHours";
			this.pnlDoctorHours.Size = new System.Drawing.Size(440, 329);
			this.pnlDoctorHours.TabIndex = 14;
			// 
			// btnHoursSelect
			// 
			this.btnHoursSelect.Location = new System.Drawing.Point(278, 282);
			this.btnHoursSelect.Name = "btnHoursSelect";
			this.btnHoursSelect.Size = new System.Drawing.Size(159, 33);
			this.btnHoursSelect.TabIndex = 2;
			this.btnHoursSelect.Text = "End of Process";
			this.btnHoursSelect.UseVisualStyleBackColor = true;
			this.btnHoursSelect.Click += new System.EventHandler(this.btnHoursSelect_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(31, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(384, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = "If you want to take a date ,Please click the button whose color is green";
			// 
			// DoctorsEmptyTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 348);
			this.Controls.Add(this.pnlDoctorHours);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DoctorsEmptyTime";
			this.ShowIcon = false;
			this.Text = "DoctorsEmptyTime";
			this.Load += new System.EventHandler(this.DoctorsEmptyTime_Load);
			this.pnlDoctorHours.ResumeLayout(false);
			this.pnlDoctorHours.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlDoctorHours;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnHoursSelect;
	}
}