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

namespace Hotel3.Forms
{
    public partial class AddOrDelete : Form
    {
        string condition;
        string Type;
        public AddOrDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Room values(@RN,@RT,@RF,@RC)", conn);
            cmd.Parameters.AddWithValue("@RN", int.Parse(textBoxRN.Text));
            cmd.Parameters.AddWithValue("@RT", Type);
            cmd.Parameters.AddWithValue("@RF", condition);
            cmd.Parameters.AddWithValue("@RC", int.Parse(textBoxCost.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            condition = "Yes";
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            condition = "No";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex == 0)
            {
                Type = comboBoxType.Text;
            }
            else if(comboBoxType.SelectedIndex == 1)
            {
                Type = comboBoxType.Text;
            }
            else if(comboBoxType.SelectedIndex == 2)
            {
                Type = comboBoxType.Text;
            }
            else
            {
                Type = comboBoxType.Text;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1VOF01P\KHOIVO;Initial Catalog=Hotel_Manager_System;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Room where Room_Number = @RN", conn);
            cmd.Parameters.AddWithValue("@RN", int.Parse(textBoxRN.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
