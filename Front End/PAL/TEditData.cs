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
    public partial class TEditData : Form
    {
        public TEditData()
        {
            InitializeComponent();
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TEditData_Load(object sender, EventArgs e)
        {
            lbltname.Text = BAL.LogTname.Tname;

            SqlDataReader reader = DAL.DBQuery.Tsub(BAL.LogTname.Tname);
            while (reader.Read())
            {
                cmbsub.Items.Add(reader["SubName"].ToString());
            }
            reader.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int cls = Convert.ToInt32(cmbclass.SelectedItem.ToString());
            try
            {
                DataTable dt = DAL.DBQuery.GetResultData(cls, cmbsec.SelectedItem.ToString(), cmbsub.SelectedItem.ToString(), cmbtest.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int sid = Convert.ToInt32(row.Cells["Student_ID"].Value);
                string name = row.Cells["Student_Name"].Value.ToString();
                string cname = row.Cells["Class"].Value.ToString();
                string sec = row.Cells["Section"].Value.ToString();
                string subject = row.Cells["Subject_Name"].Value.ToString();
                string test = row.Cells["Test_Name"].Value.ToString();
                int pmarks = Convert.ToInt32(row.Cells["Passing_Marks"].Value);
                int gmarks = Convert.ToInt32(row.Cells["Gain_Marks"].Value);
                string percentage = row.Cells["Percentage"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Pass to update form
                TUpdateData frm = new TUpdateData(sid, name, cname, sec, subject, test, pmarks, gmarks, percentage, status);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
    }
}
