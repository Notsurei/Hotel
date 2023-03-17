namespace Hotel3
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStaffManage = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelStaffManage = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.reservation1 = new Hotel3.User.Reservation();
            this.userLogin1 = new Hotel3.User.UserLogin();
            this.roomManager1 = new Hotel3.Staff_Manage.RoomManager();
            this.client1 = new Hotel3.Staff_Manage.Client();
            this.staffManage1 = new Hotel3.Staff_Manage.StaffManage();
            this.daaashboard1 = new Hotel3.User.daaashboard();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelStaffManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonStaffManage);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 599);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(30, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "User Manage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStaffManage
            // 
            this.buttonStaffManage.BackColor = System.Drawing.SystemColors.Info;
            this.buttonStaffManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStaffManage.Location = new System.Drawing.Point(30, 445);
            this.buttonStaffManage.Name = "buttonStaffManage";
            this.buttonStaffManage.Size = new System.Drawing.Size(143, 42);
            this.buttonStaffManage.TabIndex = 2;
            this.buttonStaffManage.Text = "Staff Manage";
            this.buttonStaffManage.UseVisualStyleBackColor = false;
            this.buttonStaffManage.Click += new System.EventHandler(this.buttonStaffManage_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.SystemColors.Info;
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.Location = new System.Drawing.Point(30, 375);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(143, 46);
            this.buttonReservation.TabIndex = 2;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoom.Location = new System.Drawing.Point(30, 303);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(143, 47);
            this.buttonRoom.TabIndex = 2;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.SystemColors.Info;
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.Location = new System.Drawing.Point(30, 231);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(143, 50);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.Location = new System.Drawing.Point(30, 165);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(143, 46);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 149);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel3.Properties.Resources.icon2_ico;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.labelUsername);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(203, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 100);
            this.panel4.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Location = new System.Drawing.Point(124, 71);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(20, 21);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.labelDateTime);
            this.panel5.Controls.Add(this.Logout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 64);
            this.panel5.TabIndex = 1;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(3, 34);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(20, 21);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "?";
            // 
            // Logout
            // 
            this.Logout.ActiveLinkColor = System.Drawing.Color.Black;
            this.Logout.AutoSize = true;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(667, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(68, 19);
            this.Logout.TabIndex = 0;
            this.Logout.TabStop = true;
            this.Logout.Text = "Log out\r\n";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelStaffManage
            // 
            this.panelStaffManage.Controls.Add(this.daaashboard1);
            this.panelStaffManage.Controls.Add(this.reservation1);
            this.panelStaffManage.Controls.Add(this.userLogin1);
            this.panelStaffManage.Controls.Add(this.roomManager1);
            this.panelStaffManage.Controls.Add(this.client1);
            this.panelStaffManage.Controls.Add(this.staffManage1);
            this.panelStaffManage.Location = new System.Drawing.Point(225, 119);
            this.panelStaffManage.Name = "panelStaffManage";
            this.panelStaffManage.Size = new System.Drawing.Size(724, 480);
            this.panelStaffManage.TabIndex = 1;
            this.panelStaffManage.Visible = false;
            // 
            // reservation1
            // 
            this.reservation1.Location = new System.Drawing.Point(-7, -5);
            this.reservation1.Margin = new System.Windows.Forms.Padding(4);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(731, 491);
            this.reservation1.TabIndex = 4;
            // 
            // userLogin1
            // 
            this.userLogin1.Location = new System.Drawing.Point(0, -5);
            this.userLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.userLogin1.Name = "userLogin1";
            this.userLogin1.Size = new System.Drawing.Size(666, 431);
            this.userLogin1.TabIndex = 3;
            // 
            // roomManager1
            // 
            this.roomManager1.Location = new System.Drawing.Point(0, -5);
            this.roomManager1.Margin = new System.Windows.Forms.Padding(4);
            this.roomManager1.Name = "roomManager1";
            this.roomManager1.Size = new System.Drawing.Size(724, 481);
            this.roomManager1.TabIndex = 2;
            // 
            // client1
            // 
            this.client1.Location = new System.Drawing.Point(4, 0);
            this.client1.Margin = new System.Windows.Forms.Padding(4);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(720, 479);
            this.client1.TabIndex = 1;
            // 
            // staffManage1
            // 
            this.staffManage1.BackColor = System.Drawing.SystemColors.Control;
            this.staffManage1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffManage1.ForeColor = System.Drawing.Color.Black;
            this.staffManage1.Location = new System.Drawing.Point(-7, -5);
            this.staffManage1.Margin = new System.Windows.Forms.Padding(4);
            this.staffManage1.Name = "staffManage1";
            this.staffManage1.Size = new System.Drawing.Size(720, 481);
            this.staffManage1.TabIndex = 0;
            // 
            // daaashboard1
            // 
            this.daaashboard1.Location = new System.Drawing.Point(-7, -5);
            this.daaashboard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daaashboard1.Name = "daaashboard1";
            this.daaashboard1.Size = new System.Drawing.Size(720, 413);
            this.daaashboard1.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 599);
            this.Controls.Add(this.panelStaffManage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel_Manager_Scence | Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelStaffManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStaffManage;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelStaffManage;
        private Staff_Manage.StaffManage staffManage1;
        private Staff_Manage.Client client1;
        private Staff_Manage.RoomManager roomManager1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private User.UserLogin userLogin1;
        private User.Reservation reservation1;
        private User.daaashboard daaashboard1;
    }
}