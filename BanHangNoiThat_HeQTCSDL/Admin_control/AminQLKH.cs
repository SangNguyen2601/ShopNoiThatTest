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

namespace BanHangNoiThat_HeQTCSDL.Forms.Amincontrol
{
    public partial class AminQLKH : UserControl
    {

        BS_AdminQLKH bs = new BS_AdminQLKH();
        DataTable db = new DataTable();

        public AminQLKH()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            txtFullName.ResetText();
            txtBornYear.ResetText();
            txtGioitinh.ResetText();
            txtMail.ResetText();
            txtTel.ResetText();
            txtAddress.ResetText();

            db = bs.LayDSKH();
            dgvDSKH.DataSource = db;
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            picAvatar.Image = null;
            //lấy chỉ số dòng hiện tại
            int r = dgvDSKH.CurrentCell.RowIndex;
            //đưa ra màn hình
            txtFullName.Text = dgvDSKH.Rows[r].Cells[1].Value.ToString().Trim();
            txtBornYear.Text = dgvDSKH.Rows[r].Cells[5].Value.ToString().Trim();
            txtGioitinh.Text = dgvDSKH.Rows[r].Cells[6].Value.ToString().Trim();
            txtMail.Text = dgvDSKH.Rows[r].Cells[2].Value.ToString().Trim();
            txtTel.Text = dgvDSKH.Rows[r].Cells[3].Value.ToString().Trim();
            txtAddress.Text = dgvDSKH.Rows[r].Cells[4].Value.ToString().Trim();

            //load hình ảnh
            if (bs.LoadPicture(dgvDSKH.Rows[r].Cells[0].Value.ToString().Trim()) != "")
            {
                string imgPath = "..\\image\\AvartarKH\\" + bs.LoadPicture(dgvDSKH.Rows[r].Cells[0].Value.ToString().Trim());
                picAvatar.Image = Image.FromFile(imgPath);
            }

            //lấy danh sách đơn hàng của khách
            string makh = dgvDSKH.Rows[r].Cells[0].Value.ToString().Trim();

            db = bs.LayDS_DonhangOfKH(makh);
            dgvDSDHofKH.DataSource = db;

        }
    }
}
