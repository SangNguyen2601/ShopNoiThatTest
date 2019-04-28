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
using System.IO;
using System.Drawing.Imaging;

namespace BanHangNoiThat_HeQTCSDL.Forms.Amincontrol
{
    public partial class AminQLSP : UserControl
    {
        BS_AdminQLSP bs = new BS_AdminQLSP();
        DataTable db = new DataTable();

        string imagepath;

        public AminQLSP()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            //reset
            txtTenSP.Enabled = false;
            txtKichCo.Enabled = false;
            txtXuatXu.Enabled = false;
            txtMauSac.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaVon.Enabled = false;
            txtGiaBan.Enabled = false;
            txtMota.Enabled = false;
            cbbLoaiSPedit.Enabled = false;
            uploadPic.Enabled = false;
            LuuBt.Enabled = false;
            XoaBT.Enabled = false;
            SuaBT.Enabled = false;

            txtTenSP.ResetText();
            txtKichCo.ResetText();
            txtXuatXu.ResetText();
            txtMauSac.ResetText();
            txtSoLuong.ResetText();
            txtGiaVon.ResetText();
            txtGiaBan.ResetText();
            txtMota.ResetText();
            txtMaSP.ResetText();
            cbbLoaiSPedit.SelectedIndex = -1;

            PicBoxSP.Image = null;

            //load loại sản phẩm vào combobox
            db = new DataTable();
            db = bs.LayDSLoaiSP();
            cbbFindMaSP.DataSource = db;
            cbbFindMaSP.DisplayMember = "TenLoai";
            cbbFindMaSP.ValueMember = "MaLoai";
            cbbFindMaSP.SelectedIndex = 0;

            db = bs.LayDSSP(cbbFindMaSP.SelectedValue.ToString());
            dgvDSSP.DataSource = db;
        }

        void kiemTraKTSo(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar < 122) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8)) ||
        char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
        char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
        char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
            }
        }

        private void cbbFindMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DataTable();
            db = bs.LayDSLoaiSP();
            db = bs.LayDSSP(cbbFindMaSP.SelectedValue.ToString());
            dgvDSSP.DataSource = db;
        }

        private void ReloadBt_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //sự kiện click vào dòng trong datagridview
        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PicBoxSP.Image = null;
            XoaBT.Enabled = true;
            SuaBT.Enabled = true;

            int r = dgvDSSP.CurrentCell.RowIndex;
            txtTenSP.Text = dgvDSSP.Rows[r].Cells[2].Value.ToString().Trim();
            txtKichCo.Text = dgvDSSP.Rows[r].Cells[3].Value.ToString().Trim();
            txtXuatXu.Text = dgvDSSP.Rows[r].Cells[5].Value.ToString().Trim();
            txtMauSac.Text = dgvDSSP.Rows[r].Cells[4].Value.ToString().Trim();
            txtSoLuong.Text = dgvDSSP.Rows[r].Cells[7].Value.ToString().Trim();
            txtGiaVon.Text = dgvDSSP.Rows[r].Cells[8].Value.ToString().Trim();
            txtGiaBan.Text = dgvDSSP.Rows[r].Cells[9].Value.ToString().Trim();
            txtMaSP.Text = dgvDSSP.Rows[r].Cells[0].Value.ToString().Trim();
            txtMota.Text = dgvDSSP.Rows[r].Cells[6].Value.ToString().Trim();

            db = new DataTable();
            db = bs.LayDSLoaiSP();
            cbbLoaiSPedit.DataSource = db;
            cbbLoaiSPedit.DisplayMember = "TenLoai";
            cbbLoaiSPedit.ValueMember = "MaLoai";
            cbbLoaiSPedit.SelectedValue = dgvDSSP.Rows[r].Cells[1].Value.ToString().Trim();

            if (bs.LoadPicture(dgvDSSP.Rows[r].Cells[0].Value.ToString().Trim()) != "")
            {
                string imgPath = "..\\image\\" + dgvDSSP.Rows[r].Cells[1].Value.ToString().Trim() + "\\" + bs.LoadPicture(dgvDSSP.Rows[r].Cells[0].Value.ToString().Trim());
                PicBoxSP.Image = Image.FromFile(imgPath);
            }
        }

        private void XoaBT_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có chắc xoá hàng hoá này ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (tl == DialogResult.Yes)
            {
                bs.XoaSP(txtMaSP.Text.ToString().Trim());
                LoadData();
                MessageBox.Show("Đã xoá !");
            }
        }

        private void SuaBT_Click(object sender, EventArgs e)
        {
            txtTenSP.Enabled = true;
            txtKichCo.Enabled = true;
            txtXuatXu.Enabled = true;
            txtMauSac.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaVon.Enabled = true;
            txtGiaBan.Enabled = true;
            txtMota.Enabled = true;
            cbbLoaiSPedit.Enabled = true;
            uploadPic.Enabled = true;
            LuuBt.Enabled = true;
            SuaBT.Enabled = false;
        }

        private void LuuBt_Click(object sender, EventArgs e)
        {
            string tensp = txtTenSP.Text.ToString().Trim();
            string kichco = txtKichCo.Text.ToString().Trim();
            string xuatxu = txtXuatXu.Text.ToString().Trim();
            string mausac = txtMauSac.Text.ToString().Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text.ToString().Trim());
            int giavon = Convert.ToInt32(txtGiaVon.Text.ToString().Trim());
            int giaban = Convert.ToInt32(txtGiaBan.Text.ToString().Trim());
            string masp = txtMaSP.Text.ToString().Trim();
            string mota = txtMota.Text.ToString().Trim();
            string maloai = cbbLoaiSPedit.SelectedValue.ToString().Trim();

            bs.EditSP(masp, maloai, tensp, kichco, mausac, xuatxu, mota, soluong, giavon, giaban);

            if (imagepath != null)
            {
                string piclocation = imagepath;

                bs.UploadPicture(masp, piclocation);

                PicBoxSP.Image.Save("..\\image\\" + cbbLoaiSPedit.SelectedValue.ToString().Trim() + "\\" + imagepath, ImageFormat.Jpeg);
            }

            LoadData();
            MessageBox.Show("Sửa thành công !");

            imagepath = null;
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            opFilePic.FileName = "";
            opFilePic.Title = "Images";
            opFilePic.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            opFilePic.RestoreDirectory = true;
            if (opFilePic.ShowDialog() == DialogResult.OK)
            {
                Image myImage = Image.FromFile(opFilePic.FileName);
                PicBoxSP.Image = myImage;

                imagepath = opFilePic.FileName.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                imagepath = imagepath.Remove(0, 1);
            }
        }


    }
}
