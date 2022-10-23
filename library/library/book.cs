using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtauthor.Text == "" || txtpub.Text == "" )// txtav.Text=="")
            {
                MessageBox.Show("All fields are required");
            }

            else
            {
                string name = txtname.Text;
                string au = txtauthor.Text;
                string pub = txtpub.Text;
                string  id = txtid.Text;
                string av = txtav.Text;


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "insert into book values ('" + id + "', '" + name + "' , '" + au + "' , '" + pub + "', '"+av+"')";

                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book data successfuly added");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtid.Text = "";
            txtauthor.Text = "";
            txtpub.Text = "";
            txtav.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* dashboard db = new dashboard();
            db.Show();
            this.Hide();*/
        }
    }
}
