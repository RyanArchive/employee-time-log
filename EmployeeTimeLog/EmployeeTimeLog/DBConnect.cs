using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    // Helper class for db connection
    class DBConnect
    {
        public MySqlConnection connection;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Db name: employee_time_log
            connection = new MySqlConnection("Server=localhost;Database=employee_time_log;Uid=root;Pwd=;");
        }

        // Make connection with the db
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid credentials. Please try again.");
                        break;
                }

                return false;
            }
        }

        // Check if user exists and return the type
        public string CheckLogin(string empId, string password)
        {
            string type = "";

            if (OpenConnection() == true)
            {
                string query = 
                    "SELECT * FROM employee " 
                    + "WHERE emp_id='" + empId + "' " 
                    + "AND password='" + password + "'" ;
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                int count = Convert.ToInt32(dataTable.Rows.Count.ToString());

                if (count == 1)
                {
                    DataRow row = dataTable.Rows[0];
                    type = row["type"].ToString();
                }

                connection.Close();
            }
            else
            {
                type = "Error";
            }

            return type;
        }

        // Show data of employees who logged in
        public string[] ShowEmpData(string empId)
        {
            string[] returningData = new string[4];

            if (OpenConnection() == true)
            {
                string query = "SELECT * FROM employee WHERE emp_id='" + empId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];
                returningData[0] = row["first_name"].ToString();
                returningData[1] = row["middle_name"].ToString();
                returningData[2] = row["last_name"].ToString();
                returningData[3] = row["type"].ToString();

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return returningData;
        }

        // Get name of manager
        public string GetName(string empId)
        {
            string name = "";

            if (OpenConnection() == true)
            {
                string query = "SELECT first_name, last_name FROM employee WHERE emp_id='" + empId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];
                name = row["first_name"].ToString() + " " + row["last_name"].ToString();

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return name;
        }

        // View employee list
        public DataTable ViewEmployee()
        {
            DataTable dataTable = new DataTable();

            if (OpenConnection() == true)
            {
                string query = 
                    "SELECT emp_id, first_name, middle_name, last_name, password, type " 
                    + "FROM employee";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return dataTable;
        }

        // Check if Emp Id exists
        public bool CheckEmpId(string empId)
        {
            bool existing = false;

            if (OpenConnection() == true)
            {
                string query = "SELECT * FROM employee WHERE emp_id='" + empId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                int count = Convert.ToInt32(dataTable.Rows.Count.ToString());
                connection.Close();

                if (count == 1)
                {
                    existing = true;
                }
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return existing;
        }

        // Add new employee
        public bool AddEmployee(
            string empId, 
            string firstName, 
            string middleName, 
            string lastName,
            string password,
            string type
            )
        {
            bool success = false;

            if (OpenConnection() == true)
            {
                string query = 
                    "INSERT INTO employee " 
                    + "(emp_id, first_name, middle_name, last_name, password, type) " 
                    + "VALUES ('" + empId + "', '" + firstName + "', '" + middleName + "', '" 
                    + lastName + "', '" + password + "', '" + type + "')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                success = true;
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return success;
        }

        // Update existing employee
        public bool UpdateEmployee(
            string empId, 
            string firstName, 
            string middleName, 
            string lastName, 
            string password, 
            string type
            )
        {
            bool success = false;

            if (OpenConnection() == true)
            {
                string query = 
                    "UPDATE employee " 
                    + "SET first_name='" + firstName + "', "
                    + "middle_name='" + middleName + "', "
                    + "last_name='" + lastName + "', "
                    + "password='" + password + "', "
                    + "type='" + type + "' "
                    + "WHERE emp_id='" + empId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                success = true;
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return success;
        }

        // Delete existing employee
        public bool DeleteEmployee(string empId)
        {
            bool success = false;

            if (OpenConnection() == true)
            {
                string query = "DELETE FROM employee WHERE emp_id='" + empId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                success = true;
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return success;
        }

        // View employee list
        public DataTable SearchData(string input)
        {
            DataTable dataTable = new DataTable();

            if (OpenConnection() == true)
            {
                string query =
                    "SELECT emp_id, first_name, middle_name, last_name, password, type "
                    + "FROM employee "
                    + "WHERE emp_id LIKE '" + input + "%' "
                    + "OR first_name LIKE '" + input + "%' "
                    + "OR middle_name LIKE '" + input + "%' "
                    + "OR last_name LIKE '" + input + "%'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return dataTable;
        }

        // View time log list
        public DataTable ViewTimeLog()
        {
            DataTable dataTable = new DataTable();

            if (OpenConnection() == true)
            {
                string query =
                    "SELECT emp_id, date, in_out, time "
                    + "FROM time_log ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return dataTable;
        }

        // Search time log by Employee ID and/or Date
        public DataTable SearchTimeLog(string empId, string date, string sort)
        {
            DataTable dataTable = new DataTable();
            string additional;

            if (string.IsNullOrWhiteSpace(empId))
            {
                additional = " WHERE date='" + date + "' ORDER BY id " + sort;
            }
            else
            {
                additional = 
                    " WHERE emp_id LIKE '" + empId + "%' "
                    + "AND date='" + date + "' " 
                    + "ORDER BY id " + sort;
            }

            if (OpenConnection() == true)
            {
                string query =
                    "SELECT emp_id, date, in_out, time "
                    + "FROM time_log"
                    + additional;
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return dataTable;
        }

        // Check if last activity time in or out
        public bool LastActivityTime(string empId, string inOut)
        {
            bool truthness = true;

            if (OpenConnection() == true)
            {
                string query =
                    "SELECT in_out FROM time_log "
                    + "WHERE emp_id='" + empId + "' "
                    + "ORDER BY id DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                int count = Convert.ToInt32(dataTable.Rows.Count.ToString());

                if (inOut == "Time In" && count == 0)
                {
                    truthness = false;
                }
                else if (count == 1)
                {
                    DataRow row = dataTable.Rows[0];

                    if (inOut != row["in_out"].ToString())
                    {
                        truthness = false;
                    }
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return truthness;
        }
        
        // Time in
        public bool TimeInOut(string empId, string date, string inOut, string time)
        {
            bool success = false;

            if (OpenConnection() == true)
            {
                string query =
                    "INSERT INTO time_log "
                    + "(emp_id, date, in_out, time) "
                    + "VALUES ('" + empId + "', '" + date + "', '" + inOut + "', '" + time + "')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                success = true;
            }
            else
            {
                MessageBox.Show("No connection! Please try again.");
            }

            return success;
        }
    }
}
