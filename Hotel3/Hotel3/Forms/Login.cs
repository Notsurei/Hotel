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

namespace Hotel3
{
    
    public partial class Hotel_Manager_System : Form
    {
        SqlConnection help = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
        
        public Hotel_Manager_System()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Close, "Close");
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Minimize, "Minimize");
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void pictureShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureShow, "Show Password");
        }

        private void pictureUnshow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureUnshow, "Hide Password");
        }

        

        private void pictureUnshow_Click(object sender, EventArgs e)
        {

            pictureUnshow.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureShow.Show();
        }
        private void pictureShow_Click(object sender, EventArgs e)
        {

            pictureShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureUnshow.Show();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username!");
            }
            else if(textBoxPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password!");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from User_table where User_name = @username and User_password = @password", help);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        Dashboard DB = new Dashboard();
                        DB.UserName = textBoxUsername.Text;
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        DB.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid!");
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("" + ex);
                }
                

            }
            
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
