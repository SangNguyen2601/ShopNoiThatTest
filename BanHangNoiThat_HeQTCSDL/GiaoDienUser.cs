using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat_HeQTCSDL
{

    public partial class GiaoDienUser : Form
    {
        public static string User_Login_ID = null;
        public static bool IsLogin = false;

        public GiaoDienUser()
        {
            InitializeComponent();

            bunifuProduct.Enabled = false;
            btnCart.Enabled = false;
            btnUser.Enabled = false;
        }
        public void Reload()
        {
            btnDangXuat.Text = "Đăng nhập";
            GiaoDienUser.IsLogin = false;
            bunifuProduct.Enabled = false;
            btnCart.Enabled = false;
            btnUser.Enabled = false;
            userHome1.BringToFront();
        }

        private void GiaodienUser_Load(object sender, EventArgs e)//tạo contructor để lấy MaSP từ Userproduct
        {
            userHome1.BringToFront();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn muốn thoát ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
                this.Close();
        }

        private void bunifuMenu_Click(object sender, EventArgs e)
        {
            //chỉnh hiệu ứng SileMenu
            if (SideMenu.Width == 50)
            {
                SideMenu.Visible = false;
                SideMenu.Width = 242;
                bunifuPanel.ShowSync(SideMenu);

            }
            else
            {
                SideMenu.Visible = false;
                SideMenu.Width = 50;
                bunifuPanel.ShowSync(SideMenu);
            }
        }

        private void bunifuHome_Click(object sender, EventArgs e)
        {
             userHome1.BringToFront();
        }

        private void bunifuProduct_Click(object sender, EventArgs e)
        {
            userProduct1.BringToFront();
        }

        private void bunifuContact_Click(object sender, EventArgs e)
        {
            userContact1.BringToFront();
        }

        private void bunifuAddCart_Click(object sender, EventArgs e)
        {
            addCart1.BringToFront();
            addCart1.load();
        }

        private void bunifuUserInf_Click(object sender, EventArgs e)
        {
            useInformation1.BringToFront();
            useInformation1.readInf();
        }

        public static void addUserControl(UserControl frm)
        {
            frm.BringToFront();
        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            if(IsLogin == false)
            {
                User_Login frm = new User_Login();
                frm.ShowDialog();

                if(GiaoDienUser.IsLogin == true)
                {
                    bunifuProduct.Enabled = true;
                    btnCart.Enabled = true;
                    btnUser.Enabled = true;
                    btnDangXuat.Text = "Đăng xuất";
                }
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Bạn muốn đăng xuất ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tl == DialogResult.OK)
                {
                    User_Login_ID = null;
                    IsLogin = false;
                    btnDangXuat.Text = "Đăng nhập";
                    Reload();
                }
            }
        }

        private bool checkexitform(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void activechirldform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
    }
}
