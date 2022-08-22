namespace EmployeeTimeLog
{
    partial class Employee
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
            this.FlpBody = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpDataField = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblMiddleName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.FlpNote = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FlpLogout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblDate = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnTimeIn = new System.Windows.Forms.Button();
            this.BtnTimeOut = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.FlpBody.SuspendLayout();
            this.FlpDataField.SuspendLayout();
            this.FlpLabel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FlpNote.SuspendLayout();
            this.FlpLogout.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpBody
            // 
            this.FlpBody.Controls.Add(this.FlpDataField);
            this.FlpBody.Controls.Add(this.FlpLogout);
            this.FlpBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlpBody.Location = new System.Drawing.Point(13, 13);
            this.FlpBody.Name = "FlpBody";
            this.FlpBody.Size = new System.Drawing.Size(554, 242);
            this.FlpBody.TabIndex = 0;
            // 
            // FlpDataField
            // 
            this.FlpDataField.Controls.Add(this.FlpLabel);
            this.FlpDataField.Controls.Add(this.flowLayoutPanel1);
            this.FlpDataField.Controls.Add(this.FlpNote);
            this.FlpDataField.Location = new System.Drawing.Point(3, 3);
            this.FlpDataField.Name = "FlpDataField";
            this.FlpDataField.Size = new System.Drawing.Size(352, 235);
            this.FlpDataField.TabIndex = 1;
            // 
            // FlpLabel
            // 
            this.FlpLabel.Controls.Add(this.LblEmpID);
            this.FlpLabel.Controls.Add(this.LblFirstName);
            this.FlpLabel.Controls.Add(this.LblMiddleName);
            this.FlpLabel.Controls.Add(this.LblLastName);
            this.FlpLabel.Controls.Add(this.LblType);
            this.FlpLabel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpLabel.Location = new System.Drawing.Point(3, 3);
            this.FlpLabel.Name = "FlpLabel";
            this.FlpLabel.Size = new System.Drawing.Size(140, 185);
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
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(3, 159);
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
            this.flowLayoutPanel1.Controls.Add(this.TxtType);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 185);
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
            this.TxtEmpID.ReadOnly = true;
            this.TxtEmpID.Size = new System.Drawing.Size(200, 24);
            this.TxtEmpID.TabIndex = 1;
            this.TxtEmpID.TabStop = false;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFirstName.Location = new System.Drawing.Point(0, 39);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtFirstName.MaxLength = 30;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.ReadOnly = true;
            this.TxtFirstName.Size = new System.Drawing.Size(200, 24);
            this.TxtFirstName.TabIndex = 2;
            this.TxtFirstName.TabStop = false;
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMiddleName.Location = new System.Drawing.Point(0, 78);
            this.TxtMiddleName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtMiddleName.MaxLength = 30;
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.ReadOnly = true;
            this.TxtMiddleName.Size = new System.Drawing.Size(200, 24);
            this.TxtMiddleName.TabIndex = 3;
            this.TxtMiddleName.TabStop = false;
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLastName.Location = new System.Drawing.Point(0, 117);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtLastName.MaxLength = 30;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.ReadOnly = true;
            this.TxtLastName.Size = new System.Drawing.Size(200, 24);
            this.TxtLastName.TabIndex = 4;
            this.TxtLastName.TabStop = false;
            // 
            // TxtType
            // 
            this.TxtType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtType.Location = new System.Drawing.Point(0, 156);
            this.TxtType.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TxtType.MaxLength = 30;
            this.TxtType.Name = "TxtType";
            this.TxtType.ReadOnly = true;
            this.TxtType.Size = new System.Drawing.Size(200, 24);
            this.TxtType.TabIndex = 6;
            this.TxtType.TabStop = false;
            // 
            // FlpNote
            // 
            this.FlpNote.Controls.Add(this.label1);
            this.FlpNote.Location = new System.Drawing.Point(3, 201);
            this.FlpNote.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.FlpNote.Name = "FlpNote";
            this.FlpNote.Size = new System.Drawing.Size(346, 30);
            this.FlpNote.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "* To change data, please inform the manager.";
            // 
            // FlpLogout
            // 
            this.FlpLogout.Controls.Add(this.flowLayoutPanel3);
            this.FlpLogout.Controls.Add(this.flowLayoutPanel2);
            this.FlpLogout.Location = new System.Drawing.Point(361, 3);
            this.FlpLogout.Name = "FlpLogout";
            this.FlpLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlpLogout.Size = new System.Drawing.Size(190, 235);
            this.FlpLogout.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.LblDate);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(184, 24);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(38, 4);
            this.LblDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(142, 16);
            this.LblDate.TabIndex = 11;
            this.LblDate.Text = "00/00/0000 00:00:00am";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BtnTimeIn);
            this.flowLayoutPanel2.Controls.Add(this.BtnTimeOut);
            this.flowLayoutPanel2.Controls.Add(this.BtnLogout);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 25, 0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(184, 171);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // BtnTimeIn
            // 
            this.BtnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeIn.ForeColor = System.Drawing.Color.Black;
            this.BtnTimeIn.Location = new System.Drawing.Point(56, 0);
            this.BtnTimeIn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnTimeIn.Name = "BtnTimeIn";
            this.BtnTimeIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnTimeIn.Size = new System.Drawing.Size(120, 44);
            this.BtnTimeIn.TabIndex = 4;
            this.BtnTimeIn.TabStop = false;
            this.BtnTimeIn.Text = "Time In";
            this.BtnTimeIn.UseVisualStyleBackColor = false;
            this.BtnTimeIn.Click += new System.EventHandler(this.BtnTimeIn_Click);
            // 
            // BtnTimeOut
            // 
            this.BtnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeOut.ForeColor = System.Drawing.Color.Black;
            this.BtnTimeOut.Location = new System.Drawing.Point(56, 59);
            this.BtnTimeOut.Margin = new System.Windows.Forms.Padding(8, 15, 0, 0);
            this.BtnTimeOut.Name = "BtnTimeOut";
            this.BtnTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnTimeOut.Size = new System.Drawing.Size(120, 44);
            this.BtnTimeOut.TabIndex = 5;
            this.BtnTimeOut.TabStop = false;
            this.BtnTimeOut.Text = "Time Out";
            this.BtnTimeOut.UseVisualStyleBackColor = false;
            this.BtnTimeOut.Click += new System.EventHandler(this.BtnTimeOut_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.Color.Black;
            this.BtnLogout.Location = new System.Drawing.Point(56, 118);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(8, 15, 0, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogout.Size = new System.Drawing.Size(120, 44);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(579, 269);
            this.Controls.Add(this.FlpBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.FlpBody.ResumeLayout(false);
            this.FlpDataField.ResumeLayout(false);
            this.FlpLabel.ResumeLayout(false);
            this.FlpLabel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FlpNote.ResumeLayout(false);
            this.FlpNote.PerformLayout();
            this.FlpLogout.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpBody;
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
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.FlowLayoutPanel FlpLogout;
        private System.Windows.Forms.Button BtnTimeIn;
        private System.Windows.Forms.Button BtnTimeOut;
        private System.Windows.Forms.FlowLayoutPanel FlpNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogout;
        public System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}