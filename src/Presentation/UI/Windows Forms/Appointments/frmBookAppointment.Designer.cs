namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmBookAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookAppointment));
            this.lblClinicianNumber = new System.Windows.Forms.Label();
            this.lblClinicianName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblHospitalNumber = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblPorpuse = new System.Windows.Forms.Label();
            this.btnSearchClinic = new System.Windows.Forms.Button();
            this.txtConsultant = new System.Windows.Forms.TextBox();
            this.txtClinicianNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtHospitalNumber = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.grpClinics = new System.Windows.Forms.GroupBox();
            this.lblClinicians = new System.Windows.Forms.Label();
            this.btnCloseClinicians = new System.Windows.Forms.Button();
            this.btnLoadClinic = new System.Windows.Forms.Button();
            this.dgridClinics = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.grpClinics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridClinics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClinicianNumber
            // 
            this.lblClinicianNumber.AutoSize = true;
            this.lblClinicianNumber.Location = new System.Drawing.Point(12, 43);
            this.lblClinicianNumber.Name = "lblClinicianNumber";
            this.lblClinicianNumber.Size = new System.Drawing.Size(86, 13);
            this.lblClinicianNumber.TabIndex = 0;
            this.lblClinicianNumber.Text = "Clinician Number";
            // 
            // lblClinicianName
            // 
            this.lblClinicianName.AutoSize = true;
            this.lblClinicianName.Location = new System.Drawing.Point(12, 17);
            this.lblClinicianName.Name = "lblClinicianName";
            this.lblClinicianName.Size = new System.Drawing.Size(49, 13);
            this.lblClinicianName.TabIndex = 1;
            this.lblClinicianName.Text = "Clinician ";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(12, 69);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(54, 13);
            this.lblPatientId.TabIndex = 2;
            this.lblPatientId.Text = "Patient ID";
            // 
            // lblHospitalNumber
            // 
            this.lblHospitalNumber.AutoSize = true;
            this.lblHospitalNumber.Location = new System.Drawing.Point(12, 95);
            this.lblHospitalNumber.Name = "lblHospitalNumber";
            this.lblHospitalNumber.Size = new System.Drawing.Size(88, 13);
            this.lblHospitalNumber.TabIndex = 3;
            this.lblHospitalNumber.Text = "Hospital  Number";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(12, 121);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 4;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(12, 147);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(92, 13);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "Appointment Date";
            // 
            // lblPorpuse
            // 
            this.lblPorpuse.AutoSize = true;
            this.lblPorpuse.Location = new System.Drawing.Point(12, 200);
            this.lblPorpuse.Name = "lblPorpuse";
            this.lblPorpuse.Size = new System.Drawing.Size(46, 13);
            this.lblPorpuse.TabIndex = 7;
            this.lblPorpuse.Text = "Purpose";
            // 
            // btnSearchClinic
            // 
            this.btnSearchClinic.Location = new System.Drawing.Point(295, 12);
            this.btnSearchClinic.Name = "btnSearchClinic";
            this.btnSearchClinic.Size = new System.Drawing.Size(49, 23);
            this.btnSearchClinic.TabIndex = 88;
            this.btnSearchClinic.Text = "Search";
            this.btnSearchClinic.UseVisualStyleBackColor = true;
            // 
            // txtConsultant
            // 
            this.txtConsultant.Location = new System.Drawing.Point(124, 14);
            this.txtConsultant.Name = "txtConsultant";
            this.txtConsultant.Size = new System.Drawing.Size(165, 20);
            this.txtConsultant.TabIndex = 87;
            this.txtConsultant.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatConsultant_Validating);
            // 
            // txtClinicianNumber
            // 
            this.txtClinicianNumber.Location = new System.Drawing.Point(124, 40);
            this.txtClinicianNumber.Name = "txtClinicianNumber";
            this.txtClinicianNumber.Size = new System.Drawing.Size(165, 20);
            this.txtClinicianNumber.TabIndex = 89;
            this.txtClinicianNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNum_Validating);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(124, 118);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(220, 20);
            this.txtPatientName.TabIndex = 92;
            this.txtPatientName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatname_Validating);
            // 
            // txtHospitalNumber
            // 
            this.txtHospitalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalNumber.Location = new System.Drawing.Point(124, 92);
            this.txtHospitalNumber.Name = "txtHospitalNumber";
            this.txtHospitalNumber.Size = new System.Drawing.Size(220, 20);
            this.txtHospitalNumber.TabIndex = 91;
            // 
            // txtPatientId
            // 
            this.txtPatientId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(124, 66);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(220, 20);
            this.txtPatientId.TabIndex = 90;
            this.txtPatientId.Leave += new System.EventHandler(this.txtPid_Leave);
            this.txtPatientId.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatientId_Validating);
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(124, 197);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(220, 55);
            this.txtPurpose.TabIndex = 97;
            // 
            // grpClinics
            // 
            this.grpClinics.BackColor = System.Drawing.Color.DarkGray;
            this.grpClinics.Controls.Add(this.lblClinicians);
            this.grpClinics.Controls.Add(this.btnCloseClinicians);
            this.grpClinics.Controls.Add(this.btnLoadClinic);
            this.grpClinics.Controls.Add(this.dgridClinics);
            this.grpClinics.Location = new System.Drawing.Point(350, 12);
            this.grpClinics.Name = "grpClinics";
            this.grpClinics.Size = new System.Drawing.Size(237, 270);
            this.grpClinics.TabIndex = 98;
            this.grpClinics.TabStop = false;
            // 
            // lblClinicians
            // 
            this.lblClinicians.BackColor = System.Drawing.Color.Navy;
            this.lblClinicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicians.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClinicians.Location = new System.Drawing.Point(3, 10);
            this.lblClinicians.Name = "lblClinicians";
            this.lblClinicians.Size = new System.Drawing.Size(234, 18);
            this.lblClinicians.TabIndex = 20;
            this.lblClinicians.Text = "Clinicians";
            // 
            // btnCloseClinicians
            // 
            this.btnCloseClinicians.Location = new System.Drawing.Point(176, 60);
            this.btnCloseClinicians.Name = "btnCloseClinicians";
            this.btnCloseClinicians.Size = new System.Drawing.Size(55, 25);
            this.btnCloseClinicians.TabIndex = 19;
            this.btnCloseClinicians.Text = "Cancel";
            this.btnCloseClinicians.UseVisualStyleBackColor = true;
            // 
            // btnLoadClinic
            // 
            this.btnLoadClinic.Location = new System.Drawing.Point(176, 31);
            this.btnLoadClinic.Name = "btnLoadClinic";
            this.btnLoadClinic.Size = new System.Drawing.Size(55, 25);
            this.btnLoadClinic.TabIndex = 18;
            this.btnLoadClinic.Text = "Select";
            this.btnLoadClinic.UseVisualStyleBackColor = true;
            this.btnLoadClinic.Click += new System.EventHandler(this.btnLoadClinic_Click);
            // 
            // dgridClinics
            // 
            this.dgridClinics.AllowUserToAddRows = false;
            this.dgridClinics.AllowUserToDeleteRows = false;
            this.dgridClinics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgridClinics.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgridClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridClinics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridClinics.Location = new System.Drawing.Point(6, 31);
            this.dgridClinics.MultiSelect = false;
            this.dgridClinics.Name = "dgridClinics";
            this.dgridClinics.ReadOnly = true;
            this.dgridClinics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridClinics.Size = new System.Drawing.Size(164, 233);
            this.dgridClinics.TabIndex = 17;
            this.dgridClinics.DoubleClick += new System.EventHandler(this.dgridClinics_DoubleClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Location = new System.Drawing.Point(124, 144);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(220, 20);
            this.dtpCreationDate.TabIndex = 94;
            // 
            // frmBookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 288);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpClinics);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.dtpCreationDate);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtHospitalNumber);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtClinicianNumber);
            this.Controls.Add(this.btnSearchClinic);
            this.Controls.Add(this.txtConsultant);
            this.Controls.Add(this.lblPorpuse);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblHospitalNumber);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.lblClinicianName);
            this.Controls.Add(this.lblClinicianNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookAppointment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookAppointment";
            this.Load += new System.EventHandler(this.frmBookAppointment_Load);
            this.grpClinics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridClinics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClinicianNumber;
        private System.Windows.Forms.Label lblClinicianName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblHospitalNumber;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblPorpuse;
        private System.Windows.Forms.Button btnSearchClinic;
        private System.Windows.Forms.TextBox txtConsultant;
        private System.Windows.Forms.TextBox txtClinicianNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtHospitalNumber;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.GroupBox grpClinics;
        private System.Windows.Forms.Label lblClinicians;
        private System.Windows.Forms.Button btnCloseClinicians;
        private System.Windows.Forms.Button btnLoadClinic;
        private System.Windows.Forms.DataGridView dgridClinics;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
    }
}