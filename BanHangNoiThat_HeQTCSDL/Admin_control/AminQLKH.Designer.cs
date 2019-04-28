namespace BanHangNoiThat_HeQTCSDL.Forms.Amincontrol
{
    partial class AminQLKH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGioitinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDSDHofKH = new System.Windows.Forms.DataGridView();
            this.txtTel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBornYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDHofKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSKH);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.AllowUserToAddRows = false;
            this.dgvDSKH.AllowUserToDeleteRows = false;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Location = new System.Drawing.Point(6, 19);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.ReadOnly = true;
            this.dgvDSKH.Size = new System.Drawing.Size(370, 459);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGioitinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvDSDHofKH);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBornYear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.picAvatar);
            this.groupBox2.Location = new System.Drawing.Point(391, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.AutoSize = true;
            this.txtGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioitinh.Location = new System.Drawing.Point(133, 101);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(62, 18);
            this.txtGioitinh.TabIndex = 14;
            this.txtGioitinh.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giới tính:";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(29, 274);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(90, 17);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "Địa chỉ ở đây";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Danh sách đơn hàng đã đặt";
            // 
            // dgvDSDHofKH
            // 
            this.dgvDSDHofKH.AllowUserToAddRows = false;
            this.dgvDSDHofKH.AllowUserToDeleteRows = false;
            this.dgvDSDHofKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDHofKH.Location = new System.Drawing.Point(9, 364);
            this.dgvDSDHofKH.Name = "dgvDSDHofKH";
            this.dgvDSDHofKH.ReadOnly = true;
            this.dgvDSDHofKH.Size = new System.Drawing.Size(374, 114);
            this.dgvDSDHofKH.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.AutoSize = true;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(29, 160);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(134, 18);
            this.txtTel.TabIndex = 8;
            this.txtTel.Text = "Số điện thoại ở đây";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số điện thoại:";
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(29, 213);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(85, 18);
            this.txtMail.TabIndex = 6;
            this.txtMail.Text = "Email ở đây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // txtBornYear
            // 
            this.txtBornYear.AutoSize = true;
            this.txtBornYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBornYear.Location = new System.Drawing.Point(29, 101);
            this.txtBornYear.Name = "txtBornYear";
            this.txtBornYear.Size = new System.Drawing.Size(71, 18);
            this.txtBornYear.TabIndex = 4;
            this.txtBornYear.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm sinh:";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(29, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(104, 18);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "Họ tên ở đây";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(220, 26);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(163, 180);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // AminQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AminQLKH";
            this.Size = new System.Drawing.Size(783, 490);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDHofKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDSDHofKH;
        private System.Windows.Forms.Label txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtBornYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtGioitinh;
        private System.Windows.Forms.Label label2;
    }
}
