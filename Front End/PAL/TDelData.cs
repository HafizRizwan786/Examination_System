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
    public partial class TDelData : Form
    {
        public TDelData()
        {
            InitializeComponent();
        }

        private void TDelData_Load(object sender, EventArgs e)
        {
            lbltname.Text = BAL.LogTname.Tname;

            SqlDataReader reader = DAL.DBQuery.Tsub(BAL.LogTname.Tname);
            while (reader.Read())
            {
                cmbsub.Items.Add(reader["SubName"].ToString());
            }
            reader.Close();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int cls = Convert.ToInt32(cmbclass.SelectedItem.ToString());
            try
            {
                DataTable dt = DAL.DBQuery.GetResultData(cls,cmbsec.SelectedItem.ToString(),cmbsub.SelectedItem.ToString(),cmbtest.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!!" );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int studentId = Convert.ToInt32(selectedRow.Cells["Student_ID"].Value);
                string testName = selectedRow.Cells["Test_Name"].Value.ToString();
                string subjectName = selectedRow.Cells["Subject_Name"].Value.ToString();

                // Delete from DB
                DAL.DBQuery.DeleteResult(studentId, testName, subjectName);

                // Delete from Grid
                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Result deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
