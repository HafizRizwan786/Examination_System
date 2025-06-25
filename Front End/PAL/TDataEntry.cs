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
    public partial class TDataEntry : Form
    {
        public TDataEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAddData a = new TAddData();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TDelData t = new TDelData();
            t.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TEditData t = new TEditData();
            t.Show();
            this.Hide();
        }
    }
}
