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
    public partial class DeleteRecord : Form
    {
        private string regNo;
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            regNo = cmbRegNo.SelectedItem.ToString();
            SqlDataReader reader = DAL.DataQueries.SelectedRegNo(regNo);
            while (reader.Read())
            {
                txtStudentName.Text = reader["StudentName"].ToString();
                txtQuizzes.Text = reader["Quizzes"].ToString();
                txtMidMarks.Text = reader["Mids"].ToString();
                txtFinalMarks.Text = reader["Finals"].ToString();
            }
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DAL.DataQueries.GetRegNo();
            while (reader.Read())
            {
                cmbRegNo.Items.Add(reader["RegNo"].ToString());
            }
        }

        private void cmbRegNo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm Deletion!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.DataQueries.DeleteRecord(regNo);
                MessageBox.Show("Deleted Successfuly!");
            }
            else
            {
                MessageBox.Show("Deletion Cancaled");
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
