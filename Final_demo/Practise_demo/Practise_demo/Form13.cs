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
    public partial class Form13 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;Initial Catalog='tmb';username=root;password=");
        int i;
        BAL b = new BAL();
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.EEmail = textBox1.Text;
            b.PPassword = textBox2.Text;
            b.llogin(); 
            this.Hide();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 i = new Form3();
            this.Hide();
            i.Show();
        }
    }
}

