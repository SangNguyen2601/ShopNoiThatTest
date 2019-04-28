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
using BanHangNoiThat_HeQTCSDL.Forms;


namespace BanHangNoiThat_HeQTCSDL.Forms.UsersControl
{
    public partial class UseInformation : UserControl
    {

        BS_UserInfo bs = new BS_UserInfo();
        DataTable db = new DataTable();

        string imagepath;

        public UseInformation()
        {
            InitializeComponent();

            readInf();
        }

        private void UseInformation_Load(object sender, EventArgs e)
        {
            readInf();
        }
        public void readInf()
        {
            Txtname.Enabled = false;
            txtDiachi.Enabled = false;
            txtemal.Enabled = false;
            txtSdt.Enabled = false;
           // BtnLuuInf.Enabled = false;
            radioNam.Enabled = false;
            radioNu.Enabled = false;
            updateImage.Visible = false;
            bornYear.Enabled = false;

            if (GiaoDienUser.User_Login_ID != null)
            {
                db = bs.LayTTKH(GiaoDienUser.User_Login_ID);

                Txtname.Text = db.Rows[0][0].ToString().Trim();
                txtSdt.Text = db.Rows[0][1].ToString().Trim();
                txtemal.Text = db.Rows[0][2].ToString().Trim();
                txtDiachi.Text = db.Rows[0][3].ToString().Trim();
                bornYear.Value = Convert.ToDecimal(db.Rows[0][4].ToString());

                if (radioNam.Text == db.Rows[0][5].ToString().Trim())
                {
                    radioNam.Checked = true;
                }
                if (radioNu.Text == db.Rows[0][5].ToString().Trim())
                {
                    radioNu.Checked = true;
                }

                if (bs.LoadPicture(GiaoDienUser.User_Login_ID) != "")
                {
                    string imgPath = "..\\image\\AvartarKH\\" + bs.LoadPicture(GiaoDienUser.User_Login_ID);
                    ImageUser.Image = Image.FromFile(imgPath);
                }
            }

        }

        private void BtnLuuInf_Click(object sender, EventArgs e)
        {
            //readInf();
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc lưu thay đổi không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                string makh = GiaoDienUser.User_Login_ID;
                string tenkh = Txtname.Text.ToString().Trim();
                string gioitinh = null;
                if (radioNam.Checked)
                {
                    gioitinh = radioNam.Text.ToString().Trim();
                }
                if (radioNu.Checked)
                {
                    gioitinh = radioNu.Text.ToString().Trim();
                }
                string diachi = txtDiachi.Text.ToString().Trim();
                string mail = txtemal.Text.ToString().Trim();
                int sdt = Convert.ToInt32(txtSdt.Text.ToString().Trim());

                bs.UpdateTTKH(makh, tenkh, gioitinh, diachi, mail, sdt);

                if (imagepath != null)
                {
                    string piclocation = imagepath;

                    bs.UploadPicture(makh, piclocation);

                    ImageUser.Image.Save("..\\image\\AvartarKH\\" + imagepath, ImageFormat.Jpeg);
                }

                MessageBox.Show("Lưu thành công !");
                readInf();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Txtname.Enabled = true;
            txtDiachi.Enabled = true;
            txtemal.Enabled = true;
            txtSdt.Enabled = true;
            BtnLuuInf.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            updateImage.Visible = true;
            Txtname.Focus();
            bornYear.Enabled = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            UserHome us = new UserHome();
            GiaoDienUser.addUserControl(us);
        }

        private void updateImage_Click(object sender, EventArgs e)
        {
            openAvatar.FileName = "";
            openAvatar.Title = "Images";
            openAvatar.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openAvatar.RestoreDirectory = true;
            if (openAvatar.ShowDialog() == DialogResult.OK)
            {
                Image myImage = Image.FromFile(openAvatar.FileName);
                ImageUser.Image = myImage;

                imagepath = openAvatar.FileName.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                imagepath = imagepath.Remove(0, 1);
            }
        }

        private void btnXemDH_Click(object sender, EventArgs e)
        {
            DonHangofKH frm = new DonHangofKH();
            frm.ShowDialog();
        }
    }
}
