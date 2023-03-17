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
    public partial class Reservation : UserControl
    {
        string payment;
        string holiday;
        public Reservation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dateIn = dateTimePickerIn.Value;
            DateTime dateOut = dateTimePickerOut.Value;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation (Reservation_No, Client_ID, Room_Number, DayIn, DayOut, Payment_method, Holiday) values(@ID,@ClientID,@RoomNumber,@DayIn,@DayOut,@Paymentmethod,@Holiday)", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxIDRev.Text));
            cmd.Parameters.AddWithValue("@ClientID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("RoomNumber", int.Parse(textBoxRoomNumber.Text));
            cmd.Parameters.AddWithValue("DayIn", dateIn);
            cmd.Parameters.AddWithValue("DayOut", dateOut);
            cmd.Parameters.AddWithValue("@Paymentmethod", payment);
            cmd.Parameters.AddWithValue("@Holiday", holiday);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void radioButtonDeposit_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Deposit";
        }

        private void radioButtonPaid_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Paid";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Reservation where Reservation_No = @ID",conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxIDRev.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Reservation", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DateTime dateIn = dateTimePickerIn.Value;
            DateTime dateOut = dateTimePickerOut.Value;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Reservation set Client_ID = @ID, Room_Number = @Roomnum, DayIn = @DayIn, DayOut = @DayOut, Payment_method = @PT, Holiday = @HD where Reservation_No = @RN", conn);
            cmd.Parameters.AddWithValue("@RN", int.Parse(textBoxIDRev.Text));
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@Roomnum", int.Parse(textBoxRoomNumber.Text));
            cmd.Parameters.AddWithValue("DayIn", dateIn);
            cmd.Parameters.AddWithValue("DayOut", dateOut);
            cmd.Parameters.AddWithValue("@PT", payment);
            cmd.Parameters.AddWithValue("@HD", holiday);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //textBoxSearch.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Reservation where Client_ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID",textBoxSearch.Text);
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            holiday = "Yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            holiday = "No";
        }

        
        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxSearch, "Type Client ID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Reservation where Room_Number = @RN", conn);
            cmd.Parameters.AddWithValue("@RN", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Type Room Number");
        }
    }
}
