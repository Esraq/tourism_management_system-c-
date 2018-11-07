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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select package,email,phone from tmb.cancel", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {

                MessageBox.Show("ex.Message");

            }

        }
    }
}
