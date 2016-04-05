namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmViewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAppointment));
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblClinician = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtConsultant = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToOrderColumns = true;
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppointment.Location = new System.Drawing.Point(12, 67);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(600, 213);
            this.dgvAppointment.TabIndex = 6;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(211, 15);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(33, 13);
            this.lblAppointmentDate.TabIndex = 8;
            this.lblAppointmentDate.Text = "Date:";
            // 
            // lblClinician
            // 
            this.lblClinician.AutoSize = true;
            this.lblClinician.Location = new System.Drawing.Point(408, 14);
            this.lblClinician.Name = "lblClinician";
            this.lblClinician.Size = new System.Drawing.Size(49, 13);
            this.lblClinician.TabIndex = 9;
            this.lblClinician.Text = "Clinician:";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(12, 14);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(57, 13);
            this.lblPatientId.TabIndex = 10;
            this.lblPatientId.Text = "Patient ID:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Checked = false;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(250, 12);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.ShowCheckBox = true;
            this.dtpAppointmentDate.Size = new System.Drawing.Size(152, 20);
            this.dtpAppointmentDate.TabIndex = 96;
            // 
            // txtConsultant
            // 
            this.txtConsultant.Location = new System.Drawing.Point(463, 12);
            this.txtConsultant.Name = "txtConsultant";
            this.txtConsultant.Size = new System.Drawing.Size(149, 20);
            this.txtConsultant.TabIndex = 97;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(75, 12);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(130, 20);
            this.txtPatientId.TabIndex = 99;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(563, 38);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(49, 23);
            this.btnFilter.TabIndex = 100;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtConsultant);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.lblClinician);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvAppointment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            this.Load += new System.EventHandler(this.frmViewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblClinician;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.TextBox txtConsultant;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnFilter;
    }
}