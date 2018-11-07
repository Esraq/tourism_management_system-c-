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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form30 s = new Form30();
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form30 s = new Form30();
            this.Hide();
            s.Show();
        }
    }
}
