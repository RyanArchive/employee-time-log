using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeTimeLog
{
    public partial class TimeLog : Form
    {
        private readonly DBConnect dbConnect = new DBConnect();
        private bool searched = false;

        public TimeLog()
        {
            InitializeComponent();
        }

        private void TimeLog_Load(object sender, EventArgs e)
        {
            // Update design
            Colors colors = new Colors();

            DgvTimeList.BackgroundColor = colors.Gray;
            DgvTimeList.GridColor = colors.Gray;
            DgvTimeList.ColumnHeadersDefaultCellStyle.BackColor = colors.Green;
            DgvTimeList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvTimeList.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            DgvTimeList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DgvTimeList.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            DgvTimeList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            BtnSearch.BackColor = colors.Green;
            BtnSearch.ForeColor = Color.White;
            BtnSearch.FlatAppearance.BorderColor = colors.Green;

            BtnClearSearch.BackColor = colors.Orange;
            BtnClearSearch.ForeColor = Color.White;
            BtnClearSearch.FlatAppearance.BorderColor = colors.Orange;

            CmbSortBy.Text = "Date (Oldest First)";

            // Populate employee table
            DgvTimeList.DataSource = dbConnect.ViewTimeLog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sort = "";

            if (CmbSortBy.Text == "Date (Oldest First)")
            {
                sort = "ASC";
            }
            else if (CmbSortBy.Text == "Date (Newest First)")
            {
                sort = "DESC";
            }

            DgvTimeList.DataSource = dbConnect.SearchTimeLog(TxtSearch.Text, DtpDate.Text, sort);
            searched = true;
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            if (searched)
            {
                DgvTimeList.DataSource = dbConnect.ViewTimeLog();
                TxtSearch.Clear();
                CmbSortBy.Text = "Date (Oldest First)";
                searched = false;
            }
        }
    }
}
