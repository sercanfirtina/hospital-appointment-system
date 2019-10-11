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
            this.cmvPolyclinics = new System.Windows.Forms.ComboBox();
            this.cbxDoctors = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTakeDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Location = new System.Drawing.Point(46, 67);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(196, 21);
            this.cbxCities.TabIndex = 0;
            // 
            // cbxDistricts
            // 
            this.cbxDistricts.FormattingEnabled = true;
            this.cbxDistricts.Location = new System.Drawing.Point(46, 95);
            this.cbxDistricts.Name = "cbxDistricts";
            this.cbxDistricts.Size = new System.Drawing.Size(196, 21);
            this.cbxDistricts.TabIndex = 1;
            // 
            // cbxHospitals
            // 
            this.cbxHospitals.FormattingEnabled = true;
            this.cbxHospitals.Location = new System.Drawing.Point(46, 123);
            this.cbxHospitals.Name = "cbxHospitals";
            this.cbxHospitals.Size = new System.Drawing.Size(196, 21);
            this.cbxHospitals.TabIndex = 2;
            // 
            // cmvPolyclinics
            // 
            this.cmvPolyclinics.FormattingEnabled = true;
            this.cmvPolyclinics.Location = new System.Drawing.Point(46, 151);
            this.cmvPolyclinics.Name = "cmvPolyclinics";
            this.cmvPolyclinics.Size = new System.Drawing.Size(196, 21);
            this.cmvPolyclinics.TabIndex = 3;
            // 
            // cbxDoctors
            // 
            this.cbxDoctors.FormattingEnabled = true;
            this.cbxDoctors.Location = new System.Drawing.Point(46, 179);
            this.cbxDoctors.Name = "cbxDoctors";
            this.cbxDoctors.Size = new System.Drawing.Size(196, 21);
            this.cbxDoctors.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnTakeDate
            // 
            this.btnTakeDate.Location = new System.Drawing.Point(82, 233);
            this.btnTakeDate.Name = "btnTakeDate";
            this.btnTakeDate.Size = new System.Drawing.Size(121, 30);
            this.btnTakeDate.TabIndex = 6;
            this.btnTakeDate.Text = "Take Date";
            this.btnTakeDate.UseVisualStyleBackColor = true;
            // 
            // PatientTakesDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakeDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxDoctors);
            this.Controls.Add(this.cmvPolyclinics);
            this.Controls.Add(this.cbxHospitals);
            this.Controls.Add(this.cbxDistricts);
            this.Controls.Add(this.cbxCities);
            this.Name = "PatientTakesDate";
            this.Text = "PatientTakesDate";
            this.Load += new System.EventHandler(this.PatientTakesDate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCities;
        private System.Windows.Forms.ComboBox cbxDistricts;
        private System.Windows.Forms.ComboBox cbxHospitals;
        private System.Windows.Forms.ComboBox cmvPolyclinics;
        private System.Windows.Forms.ComboBox cbxDoctors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTakeDate;
    }
}