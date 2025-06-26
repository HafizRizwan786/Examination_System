using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Front_End.PAL
{
    public partial class TDelSchedule : Form
    {
        public TDelSchedule()
        {
            InitializeComponent();
        }

        private void TDelSchedule_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsec.Items.Clear();
            int Cname = Convert.ToInt32(cmbclass.SelectedItem.ToString());
            SqlDataReader reader = DAL.DBQuery.AddSec(Cname);
            while (reader.Read())
            {
                cmbsec.Items.Add(reader["Sec"].ToString());
            }
            reader.Close();


            cmbtest.Items.Clear();
            SqlDataReader r = DAL.DBQuery.AddTest(Cname);
            while (r.Read())
            {
                cmbtest.Items.Add(r["tName"].ToString());
            }
            r.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string cname = cmbclass.Text;
            string sec = cmbsec.Text;
            string test = cmbtest.Text;
            if (cmbclass.Text == "")
            {
                MessageBox.Show("Something went wrong!!!");
            }
            else if (cmbsec.Text == "")
            {
                MessageBox.Show("Something went wrong!!!");
            }
            else if (cmbtest.Text == "")
            {
                MessageBox.Show("Something went wrong!!!");
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataReader rd = DAL.DBQuery.ListBox(cname, sec, test);

                dt.Load(rd);
                dataGridView1.DataSource = dt;
                rd.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string cname = row.Cells["Class"].Value.ToString();
                string sec = row.Cells["Section"].Value.ToString();
                string test = row.Cells["Test_Name"].Value.ToString();
                string subject = row.Cells["Subject_Name"].Value.ToString();
                string date = row.Cells["S_Date"].Value.ToString();

                DAL.DBQuery.DelSchedule(cname, sec, test, subject, date);

                MessageBox.Show("Deleted successfully!");

                // Remove row from GridView
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete!");
            }


        }

        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSchedule t = new TSchedule();
            t.Show();
            this.Hide();
        }
    }
}
