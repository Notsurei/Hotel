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
using Hotel3.Forms;

namespace Hotel3.Staff_Manage
{
    public partial class RoomManager : UserControl
    {

        public RoomManager()
        {
            InitializeComponent();
        }
        string Condition;
        
        string Type;

        private void button1_Click(object sender, EventArgs e)
        {
            RequirePassword RP = new RequirePassword();
            RP.Show();           
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            Condition = "Yes";
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            Condition = "No";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Type = comboBox1.Text;                    
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Type = comboBox1.Text;                
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Type = comboBox1.Text;                
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Type = comboBox1.Text;
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                Type = comboBox1.Text;
            }
            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RequirePassword RP = new RequirePassword();
            RP.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Room set Room_Type = @Type, Room_Free = @Condition, Room_Cost_Over_Night = @Cost where Room_Number = @Number",conn);
            cmd.Parameters.AddWithValue("@Number",textBoxNumber.Text);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Condition", Condition);
            cmd.Parameters.AddWithValue("@Cost", int.Parse(textBoxCost.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Room", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //textBoxSearch.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Room where Room_Type = @Type", conn);
            cmd.Parameters.AddWithValue("@Type",textBoxSearch.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(textBoxSearch.Text == "Not Free")
            {
                cmd = new SqlCommand("select * from Room where Room_Free = 'No'", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if(textBoxSearch.Text == "Free")
            {
                cmd = new SqlCommand("select * from Room where Room_Free = 'Yes'", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            
            conn.Close();
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxSearch, "Type Room Number or Room Free");
        }
    }
}
