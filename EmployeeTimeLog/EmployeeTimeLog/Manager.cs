using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    public partial class Manager : Form
    {
        private string currentChild = "";
        private readonly string empId;
        private readonly DBConnect dbConnect = new DBConnect();

        public Manager(string passedId)
        {
            InitializeComponent();
            empId = passedId;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            OpenChild("Master Data");

            // Update design
            Colors colors = new Colors();

            BtnLogout.BackColor = colors.Orange;
            BtnLogout.ForeColor = Color.White;
            BtnLogout.FlatAppearance.BorderColor = colors.Orange;

            BtnTimeIn.BackColor = colors.Green;
            BtnTimeIn.ForeColor = Color.White;
            BtnTimeIn.FlatAppearance.BorderColor = colors.Green;

            BtnTimeOut.BackColor = colors.Yellow;
            BtnTimeOut.ForeColor = Color.White;
            BtnTimeOut.FlatAppearance.BorderColor = colors.Yellow;

            // Get name of manager
            LblName.Text = dbConnect.GetName(empId);
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Logout() == "Cancel Logout")
            {
                e.Cancel = true;
            }
        }

        private void BtnMasterData_Click(object sender, EventArgs e)
        {
            OpenChild("Master Data");
        }

        private void BtnTimeLog_Click(object sender, EventArgs e)
        {
            OpenChild("Time Log");
        }

        // Show content in the panel based on the clicked tabs
        private void OpenChild(string active)
        {
            if (active != currentChild)
            {
                PnlBody.Controls.Clear();

                if (active == "Master Data")
                {
                    MasterData masterData = new MasterData()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false
                    };

                    PnlBody.Controls.Add(masterData);
                    masterData.Show();
                }
                else if (active == "Time Log")
                {
                    TimeLog timeLog = new TimeLog()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false
                    };

                    PnlBody.Controls.Add(timeLog);
                    timeLog.Show();
                }

                currentChild = active;
                ChangeBtnDesign(active);
            }
        }

        // Change design of buttons in tabs
        private void ChangeBtnDesign(string active)
        {
            Colors colors = new Colors();

            if (active == "Master Data")
            {
                BtnMasterData.BackColor = colors.Green;
                BtnMasterData.ForeColor = Color.White;
                BtnMasterData.FlatAppearance.BorderColor = colors.Green;

                BtnTimeLog.BackColor = Color.White;
                BtnTimeLog.ForeColor = Color.Black;
                BtnTimeLog.FlatAppearance.BorderColor = colors.Green;
            }
            else if (active == "Time Log")
            {
                BtnMasterData.BackColor = Color.White;
                BtnMasterData.ForeColor = Color.Black;
                BtnMasterData.FlatAppearance.BorderColor = colors.Green;

                BtnTimeLog.BackColor = colors.Green;
                BtnTimeLog.ForeColor = Color.White;
                BtnTimeLog.FlatAppearance.BorderColor = colors.Green;
            }

            lblFocus.Focus();
        }

        private void BtnTimeIn_Click(object sender, EventArgs e)
        {
            if (dbConnect.LastActivityTime(empId, "Time In"))
            {
                ShowWarningMessage("Already timed in.");
            }
            else
            {
                if (TimeInOut("Time In"))
                {
                    ShowSuccessMessage("Successfully timed in.");
                    ReloadTimeLog();
                }
            }
        }

        private void BtnTimeOut_Click(object sender, EventArgs e)
        {
            if (dbConnect.LastActivityTime(empId, "Time Out"))
            {
                ShowWarningMessage("Already timed out.");
            }
            else
            {
                if (TimeInOut("Time Out"))
                {
                    ShowSuccessMessage("Successfully timed out.");
                    ReloadTimeLog();
                }
            }

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        // Show warning message
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Time in and out
        private bool TimeInOut(string inOut)
        {
            return dbConnect.TimeInOut(
                empId,
                DateTime.Now.ToString("MM/dd/yyyy"),
                inOut,
                DateTime.Now.ToString("hh:mm:ss tt")
                );
        }

        // Show success message
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Reload time log
        private void ReloadTimeLog()
        {
            TimeLog timeLog = new TimeLog()
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };

            PnlBody.Controls.Clear();
            PnlBody.Controls.Add(timeLog);
            timeLog.Show();
        }

        // Logout
        private string Logout()
        {
            DialogResult message = MessageBox.Show(
                "You are logging out. Do you want to continue?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            string returningData = "";

            if (message == DialogResult.Yes)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
                Hide();
                returningData = "Logout";
            }
            else if (message == DialogResult.No)
            {
                returningData = "Cancel Logout";
            }

            return returningData;
        }
    }
}
