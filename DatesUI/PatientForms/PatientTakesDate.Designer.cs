namespace DatesUI.PatientForms
{
    partial class PatientTakesDate
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
			this.cbxCities = new System.Windows.Forms.ComboBox();
			this.cbxDistricts = new System.Windows.Forms.ComboBox();
			this.cbxHospitals = new System.Windows.Forms.ComboBox();
			this.cbxPolyClinics = new System.Windows.Forms.ComboBox();
			this.cbxDoctors = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnTakeDate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxCities
			// 
			this.cbxCities.FormattingEnabled = true;
			this.cbxCities.Location = new System.Drawing.Point(81, 27);
			this.cbxCities.Name = "cbxCities";
			this.cbxCities.Size = new System.Drawing.Size(196, 21);
			this.cbxCities.TabIndex = 0;
			this.cbxCities.SelectedIndexChanged += new System.EventHandler(this.CbxCities_SelectedIndexChanged);
			// 
			// cbxDistricts
			// 
			this.cbxDistricts.Enabled = false;
			this.cbxDistricts.FormattingEnabled = true;
			this.cbxDistricts.Location = new System.Drawing.Point(81, 55);
			this.cbxDistricts.Name = "cbxDistricts";
			this.cbxDistricts.Size = new System.Drawing.Size(196, 21);
			this.cbxDistricts.TabIndex = 1;
			this.cbxDistricts.SelectedIndexChanged += new System.EventHandler(this.CbxDistricts_SelectedIndexChanged);
			// 
			// cbxHospitals
			// 
			this.cbxHospitals.Enabled = false;
			this.cbxHospitals.FormattingEnabled = true;
			this.cbxHospitals.Location = new System.Drawing.Point(81, 83);
			this.cbxHospitals.Name = "cbxHospitals";
			this.cbxHospitals.Size = new System.Drawing.Size(196, 21);
			this.cbxHospitals.TabIndex = 2;
			this.cbxHospitals.SelectedIndexChanged += new System.EventHandler(this.CbxHospitals_SelectedIndexChanged);
			// 
			// cbxPolyClinics
			// 
			this.cbxPolyClinics.Enabled = false;
			this.cbxPolyClinics.FormattingEnabled = true;
			this.cbxPolyClinics.Location = new System.Drawing.Point(81, 111);
			this.cbxPolyClinics.Name = "cbxPolyClinics";
			this.cbxPolyClinics.Size = new System.Drawing.Size(196, 21);
			this.cbxPolyClinics.TabIndex = 3;
			this.cbxPolyClinics.SelectedIndexChanged += new System.EventHandler(this.CbxPolyClinics_SelectedIndexChanged);
			// 
			// cbxDoctors
			// 
			this.cbxDoctors.FormattingEnabled = true;
			this.cbxDoctors.Location = new System.Drawing.Point(81, 139);
			this.cbxDoctors.Name = "cbxDoctors";
			this.cbxDoctors.Size = new System.Drawing.Size(196, 21);
			this.cbxDoctors.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(81, 166);
			this.dateTimePicker1.MinDate = new System.DateTime(2019, 10, 13, 12, 12, 41, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
			this.dateTimePicker1.TabIndex = 5;
			this.dateTimePicker1.Value = new System.DateTime(2019, 10, 13, 12, 12, 41, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// btnTakeDate
			// 
			this.btnTakeDate.Enabled = false;
			this.btnTakeDate.Location = new System.Drawing.Point(81, 192);
			this.btnTakeDate.Name = "btnTakeDate";
			this.btnTakeDate.Size = new System.Drawing.Size(196, 30);
			this.btnTakeDate.TabIndex = 6;
			this.btnTakeDate.Text = "Take Hour";
			this.btnTakeDate.UseVisualStyleBackColor = true;
			this.btnTakeDate.Click += new System.EventHandler(this.BtnTakeDate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnTakeDate);
			this.groupBox1.Controls.Add(this.cbxCities);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.cbxDistricts);
			this.groupBox1.Controls.Add(this.cbxDoctors);
			this.groupBox1.Controls.Add(this.cbxHospitals);
			this.groupBox1.Controls.Add(this.cbxPolyClinics);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 312);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Patient Date Screen";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(81, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 30);
			this.button1.TabIndex = 13;
			this.button1.Text = "Confirm Date";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Date : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Doctors : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Polyclinics : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Hospitals : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Districts : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cities : ";
			// 
			// PatientTakesDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 340);
			this.Controls.Add(this.groupBox1);
			this.Name = "PatientTakesDate";
			this.Text = "PatientTakesDate";
			this.Load += new System.EventHandler(this.PatientTakesDate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.ComboBox cbxDistricts;
        private System.Windows.Forms.ComboBox cbxHospitals;
        private System.Windows.Forms.ComboBox cbxPolyClinics;
        private System.Windows.Forms.ComboBox cbxDoctors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTakeDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}