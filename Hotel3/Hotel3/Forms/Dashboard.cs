using Hotel3.Staff_Manage;
using Hotel3.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel3
{
    public partial class Dashboard : Form
    {
        public string UserName;
        

        

        public Dashboard()
        {
            InitializeComponent();
        }
        

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to quit?", "Log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
                Hotel_Manager_System HMs = new Hotel_Manager_System();
                HMs.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = UserName;
            
        }

        private void buttonStaffManage_Click(object sender, EventArgs e)
        {
            panelStaffManage.Show();
            staffManage1.Show();
            client1.Hide();
            roomManager1.Hide();
            userLogin1.Hide();
            reservation1.Hide();
            daaashboard1.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            panelStaffManage.Show();
            staffManage1.Hide();
            client1.Show();
            roomManager1.Hide();
            userLogin1.Hide();
            reservation1.Hide();
            daaashboard1.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            panelStaffManage.Show();
            staffManage1.Hide();
            client1.Hide();
            roomManager1.Show();
            userLogin1.Hide();
            reservation1.Hide();
            daaashboard1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelStaffManage.Show();
            staffManage1.Hide();
            client1.Hide();
            roomManager1.Hide();
            userLogin1.Show();
            reservation1.Hide();
            daaashboard1.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            panelStaffManage.Show();
            staffManage1.Hide();
            client1.Hide();
            roomManager1.Hide();
            userLogin1.Hide();
            reservation1.Show();
            daaashboard1.Hide();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

            panelStaffManage.Show();
            staffManage1.Hide();
            client1.Hide();
            roomManager1.Hide();
            userLogin1.Hide();
            reservation1.Hide();
            daaashboard1.Show();
        }
    }
}
