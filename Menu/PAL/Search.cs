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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            DataSet ds = DAL.DataQueries.GetDataThroughReader();
            grdSearchRecord.DataSource = ds.Tables["Student"];
            txtSearchRegNo.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //grdSearchRecord.ClearSelection();
            DataSet ds = DAL.DataQueries.Search(txtSearchRegNo.Text);
            grdSearchRecord.DataSource = ds.Tables["Student"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
