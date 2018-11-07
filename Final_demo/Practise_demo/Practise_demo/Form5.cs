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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 s = new Form14();
            this.Hide();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 q = new Form3();
            q.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form32 s = new Form32();
            this.Hide();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form27 s = new Form27();
            this.Hide();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form31 s = new Form31();
            this.Hide();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form34 c = new Form34();
            this.Hide();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
