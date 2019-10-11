namespace DatesUI.PatientForms
{
    partial class TakeDateForm
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
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxHospital = new System.Windows.Forms.ComboBox();
            this.cbxPolyClinic = new System.Windows.Forms.ComboBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnChoiseDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTakeDate = new System.Windows.Forms.Button();
            this.pnlDoctorHours = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlDoctorHours.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnChoiseDate);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbxDoctor);
            this.groupBox1.Controls.Add(this.cbxPolyClinic);
            this.groupBox1.Controls.Add(this.cbxHospital);
            this.groupBox1.Controls.Add(this.cbxDistrict);
            this.groupBox1.Controls.Add(this.cbxCity);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(20, 45);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(168, 24);
            this.cbxCity.TabIndex = 0;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(20, 75);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(168, 24);
            this.cbxDistrict.TabIndex = 1;
            // 
            // cbxHospital
            // 
            this.cbxHospital.FormattingEnabled = true;
            this.cbxHospital.Location = new System.Drawing.Point(20, 116);
            this.cbxHospital.Name = "cbxHospital";
            this.cbxHospital.Size = new System.Drawing.Size(168, 24);
            this.cbxHospital.TabIndex = 2;
            // 
            // cbxPolyClinic
            // 
            this.cbxPolyClinic.FormattingEnabled = true;
            this.cbxPolyClinic.Location = new System.Drawing.Point(20, 158);
            this.cbxPolyClinic.Name = "cbxPolyClinic";
            this.cbxPolyClinic.Size = new System.Drawing.Size(168, 24);
            this.cbxPolyClinic.TabIndex = 3;
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(20, 202);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(168, 24);
            this.cbxDoctor.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnChoiseDate
            // 
            this.btnChoiseDate.Location = new System.Drawing.Point(20, 303);
            this.btnChoiseDate.Name = "btnChoiseDate";
            this.btnChoiseDate.Size = new System.Drawing.Size(157, 66);
            this.btnChoiseDate.TabIndex = 6;
            this.btnChoiseDate.Text = "Choise Date";
            this.btnChoiseDate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(295, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 348);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnTakeDate
            // 
            this.btnTakeDate.Location = new System.Drawing.Point(331, 336);
            this.btnTakeDate.Name = "btnTakeDate";
            this.btnTakeDate.Size = new System.Drawing.Size(197, 52);
            this.btnTakeDate.TabIndex = 0;
            this.btnTakeDate.Text = "Take Date";
            this.btnTakeDate.UseVisualStyleBackColor = true;
            // 
            // pnlDoctorHours
            // 
            this.pnlDoctorHours.Controls.Add(this.btnTakeDate);
            this.pnlDoctorHours.Location = new System.Drawing.Point(255, 33);
            this.pnlDoctorHours.Name = "pnlDoctorHours";
            this.pnlDoctorHours.Size = new System.Drawing.Size(531, 399);
            this.pnlDoctorHours.TabIndex = 1;
            // 
            // TakeDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 489);
            this.Controls.Add(this.pnlDoctorHours);
            this.Controls.Add(this.groupBox1);
            this.Name = "TakeDateForm";
            this.Text = "TakeDateForm";
            this.groupBox1.ResumeLayout(false);
            this.pnlDoctorHours.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChoiseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ComboBox cbxPolyClinic;
        private System.Windows.Forms.ComboBox cbxHospital;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Button btnTakeDate;
        private System.Windows.Forms.Panel pnlDoctorHours;
    }
}