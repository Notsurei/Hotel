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
using Hotel3.Staff_Manage;

namespace Hotel3.Forms
{
    public partial class RequirePassword : Form
    {
        public RequirePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Please Enter Password!");
            }         
            else
            {
                try
                {                   
                    SqlCommand cmd = new SqlCommand("select * from Password where Password = @PW", conn);
                    cmd.Parameters.AddWithValue("@PW",textBoxLogin.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        AddOrDelete AOD = new AddOrDelete();
                        AOD.Show();
                        this.Close();                       
                    }
                    else
                    {
                        MessageBox.Show("invalid");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxLogin.UseSystemPasswordChar= true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Show Password");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Hide Password");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            textBoxLogin.UseSystemPasswordChar = false;
            pictureBox1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            textBoxLogin.UseSystemPasswordChar = true;
            pictureBox2.Show();
        }
    }
}
