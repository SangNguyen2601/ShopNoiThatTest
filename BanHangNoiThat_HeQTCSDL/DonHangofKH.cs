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

namespace BanHangNoiThat_HeQTCSDL
{
    public partial class DonHangofKH : Form
    {
        BS_UserInfo bs = new BS_UserInfo();
        DataTable db = new DataTable();

        public DonHangofKH()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {
            db = bs.LayDS_DHB(GiaoDienUser.User_Login_ID);

            dgvDS_DHB.DataSource = db;
        }
    }
}
