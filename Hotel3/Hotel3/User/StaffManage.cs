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

namespace Hotel3.Staff_Manage
{
    public partial class StaffManage : UserControl
    {
        
        
        public StaffManage()
        {            
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff values(@ID,@Name,@Position)", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@Position", textBoxPostion.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            if(textBoxName.Text == "" || textBoxPostion.Text == "")
            {
                MessageBox.Show("May something is missing");
            }
            
            
        }

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Staff set Staff_Position = @Position where Staff_ID = @ID", conn);
            cmd.Parameters.AddWithValue("@Position", textBoxPostion.Text);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBoxID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Staff", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            conn.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Staff where Staff_ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //textBoxSearch.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Staff where Staff_name = @Name ", conn);
            cmd.Parameters.AddWithValue("@Name", textBoxSearch.Text);
            cmd.ExecuteNonQuery();            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxSearch, "Type Staff Name");
        }
    }
}
