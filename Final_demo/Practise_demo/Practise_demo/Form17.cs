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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 b = new Form15();
            this.Hide();
            b.Show(); 
        }

    
    }
}
