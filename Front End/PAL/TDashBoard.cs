using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End.PAL
{
    public partial class TDashBoard : Form
    {
        public TDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASchedule a = new ASchedule();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TDataEntry t = new TDataEntry();
            t.Show();
            this.Hide();
        }
    }
}
