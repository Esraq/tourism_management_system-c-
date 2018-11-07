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
    public partial class Form9 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Form9()
        {
            InitializeComponent();
            string[] a = { "a1", "a2", "a3", "a4", "a5" };
            comboBox1.DataSource = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 eisty = new Form8();
            this.Hide();
            eisty.Show();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            this.Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select package,email,phone from tmb.booking",conDataBase);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery = "DELETE  FROM tmb.booking WHERE email='" + textBox2.Text + "'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
