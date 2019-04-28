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
using Bunifu.Framework.UI;

namespace BanHangNoiThat_HeQTCSDL.Forms.UsersControl
{
    public partial class UserProduct : UserControl
    {
        List<string> MaSP = new List<string>();//tạo danh sách chứa mã sản phẩm
        DataTable db = new DataTable();
        BS_UserProduct bs = new BS_UserProduct();

        public UserProduct()
        {
            InitializeComponent();

            db = new DataTable();
            db = bs.LayDSLoaiSP();
            CbSapxep.DataSource = db;
            CbSapxep.DisplayMember = "TenLoai";
            CbSapxep.ValueMember = "MaLoai";
            CbSapxep.SelectedIndex = 0;

        }


        private void UserProduct_Load(object sender, EventArgs e)
        {
            db = bs.Load_DSSP(CbSapxep.SelectedValue.ToString().Trim());
            ImageList imgList = new ImageList();
            int countIndex = 0;

            listViewSanpham.Clear();

            for (int i = 0; i < db.Rows.Count; i++)
            {
                ListViewItem sp = new ListViewItem(db.Rows[i][2].ToString().Trim());
                ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(sp, db.Rows[i][3].ToString().Trim());
                MaSP.Add(db.Rows[i][0].ToString().Trim());//khởi tạo mã sp
                sp.ImageIndex = countIndex;
                listViewSanpham.Items.Add(sp).SubItems.Add(sub);

                if (db.Rows[i][4].ToString().Trim() != "")
                {
                    string path = "..\\image\\" + db.Rows[i][1].ToString().Trim() + "\\" + db.Rows[i][4].ToString().Trim();
                    imgList.Images.Add(Image.FromFile(path));
                }

                countIndex++;
            }

            imgList.ImageSize = new Size(200, 200);
            listViewSanpham.LargeImageList = imgList;
        }

        private void listViewSanpham_ItemActivate(object sender, EventArgs e)
        {
            ListView senders = (ListView)sender;
            string ma = MaSP[senders.SelectedIndices[0]];//gán mã sp ở vị trí click chuột  
            Detailproduct frm = new Detailproduct(ma);//truyền mã sp tham chiếu đến GiaoDienUser
            frm.ShowDialog();
         }

        private void CbSapxep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UserProduct_Load(sender, e);
        }
    }
}
