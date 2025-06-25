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
    public partial class TUpdateData : Form
    {
        private int oldSid;
        private string oldTest, oldSubject;

        public TUpdateData(int sid, string name, string cname, string sec, string subject, string test, int pmarks, int gmarks, string percent, string status)
        {
            InitializeComponent();

            // Store for WHERE clause
            oldSid = sid;
            oldTest = test;
            oldSubject = subject;

            // Fill controls
            txtrno.Text = sid.ToString();
            txtsname.Text = name;
            cmbclass.Text = cname;
            cmbsec.Text = sec;
            cmbsub.Text = subject;
            cmbtest.Text = test;
            txtmark.Text = pmarks.ToString();
            txtgmark.Text = gmarks.ToString();
            txtper.Text = percent;
            
        }

        public TUpdateData()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(txtrno.Text);
            string name = txtsname.Text;
            int cname =Convert.ToInt16( cmbclass.Text);
            string sec = cmbsec.Text;
            string subject = cmbsub.Text;
            string test = cmbtest.Text;
            int pmarks = int.Parse(txtmark.Text);
            int gmarks = int.Parse(txtgmark.Text);
            string percent = txtper.Text;

            if (DAL.DBQuery.checkSchedule(cname, cmbsec.Text, cmbtest.Text, cmbsub.Text, pmarks))
            {

                
                if (DAL.DBQuery.checkStudent(sid, txtsname.Text))
                {
                    DAL.DBQuery.UpdateResult(oldSid, oldTest, oldSubject, sid, name, cname, sec, subject, test, pmarks, gmarks, percent, "Unproved");

                    MessageBox.Show("Result updated successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Student is not availible");
                }
            }
            else
            {
                MessageBox.Show("This schedule is not availible");
            }


            
            
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

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgmark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalMarks = Convert.ToInt32(txtmark.Text);
                int gainMarks = Convert.ToInt32(txtgmark.Text);

                if (totalMarks == 0)
                {
                    MessageBox.Show("Total marks can't be zero.");
                    return;
                }

                int per = (gainMarks * 100) / totalMarks;
                txtper.Text = per.ToString() + "%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid inputs!!!!!!");
            }
        }

        private void TUpdateData_Load(object sender, EventArgs e)
        {
            lbltname.Text = BAL.LogTname.Tname;

            SqlDataReader reader = DAL.DBQuery.Tsub(BAL.LogTname.Tname);
            while (reader.Read())
            {
                cmbsub.Items.Add(reader["SubName"].ToString());
            }
            reader.Close();
        }
    }
}
