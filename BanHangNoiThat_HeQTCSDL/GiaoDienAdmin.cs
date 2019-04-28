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
using BanHangNoiThat_HeQTCSDL.DB_Main;


namespace BanHangNoiThat_HeQTCSDL
{
    public partial class GiaoDienAdmin : Form
    {
        

        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn muốn thoát ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
                Application.Exit();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            aminQLSP2.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
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

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            aminQLKH1.BringToFront();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            aminNhapSP1.BringToFront();
        }
    }
}
