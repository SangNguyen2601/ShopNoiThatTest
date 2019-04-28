namespace BanHangNoiThat_HeQTCSDL
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.header = new System.Windows.Forms.Panel();
            this.Lablename = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveformlogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnForgotPass = new System.Windows.Forms.LinkLabel();
            this.unshowpassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.showpassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.Login_admin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSignin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unshowpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.Lablename);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(395, 59);
            this.header.TabIndex = 25;
            // 
            // Lablename
            // 
            this.Lablename.AutoSize = true;
            this.Lablename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lablename.ForeColor = System.Drawing.Color.White;
            this.Lablename.Location = new System.Drawing.Point(104, 17);
            this.Lablename.Name = "Lablename";
            this.Lablename.Size = new System.Drawing.Size(197, 29);
            this.Lablename.TabIndex = 2;
            this.Lablename.Text = "SH FURNITURE ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(58, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "SH Furniture - Enhance the value of your home";
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.password.BorderThickness = 3;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(26, 186);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(338, 40);
            this.password.TabIndex = 29;
            this.password.Text = "Pasword";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // username
            // 
            this.username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.username.BorderThickness = 3;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(26, 137);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(338, 40);
            this.username.TabIndex = 28;
            this.username.Text = "User name";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(91, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Please Login First";
            // 
            // moveformlogin
            // 
            this.moveformlogin.Fixed = true;
            this.moveformlogin.Horizontal = true;
            this.moveformlogin.TargetControl = this.header;
            this.moveformlogin.Vertical = true;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.AutoSize = true;
            this.btnForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.Location = new System.Drawing.Point(139, 337);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(121, 18);
            this.btnForgotPass.TabIndex = 34;
            this.btnForgotPass.TabStop = true;
            this.btnForgotPass.Text = "Quên mật khẩu ?";
            this.btnForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnForgotPass_LinkClicked);
            // 
            // unshowpassword
            // 
            this.unshowpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unshowpassword.BackColor = System.Drawing.SystemColors.Control;
            this.unshowpassword.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Invisible_64px;
            this.unshowpassword.ImageActive = null;
            this.unshowpassword.Location = new System.Drawing.Point(331, 193);
            this.unshowpassword.Name = "unshowpassword";
            this.unshowpassword.Size = new System.Drawing.Size(27, 27);
            this.unshowpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unshowpassword.TabIndex = 36;
            this.unshowpassword.TabStop = false;
            this.unshowpassword.Zoom = 10;
            this.unshowpassword.Click += new System.EventHandler(this.unshowpassword_Click);
            // 
            // showpassword
            // 
            this.showpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showpassword.BackColor = System.Drawing.SystemColors.Control;
            this.showpassword.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Eye_64px;
            this.showpassword.ImageActive = null;
            this.showpassword.Location = new System.Drawing.Point(331, 193);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(27, 27);
            this.showpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showpassword.TabIndex = 35;
            this.showpassword.TabStop = false;
            this.showpassword.Visible = false;
            this.showpassword.Zoom = 10;
            this.showpassword.Click += new System.EventHandler(this.showpassword_Click);
            // 
            // Login_admin
            // 
            this.Login_admin.ActiveBorderThickness = 1;
            this.Login_admin.ActiveCornerRadius = 20;
            this.Login_admin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Login_admin.ActiveForecolor = System.Drawing.Color.White;
            this.Login_admin.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.Login_admin.BackColor = System.Drawing.SystemColors.Control;
            this.Login_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_admin.BackgroundImage")));
            this.Login_admin.ButtonText = "Đăng nhập với tư cách quản trị viên";
            this.Login_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_admin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_admin.ForeColor = System.Drawing.Color.SeaGreen;
            this.Login_admin.IdleBorderThickness = 1;
            this.Login_admin.IdleCornerRadius = 20;
            this.Login_admin.IdleFillColor = System.Drawing.Color.DarkGray;
            this.Login_admin.IdleForecolor = System.Drawing.Color.White;
            this.Login_admin.IdleLineColor = System.Drawing.Color.Silver;
            this.Login_admin.Location = new System.Drawing.Point(95, 375);
            this.Login_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_admin.Name = "Login_admin";
            this.Login_admin.Size = new System.Drawing.Size(215, 33);
            this.Login_admin.TabIndex = 32;
            this.Login_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_admin.Click += new System.EventHandler(this.Login_admin_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.ActiveBorderThickness = 1;
            this.btnSignin.ActiveCornerRadius = 20;
            this.btnSignin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignin.BackgroundImage")));
            this.btnSignin.ButtonText = "Sign In";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.IdleBorderThickness = 1;
            this.btnSignin.IdleCornerRadius = 20;
            this.btnSignin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSignin.IdleForecolor = System.Drawing.Color.White;
            this.btnSignin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSignin.Location = new System.Drawing.Point(26, 284);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(338, 48);
            this.btnSignin.TabIndex = 33;
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogin.Location = new System.Drawing.Point(26, 231);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(338, 51);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.gnome_session_hibernate;
            this.pictureBox1.Location = new System.Drawing.Point(351, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unshowpassword);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.Login_admin);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unshowpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label Lablename;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton unshowpassword;
        private Bunifu.Framework.UI.BunifuImageButton showpassword;
        private System.Windows.Forms.LinkLabel btnForgotPass;
        private Bunifu.Framework.UI.BunifuThinButton2 Login_admin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuDragControl moveformlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}