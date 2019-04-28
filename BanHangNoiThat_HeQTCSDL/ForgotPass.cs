using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHangNoiThat_HeQTCSDL.BS_Main;

namespace BanHangNoiThat_HeQTCSDL
{
    public partial class ForgotPass : Form
    {
        BS_Login bs = new BS_Login();

        string taikhoan = null;
        string email = null;
        string newpass = null;

        public ForgotPass()
        {
            InitializeComponent();
        }
        User_Login frm = new User_Login();
        private void txtEmailForgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 64 && e.KeyChar < 122) || (e.KeyChar == 46) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8))
            {
            }
            else
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
            }
        }

        void kiemTraKTSo(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 64 && e.KeyChar < 122) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8)) ||
        char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
        char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
        char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
            }
        }

        private void txtIDforgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void txtConfimPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void ConfimBT_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text.Trim() != "" && txtConfimPass.Text.Trim() != "" && txtConfimPass.Text.Trim() == txtNewPass.Text.Trim())
            {
                newpass = txtConfimPass.Text.Trim().ToString();
                bs.UpdatePass(newpass, taikhoan);
                MessageBox.Show("Successfull!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cập nhật không hợp lệ !");
                txtNewPass.Focus();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void CheckBt_Click(object sender, EventArgs e)
        {
            taikhoan = txtIDforgot.Text.Trim().ToString();
            email = txtEmailForgot.Text.Trim().ToString();
            if(bs.KiemtraTK_Email(taikhoan, email) == 0)
            {
                MessageBox.Show("Tài khoản hoặc email không tồn tại!");
                txtIDforgot.Focus();
            }
            else
            {
                txtNewPass.Enabled = true;
                txtConfimPass.Enabled = true;
                ConfimBT.Enabled = true;
            }
        }
    }
}
