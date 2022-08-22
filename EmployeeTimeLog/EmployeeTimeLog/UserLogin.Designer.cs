namespace EmployeeTimeLog
{
    partial class UserLogin
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
            this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.FlpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LblEmployeeID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.FlpTextBox = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtEmployeeID = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.FlpClear = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.FlpLogin = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.FlpMain.SuspendLayout();
            this.FlpLabel.SuspendLayout();
            this.FlpTextBox.SuspendLayout();
            this.FlpClear.SuspendLayout();
            this.FlpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpMain
            // 
            this.FlpMain.BackColor = System.Drawing.Color.Transparent;
            this.FlpMain.Controls.Add(this.LblTitle);
            this.FlpMain.Controls.Add(this.FlpLabel);
            this.FlpMain.Controls.Add(this.FlpTextBox);
            this.FlpMain.Controls.Add(this.FlpClear);
            this.FlpMain.Controls.Add(this.FlpLogin);
            this.FlpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlpMain.Location = new System.Drawing.Point(11, 11);
            this.FlpMain.Margin = new System.Windows.Forms.Padding(2);
            this.FlpMain.Name = "FlpMain";
            this.FlpMain.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.FlpMain.Size = new System.Drawing.Size(462, 369);
            this.FlpMain.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Abraham", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(101, 20);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(92, 10, 90, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(262, 65);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Company XYZ";
            // 
            // FlpLabel
            // 
            this.FlpLabel.Controls.Add(this.LblEmployeeID);
            this.FlpLabel.Controls.Add(this.LblPassword);
            this.FlpLabel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpLabel.Location = new System.Drawing.Point(51, 145);
            this.FlpLabel.Margin = new System.Windows.Forms.Padding(42, 60, 3, 3);
            this.FlpLabel.Name = "FlpLabel";
            this.FlpLabel.Padding = new System.Windows.Forms.Padding(3);
            this.FlpLabel.Size = new System.Drawing.Size(130, 90);
            this.FlpLabel.TabIndex = 0;
            // 
            // LblEmployeeID
            // 
            this.LblEmployeeID.AutoSize = true;
            this.LblEmployeeID.Location = new System.Drawing.Point(6, 9);
            this.LblEmployeeID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblEmployeeID.Name = "LblEmployeeID";
            this.LblEmployeeID.Size = new System.Drawing.Size(96, 18);
            this.LblEmployeeID.TabIndex = 0;
            this.LblEmployeeID.Text = "Employee ID:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(6, 56);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(3, 29, 3, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 18);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // FlpTextBox
            // 
            this.FlpTextBox.Controls.Add(this.TxtEmployeeID);
            this.FlpTextBox.Controls.Add(this.TxtPassword);
            this.FlpTextBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpTextBox.Location = new System.Drawing.Point(187, 145);
            this.FlpTextBox.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.FlpTextBox.Name = "FlpTextBox";
            this.FlpTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.FlpTextBox.Size = new System.Drawing.Size(223, 90);
            this.FlpTextBox.TabIndex = 0;
            // 
            // TxtEmployeeID
            // 
            this.TxtEmployeeID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmployeeID.Location = new System.Drawing.Point(6, 6);
            this.TxtEmployeeID.MaxLength = 8;
            this.TxtEmployeeID.Name = "TxtEmployeeID";
            this.TxtEmployeeID.Size = new System.Drawing.Size(200, 24);
            this.TxtEmployeeID.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Location = new System.Drawing.Point(6, 53);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtPassword.MaxLength = 30;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(200, 24);
            this.TxtPassword.TabIndex = 2;
            // 
            // FlpClear
            // 
            this.FlpClear.Controls.Add(this.BtnClear);
            this.FlpClear.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpClear.Location = new System.Drawing.Point(51, 258);
            this.FlpClear.Margin = new System.Windows.Forms.Padding(42, 20, 3, 3);
            this.FlpClear.Name = "FlpClear";
            this.FlpClear.Padding = new System.Windows.Forms.Padding(3);
            this.FlpClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FlpClear.Size = new System.Drawing.Size(176, 60);
            this.FlpClear.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.Black;
            this.BtnClear.Location = new System.Drawing.Point(8, 6);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 44);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.TabStop = false;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FlpLogin
            // 
            this.FlpLogin.Controls.Add(this.BtnLogin);
            this.FlpLogin.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpLogin.Location = new System.Drawing.Point(233, 258);
            this.FlpLogin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.FlpLogin.Name = "FlpLogin";
            this.FlpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.FlpLogin.Size = new System.Drawing.Size(177, 60);
            this.FlpLogin.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(61, 6);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 44);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.FlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.FlpMain.ResumeLayout(false);
            this.FlpMain.PerformLayout();
            this.FlpLabel.ResumeLayout(false);
            this.FlpLabel.PerformLayout();
            this.FlpTextBox.ResumeLayout(false);
            this.FlpTextBox.PerformLayout();
            this.FlpClear.ResumeLayout(false);
            this.FlpLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpMain;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblEmployeeID;
        private System.Windows.Forms.FlowLayoutPanel FlpLabel;
        private System.Windows.Forms.FlowLayoutPanel FlpTextBox;
        private System.Windows.Forms.TextBox TxtEmployeeID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.FlowLayoutPanel FlpClear;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.FlowLayoutPanel FlpLogin;
        private System.Windows.Forms.Button BtnLogin;
    }
}

