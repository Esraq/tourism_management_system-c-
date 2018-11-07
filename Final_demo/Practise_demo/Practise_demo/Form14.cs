using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practise_demo
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form45 f = new Form45();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form50 f = new Form50();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 b = new Form5();
            this.Hide();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form35 c = new Form35();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form40 f = new Form40();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
