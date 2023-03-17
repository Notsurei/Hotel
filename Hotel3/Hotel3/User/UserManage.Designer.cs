namespace Hotel3.User
{
    partial class UserManage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureShow = new System.Windows.Forms.PictureBox();
            this.pictureUnshow = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUnshow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(135, 163);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(248, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter Password:";
            // 
            // pictureShow
            // 
            this.pictureShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShow.Image = global::Hotel3.Properties.Resources.see;
            this.pictureShow.Location = new System.Drawing.Point(389, 163);
            this.pictureShow.Name = "pictureShow";
            this.pictureShow.Size = new System.Drawing.Size(27, 22);
            this.pictureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureShow.TabIndex = 8;
            this.pictureShow.TabStop = false;
            this.pictureShow.Click += new System.EventHandler(this.pictureShow_Click);
            this.pictureShow.MouseHover += new System.EventHandler(this.pictureShow_MouseHover);
            // 
            // pictureUnshow
            // 
            this.pictureUnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUnshow.Image = global::Hotel3.Properties.Resources.unsee;
            this.pictureUnshow.Location = new System.Drawing.Point(389, 163);
            this.pictureUnshow.Name = "pictureUnshow";
            this.pictureUnshow.Size = new System.Drawing.Size(27, 22);
            this.pictureUnshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUnshow.TabIndex = 9;
            this.pictureUnshow.TabStop = false;
            this.pictureUnshow.Click += new System.EventHandler(this.pictureUnshow_Click);
            this.pictureUnshow.MouseHover += new System.EventHandler(this.pictureUnshow_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(215, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureShow);
            this.Controls.Add(this.pictureUnshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Name = "UserManage";
            this.Size = new System.Drawing.Size(532, 424);
            ((System.ComponentModel.ISupportInitialize)(this.pictureShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUnshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureShow;
        private System.Windows.Forms.PictureBox pictureUnshow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private UserLogin userLogin1;
    }
}
