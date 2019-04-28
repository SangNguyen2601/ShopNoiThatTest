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
    public partial class SignIn : Form
    {
        BS_Login bs = new BS_Login();

        public SignIn()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text.ToString().Trim() != "" 
                && usernameSignIn.Text.ToString().Trim() != "" 
                && passwordSignIn.Text.ToString().Trim() != ""
                && Confirmpassword.Text.ToString().Trim() !=""
                && txtemail.Text.ToString().Trim() != ""
                && (CheckMale.Checked != false
                || checkFemale.Checked != false))
            {
                string tenkh = txtFullName.Text.ToString().Trim();
                string makh = usernameSignIn.Text.Trim().ToString();
                string email = txtemail.Text.ToString().Trim();
                int tuoi = Convert.ToInt16(bornYear.Value);
                string gioitinh = null;
                if (CheckMale.Checked)
                {
                    gioitinh = CheckMale.Text.ToString().Trim();
                }
                if (checkFemale.Checked)
                {
                    gioitinh = CheckMale.Text.ToString().Trim();
                }
                string pass = passwordSignIn.Text.ToString().Trim();

                bs.ThemIDmoi(makh, tenkh, email, tuoi, gioitinh, pass, "", 0, "");

                MessageBox.Show("Successfull!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void usernameSignIn_Leave(object sender, EventArgs e)
        {
            if (usernameSignIn.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Tài khoản !");
                usernameSignIn.Focus();
            }
            else
            {
                if (usernameSignIn.Text.Length > 16)
                {
                    MessageBox.Show("Tài khoản có độ dài không quá 16 ký tự !");
                    usernameSignIn.Focus();
                }
                else
                {
                    string temp = usernameSignIn.Text.ToString().Trim();
                    if (bs.KiemtraIDtontai(temp) == 1)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại !");
                        usernameSignIn.Focus();
                    }
                }
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

        private void usernameSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void passwordSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordSignIn.isPassword = true;
        }

        private void Confirmpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Confirmpassword.isPassword = true;
        }

        private void showpassword_Click(object sender, EventArgs e)
        {
            passwordSignIn.isPassword = true;
            showpassword.Visible = false;
            unshowpassword.Visible = true;
        }

        private void unshowpassword_Click(object sender, EventArgs e)
        {

            passwordSignIn.isPassword = false;
            unshowpassword.Visible = false;
            showpassword.Visible = true;
        }
    }
}
