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
   
    public partial class Form7 : Form
    {
         MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Form7()
        {
            InitializeComponent();
            string[] a = { "a1", "a2", "a3", "a4", "a5" };
            comboBox1.DataSource = a;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 esraq = new Form6();
            this.Hide();
            esraq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox2.Text.Length > 0 && textBox3.Text.Length > 3)
                {
                    string insertQuery = "INSERT into tmb.details(package,duration,cost) VALUES('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    con.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, con);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("inserted successfully");
                        }


                        else
                        {

                            MessageBox.Show("Data not inserted");

                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {

                    MessageBox.Show("ALL fields are not satisfied");

                }
                con.Close();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string insertQuery = "DELETE  FROM tmb.details WHERE package='" + comboBox1.Text + "'";
            con.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, con);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Request canceled successfully");
                }
                else
                {

                    MessageBox.Show("Data not inserted");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select package,duration,cost from tmb.details", conDataBase);
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
            catch (Exception ex)
            {

                MessageBox.Show("ex.Message");

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
