namespace DatesUI.DoctorForms
{
    partial class DrMainForm
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
            this.lstBoxDoctorDates = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxDoctorDates
            // 
            this.lstBoxDoctorDates.FormattingEnabled = true;
            this.lstBoxDoctorDates.ItemHeight = 16;
            this.lstBoxDoctorDates.Location = new System.Drawing.Point(6, 37);
            this.lstBoxDoctorDates.Name = "lstBoxDoctorDates";
            this.lstBoxDoctorDates.Size = new System.Drawing.Size(390, 596);
            this.lstBoxDoctorDates.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxDoctorDates);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 645);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor\'s Dates";
            // 
            // DrMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 669);
            this.Controls.Add(this.groupBox1);
            this.Name = "DrMainForm";
            this.Text = "DrMainForm";
            this.Load += new System.EventHandler(this.DrMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDoctorDates;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}