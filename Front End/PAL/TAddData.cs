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
    public partial class TAddData : Form
    {
        

        public TAddData()
        {
            InitializeComponent();
        }

        private void TAddData_Load(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            int cls = Convert.ToInt16( cmbclass.SelectedItem.ToString());
            int mark = Convert.ToInt16(txtmark.Text);
            int id = Convert.ToInt32(txtrno.Text);
            int gmark = Convert.ToInt32(txtgmark.Text);

            if (DAL.DBQuery.checkSchedule(cls, cmbsec.SelectedItem.ToString(), cmbtest.SelectedItem.ToString(), cmbsub.SelectedItem.ToString(), mark))
            {
                if (DAL.DBQuery.checkStudent(id, txtsname.Text))
                {
                    DAL.DBQuery.Result(id, txtsname.Text, cls, cmbsec.SelectedItem.ToString(), cmbsub.SelectedItem.ToString(), cmbtest.SelectedItem.ToString(), mark, gmark, txtper.Text,"Unproved");
                    MessageBox.Show("Record added successfully!!!");
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
    }
}
