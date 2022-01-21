using Menu.BAL;
using Menu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.PAL
{
    public partial class AddRecord : Form
    {
        
        public AddRecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmitRecord_Click(object sender, EventArgs e)
        {
            
            string name = txtStudentName.Text;
            string regNo = txtRegNo.Text;
            double quizzes = double.Parse(txtQuizzes.Text);
            double mid = double.Parse(txtMidMarks.Text);
            double final = double.Parse(txtFinalMarks.Text);
            Student std = new Student(name, regNo, quizzes, mid, final);
            try
            {
                DataQueries.AddRecord(std);
                MessageBox.Show("Record Added!", "DONE!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Record Cannot be Added!", "FAILED!", MessageBoxButtons.OK);
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
