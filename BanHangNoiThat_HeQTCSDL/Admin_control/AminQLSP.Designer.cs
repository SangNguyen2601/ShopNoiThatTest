namespace BanHangNoiThat_HeQTCSDL.Forms.Amincontrol
{
    partial class AminQLSP
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
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.ReloadBt = new System.Windows.Forms.Button();
            this.SuaBT = new System.Windows.Forms.Button();
            this.XoaBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbLoaiSPedit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaVon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadPic = new System.Windows.Forms.Button();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKichCo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.PicBoxSP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbFindMaSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LuuBt = new System.Windows.Forms.Button();
            this.opFilePic = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AllowUserToAddRows = false;
            this.dgvDSSP.AllowUserToDeleteRows = false;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(5, 300);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.ReadOnly = true;
            this.dgvDSSP.Size = new System.Drawing.Size(658, 187);
            this.dgvDSSP.TabIndex = 0;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // ReloadBt
            // 
            this.ReloadBt.Location = new System.Drawing.Point(690, 456);
            this.ReloadBt.Name = "ReloadBt";
            this.ReloadBt.Size = new System.Drawing.Size(90, 31);
            this.ReloadBt.TabIndex = 1;
            this.ReloadBt.Text = "Tải lại";
            this.ReloadBt.UseVisualStyleBackColor = true;
            this.ReloadBt.Click += new System.EventHandler(this.ReloadBt_Click);
            // 
            // SuaBT
            // 
            this.SuaBT.Location = new System.Drawing.Point(690, 357);
            this.SuaBT.Name = "SuaBT";
            this.SuaBT.Size = new System.Drawing.Size(90, 31);
            this.SuaBT.TabIndex = 1;
            this.SuaBT.Text = "Sửa";
            this.SuaBT.UseVisualStyleBackColor = true;
            this.SuaBT.Click += new System.EventHandler(this.SuaBT_Click);
            // 
            // XoaBT
            // 
            this.XoaBT.Location = new System.Drawing.Point(690, 299);
            this.XoaBT.Name = "XoaBT";
            this.XoaBT.Size = new System.Drawing.Size(90, 31);
            this.XoaBT.TabIndex = 1;
            this.XoaBT.Text = "Xoá";
            this.XoaBT.UseVisualStyleBackColor = true;
            this.XoaBT.Click += new System.EventHandler(this.XoaBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbbLoaiSPedit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaVon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtXuatXu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.uploadPic);
            this.groupBox1.Controls.Add(this.txtMauSac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKichCo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.PicBoxSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(79, 175);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(481, 50);
            this.txtMota.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mô tả:";
            // 
            // cbbLoaiSPedit
            // 
            this.cbbLoaiSPedit.FormattingEnabled = true;
            this.cbbLoaiSPedit.Location = new System.Drawing.Point(327, 30);
            this.cbbLoaiSPedit.Name = "cbbLoaiSPedit";
            this.cbbLoaiSPedit.Size = new System.Drawing.Size(123, 21);
            this.cbbLoaiSPedit.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã Loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(456, 135);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(104, 20);
            this.txtGiaBan.TabIndex = 16;
            // 
            // txtGiaVon
            // 
            this.txtGiaVon.Location = new System.Drawing.Point(255, 136);
            this.txtGiaVon.Name = "txtGiaVon";
            this.txtGiaVon.Size = new System.Drawing.Size(108, 20);
            this.txtGiaVon.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá vốn:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(79, 135);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(81, 20);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(456, 98);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(104, 20);
            this.txtXuatXu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Xuất xứ:";
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(641, 202);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(79, 23);
            this.uploadPic.TabIndex = 9;
            this.uploadPic.Text = "Tải ảnh lên";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(79, 98);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(122, 20);
            this.txtMauSac.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Màu sắc:";
            // 
            // txtKichCo
            // 
            this.txtKichCo.Location = new System.Drawing.Point(279, 98);
            this.txtKichCo.Name = "txtKichCo";
            this.txtKichCo.Size = new System.Drawing.Size(103, 20);
            this.txtKichCo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kích cỡ:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(104, 63);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 20);
            this.txtTenSP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(79, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(122, 20);
            this.txtMaSP.TabIndex = 2;
            // 
            // PicBoxSP
            // 
            this.PicBoxSP.Location = new System.Drawing.Point(591, 27);
            this.PicBoxSP.Name = "PicBoxSP";
            this.PicBoxSP.Size = new System.Drawing.Size(179, 169);
            this.PicBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxSP.TabIndex = 1;
            this.PicBoxSP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbFindMaSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbbFindMaSP
            // 
            this.cbbFindMaSP.FormattingEnabled = true;
            this.cbbFindMaSP.Location = new System.Drawing.Point(138, 19);
            this.cbbFindMaSP.Name = "cbbFindMaSP";
            this.cbbFindMaSP.Size = new System.Drawing.Size(121, 21);
            this.cbbFindMaSP.TabIndex = 1;
            this.cbbFindMaSP.SelectionChangeCommitted += new System.EventHandler(this.cbbFindMaSP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // LuuBt
            // 
            this.LuuBt.Location = new System.Drawing.Point(690, 394);
            this.LuuBt.Name = "LuuBt";
            this.LuuBt.Size = new System.Drawing.Size(90, 31);
            this.LuuBt.TabIndex = 4;
            this.LuuBt.Text = "Lưu";
            this.LuuBt.UseVisualStyleBackColor = true;
            this.LuuBt.Click += new System.EventHandler(this.LuuBt_Click);
            // 
            // opFilePic
            // 
            this.opFilePic.FileName = "openFileDialog1";
            // 
            // AminQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.LuuBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XoaBT);
            this.Controls.Add(this.SuaBT);
            this.Controls.Add(this.ReloadBt);
            this.Controls.Add(this.dgvDSSP);
            this.Name = "AminQLSP";
            this.Size = new System.Drawing.Size(810, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Button ReloadBt;
        private System.Windows.Forms.Button SuaBT;
        private System.Windows.Forms.Button XoaBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKichCo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.PictureBox PicBoxSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaVon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbFindMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LuuBt;
        private System.Windows.Forms.ComboBox cbbLoaiSPedit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog opFilePic;
    }
}
