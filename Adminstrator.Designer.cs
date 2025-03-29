namespace Pharmacy_Management_System
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ViewUser1 = new Pharmacy_Management_System.AdminstratorUC.UC_ViewUser();
            this.uC_AddUser1 = new Pharmacy_Management_System.AdminstratorUC.UC_AddUser();
            this.uC_Dashbord1 = new Pharmacy_Management_System.AdminstratorUC.UC_Dashbord();
            this.uC_Profile1 = new Pharmacy_Management_System.AdminstratorUC.UC_Profile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNameLabel.Location = new System.Drawing.Point(3, 691);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(269, 30);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "Abdul Manan";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(54, 593);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(221, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(54, 514);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(221, 45);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(54, 435);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(221, 45);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(54, 357);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(221, 45);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashbord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashbord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashbord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashbord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashbord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbord.Image")));
            this.btnDashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashbord.Location = new System.Drawing.Point(54, 279);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(221, 45);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adminstrator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 768);
            this.panel2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_ViewUser1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 1;
            // 
            // uC_Dashbord1
            // 
            this.uC_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashbord1.Name = "uC_Dashbord1";
            this.uC_Dashbord1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Dashbord1.TabIndex = 0;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Profile1.TabIndex = 3;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnDashbord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminstratorUC.UC_Dashbord uC_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdminstratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdminstratorUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminstratorUC.UC_Profile uC_Profile1;
    }
}