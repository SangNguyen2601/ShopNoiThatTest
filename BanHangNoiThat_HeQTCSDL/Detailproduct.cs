using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

using BanHangNoiThat_HeQTCSDL.BS_Main;

namespace BanHangNoiThat_HeQTCSDL.Forms
{
    public partial class Detailproduct : Form
    {
        DataTable db = new DataTable();
        BS_DetailProduct bs = new BS_DetailProduct();

        private string TenSP;
        public Detailproduct()
        {
            InitializeComponent();
        }
        public Detailproduct(string tensp)
        {
            //MessageBox.Show(tensp);
            this.TenSP = tensp;
            InitializeComponent();

            db = bs.Lay_CTSP(TenSP);

            txtNameProduct.Text = db.Rows[0][1].ToString().Trim();
            txtGia.Text = db.Rows[0][8].ToString().Trim();
            txtSoluong.Text = db.Rows[0][7].ToString().Trim();
            txtMausac.Text = db.Rows[0][4].ToString().Trim();
            txtkichco.Text = db.Rows[0][3].ToString().Trim();
            txtXuatxu.Text = db.Rows[0][5].ToString().Trim();
            txtMota.Text = db.Rows[0][6].ToString().Trim();

            if (bs.LoadPicture(db.Rows[0][0].ToString().Trim()) != "")
            {
                string imgPath = "..\\image\\" + db.Rows[0][9].ToString().Trim() + "\\" + bs.LoadPicture(db.Rows[0][0].ToString().Trim());
                pictureProduct.Image = Image.FromFile(imgPath);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt16(numUpDown_SoLuongMua.Value);
            bs.ThemvaoGioHang(TenSP, GiaoDienUser.User_Login_ID, soluong);
            MessageBox.Show("Thêm giỏ hàng thành công!");
            this.Close();
        }
    }
}
