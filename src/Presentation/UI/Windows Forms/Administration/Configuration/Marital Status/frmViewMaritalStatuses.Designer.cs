namespace CIS.Presentation.UI.WindowsForms.Administration.Configuration.MaritalStatus
{
    partial class frmViewMaritalStatuses
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
            this.components = new System.ComponentModel.Container();
            this.dgvMaritalStatuses = new System.Windows.Forms.DataGridView();
            this.bsMaritalStatuses = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaritalStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaritalStatuses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaritalStatuses
            // 
            this.dgvMaritalStatuses.AllowUserToAddRows = false;
            this.dgvMaritalStatuses.AllowUserToDeleteRows = false;
            this.dgvMaritalStatuses.AllowUserToResizeRows = false;
            this.dgvMaritalStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaritalStatuses.AutoGenerateColumns = false;
            this.dgvMaritalStatuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaritalStatuses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaritalStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaritalStatuses.DataSource = this.bsMaritalStatuses;
            this.dgvMaritalStatuses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMaritalStatuses.Location = new System.Drawing.Point(12, 12);
            this.dgvMaritalStatuses.MultiSelect = false;
            this.dgvMaritalStatuses.Name = "dgvMaritalStatuses";
            this.dgvMaritalStatuses.ReadOnly = true;
            this.dgvMaritalStatuses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMaritalStatuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaritalStatuses.ShowEditingIcon = false;
            this.dgvMaritalStatuses.Size = new System.Drawing.Size(505, 249);
            this.dgvMaritalStatuses.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(280, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(361, 267);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(442, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmViewMaritalStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMaritalStatuses);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewMaritalStatus";
            this.ShowInTaskbar = false;
            this.Text = "List of Marital Statuses";
            this.Load += new System.EventHandler(this.frmViewMaritalStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaritalStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaritalStatuses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaritalStatuses;
        private System.Windows.Forms.BindingSource bsMaritalStatuses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}