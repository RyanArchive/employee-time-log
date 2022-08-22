namespace EmployeeTimeLog
{
    partial class MasterData
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
            this.DgvEmpList = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearchEmpID = new System.Windows.Forms.Button();
            this.BtnClearSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FlpDataField = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblMiddleName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.FlpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdateExisting = new System.Windows.Forms.Button();
            this.BtnDeleteExisting = new System.Windows.Forms.Button();
            this.BtnClearFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpList)).BeginInit();
            this.FlpSearch.SuspendLayout();
            this.FlpDataField.SuspendLayout();
            this.FlpLabel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmpList
            // 
            this.DgvEmpList.AllowUserToAddRows = false;
            this.DgvEmpList.AllowUserToDeleteRows = false;
            this.DgvEmpList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEmpList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvEmpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmpFirstName,
            this.EmpMiddleName,
            this.EmpLastName,
            this.EmpPassword,
            this.EmpType});
            this.DgvEmpList.EnableHeadersVisualStyles = false;
            this.DgvEmpList.Location = new System.Drawing.Point(0, 0);
            this.DgvEmpList.Margin = new System.Windows.Forms.Padding(0);
            this.DgvEmpList.Name = "DgvEmpList";
            this.DgvEmpList.ReadOnly = true;
            this.DgvEmpList.RowHeadersWidth = 51;
            this.DgvEmpList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvEmpList.Size = new System.Drawing.Size(871, 575);
            this.DgvEmpList.TabIndex = 1;
            this.DgvEmpList.TabStop = false;
            this.DgvEmpList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpList_CellClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "emp_id";
            this.EmployeeId.HeaderText = "Emp ID";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeId.Width = 110;
            // 
            // EmpFirstName
            // 
            this.EmpFirstName.DataPropertyName = "first_name";
            this.EmpFirstName.HeaderText = "First Name";
            this.EmpFirstName.MinimumWidth = 6;
            this.EmpFirstName.Name = "EmpFirstName";
            this.EmpFirstName.ReadOnly = true;
            this.EmpFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpFirstName.Width = 140;
            // 
            // EmpMiddleName
            // 
            this.EmpMiddleName.DataPropertyName = "middle_name";
            this.EmpMiddleName.HeaderText = "Middle Name";
            this.EmpMiddleName.MinimumWidth = 6;
            this.EmpMiddleName.Name = "EmpMiddleName";
            this.EmpMiddleName.ReadOnly = true;
            this.EmpMiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpMiddleName.Width = 140;
            // 
            // EmpLastName
            // 
            this.EmpLastName.DataPropertyName = "last_name";
            this.EmpLastName.HeaderText = "Last Name";
            this.EmpLastName.MinimumWidth = 6;
            this.EmpLastName.Name = "EmpLastName";
            this.EmpLastName.ReadOnly = true;
            this.EmpLastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpLastName.Width = 140;
            // 
            // EmpPassword
            // 
            this.EmpPassword.DataPropertyName = "password";
            this.EmpPassword.HeaderText = "Password";
            this.EmpPassword.MinimumWidth = 6;
            this.EmpPassword.Name = "EmpPassword";
            this.EmpPassword.ReadOnly = true;
            this.EmpPassword.Width = 180;
            // 
            // EmpType
            // 
            this.EmpType.DataPropertyName = "type";
            this.EmpType.HeaderText = "Type";
            this.EmpType.MinimumWidth = 6;
            this.EmpType.Name = "EmpType";
            this.EmpType.ReadOnly = true;
            this.EmpType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpType.Width = 110;
            // 
            // FlpSearch
            // 
            this.FlpSearch.Controls.Add(this.TxtSearch);
            this.FlpSearch.Controls.Add(this.BtnSearchEmpID);
            this.FlpSearch.Controls.Add(this.BtnClearSearch);
            this.FlpSearch.Controls.Add(this.label1);
            this.FlpSearch.Location = new System.Drawing.Point(880, 0);
            this.FlpSearch.Name = "FlpSearch";
            this.FlpSearch.Size = new System.Drawing.Size(352, 65);
            this.FlpSearch.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(10, 7);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(10, 7, 0, 0);
            this.TxtSearch.MaxLength = 8;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(129, 24);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TabStop = false;
            // 
            // BtnSearchEmpID
            // 
            this.BtnSearchEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchEmpID.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchEmpID.Location = new System.Drawing.Point(159, 0);
            this.BtnSearchEmpID.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSearchEmpID.Name = "BtnSearchEmpID";
            this.BtnSearchEmpID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearchEmpID.Size = new System.Drawing.Size(90, 38);
            this.BtnSearchEmpID.TabIndex = 3;
            this.BtnSearchEmpID.TabStop = false;
            this.BtnSearchEmpID.Text = "Search";
            this.BtnSearchEmpID.UseVisualStyleBackColor = false;
            this.BtnSearchEmpID.Click += new System.EventHandler(this.BtnSearchEmpID_Click);
            // 
            // BtnClearSearch
            // 
            this.BtnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnClearSearch.Location = new System.Drawing.Point(259, 0);
            this.BtnClearSearch.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnClearSearch.Name = "BtnClearSearch";
            this.BtnClearSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClearSearch.Size = new System.Drawing.Size(90, 38);
            this.BtnClearSearch.TabIndex = 14;
            this.BtnClearSearch.TabStop = false;
            this.BtnClearSearch.Text = "Clear";
            this.BtnClearSearch.UseVisualStyleBackColor = false;
            this.BtnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search by Employee ID, First, Middle or Last Name";
            // 
            // FlpDataField
            // 
            this.FlpDataField.Controls.Add(this.FlpLabel);
            this.FlpDataField.Controls.Add(this.flowLayoutPanel1);
            this.FlpDataField.Location = new System.Drawing.Point(880, 95);
            this.FlpDataField.Name = "FlpDataField";
            this.FlpDataField.Size = new System.Drawing.Size(352, 237);
            this.FlpDataField.TabIndex = 0;
            // 
            // FlpLabel
            // 
            this.FlpLabel.Controls.Add(this.LblEmpID);
            this.FlpLabel.Controls.Add(this.LblFirstName);
            this.FlpLabel.Controls.Add(this.LblMiddleName);
            this.FlpLabel.Controls.Add(this.LblLastName);
            this.FlpLabel.Controls.Add(this.LblPassword);
            this.FlpLabel.Controls.Add(this.LblType);
            this.FlpLabel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpLabel.Location = new System.Drawing.Point(3, 3);
            this.FlpLabel.Name = "FlpLabel";
            this.FlpLabel.Size = new System.Drawing.Size(140, 230);
            this.FlpLabel.TabIndex = 0;
            // 
            // LblEmpID
            // 
            this.LblEmpID.AutoSize = true;
            this.LblEmpID.Location = new System.Drawing.Point(3, 3);
            this.LblEmpID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblEmpID.Name = "LblEmpID";
            this.LblEmpID.Size = new System.Drawing.Size(96, 18);
            this.LblEmpID.TabIndex = 0;
            this.LblEmpID.Text = "Employee ID:";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(3, 42);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(3, 21, 3, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(85, 18);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name:";
            // 
            // LblMiddleName
            // 
            this.LblMiddleName.AutoSize = true;
            this.LblMiddleName.Location = new System.Drawing.Point(3, 81);
            this.LblMiddleName.Margin = new System.Windows.Forms.Padding(3, 21, 3, 0);
            this.LblMiddleName.Name = "LblMiddleName";
            this.LblMiddleName.Size = new System.Drawing.Size(99, 18);
            this.LblMiddleName.TabIndex = 0;
            this.LblMiddleName.Text = "Middle Name:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(3, 120);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(3, 21, 3, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(84, 18);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Last Name:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(3, 159);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(3, 21, 3, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 18);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(3, 198);
            this.LblType.Margin = new System.Windows.Forms.Padding(3, 21, 3, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(44, 18);
            this.LblType.TabIndex = 0;
            this.LblType.Text = "Type:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TxtEmpID);
            this.flowLayoutPanel1.Controls.Add(this.TxtFirstName);
            this.flowLayoutPanel1.Controls.Add(this.TxtMiddleName);
            this.flowLayoutPanel1.Controls.Add(this.TxtLastName);
            this.flowLayoutPanel1.Controls.Add(this.TxtPassword);
            this.flowLayoutPanel1.Controls.Add(this.CmbType);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 230);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmpID.Location = new System.Drawing.Point(0, 0);
            this.TxtEmpID.Margin = new System.Windows.Forms.Padding(0);
            this.TxtEmpID.MaxLength = 8;
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(200, 24);
            this.TxtEmpID.TabIndex = 4;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFirstName.Location = new System.Drawing.Point(0, 39);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtFirstName.MaxLength = 30;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(200, 24);
            this.TxtFirstName.TabIndex = 5;
            this.TxtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstName_KeyPress);
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMiddleName.Location = new System.Drawing.Point(0, 78);
            this.TxtMiddleName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtMiddleName.MaxLength = 30;
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(200, 24);
            this.TxtMiddleName.TabIndex = 6;
            this.TxtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMiddleName_KeyPress);
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLastName.Location = new System.Drawing.Point(0, 117);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtLastName.MaxLength = 30;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(200, 24);
            this.TxtLastName.TabIndex = 7;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Location = new System.Drawing.Point(0, 156);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtPassword.MaxLength = 30;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(200, 24);
            this.TxtPassword.TabIndex = 8;
            // 
            // CmbType
            // 
            this.CmbType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "--Select--",
            "Employee",
            "Manager"});
            this.CmbType.Location = new System.Drawing.Point(0, 195);
            this.CmbType.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(200, 26);
            this.CmbType.TabIndex = 9;
            // 
            // FlpButtons
            // 
            this.FlpButtons.Controls.Add(this.BtnAddNew);
            this.FlpButtons.Controls.Add(this.BtnUpdateExisting);
            this.FlpButtons.Controls.Add(this.BtnDeleteExisting);
            this.FlpButtons.Controls.Add(this.BtnClearFields);
            this.FlpButtons.Location = new System.Drawing.Point(880, 353);
            this.FlpButtons.Name = "FlpButtons";
            this.FlpButtons.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FlpButtons.Size = new System.Drawing.Size(352, 221);
            this.FlpButtons.TabIndex = 2;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNew.ForeColor = System.Drawing.Color.Black;
            this.BtnAddNew.Location = new System.Drawing.Point(10, 0);
            this.BtnAddNew.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddNew.Size = new System.Drawing.Size(339, 44);
            this.BtnAddNew.TabIndex = 10;
            this.BtnAddNew.TabStop = false;
            this.BtnAddNew.Text = "Add New Employee";
            this.BtnAddNew.UseVisualStyleBackColor = false;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnUpdateExisting
            // 
            this.BtnUpdateExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateExisting.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdateExisting.Location = new System.Drawing.Point(10, 59);
            this.BtnUpdateExisting.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnUpdateExisting.Name = "BtnUpdateExisting";
            this.BtnUpdateExisting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUpdateExisting.Size = new System.Drawing.Size(339, 44);
            this.BtnUpdateExisting.TabIndex = 11;
            this.BtnUpdateExisting.TabStop = false;
            this.BtnUpdateExisting.Text = "Update Existing Employee";
            this.BtnUpdateExisting.UseVisualStyleBackColor = false;
            this.BtnUpdateExisting.Click += new System.EventHandler(this.BtnUpdateExisting_Click);
            // 
            // BtnDeleteExisting
            // 
            this.BtnDeleteExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteExisting.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteExisting.Location = new System.Drawing.Point(10, 118);
            this.BtnDeleteExisting.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnDeleteExisting.Name = "BtnDeleteExisting";
            this.BtnDeleteExisting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeleteExisting.Size = new System.Drawing.Size(339, 44);
            this.BtnDeleteExisting.TabIndex = 12;
            this.BtnDeleteExisting.TabStop = false;
            this.BtnDeleteExisting.Text = "Delete Existing Employee";
            this.BtnDeleteExisting.UseVisualStyleBackColor = false;
            this.BtnDeleteExisting.Click += new System.EventHandler(this.BtnDeleteExisting_Click);
            // 
            // BtnClearFields
            // 
            this.BtnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearFields.ForeColor = System.Drawing.Color.Black;
            this.BtnClearFields.Location = new System.Drawing.Point(10, 177);
            this.BtnClearFields.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnClearFields.Name = "BtnClearFields";
            this.BtnClearFields.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClearFields.Size = new System.Drawing.Size(339, 44);
            this.BtnClearFields.TabIndex = 13;
            this.BtnClearFields.TabStop = false;
            this.BtnClearFields.Text = "Clear All Fields";
            this.BtnClearFields.UseVisualStyleBackColor = false;
            this.BtnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
            // 
            // MasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1232, 575);
            this.Controls.Add(this.FlpButtons);
            this.Controls.Add(this.FlpDataField);
            this.Controls.Add(this.FlpSearch);
            this.Controls.Add(this.DgvEmpList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MasterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpList)).EndInit();
            this.FlpSearch.ResumeLayout(false);
            this.FlpSearch.PerformLayout();
            this.FlpDataField.ResumeLayout(false);
            this.FlpLabel.ResumeLayout(false);
            this.FlpLabel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpList;
        private System.Windows.Forms.FlowLayoutPanel FlpSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearchEmpID;
        private System.Windows.Forms.FlowLayoutPanel FlpDataField;
        private System.Windows.Forms.FlowLayoutPanel FlpLabel;
        private System.Windows.Forms.Label LblEmpID;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblMiddleName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.FlowLayoutPanel FlpButtons;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdateExisting;
        private System.Windows.Forms.Button BtnDeleteExisting;
        private System.Windows.Forms.Button BtnClearFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpType;
        private System.Windows.Forms.Button BtnClearSearch;
        private System.Windows.Forms.Label label1;
    }
}