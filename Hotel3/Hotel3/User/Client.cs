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


namespace Hotel3.Staff_Manage
{
    public partial class Client : UserControl
    {
        
        public Client()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Client values(@ID,@FirstName,@LastName,@PhoneNumber,@Address)", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            if(textBoxLastName.Text == "" && textBoxFirstName.Text == "")
            {
                MessageBox.Show("Please fill the name of CLient");
            }
            else if(textBoxAddress.Text == "" || textBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Please fill the address or phone number of Client");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Client where Client_ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBoxID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Client set Client_PhoneNumber = @PhoneNumber, Client_Address = @Address, Client_FirstName = @FirstName, Client_LastName = @LastName where Client_ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@FirstName",textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName",textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Address",textBoxAddress.Text);
           
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Client", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where Client_FirstName = @PN", conn);
            cmd.Parameters.AddWithValue("@PN", textBoxSearch.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxSearch, "Type the first name of the customer");
        }
    }
}
