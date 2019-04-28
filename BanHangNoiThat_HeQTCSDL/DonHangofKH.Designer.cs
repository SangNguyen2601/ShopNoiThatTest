namespace BanHangNoiThat_HeQTCSDL
{
    partial class DonHangofKH
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
            this.dgvDS_DHB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_DHB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDS_DHB
            // 
            this.dgvDS_DHB.AllowUserToAddRows = false;
            this.dgvDS_DHB.AllowUserToDeleteRows = false;
            this.dgvDS_DHB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS_DHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS_DHB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS_DHB.Location = new System.Drawing.Point(0, 0);
            this.dgvDS_DHB.Name = "dgvDS_DHB";
            this.dgvDS_DHB.ReadOnly = true;
            this.dgvDS_DHB.Size = new System.Drawing.Size(679, 216);
            this.dgvDS_DHB.TabIndex = 0;
            // 
            // DonHangofKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 216);
            this.Controls.Add(this.dgvDS_DHB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonHangofKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng của tôi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_DHB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDS_DHB;
    }
}