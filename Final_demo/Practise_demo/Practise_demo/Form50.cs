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
    public partial class Form50 : Form
    {
        public Form50()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form51 f = new Form51();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form54 f = new Form54();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.Show();
            this.Hide();
        }
    }
}
