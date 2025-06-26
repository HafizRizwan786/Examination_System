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
    public partial class TSchedule : Form
    {
        public TSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAddSchedule tadd = new TAddSchedule();
            tadd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TDelSchedule del = new TDelSchedule();
            del.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TEditSchedule te = new TEditSchedule();
            te.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ASchedule a = new ASchedule();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ADashBoard a = new ADashBoard();
            a.Show();
            this.Hide();
        }
    }
}
