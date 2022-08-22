using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    public partial class Employee : Form
    {
        private readonly string empId;
        private readonly Timer timer = new Timer();
        private readonly DBConnect dbConnect = new DBConnect();

        public Employee(string passedId)
        {
            InitializeComponent();
            empId = passedId;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Update design
            Colors colors = new Colors();

            BtnTimeIn.BackColor = colors.Green;
            BtnTimeIn.ForeColor = Color.White;
            BtnTimeIn.FlatAppearance.BorderColor = colors.Green;

            BtnTimeOut.BackColor = colors.Yellow;
            BtnTimeOut.ForeColor = Color.White;
            BtnTimeOut.FlatAppearance.BorderColor = colors.Yellow;

            BtnLogout.BackColor = colors.Orange;
            BtnLogout.ForeColor = Color.White;
            BtnLogout.FlatAppearance.BorderColor = colors.Orange;

            // Set timer
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();

            // Show user data
            string[] returnedData = dbConnect.ShowEmpData(empId);
            TxtEmpID.Text = empId;
            TxtFirstName.Text = returnedData[0];
            TxtMiddleName.Text = returnedData[1];
            TxtLastName.Text = returnedData[2];
            TxtType.Text = returnedData[3];
        }

        private void TimerTick(object sender, EventArgs e)
        {
            LblDate.Text = DateTime.Now.ToString("MM/dd/yyyy \t hh:mm:ss tt");
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Logout() == "Cancel Logout")
            {
                e.Cancel = true;
            }
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
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
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

        // Show warning message
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Show success message
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
