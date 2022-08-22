using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    public partial class MasterData : Form
    {
        private readonly DBConnect dbConnect = new DBConnect();
        private DataGridViewRow selectedRow;
        private bool searched = false;

        public MasterData()
        {
            InitializeComponent();
        }

        private void MasterData_Load(object sender, EventArgs e)
        {
            // Update design
            Colors colors = new Colors();

            DgvEmpList.BackgroundColor = colors.Gray;
            DgvEmpList.GridColor = colors.Gray;
            DgvEmpList.ColumnHeadersDefaultCellStyle.BackColor = colors.Green;
            DgvEmpList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvEmpList.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            DgvEmpList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DgvEmpList.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            DgvEmpList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            BtnSearchEmpID.BackColor = colors.Green;
            BtnSearchEmpID.ForeColor = Color.White;
            BtnSearchEmpID.FlatAppearance.BorderColor = colors.Green;

            BtnClearSearch.BackColor = colors.Orange;
            BtnClearSearch.ForeColor = Color.White;
            BtnClearSearch.FlatAppearance.BorderColor = colors.Orange;

            BtnAddNew.BackColor = colors.Green;
            BtnAddNew.ForeColor = Color.White;
            BtnAddNew.FlatAppearance.BorderColor = colors.Green;

            BtnUpdateExisting.BackColor = colors.Yellow;
            BtnUpdateExisting.ForeColor = Color.White;
            BtnUpdateExisting.FlatAppearance.BorderColor = colors.Yellow;

            BtnDeleteExisting.BackColor = colors.Red;
            BtnDeleteExisting.ForeColor = Color.White;
            BtnDeleteExisting.FlatAppearance.BorderColor = colors.Red;

            BtnClearFields.BackColor = colors.Orange;
            BtnClearFields.ForeColor = Color.White;
            BtnClearFields.FlatAppearance.BorderColor = colors.Orange;

            CmbType.Text = "--Select--";

            // Populate employee table
            DgvEmpList.DataSource = dbConnect.ViewEmployee();
        }

        private void DgvEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                selectedRow = DgvEmpList.Rows[index];

                TxtEmpID.Text = selectedRow.Cells[0].Value.ToString();
                TxtFirstName.Text = selectedRow.Cells[1].Value.ToString();
                TxtMiddleName.Text = selectedRow.Cells[2].Value.ToString();
                TxtLastName.Text = selectedRow.Cells[3].Value.ToString();
                TxtPassword.Text = selectedRow.Cells[4].Value.ToString(); ;
                CmbType.Text = selectedRow.Cells[5].Value.ToString();

                TxtEmpID.Enabled = false;
            }
        }

        private void BtnSearchEmpID_Click(object sender, EventArgs e)
        {
            string input = TxtSearch.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                ShowWarningMessage("Nothing to search. Please enter the Employee ID.");
                TxtSearch.Focus();
            }
            else
            {
                DgvEmpList.DataSource = dbConnect.SearchData(input);
                searched = true;
            }
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            if (searched)
            {
                TxtSearch.Clear();
                DgvEmpList.DataSource = dbConnect.ViewEmployee();
                searched = false;
            }
        }

        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateName(e);
        }

        private void TxtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateName(e);
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateName(e);
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (TxtEmpID.Enabled == false)
            {
                ShowWarningMessage("You selected an existing data. Please click the Clear All Fields first.");
            }
            else
            {
                string empId = TxtEmpID.Text;

                if (
                    string.IsNullOrWhiteSpace(empId)
                    || string.IsNullOrWhiteSpace(TxtFirstName.Text)
                    || string.IsNullOrWhiteSpace(TxtLastName.Text)
                    || string.IsNullOrWhiteSpace(TxtPassword.Text)
                    || CmbType.Text == "--Select--"
                    )
                {
                    ShowWarningMessage("Please fill the missing field/s to add new employee.");
                }
                else
                {
                    if (dbConnect.CheckEmpId(empId) == true)
                    {
                        ShowWarningMessage("Employee ID is already existing.");
                        TxtEmpID.Clear();
                    }
                    else
                    {
                        if (
                            dbConnect.AddEmployee(
                                TxtEmpID.Text, 
                                TxtFirstName.Text.Trim(), 
                                TxtMiddleName.Text.Trim(), 
                                TxtLastName.Text.Trim(), 
                                TxtPassword.Text, 
                                CmbType.Text
                                )
                            )
                        {
                            ShowSuccessMessage("New employee has been successfully added.");
                            DgvEmpList.DataSource = dbConnect.ViewEmployee();
                            ClearFields();
                        }
                    }
                }
            }
        }

        private void BtnUpdateExisting_Click(object sender, EventArgs e)
        {
            if (TxtEmpID.Enabled == true)
            {
                ShowWarningMessage("Nothing to update. Please select a row in the table.");
            }
            else
            {
                if (
                    string.IsNullOrWhiteSpace(TxtFirstName.Text)
                    || string.IsNullOrWhiteSpace(TxtLastName.Text)
                    || string.IsNullOrWhiteSpace(TxtPassword.Text)
                    || CmbType.Text == "--Select--"
                    )
                {
                    ShowWarningMessage("Please fill the missing field/s.");
                }
                else
                {

                    DialogResult dialog = ShowDialog(
                        "This action cannot be undo. Are you sure you want to UPDATE the employee data?"
                        );

                    if (dialog == DialogResult.Yes)
                    {
                        if (
                            dbConnect.UpdateEmployee(
                                TxtEmpID.Text,
                                TxtFirstName.Text.Trim(),
                                TxtMiddleName.Text.Trim(),
                                TxtLastName.Text.Trim(),
                                TxtPassword.Text,
                                CmbType.Text
                                )
                            )
                        {
                            ShowSuccessMessage("Employee's information has been successfully modified.");
                            DgvEmpList.DataSource = dbConnect.ViewEmployee();
                            ClearFields();
                        }
                    }
                }
            }
        }

        private void BtnDeleteExisting_Click(object sender, EventArgs e)
        {
            if (TxtEmpID.Enabled == true)
            {
                ShowWarningMessage("Nothing to delete. Please select a row in the table.");
            }
            else
            {
                DialogResult dialog = ShowDialog(
                    "This action cannot be undo. Are you sure you want to DELETE the employee data?"
                    );

                if (dialog == DialogResult.Yes)
                {
                    if (dbConnect.DeleteEmployee(TxtEmpID.Text))
                    {
                        ShowSuccessMessage("Employee data has been successfully deleted.");
                        DgvEmpList.DataSource = dbConnect.ViewEmployee();
                        ClearFields();
                    }
                }
            }
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            ShowSuccessMessage("Fields have been cleared.");
            ClearFields();
        }

        // Show warning message
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Accept only letters and necessary characters for names
        private void ValidateName(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 32 && ch != 44 && ch != 45 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Clear all fields
        private void ClearFields()
        {
            TxtEmpID.Clear();
            TxtFirstName.Clear();
            TxtMiddleName.Clear();
            TxtLastName.Clear();
            TxtPassword.Clear();
            CmbType.Text = "--Select--";

            TxtEmpID.Enabled = true;
        }

        // Show success message
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Show dialog
        private DialogResult ShowDialog(string message)
        {
            DialogResult dialog = MessageBox.Show(
                message,
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            return dialog;
        }
    }
}
