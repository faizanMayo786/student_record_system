using Menu.PAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.DataQueries.GetConnection();
        }

        private void btnLoadRecord_Click(object sender, EventArgs e)
        {
            LoadRecord load = new LoadRecord();
            load.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddRecord add = new AddRecord();
            add.Show();
            this.Hide();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord delete = new DeleteRecord();
            delete.Show();
            this.Hide();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            UpdateRecord update = new UpdateRecord();
            update.Show();
            this.Hide();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void btnMinimumMarks_Click(object sender, EventArgs e)
        {
            string min="";
            SqlDataReader reader = DAL.DataQueries.MinimumMarks();
            while (reader.Read())
            {
                min = reader[""].ToString();
            }
            MessageBox.Show("Mainimum Marks are "+min,"Marks!");
        }

        private void btnMaximumMarks_Click(object sender, EventArgs e)
        {
            string max = "";
            SqlDataReader reader = DAL.DataQueries.MaximumMarks();
            while (reader.Read())
            {
                max = reader["Maximum"].ToString();
            }
            MessageBox.Show("Maximum Marks are " + max, "Marks!");
        }
        #region
        private void btnAddRecord_MouseLeave(object sender, EventArgs e)
        {
            btnAddRecord.BackColor = Color.WhiteSmoke;
        }

        private void btnAddRecord_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddRecord.BackColor = Color.Orange;

        }

        private void btnUpdateRecord_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateRecord.BackColor = Color.WhiteSmoke;
        }

        private void btnUpdateRecord_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdateRecord.BackColor = Color.Orange;
        }

        private void btnDeleteRecord_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteRecord.BackColor = Color.WhiteSmoke;
        }

        private void btnDeleteRecord_MouseMove(object sender, MouseEventArgs e)
        {
            btnDeleteRecord.BackColor = Color.Orange;
        }

        private void btnLoadRecord_MouseLeave(object sender, EventArgs e)
        {
            btnLoadRecord.BackColor = Color.WhiteSmoke;
        }

        private void btnLoadRecord_MouseMove(object sender, MouseEventArgs e)
        {
            btnLoadRecord.BackColor= Color.Orange;
        }

        private void btnSearchStudent_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearchStudent.BackColor = Color.Orange;
        }

        private void btnSearchStudent_MouseLeave(object sender, EventArgs e)
        {
            btnSearchStudent.BackColor = Color.WhiteSmoke;
        }

        private void btnMinimumMarks_MouseLeave(object sender, EventArgs e)
        {
            btnMinimumMarks.BackColor = Color.WhiteSmoke;
        }

        private void btnMinimumMarks_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimumMarks.BackColor = Color.Orange;
        }

        private void btnMaximumMarks_MouseLeave(object sender, EventArgs e)
        {
            btnMaximumMarks.BackColor = Color.WhiteSmoke;
        }

        private void btnMaximumMarks_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximumMarks.BackColor = Color.Orange;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.DarkRed;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.Green;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Green;
        }
        #endregion
    }
}
