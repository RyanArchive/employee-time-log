using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    public partial class UserLogin : Form
    {
        private readonly DBConnect dbConnect = new DBConnect();

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            Colors colors = new Colors();

            BtnLogin.BackColor = colors.Green;
            BtnLogin.ForeColor = Color.White;
            BtnLogin.FlatAppearance.BorderColor = colors.Green;

            BtnClear.BackColor = Color.White;
            BtnClear.ForeColor = colors.Orange;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmployeeID.Text))
            {
                MessageBox.Show(
                    "Please fill the missing field/s.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                TxtEmployeeID.Focus();
            }
            else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show(
                    "Please fill the missing field/s.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                TxtPassword.Focus();
            }
            else
            {
                string empId = TxtEmployeeID.Text;
                string type = dbConnect.CheckLogin(empId, TxtPassword.Text);

                switch (type)
                {
                    case "Employee":
                        Employee employee = new Employee(empId);
                        employee.Show();
                        Hide();
                        break;
                    case "Manager":
                        Manager manager = new Manager(empId);
                        manager.Show();
                        Hide();
                        break;
                    case "Error":
                        MessageBox.Show(
                            "No connection! Please try again.",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    default:
                        MessageBox.Show(
                            "Invalid credentials.",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        TxtPassword.Clear();
                        TxtEmployeeID.Focus();
                        break;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            TxtEmployeeID.Clear();
            TxtPassword.Clear();
            TxtEmployeeID.Focus();
        }
    }
}
