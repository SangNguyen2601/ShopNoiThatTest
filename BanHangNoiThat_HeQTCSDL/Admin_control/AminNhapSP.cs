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

namespace BanHangNoiThat_HeQTCSDL.Admin_control
{
    public partial class AminNhapSP : UserControl
    {

        BS_AdminQLDHN bs = new BS_AdminQLDHN();
        DataTable db = new DataTable();

        int count = 0; //biến đếm nhập hàng

        public AminNhapSP()
        {
            InitializeComponent();

            //đổ dữ liệu loại sản phẩm vào combobox
            db = bs.LayDSLoaiSP();
            cbbLoaiSP.DataSource = db;
            cbbLoaiSP.DisplayMember = "TenLoai";
            cbbLoaiSP.ValueMember = "MaLoai";
            cbbLoaiSP.SelectedIndex = -1;

            LoadData();
        }

        void LoadData()
        {
            txtMaDHN.ResetText();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtXuatXu.ResetText();
            txtKichCo.ResetText();
            txtSoLuong.ResetText();
            txtGiaVon.ResetText();
            txtGiaBan.ResetText();
            cbbLoaiSP.SelectedIndex = -1;

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtXuatXu.Enabled = false;
            txtKichCo.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaVon.Enabled = false;
            txtGiaBan.Enabled = false;
            cbbLoaiSP.Enabled = false;

            txtMaDHN.Enabled = true;
            btnXacNhan.Enabled = true;
            btnThem.Enabled = false;
            btnHoanThanh.Enabled = false;

            LoadDS_DHN();
        }

        void LoadDS_DHN()
        {
            db = bs.LayDS_DHN();
            dgvDSDHN.DataSource = db;
        }

        //load lại form cho việc nhập sản phẩm tiếp theo
        void LoadNhapHang()
        {
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtXuatXu.ResetText();
            txtKichCo.ResetText();
            txtSoLuong.ResetText();
            txtGiaVon.ResetText();
            txtGiaBan.ResetText();
            cbbLoaiSP.SelectedIndex = -1;

            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtXuatXu.Enabled = true;
            txtKichCo.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaVon.Enabled = true;
            txtGiaBan.Enabled = true;
            cbbLoaiSP.Enabled = true;
        }

        //xác nhận tạo đơn hàng mới
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string madhn = txtMaDHN.Text.ToString().Trim();

            DateTime ngaynhap = new DateTime();
            ngaynhap = DateTime.Now;

            bs.TaoDHN(madhn,ngaynhap);

            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtXuatXu.Enabled = true;
            txtKichCo.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaVon.Enabled = true;
            txtGiaBan.Enabled = true;
            cbbLoaiSP.Enabled = true;
            btnThem.Enabled = true;
            btnHoanThanh.Enabled = true;

            btnXacNhan.Enabled = false;
            txtMaDHN.Enabled = false;
            txtMaSP.Focus();
        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.ToString().Trim();

            if(bs.KTSanPhamTonTai(masp) == 1)
            {
                db = bs.LayTTSP(masp);

                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                txtXuatXu.Enabled = false;
                txtKichCo.Enabled = false;
                txtGiaVon.Enabled = false;
                txtGiaBan.Enabled = false;
                cbbLoaiSP.Enabled = false;

                txtTenSP.Text = db.Rows[0][1].ToString().Trim();
                cbbLoaiSP.SelectedValue = db.Rows[0][2].ToString().Trim();
                txtXuatXu.Text = db.Rows[0][3].ToString().Trim();
                txtKichCo.Text = db.Rows[0][4].ToString().Trim();
                txtGiaVon.Text = db.Rows[0][5].ToString().Trim();
                txtGiaBan.Text = db.Rows[0][6].ToString().Trim();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.ToString().Trim() != "")
            {
                string masp = txtMaSP.Text.ToString().Trim();

                //kiểm tra sp đã tồn tại trong kho hay chưa
                if (bs.KTSanPhamTonTai(masp) == 1)
                {
                    bs.ThemvaoHHN(masp, txtMaDHN.Text.ToString().Trim(), Convert.ToInt16(txtSoLuong.Text.ToString().Trim()));
                    LoadNhapHang();
                    LoadDS_DHN();
                    count++;
                }
                else
                {
                    //nếu sp chưa tồn tại, thêm sp mới
                    string tensp = txtTenSP.Text.ToString().Trim();
                    string maloai = cbbLoaiSP.SelectedValue.ToString().Trim();
                    string xuatxu = txtXuatXu.Text.ToString().Trim();
                    string kichco = txtKichCo.Text.ToString().Trim();
                    int giavon = Convert.ToInt32(txtGiaVon.Text.ToString().Trim());
                    int giaban = Convert.ToInt32(txtGiaBan.Text.ToString().Trim());
                    int soluong = Convert.ToInt32(txtSoLuong.Text.ToString().Trim());
                    bs.ThemSPMoi(masp, tensp, maloai, xuatxu, kichco, giavon, giaban, "", soluong);

                    //thêm vào Hàng hoá nhập
                    bs.ThemvaoHHN(masp, txtMaDHN.Text.ToString().Trim(), Convert.ToInt16(txtSoLuong.Text.ToString().Trim()));

                    LoadNhapHang();
                    LoadDS_DHN();
                    count++;
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập hàng hoá");
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                bs.Tinh_Tongtien(txtMaDHN.Text.ToString().Trim());

                LoadData();
            }
            else
                return;
        }
    }
}
