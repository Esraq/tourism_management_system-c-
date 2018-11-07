using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Practise_demo
{
    class DAL
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;Initial Catalog='tmb';username=root;password=");
        int i;
        public void log_db(string e, string p)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from admin where email='" + e + "'and password='" + p + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Password dao");

            }
            else
            {
                Form6 a = new Form6();
                
                a.Show();



            }
            con.Close();
        }
        public void userlog(string e1,string p1)
        {
             i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "select * from bug where BINARY email='"+e1+"'and binary password='"+p1+"'";
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Password dao");

            }
            else
            {

                Form5 a = new Form5();
               
                a.Show();


            }
            con.Close();
        }
        


        }
    }

