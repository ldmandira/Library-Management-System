using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library
{
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtsid.Text == "" || txtbid.Text == "" || txtpe.Text == "" || datetime.Text == "")
            {
                MessageBox.Show("All fields are required");
            }

            else
            {
                
                string pe = txtpe.Text;
                string sid = txtsid.Text;
                string bid = txtbid.Text;
                string date = datetime.Value.ToString("yyyy-MM-dd");


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
               
                string query = "select availability from book where Id='" + bid + "'";

                SqlCommand cmd = new SqlCommand(query, con);
               // string av="" ;
                con.Open();

                SqlDataReader readav = cmd.ExecuteReader();
                string av = "";
                

                while (readav.Read())
                {
                    av = readav["availability"].ToString();
                    
                }
               
                
                con.Close();
                //MessageBox.Show(av);

                 //MessageBox.Show(Convert.ToString(av.Length));

                if (av.Length>1)
                {
                    MessageBox.Show("Book is available");
                    string qry = "insert into issuebk (id,sid,period,date) values ('" + bid + "', '" + sid + "' , '" + pe + "' , '" + date + "')";

                    string up = "update book set availability='' where Id= '" + bid + "'";



                    SqlCommand cmd1 = new SqlCommand(qry, con);

                    SqlCommand cmd2 = new SqlCommand(up, con);

                    try
                    {
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Book issued data added  successfuly ");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

                else
                {
                    MessageBox.Show("Book is not available");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            txtsid.Text = "";
            txtbid.Text = "";
            txtpe.Text = "";
            datetime.Text = "";
        }
    }
}
