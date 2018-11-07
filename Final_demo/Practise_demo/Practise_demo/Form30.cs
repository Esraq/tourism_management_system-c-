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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            this.Hide();
            s.Show();
        }
    }
}
