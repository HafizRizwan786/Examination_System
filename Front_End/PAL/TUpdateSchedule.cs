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
    public partial class TUpdateSchedule : Form
    {
        private string oldClass, oldSec, oldTest;

        public TUpdateSchedule(string cname, string sec, string test, string subject, string total, string passing, string date)
        {
            InitializeComponent();

            // Store old values (for WHERE clause)
            oldClass = cname;
            oldSec = sec;
            oldTest = test;

            // Fill form controls
            cmbuclass.Text = cname;
            cmbusec.Text = sec;
            cmbutest.Text = test;
            cmbusubject.Text = subject;
            txttmark.Text = total;
            txtpmark.Text = passing;

            DateTime dt;
            if (DateTime.TryParse(date, out dt))
                dtp.Value = dt;
            else
                dtp.Value = DateTime.Now;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string newClass = cmbuclass.Text;
            string newSec = cmbusec.Text;
            string newTest = cmbutest.Text;
            string subject = cmbusubject.Text;
            int total = int.Parse(txttmark.Text);
            int passing = int.Parse(txtpmark.Text);
            string date = dtp.Value.ToShortDateString();

            DAL.DBQuery.UpdateFullSchedule(
                oldClass, oldSec, oldTest,
                newClass, newSec, newTest,
                subject, total, passing, date
            );

            MessageBox.Show("Schedule updated successfully!");
            this.Close();
        }

        private void cmbuclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbusec.Items.Clear();
            int Cname = Convert.ToInt32(cmbuclass.SelectedItem.ToString());
            SqlDataReader reader = DAL.DBQuery.AddSec(Cname);
            while (reader.Read())
            {
                cmbusec.Items.Add(reader["Sec"].ToString());
            }
            reader.Close();




            cmbutest.Items.Clear();
            SqlDataReader r = DAL.DBQuery.AddTest(Cname);
            while (r.Read())
            {
                cmbutest.Items.Add(r["tName"].ToString());
            }
            r.Close();
        }

        private void cmbusec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = cmbusec.Text;
            int cname = Convert.ToInt16(cmbuclass.Text);
            cmbusubject.Items.Clear();
            SqlDataReader read = DAL.DBQuery.AddSub(cname, sec);
            while (read.Read())
            {
                cmbusubject.Items.Add(read["SubName"].ToString());
            }
            read.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public TUpdateSchedule()
        {
            InitializeComponent();
        }

        private void TUpdateSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
