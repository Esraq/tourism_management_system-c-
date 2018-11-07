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
    public partial class Form27 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Form27()
        {
            InitializeComponent();
            string[] a = { "a1", "a2", "a3", "a4", "a5" };
            comboBox1.DataSource = a;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            {
                if (textBox2.Text.Length > 2 && textBox3.Text.Length > 5)
                {
                    string insertQuery = "INSERT into tmb.booking(package,email,phone) VALUES('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    con.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, con);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("Package booked successfully");
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
            

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select package,duration,cost from tmb.details",conDataBase);
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
            }catch(Exception ex){

                MessageBox.Show("ex.Message");

            }



            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form32 f = new Form32();
            f.Show();
            this.Hide();
        }
        }
    }

