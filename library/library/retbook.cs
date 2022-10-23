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
    public partial class retbook : Form
    {
        public retbook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            txtsid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string bid= txtbid.Text;
           string sid= txtsid.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "insert into rebook values('"+bid+"','"+sid+"')";

            SqlCommand cmd = new SqlCommand(query,con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("return book data added successfully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
