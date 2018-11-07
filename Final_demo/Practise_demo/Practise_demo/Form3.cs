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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 w = new Form1();
            w.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            this.Hide();
            a.Show();

        }
    }
}
