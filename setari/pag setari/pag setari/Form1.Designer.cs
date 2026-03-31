namespace pag_setari
{
    partial class PROFIL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PROFIL));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            profilepicture = new PictureBox();
            ButtonUsername = new Button();
            ButtonNickname = new Button();
            FavPlaces = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            FAV1 = new PictureBox();
            FAV2 = new PictureBox();
            FAV3 = new PictureBox();
            panel1 = new Panel();
            Delete = new Label();
            Notif = new Label();
            changePassword = new Label();
            Settings = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            Profilesettings = new Label();
            Username = new Label();
            SignOutProfile = new Button();
            NICKNAME = new Label();
            Meniu = new TableLayoutPanel();
            buttonHome = new Button();
           
            buttonSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)profilepicture).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FAV1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FAV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FAV3).BeginInit();
            panel1.SuspendLayout();
            Meniu.SuspendLayout();
            SuspendLayout();
            // 
            // profilepicture
            // 
            profilepicture.Image = (Image)resources.GetObject("profilepicture.Image");
            profilepicture.Location = new Point(23, 71);
            profilepicture.Name = "profilepicture";
            profilepicture.Size = new Size(100, 97);
            profilepicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilepicture.TabIndex = 0;
            profilepicture.TabStop = false;
            profilepicture.UseWaitCursor = true;
            profilepicture.Click += profilepicture_Click;
            // 
            // ButtonUsername
            // 
            ButtonUsername.AccessibleName = "";
            ButtonUsername.FlatStyle = FlatStyle.Flat;
            ButtonUsername.ForeColor = Color.FromArgb(255, 224, 192);
            ButtonUsername.Image = (Image)resources.GetObject("ButtonUsername.Image");
            ButtonUsername.Location = new Point(127, 91);
            ButtonUsername.Name = "ButtonUsername";
            ButtonUsername.Size = new Size(30, 29);
            ButtonUsername.TabIndex = 5;
            ButtonUsername.UseVisualStyleBackColor = true;
            ButtonUsername.UseWaitCursor = true;
            ButtonUsername.Click += button1_Click;
            // 
            // ButtonNickname
            // 
            ButtonNickname.FlatStyle = FlatStyle.Flat;
            ButtonNickname.ForeColor = Color.FromArgb(255, 224, 192);
            ButtonNickname.Image = Properties.Resources.edit__1_;
            ButtonNickname.Location = new Point(129, 142);
            ButtonNickname.Name = "ButtonNickname";
            ButtonNickname.Size = new Size(28, 26);
            ButtonNickname.TabIndex = 6;
            ButtonNickname.UseVisualStyleBackColor = true;
            ButtonNickname.UseWaitCursor = true;
            // 
            // FavPlaces
            // 
            FavPlaces.AutoSize = true;
            FavPlaces.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavPlaces.ForeColor = Color.FromArgb(73, 179, 177);
            FavPlaces.Location = new Point(46, 196);
            FavPlaces.Name = "FavPlaces";
            FavPlaces.Size = new Size(251, 31);
            FavPlaces.TabIndex = 7;
            FavPlaces.Text = "FAVOURITE PLACES";
            FavPlaces.UseWaitCursor = true;
            FavPlaces.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(FAV1);
            flowLayoutPanel1.Controls.Add(FAV2);
            flowLayoutPanel1.Controls.Add(FAV3);
            flowLayoutPanel1.Location = new Point(42, 240);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(261, 71);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.UseWaitCursor = true;
            // 
            // FAV1
            // 
            FAV1.Image = Properties.Resources._7845744;
            FAV1.Location = new Point(3, 3);
            FAV1.Name = "FAV1";
            FAV1.Size = new Size(94, 62);
            FAV1.SizeMode = PictureBoxSizeMode.Zoom;
            FAV1.TabIndex = 2;
            FAV1.TabStop = false;
            FAV1.UseWaitCursor = true;
            FAV1.Click += FAV1_Click;
            // 
            // FAV2
            // 
            FAV2.Image = Properties.Resources._8560726;
            FAV2.Location = new Point(103, 3);
            FAV2.Name = "FAV2";
            FAV2.Size = new Size(68, 62);
            FAV2.SizeMode = PictureBoxSizeMode.Zoom;
            FAV2.TabIndex = 0;
            FAV2.TabStop = false;
            FAV2.UseWaitCursor = true;
            FAV2.Click += FAV2_Click;
            // 
            // FAV3
            // 
            FAV3.Image = Properties.Resources._6666513;
            FAV3.Location = new Point(177, 3);
            FAV3.Name = "FAV3";
            FAV3.Size = new Size(81, 62);
            FAV3.SizeMode = PictureBoxSizeMode.Zoom;
            FAV3.TabIndex = 1;
            FAV3.TabStop = false;
            FAV3.UseWaitCursor = true;
            FAV3.Click += FAV3_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Notif);
            panel1.Controls.Add(changePassword);
            panel1.Location = new Point(38, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 95);
            panel1.TabIndex = 9;
            panel1.UseWaitCursor = true;
            panel1.Paint += panel1_Paint;
            // 
            // Delete
            // 
            Delete.AutoSize = true;
            Delete.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.FromArgb(139, 74, 31);
            Delete.Location = new Point(3, 74);
            Delete.Name = "Delete";
            Delete.Size = new Size(128, 20);
            Delete.TabIndex = 2;
            Delete.Text = "Delete Account";
            Delete.UseWaitCursor = true;
            // 
            // Notif
            // 
            Notif.AutoSize = true;
            Notif.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Notif.ForeColor = Color.FromArgb(139, 74, 31);
            Notif.Location = new Point(3, 44);
            Notif.Name = "Notif";
            Notif.Size = new Size(111, 20);
            Notif.TabIndex = 1;
            Notif.Text = "Notifications";
            Notif.UseWaitCursor = true;
            // 
            // changePassword
            // 
            changePassword.AutoSize = true;
            changePassword.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePassword.ForeColor = Color.FromArgb(139, 74, 31);
            changePassword.Location = new Point(3, 13);
            changePassword.Name = "changePassword";
            changePassword.Size = new Size(153, 20);
            changePassword.TabIndex = 0;
            changePassword.Text = "Change Password";
            changePassword.UseWaitCursor = true;
            // 
            // Settings
            // 
            Settings.AutoSize = true;
            Settings.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Settings.ForeColor = Color.FromArgb(139, 74, 31);
            Settings.Location = new Point(88, 314);
            Settings.Name = "Settings";
            Settings.Size = new Size(172, 41);
            Settings.TabIndex = 10;
            Settings.Text = "SETTINGS";
            Settings.UseWaitCursor = true;
            Settings.Click += Settings_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges5;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(156, 146);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(174, 22);
            guna2TextBox1.TabIndex = 11;
            guna2TextBox1.UseWaitCursor = true;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.CustomizableEdges = customizableEdges7;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(156, 98);
            guna2TextBox2.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox2.Size = new Size(174, 22);
            guna2TextBox2.TabIndex = 12;
            guna2TextBox2.UseWaitCursor = true;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // Profilesettings
            // 
            Profilesettings.AutoSize = true;
            Profilesettings.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profilesettings.ForeColor = Color.FromArgb(139, 74, 31);
            Profilesettings.Location = new Point(83, 20);
            Profilesettings.Name = "Profilesettings";
            Profilesettings.Size = new Size(203, 39);
            Profilesettings.TabIndex = 13;
            Profilesettings.Text = "Your Profile";
            Profilesettings.UseWaitCursor = true;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.FromArgb(73, 179, 177);
            Username.Location = new Point(154, 74);
            Username.Name = "Username";
            Username.Size = new Size(88, 20);
            Username.TabIndex = 15;
            Username.Text = "Username";
            Username.UseWaitCursor = true;
            // 
            // SignOutProfile
            // 
            SignOutProfile.BackColor = Color.FromArgb(73, 179, 177);
            SignOutProfile.FlatStyle = FlatStyle.Flat;
            SignOutProfile.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOutProfile.ForeColor = Color.White;
            SignOutProfile.Location = new Point(73, 467);
            SignOutProfile.Margin = new Padding(0);
            SignOutProfile.Name = "SignOutProfile";
            SignOutProfile.Size = new Size(198, 55);
            SignOutProfile.TabIndex = 17;
            SignOutProfile.Text = "Sign Out";
            SignOutProfile.UseVisualStyleBackColor = false;
            SignOutProfile.UseWaitCursor = true;
            SignOutProfile.Click += SignOutProfile_Click;
            // 
            // NICKNAME
            // 
            NICKNAME.AutoSize = true;
            NICKNAME.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NICKNAME.ForeColor = Color.FromArgb(139, 74, 31);
            NICKNAME.Location = new Point(157, 124);
            NICKNAME.Name = "NICKNAME";
            NICKNAME.Size = new Size(90, 20);
            NICKNAME.TabIndex = 18;
            NICKNAME.Text = "Nickname";
            NICKNAME.UseWaitCursor = true;
            // 
            // Meniu
            // 
            Meniu.ColumnCount = 3;
            Meniu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2456131F));
            Meniu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7543869F));
            Meniu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            Meniu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            

            Meniu.Controls.Add(buttonSettings, 2, 0);
            Meniu.Controls.Add(buttonHome, 0, 0);
            Meniu.Dock = DockStyle.Bottom;
            Meniu.Location = new Point(0, 538);
            Meniu.Name = "Meniu";
            Meniu.RowCount = 1;
            Meniu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Meniu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Meniu.Size = new Size(342, 52);
            Meniu.TabIndex = 19;
            Meniu.UseWaitCursor = true;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(255, 224, 192);
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.FromArgb(139, 74, 31);
            buttonHome.Location = new Point(3, 3);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(104, 46);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonMap
            // 
            
            
           

            
            
           
           
           
           
           
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(255, 224, 192);
            buttonSettings.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = Color.FromArgb(139, 74, 31);
            buttonSettings.Location = new Point(231, 3);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(108, 46);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "PROFILE";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // PROFIL
            // 
            AccessibleName = "ButtonUsername";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(342, 590);
            Controls.Add(Meniu);
            Controls.Add(NICKNAME);
            Controls.Add(SignOutProfile);
            Controls.Add(Username);
            Controls.Add(Profilesettings);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(Settings);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(FavPlaces);
            Controls.Add(ButtonNickname);
            Controls.Add(ButtonUsername);
            Controls.Add(profilepicture);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PROFIL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            UseWaitCursor = true;
            Load += PROFIL_Load;
            ((System.ComponentModel.ISupportInitialize)profilepicture).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FAV1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FAV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)FAV3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Meniu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profilepicture;
    
       
        private Button ButtonUsername;
        private Button ButtonNickname;
        private Label FavPlaces;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox FAV1;
        private PictureBox FAV2;
        private PictureBox FAV3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label Settings;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Label Profilesettings;
        private Label Delete;
        private Label Notif;
        private Label changePassword;
        private Label Username;
        private Button SignOutProfile;
        private Label NICKNAME;
        private TableLayoutPanel Meniu;
        private Button buttonHome;
        private Button button2;
        private Button buttonSettings;
    }
}
