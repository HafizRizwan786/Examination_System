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
using Front_End.BAL;


namespace Front_End.PAL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ChangePassword ch = new ChangePassword();
            ch.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DAL.DBQuery.VerifyLogin(txtEmail.Text, txtPassword.Text))
            {
                if (cmbSelect.SelectedItem.ToString() == "Administrator")
                {
                    ADashBoard ad = new ADashBoard();
                    ad.Show();
                    this.Hide();
                }
                else if (cmbSelect.SelectedItem.ToString() == "Teacher")
                {
                    // Storing Tname Globally
                    string tname = DAL.DBQuery.teacherName(txtEmail.Text);
                    LogTname.Tname = tname;

                    TDashBoard t = new TDashBoard();
                    t.Show();
                    this.Hide();

                   
                }
                else
                {
                    MessageBox.Show("Select User Type!!!");
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!!");
            }


        }
    }
}
