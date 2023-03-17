using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel3.User
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "" || textBoxPassWord.Text == "")
            {
                MessageBox.Show("Username or Password is missing");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into User_Table values(@ID,@Username,@Password)", conn);
                    cmd.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassWord.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("This Username has already taken");
                }
            }
        }

        

        

        private void buttonList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from User_table",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            if(int.Parse(textBoxID.Text) == 1)
            {
                MessageBox.Show("Can't delete this Username");
                
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Delete User_table where User_ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from User_table where User_name = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", textBoxSearch.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
