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
    public partial class Form33 : Form
    {
        public static string s; 
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }
    }
}
