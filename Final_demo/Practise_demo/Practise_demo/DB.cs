using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Practise_demo
{
    class DB
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;Initial Catalog='tmb';username=root;password=");

        public void insert_db(string n, string e, string p)
        {
            if (n.Length > 4 && e.Length > 4 && p.Length > 4)
            {
                string insertQuery = "INSERT into tmb.bug(name,email,password) VALUES('" + n + "','" + e + "','" + p + "')";

                con.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, con);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("Registration done successfully");
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

                MessageBox.Show("All field must be 4 character");
            }
            con.Close();

        }
    }
}
