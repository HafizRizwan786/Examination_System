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
    public partial class TAddSchedule : Form
    {
        public TAddSchedule()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSec.Items.Clear();
            int Cname = Convert.ToInt32(cmbclass.SelectedItem.ToString());
            SqlDataReader reader = DAL.DBQuery.AddSec(Cname);
            while (reader.Read())
            {
                cmbSec.Items.Add(reader["Sec"].ToString());
            }
            reader.Close();


            

            cmbTest.Items.Clear();
            SqlDataReader r = DAL.DBQuery.AddTest(Cname);
            while (r.Read())
            {
                cmbTest.Items.Add(r["tName"].ToString());
            }
            r.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Cname = cmbclass.Text;
            string sub = cmbSub.Text;
            string sec = cmbSec.Text;
            string date = dtp.Text;
            int pmark =Convert.ToInt16(txtPass.Text);
            int tmark = Convert.ToInt16(txtTotal.Text);
            string tname = cmbTest.Text;
            if (cmbclass.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (cmbSub.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (cmbSec.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (dtp.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (cmbTest.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Something Went wrong!!!");
            }
            else
            {
                DAL.DBQuery.AddSchedule(Cname, sec, sub, tname, date, tmark, pmark);
                MessageBox.Show("Schedule Added Successfully");
            }
        }

        private void cmbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = cmbSec.Text;
            int cname = Convert.ToInt16(cmbclass.Text);
            cmbSub.Items.Clear();
            SqlDataReader read = DAL.DBQuery.AddSub(cname,sec);
            while (read.Read())
            {
                cmbSub.Items.Add(read["SubName"].ToString());
            }
            read.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSchedule t = new TSchedule();
            t.Show();
            this.Hide();
        }
    }
}
