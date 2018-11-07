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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 c = new Form14();
            this.Hide();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 ss = new Form17();
            this.Hide();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 s = new Form21();
            this.Hide();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 sq = new Form23();
            this.Hide();
            sq.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form25 st = new Form25();
            this.Hide();
            st.Show();
        }
    }
}
