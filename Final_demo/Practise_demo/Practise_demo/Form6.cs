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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 q = new Form7();
            this.Hide();
            q.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 king = new Form8();
            this.Hide();
            king.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form33 a = new Form33();
            this.Hide();
            a.Show();
        }
    }
}
