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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 yt = new Form9();
            this.Hide();
            yt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 c = new Form7();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 er = new Form10();
            this.Hide();
            er.Show();
        }
    }
}
