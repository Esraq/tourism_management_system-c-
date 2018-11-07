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
    public partial class Form12 : Form  ////inheritance
    {
        User u = new User();
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.Name = textBox1.Text;
            u.Email = textBox2.Text;
            u.Password = textBox4.Text;
            u.insert();  
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 er = new Form13();
            this.Hide();
            er.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
