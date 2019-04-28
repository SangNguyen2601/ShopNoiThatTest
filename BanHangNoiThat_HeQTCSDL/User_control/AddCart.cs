using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHangNoiThat_HeQTCSDL.BS_Main;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace BanHangNoiThat_HeQTCSDL.Forms.UsersControl
{
    public partial class AddCart : UserControl
    {
        BS_UserAddCart bs = new BS_UserAddCart();
        DataTable db = new DataTable();
        int r;

        public AddCart()
        {
            InitializeComponent();

            load();
        }

        private void AddCart_Load(object sender, EventArgs e)
        {
        }
        public void load()
        {
            txtTongTien.ResetText();
            Txtname.Enabled = false;
            txtDiachi.Enabled = false;
            txtSdt.Enabled = false;
            txtemal.Enabled = false;

            if (GiaoDienUser.User_Login_ID != null)
            {
                db = bs.LayTTKH(GiaoDienUser.User_Login_ID);
                Txtname.Text = db.Rows[0][0].ToString().Trim();
                txtDiachi.Text = db.Rows[0][3].ToString().Trim();
                txtSdt.Text = db.Rows[0][1].ToString().Trim();
                txtemal.Text = db.Rows[0][2].ToString().Trim();

                db = bs.LayGioHang(GiaoDienUser.User_Login_ID);
                dgvSanpham.DataSource = db;
                for (int i = 0; i < dgvSanpham.Rows.Count; i++)
                {
                    string imgPath = "..\\image\\" + dgvSanpham.Rows[i].Cells[6].Value.ToString().Trim() + "\\" + dgvSanpham.Rows[i].Cells[2].Value.ToString().Trim();
                    dgvSanpham.Rows[i].Cells[0].Value = Image.FromFile(imgPath);

                    //SoLuong.ValueMember = dgvSanpham.Rows[i].Cells[4].Value.ToString().Trim();
                }

                float thanhtien = 0;
                for (int i = 0; i < dgvSanpham.Rows.Count; i++)
                    thanhtien += float.Parse(dgvSanpham.Rows[i].Cells[5].Value.ToString());

                txtTongTien.Text = thanhtien.ToString();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Txtname.Enabled = true;
            txtDiachi.Enabled = true;
            txtSdt.Enabled = true;
            txtemal.Enabled = true;
        }
        private void dathang_Click(object sender, EventArgs e)
        {
            DateTime ngaymua = new DateTime();
            ngaymua = DateTime.Now;
            int thanhtien = Convert.ToInt32(txtTongTien.Text.ToString().Trim()) + 20000;

            bs.themdonhangban(GiaoDienUser.User_Login_ID, ngaymua, thanhtien);

            MessageBox.Show("Đặt hàng thành công!");

            bs.XoaGioHang(GiaoDienUser.User_Login_ID);

            this.SendToBack();
        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            Txtname.Enabled = false;
            txtDiachi.Enabled = false;
            txtSdt.Enabled = false;
            txtemal.Enabled = false;

            string name = Txtname.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string mail = txtemal.Text.ToString().Trim();
            int sdt = Convert.ToInt32(txtSdt.Text.ToString().Trim());

            bs.Capnhat_TTThanhToan(GiaoDienUser.User_Login_ID, name, diachi, mail, sdt);

            load();
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvSanpham.CurrentCell.RowIndex;

            /*string masp = dgvSanpham.Rows[r].Cells[0].Value.ToString().Trim();
            int soluong = Convert.ToInt16(dgvSanpham.Rows[r].Cells[3].Value.ToString().Trim());

            bs.capnhat_SoLuong(soluong, masp, GiaoDienUser.User_Login_ID);

            load();*/
        }

        private void dgvSanpham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
