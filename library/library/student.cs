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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("All fields are required");
            }

            else
            {
                string name = txtname.Text;
                string email = txtemail.Text;
                string id = txtid.Text;


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "insert into student values ('" + id + "', '" + name + "' , '" + email + "')";

                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student data successfuly added");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*dashboard db = new dashboard();
            db.Show();
            this.Hide();*/
        }
    }
    }

