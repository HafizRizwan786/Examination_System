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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (DAL.DBQuery.VerifyEmail(txtchEmail.Text) != null)
            {
                DAL.DBQuery.UpdatePassword(txtchEmail.Text, txtchPassword.Text);
                MessageBox.Show("Password Changed Successfully");
            }
            else
            {
                MessageBox.Show("Your Email is Invalid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
    }
}
