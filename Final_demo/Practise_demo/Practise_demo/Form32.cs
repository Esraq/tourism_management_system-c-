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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form26 a = new Form26();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form55 f = new Form55();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form56 f = new Form56();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form57 f = new Form57();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form58 f = new Form58();
            f.Show();
            this.Hide();
        }
    }
}
