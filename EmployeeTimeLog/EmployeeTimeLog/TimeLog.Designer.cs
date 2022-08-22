namespace EmployeeTimeLog
{
    partial class TimeLog
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
            this.DgvTimeList = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblSort = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmbSortBy = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClearSearch = new System.Windows.Forms.Button();
            this.FlpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTimeList)).BeginInit();
            this.FlpSearch.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.FlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTimeList
            // 
            this.DgvTimeList.AllowUserToAddRows = false;
            this.DgvTimeList.AllowUserToDeleteRows = false;
            this.DgvTimeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTimeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTimeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTimeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.Date,
            this.InOut,
            this.Time});
            this.DgvTimeList.EnableHeadersVisualStyles = false;
            this.DgvTimeList.Location = new System.Drawing.Point(0, 0);
            this.DgvTimeList.Margin = new System.Windows.Forms.Padding(0);
            this.DgvTimeList.Name = "DgvTimeList";
            this.DgvTimeList.ReadOnly = true;
            this.DgvTimeList.RowHeadersWidth = 51;
            this.DgvTimeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTimeList.Size = new System.Drawing.Size(691, 575);
            this.DgvTimeList.TabIndex = 2;
            this.DgvTimeList.TabStop = false;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "emp_id";
            this.EmpID.HeaderText = "Emp ID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpID.Width = 160;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.Width = 160;
            // 
            // InOut
            // 
            this.InOut.DataPropertyName = "in_out";
            this.InOut.HeaderText = "In/Out";
            this.InOut.MinimumWidth = 6;
            this.InOut.Name = "InOut";
            this.InOut.ReadOnly = true;
            this.InOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InOut.Width = 140;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.Width = 180;
            // 
            // FlpSearch
            // 
            this.FlpSearch.Controls.Add(this.flowLayoutPanel1);
            this.FlpSearch.Controls.Add(this.flowLayoutPanel2);
            this.FlpSearch.Location = new System.Drawing.Point(730, 0);
            this.FlpSearch.Name = "FlpSearch";
            this.FlpSearch.Size = new System.Drawing.Size(502, 120);
            this.FlpSearch.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblSearch);
            this.flowLayoutPanel1.Controls.Add(this.LblDate);
            this.flowLayoutPanel1.Controls.Add(this.LblSort);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 110);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(3, 3);
            this.LblSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(112, 18);
            this.LblSearch.TabIndex = 15;
            this.LblSearch.Text = "Search Emp ID:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(3, 44);
            this.LblDate.Margin = new System.Windows.Forms.Padding(3, 23, 3, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(43, 18);
            this.LblDate.TabIndex = 15;
            this.LblDate.Text = "Date:";
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Location = new System.Drawing.Point(3, 85);
            this.LblSort.Margin = new System.Windows.Forms.Padding(3, 23, 3, 0);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(59, 18);
            this.LblSort.TabIndex = 16;
            this.LblSort.Text = "Sort by:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.TxtSearch);
            this.flowLayoutPanel2.Controls.Add(this.DtpDate);
            this.flowLayoutPanel2.Controls.Add(this.CmbSortBy);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(169, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(321, 110);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(0, 0);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TxtSearch.MaxLength = 8;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(250, 24);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TabStop = false;
            // 
            // CmbSortBy
            // 
            this.CmbSortBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSortBy.FormattingEnabled = true;
            this.CmbSortBy.Items.AddRange(new object[] {
            "Date (Oldest First)",
            "Date (Newest First)"});
            this.CmbSortBy.Location = new System.Drawing.Point(0, 78);
            this.CmbSortBy.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.CmbSortBy.Name = "CmbSortBy";
            this.CmbSortBy.Size = new System.Drawing.Size(250, 26);
            this.CmbSortBy.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnSearch.Location = new System.Drawing.Point(10, 0);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearch.Size = new System.Drawing.Size(120, 44);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClearSearch
            // 
            this.BtnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnClearSearch.Location = new System.Drawing.Point(140, 0);
            this.BtnClearSearch.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnClearSearch.Name = "BtnClearSearch";
            this.BtnClearSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClearSearch.Size = new System.Drawing.Size(120, 44);
            this.BtnClearSearch.TabIndex = 6;
            this.BtnClearSearch.TabStop = false;
            this.BtnClearSearch.Text = "Reset";
            this.BtnClearSearch.UseVisualStyleBackColor = false;
            this.BtnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // FlpButton
            // 
            this.FlpButton.Controls.Add(this.BtnSearch);
            this.FlpButton.Controls.Add(this.BtnClearSearch);
            this.FlpButton.Location = new System.Drawing.Point(730, 140);
            this.FlpButton.Name = "FlpButton";
            this.FlpButton.Size = new System.Drawing.Size(502, 49);
            this.FlpButton.TabIndex = 16;
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "MM/dd/yyyy";
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.Location = new System.Drawing.Point(0, 39);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.DtpDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(250, 24);
            this.DtpDate.TabIndex = 3;
            // 
            // TimeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1232, 575);
            this.Controls.Add(this.FlpSearch);
            this.Controls.Add(this.DgvTimeList);
            this.Controls.Add(this.FlpButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimeLog";
            this.Load += new System.EventHandler(this.TimeLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTimeList)).EndInit();
            this.FlpSearch.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.FlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTimeList;
        private System.Windows.Forms.FlowLayoutPanel FlpSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClearSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.FlowLayoutPanel FlpButton;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ComboBox CmbSortBy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblSort;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}