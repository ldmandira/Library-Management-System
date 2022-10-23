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
    public partial class Form1 : Form
    {
       /* string username = txtuname.Text;
        string password=txtpw.Text;*/
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signupform obj = new signupform();
            obj.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from signup where username='" +txtuname.Text+ "' AND password='" +txtpw.Text+ "' ";

            SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 con.Open();
                 SqlDataAdapter da = new SqlDataAdapter(query,con);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 if (dt.Rows.Count > 0)
                 {
                     //MessageBox.Show("Welcome");
                     dashboard db = new dashboard();
                     db.Show();
                     this.Hide();

                 }
                 else
                 {
                     MessageBox.Show("You dont't have a account.Please signup");
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show("Error generated" + ex);
             }
         }

            /*if (txtuname.Text == "dulani" && txtpw.Text== "123")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();
            }*/


            private void Form1_Load(object sender, EventArgs e)
            {

            }

       /* private void button3_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpw.Text = "";
        }
    }
    }

