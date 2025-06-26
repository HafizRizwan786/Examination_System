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
    public partial class ASchedule : Form
    {
        public ASchedule()
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

        private void btnView_Click(object sender, EventArgs e)
        {
                if (cmbclass.Text == "" || cmbsec.Text == "" || cmbtest.Text == "")
                {
                    MessageBox.Show("Please select Class, Section and Test Name.");
                    return;
                }

                string cname = cmbclass.Text;
                string sec = cmbsec.Text;
                string test = cmbtest.Text;

                DataTable dt = DAL.DBQuery.GetScheduleData(cname, sec, test);
                dataGridView1.DataSource = dt;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSchedule t = new TSchedule();
            t.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
