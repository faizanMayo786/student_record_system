using Menu.BAL;
using Menu.DAL;
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

namespace Menu.PAL
{
    public partial class UpdateRecord : Form
    {
        private string regNo;
        public UpdateRecord()
        {
            InitializeComponent();
        }

        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DAL.DataQueries.GetRegNo();
            while (reader.Read())
            {
                cmbRegNo.Items.Add(reader["RegNo"].ToString());
            }
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            regNo = cmbRegNo.SelectedItem.ToString();
            SqlDataReader reader = DAL.DataQueries.SelectedRegNo(regNo);
            while(reader.Read())
            {
                txtRegNo.Text = reader["RegNo"].ToString();
                txtStudentName.Text = reader["StudentName"].ToString();
                txtQuizzes.Text = reader["Quizzes"].ToString();
                txtMidMarks.Text = reader["Mids"].ToString();
                txtFinalMarks.Text = reader["Finals"].ToString();
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You Want to Update?", "Confirm Update!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string name = txtStudentName.Text;
                string RegNo = txtRegNo.Text;
                double quizzes = double.Parse(txtQuizzes.Text);
                double mid = double.Parse(txtMidMarks.Text);
                double final = double.Parse(txtFinalMarks.Text);
                Student std = new Student(name, RegNo, quizzes, mid, final);
                DAL.DataQueries.UpdateRecord(regNo, std);
                MessageBox.Show("Updated Successfuly!");
            }
            else
            {
                MessageBox.Show("Update Canceled");
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
