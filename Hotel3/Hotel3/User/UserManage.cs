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

namespace Hotel3.User
{
    public partial class UserManage : UserControl
    {
        
        public UserManage()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureShow_Click(object sender, EventArgs e)
        {
            pictureShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureUnshow.Show();
        }

        private void pictureUnshow_Click(object sender, EventArgs e)
        {
            pictureUnshow.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureShow.Show();
        }

        private void pictureShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureShow, "Show Password");
        }

        private void pictureUnshow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureUnshow, "Hide PassWord");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter Password");
            }
            else
            {
                try
                {
                    SqlConnection help = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
                    help.Open();
                    SqlCommand cmd = new SqlCommand("select * from Password where Password = @PW", help);
                    cmd.Parameters.AddWithValue("@PW", textBoxPassword.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid Password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
