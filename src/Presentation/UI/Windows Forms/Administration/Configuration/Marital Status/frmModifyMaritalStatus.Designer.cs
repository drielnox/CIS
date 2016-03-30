namespace CIS.Presentation.UI.WindowsForms.Administration.Configuration.MaritalStatus
{
    partial class frmModifyMaritalStatus
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
            System.Windows.Forms.Label lblIdentifier;
            System.Windows.Forms.Label lblAbbreviation;
            System.Windows.Forms.Label lblDescription;
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            lblIdentifier = new System.Windows.Forms.Label();
            lblAbbreviation = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdentifier
            // 
            lblIdentifier.AutoSize = true;
            lblIdentifier.Location = new System.Drawing.Point(12, 15);
            lblIdentifier.Name = "lblIdentifier";
            lblIdentifier.Size = new System.Drawing.Size(47, 13);
            lblIdentifier.TabIndex = 0;
            lblIdentifier.Text = "Identifier";
            // 
            // lblAbbreviation
            // 
            lblAbbreviation.AutoSize = true;
            lblAbbreviation.Location = new System.Drawing.Point(12, 41);
            lblAbbreviation.Name = "lblAbbreviation";
            lblAbbreviation.Size = new System.Drawing.Size(66, 13);
            lblAbbreviation.TabIndex = 2;
            lblAbbreviation.Text = "Abbreviation";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(12, 67);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentifier.Location = new System.Drawing.Point(116, 12);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.ReadOnly = true;
            this.txtIdentifier.Size = new System.Drawing.Size(194, 20);
            this.txtIdentifier.TabIndex = 1;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbbreviation.Location = new System.Drawing.Point(116, 38);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(194, 20);
            this.txtAbbreviation.TabIndex = 3;
            this.txtAbbreviation.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbbreviation_Validating);
            this.txtAbbreviation.Validated += new System.EventHandler(this.txtAbbreviation_Validated);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(116, 64);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 20);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(154, 102);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmModifyMaritalStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(322, 137);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.txtAbbreviation);
            this.Controls.Add(lblAbbreviation);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(lblIdentifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyMaritalStatus";
            this.ShowInTaskbar = false;
            this.Text = "Modify Marital Status";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmModifyMaritalStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox txtAbbreviation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}