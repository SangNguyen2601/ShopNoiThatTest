namespace BanHangNoiThat_HeQTCSDL
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.Lablename = new System.Windows.Forms.Label();
            this.CheckMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Confirmpassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passwordSignIn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameSignIn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.checkFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bornYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.moveFormSignIn = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unshowpassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.showpassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bornYear)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unshowpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(385, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sign In";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.Lablename);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(266, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(338, 43);
            this.header.TabIndex = 16;
            // 
            // Lablename
            // 
            this.Lablename.AutoSize = true;
            this.Lablename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lablename.ForeColor = System.Drawing.Color.White;
            this.Lablename.Location = new System.Drawing.Point(77, 8);
            this.Lablename.Name = "Lablename";
            this.Lablename.Size = new System.Drawing.Size(197, 29);
            this.Lablename.TabIndex = 3;
            this.Lablename.Text = "SH FURNITURE ";
            this.Lablename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckMale
            // 
            this.CheckMale.AutoSize = true;
            this.CheckMale.Location = new System.Drawing.Point(6, 15);
            this.CheckMale.Name = "CheckMale";
            this.CheckMale.Size = new System.Drawing.Size(47, 17);
            this.CheckMale.TabIndex = 0;
            this.CheckMale.TabStop = true;
            this.CheckMale.Text = "Nam";
            this.CheckMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(273, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Anh Sang Furniture - Enhance the value of your home";
            // 
            // txtemail
            // 
            this.txtemail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtemail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtemail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtemail.BorderThickness = 3;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.isPassword = false;
            this.txtemail.Location = new System.Drawing.Point(266, 351);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(338, 40);
            this.txtemail.TabIndex = 21;
            this.txtemail.Text = "Email";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // Confirmpassword
            // 
            this.Confirmpassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Confirmpassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Confirmpassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Confirmpassword.BorderThickness = 3;
            this.Confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Confirmpassword.ForeColor = System.Drawing.Color.DimGray;
            this.Confirmpassword.isPassword = false;
            this.Confirmpassword.Location = new System.Drawing.Point(266, 301);
            this.Confirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmpassword.Name = "Confirmpassword";
            this.Confirmpassword.Size = new System.Drawing.Size(338, 40);
            this.Confirmpassword.TabIndex = 20;
            this.Confirmpassword.Text = "Confirm Password";
            this.Confirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Confirmpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Confirmpassword_KeyPress);
            // 
            // passwordSignIn
            // 
            this.passwordSignIn.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.passwordSignIn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.passwordSignIn.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.passwordSignIn.BorderThickness = 3;
            this.passwordSignIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.passwordSignIn.isPassword = false;
            this.passwordSignIn.Location = new System.Drawing.Point(266, 249);
            this.passwordSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.passwordSignIn.Name = "passwordSignIn";
            this.passwordSignIn.Size = new System.Drawing.Size(338, 40);
            this.passwordSignIn.TabIndex = 19;
            this.passwordSignIn.Text = "Password";
            this.passwordSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordSignIn_KeyPress);
            // 
            // usernameSignIn
            // 
            this.usernameSignIn.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.usernameSignIn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.usernameSignIn.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.usernameSignIn.BorderThickness = 3;
            this.usernameSignIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usernameSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.usernameSignIn.isPassword = false;
            this.usernameSignIn.Location = new System.Drawing.Point(266, 198);
            this.usernameSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.usernameSignIn.Name = "usernameSignIn";
            this.usernameSignIn.Size = new System.Drawing.Size(338, 40);
            this.usernameSignIn.TabIndex = 18;
            this.usernameSignIn.Text = "User name";
            this.usernameSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameSignIn_KeyPress);
            this.usernameSignIn.Leave += new System.EventHandler(this.usernameSignIn_Leave);
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(74, 15);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(39, 17);
            this.checkFemale.TabIndex = 1;
            this.checkFemale.TabStop = true;
            this.checkFemale.Text = "Nữ";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bornYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkFemale);
            this.groupBox1.Controls.Add(this.CheckMale);
            this.groupBox1.Location = new System.Drawing.Point(269, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 46);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // bornYear
            // 
            this.bornYear.Location = new System.Drawing.Point(213, 15);
            this.bornYear.Maximum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.bornYear.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.bornYear.Name = "bornYear";
            this.bornYear.Size = new System.Drawing.Size(83, 20);
            this.bornYear.TabIndex = 3;
            this.bornYear.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm sinh:";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFullName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFullName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtFullName.BorderThickness = 3;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFullName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFullName.isPassword = false;
            this.txtFullName.Location = new System.Drawing.Point(266, 100);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(338, 40);
            this.txtFullName.TabIndex = 17;
            this.txtFullName.Text = "Full name";
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // moveFormSignIn
            // 
            this.moveFormSignIn.Fixed = true;
            this.moveFormSignIn.Horizontal = true;
            this.moveFormSignIn.TargetControl = this.header;
            this.moveFormSignIn.Vertical = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-8, -18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.gnome_session_hibernate;
            this.btnexit.Location = new System.Drawing.Point(569, 46);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(31, 36);
            this.btnexit.TabIndex = 25;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.White;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConfirm.IdleForecolor = System.Drawing.Color.White;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConfirm.Location = new System.Drawing.Point(266, 414);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(338, 51);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.panel1.BackgroundImage = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.nha_cap_4_gac_lung_dep_NDNC413;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 500);
            this.panel1.TabIndex = 15;
            // 
            // unshowpassword
            // 
            this.unshowpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unshowpassword.BackColor = System.Drawing.SystemColors.Control;
            this.unshowpassword.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Invisible_64px;
            this.unshowpassword.ImageActive = null;
            this.unshowpassword.Location = new System.Drawing.Point(569, 256);
            this.unshowpassword.Name = "unshowpassword";
            this.unshowpassword.Size = new System.Drawing.Size(27, 27);
            this.unshowpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unshowpassword.TabIndex = 38;
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
            this.showpassword.Location = new System.Drawing.Point(569, 256);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(27, 27);
            this.showpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showpassword.TabIndex = 37;
            this.showpassword.TabStop = false;
            this.showpassword.Visible = false;
            this.showpassword.Zoom = 10;
            this.showpassword.Click += new System.EventHandler(this.showpassword_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 500);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.unshowpassword);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.Confirmpassword);
            this.Controls.Add(this.passwordSignIn);
            this.Controls.Add(this.usernameSignIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bornYear)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unshowpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label Lablename;
        private System.Windows.Forms.RadioButton CheckMale;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtemail;
        private Bunifu.Framework.UI.BunifuMetroTextbox Confirmpassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordSignIn;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameSignIn;
        private System.Windows.Forms.RadioButton checkFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown bornYear;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFullName;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl moveFormSignIn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton unshowpassword;
        private Bunifu.Framework.UI.BunifuImageButton showpassword;
    }
}