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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 c = new Form15();
            this.Hide();
            c.Show();
        }
    }
}
