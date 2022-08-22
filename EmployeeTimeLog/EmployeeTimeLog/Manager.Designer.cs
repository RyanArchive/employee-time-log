namespace EmployeeTimeLog
{
    partial class Manager
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
            this.FlpNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFocus = new System.Windows.Forms.Label();
            this.FlpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMasterData = new System.Windows.Forms.Button();
            this.BtnTimeLog = new System.Windows.Forms.Button();
            this.FlpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnTimeOut = new System.Windows.Forms.Button();
            this.BtnTimeIn = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.FlpNavigation.SuspendLayout();
            this.FlpButton.SuspendLayout();
            this.FlpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpNavigation
            // 
            this.FlpNavigation.BackColor = System.Drawing.Color.Transparent;
            this.FlpNavigation.Controls.Add(this.lblFocus);
            this.FlpNavigation.Controls.Add(this.FlpButton);
            this.FlpNavigation.Controls.Add(this.FlpRight);
            this.FlpNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlpNavigation.Location = new System.Drawing.Point(12, 12);
            this.FlpNavigation.Name = "FlpNavigation";
            this.FlpNavigation.Padding = new System.Windows.Forms.Padding(3);
            this.FlpNavigation.Size = new System.Drawing.Size(1232, 60);
            this.FlpNavigation.TabIndex = 0;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(5, 3);
            this.lblFocus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 18);
            this.lblFocus.TabIndex = 3;
            // 
            // FlpButton
            // 
            this.FlpButton.Controls.Add(this.BtnMasterData);
            this.FlpButton.Controls.Add(this.BtnTimeLog);
            this.FlpButton.Location = new System.Drawing.Point(7, 3);
            this.FlpButton.Margin = new System.Windows.Forms.Padding(0);
            this.FlpButton.Name = "FlpButton";
            this.FlpButton.Size = new System.Drawing.Size(605, 54);
            this.FlpButton.TabIndex = 4;
            // 
            // BtnMasterData
            // 
            this.BtnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMasterData.ForeColor = System.Drawing.Color.Black;
            this.BtnMasterData.Location = new System.Drawing.Point(3, 3);
            this.BtnMasterData.Name = "BtnMasterData";
            this.BtnMasterData.Size = new System.Drawing.Size(145, 44);
            this.BtnMasterData.TabIndex = 1;
            this.BtnMasterData.TabStop = false;
            this.BtnMasterData.Text = "Master Data";
            this.BtnMasterData.UseVisualStyleBackColor = false;
            this.BtnMasterData.Click += new System.EventHandler(this.BtnMasterData_Click);
            // 
            // BtnTimeLog
            // 
            this.BtnTimeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeLog.ForeColor = System.Drawing.Color.Black;
            this.BtnTimeLog.Location = new System.Drawing.Point(154, 3);
            this.BtnTimeLog.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BtnTimeLog.Name = "BtnTimeLog";
            this.BtnTimeLog.Size = new System.Drawing.Size(120, 44);
            this.BtnTimeLog.TabIndex = 2;
            this.BtnTimeLog.TabStop = false;
            this.BtnTimeLog.Text = "Time Log";
            this.BtnTimeLog.UseVisualStyleBackColor = false;
            this.BtnTimeLog.Click += new System.EventHandler(this.BtnTimeLog_Click);
            // 
            // FlpRight
            // 
            this.FlpRight.Controls.Add(this.BtnLogout);
            this.FlpRight.Controls.Add(this.BtnTimeOut);
            this.FlpRight.Controls.Add(this.BtnTimeIn);
            this.FlpRight.Controls.Add(this.LblName);
            this.FlpRight.Location = new System.Drawing.Point(617, 3);
            this.FlpRight.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.FlpRight.Name = "FlpRight";
            this.FlpRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FlpRight.Size = new System.Drawing.Size(605, 54);
            this.FlpRight.TabIndex = 5;
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.Color.Black;
            this.BtnLogout.Location = new System.Drawing.Point(482, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(120, 44);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnTimeOut
            // 
            this.BtnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeOut.ForeColor = System.Drawing.Color.Black;
            this.BtnTimeOut.Location = new System.Drawing.Point(356, 3);
            this.BtnTimeOut.Name = "BtnTimeOut";
            this.BtnTimeOut.Size = new System.Drawing.Size(120, 44);
            this.BtnTimeOut.TabIndex = 6;
            this.BtnTimeOut.TabStop = false;
            this.BtnTimeOut.Text = "Time Out";
            this.BtnTimeOut.UseVisualStyleBackColor = false;
            this.BtnTimeOut.Click += new System.EventHandler(this.BtnTimeOut_Click);
            // 
            // BtnTimeIn
            // 
            this.BtnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimeIn.ForeColor = System.Drawing.Color.Black;
            this.BtnTimeIn.Location = new System.Drawing.Point(230, 3);
            this.BtnTimeIn.Name = "BtnTimeIn";
            this.BtnTimeIn.Size = new System.Drawing.Size(120, 44);
            this.BtnTimeIn.TabIndex = 5;
            this.BtnTimeIn.TabStop = false;
            this.BtnTimeIn.Text = "Time In";
            this.BtnTimeIn.UseVisualStyleBackColor = false;
            this.BtnTimeIn.Click += new System.EventHandler(this.BtnTimeIn_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(71, 17);
            this.LblName.Margin = new System.Windows.Forms.Padding(15, 17, 3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(141, 18);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Welcome, First Last";
            // 
            // PnlBody
            // 
            this.PnlBody.BackColor = System.Drawing.Color.Transparent;
            this.PnlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBody.Location = new System.Drawing.Point(12, 100);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(1232, 575);
            this.PnlBody.TabIndex = 0;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1256, 687);
            this.Controls.Add(this.PnlBody);
            this.Controls.Add(this.FlpNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.FlpNavigation.ResumeLayout(false);
            this.FlpNavigation.PerformLayout();
            this.FlpButton.ResumeLayout(false);
            this.FlpRight.ResumeLayout(false);
            this.FlpRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpNavigation;
        private System.Windows.Forms.Button BtnMasterData;
        private System.Windows.Forms.Button BtnTimeLog;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.FlowLayoutPanel FlpButton;
        private System.Windows.Forms.FlowLayoutPanel FlpRight;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnTimeIn;
        private System.Windows.Forms.Button BtnTimeOut;
    }
}