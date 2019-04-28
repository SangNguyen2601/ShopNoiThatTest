namespace BanHangNoiThat_HeQTCSDL.Forms
{
    partial class Detailproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailproduct));
            this.label1 = new System.Windows.Forms.Label();
            this.giasp = new System.Windows.Forms.Label();
            this.tensp = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TXTtensp = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtkichco = new System.Windows.Forms.Label();
            this.txtMausac = new System.Windows.Forms.Label();
            this.txtXuatxu = new System.Windows.Forms.Label();
            this.numUpDown_SoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SoLuongMua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(305, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số lượng còn lại:";
            // 
            // giasp
            // 
            this.giasp.AutoSize = true;
            this.giasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.giasp.Location = new System.Drawing.Point(307, 107);
            this.giasp.Name = "giasp";
            this.giasp.Size = new System.Drawing.Size(112, 20);
            this.giasp.TabIndex = 18;
            this.giasp.Text = "Giá sản phẩm:";
            // 
            // tensp
            // 
            this.tensp.AutoSize = true;
            this.tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tensp.Location = new System.Drawing.Point(305, 62);
            this.tensp.Name = "tensp";
            this.tensp.Size = new System.Drawing.Size(114, 20);
            this.tensp.TabIndex = 17;
            this.tensp.Text = "Tên sản phẩm:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TXTtensp
            // 
            this.TXTtensp.AutoSize = true;
            this.TXTtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTtensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTtensp.Location = new System.Drawing.Point(425, 62);
            this.TXTtensp.Name = "TXTtensp";
            this.TXTtensp.Size = new System.Drawing.Size(0, 20);
            this.TXTtensp.TabIndex = 24;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bunifuImageButton2.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Shutdown_48px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(708, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 25;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.ActiveBorderThickness = 1;
            this.btnAddCart.ActiveCornerRadius = 20;
            this.btnAddCart.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(97)))), ((int)(((byte)(30)))));
            this.btnAddCart.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCart.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(97)))), ((int)(((byte)(30)))));
            this.btnAddCart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCart.BackgroundImage")));
            this.btnAddCart.ButtonText = "Mua ngay";
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddCart.IdleBorderThickness = 1;
            this.btnAddCart.IdleCornerRadius = 20;
            this.btnAddCart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.btnAddCart.IdleForecolor = System.Drawing.Color.White;
            this.btnAddCart.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.btnAddCart.Location = new System.Drawing.Point(558, 337);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(168, 51);
            this.btnAddCart.TabIndex = 16;
            this.btnAddCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Image = ((System.Drawing.Image)(resources.GetObject("pictureProduct.Image")));
            this.pictureProduct.Location = new System.Drawing.Point(12, 56);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(277, 275);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 15;
            this.pictureProduct.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(744, 37);
            this.header.TabIndex = 26;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kích cỡ:";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.AutoSize = true;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(431, 62);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(170, 20);
            this.txtNameProduct.TabIndex = 28;
            this.txtNameProduct.Text = "Tên sản phẩm ở đây";
            // 
            // txtGia
            // 
            this.txtGia.AutoSize = true;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(451, 107);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(72, 20);
            this.txtGia.TabIndex = 29;
            this.txtGia.Text = "Giá bán";
            // 
            // txtSoluong
            // 
            this.txtSoluong.AutoSize = true;
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(452, 137);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(64, 17);
            this.txtSoluong.TabIndex = 30;
            this.txtSoluong.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Màu sắc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Xuất xứ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mô tả:";
            // 
            // txtMota
            // 
            this.txtMota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMota.Location = new System.Drawing.Point(378, 255);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(348, 74);
            this.txtMota.TabIndex = 34;
            // 
            // txtkichco
            // 
            this.txtkichco.AutoSize = true;
            this.txtkichco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkichco.Location = new System.Drawing.Point(364, 184);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(74, 15);
            this.txtkichco.TabIndex = 35;
            this.txtkichco.Text = "kichco ở đây";
            // 
            // txtMausac
            // 
            this.txtMausac.AutoSize = true;
            this.txtMausac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMausac.Location = new System.Drawing.Point(545, 184);
            this.txtMausac.Name = "txtMausac";
            this.txtMausac.Size = new System.Drawing.Size(83, 15);
            this.txtMausac.TabIndex = 36;
            this.txtMausac.Text = "Mausac ở đây";
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.AutoSize = true;
            this.txtXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatxu.Location = new System.Drawing.Point(365, 222);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(75, 15);
            this.txtXuatxu.TabIndex = 37;
            this.txtXuatxu.Text = "xuatxu ở đây";
            // 
            // numUpDown_SoLuongMua
            // 
            this.numUpDown_SoLuongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_SoLuongMua.Location = new System.Drawing.Point(432, 348);
            this.numUpDown_SoLuongMua.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDown_SoLuongMua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_SoLuongMua.Name = "numUpDown_SoLuongMua";
            this.numUpDown_SoLuongMua.Size = new System.Drawing.Size(91, 29);
            this.numUpDown_SoLuongMua.TabIndex = 38;
            this.numUpDown_SoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số lượng mua:";
            // 
            // Detailproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUpDown_SoLuongMua);
            this.Controls.Add(this.txtXuatxu);
            this.Controls.Add(this.txtMausac);
            this.Controls.Add(this.txtkichco);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.TXTtensp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giasp);
            this.Controls.Add(this.tensp);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.pictureProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detailproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailproduct";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SoLuongMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label giasp;
        private System.Windows.Forms.Label tensp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCart;
        private System.Windows.Forms.PictureBox pictureProduct;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label TXTtensp;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label txtXuatxu;
        private System.Windows.Forms.Label txtMausac;
        private System.Windows.Forms.Label txtkichco;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSoluong;
        private System.Windows.Forms.Label txtGia;
        private System.Windows.Forms.Label txtNameProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDown_SoLuongMua;
    }
}