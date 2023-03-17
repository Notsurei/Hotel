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


namespace Hotel3.User
{
    public partial class daaashboard : UserControl
    {
        public daaashboard()
        {
            InitializeComponent();
        }
   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Staff", conn);
            cmd.ExecuteNonQuery();
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();
            labelStaff.Text = rows_count.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Room where Room_Free = 'Yes'", conn);
            cmd.ExecuteNonQuery();
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();
            Room.Text = rows_count.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from User_table", conn);
            cmd.ExecuteNonQuery();
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();
            labelUser.Text = rows_count.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select sum(Money) from Reservation", conn);
            cmd.ExecuteNonQuery();
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();
            labelR.Text = rows_count.ToString();
        }
    }
}
