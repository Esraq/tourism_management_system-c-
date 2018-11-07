using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practise_demo
{
    public partial class Form11 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;Initial Catalog='tmb';username=root;password=");
        int i;

        BL b = new BL();
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            b.Email = textBox1.Text;
            b.Password = textBox2.Text;
            b.login();
            this.Hide();
        }
          
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 er = new Form1();
            this.Hide();
            er.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
