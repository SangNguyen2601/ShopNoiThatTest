using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.NetworkInformation;
using BanHangNoiThat_HeQTCSDL.Properties;

using System.Data.Sql;
using System.Data.SqlClient;

using BanHangNoiThat_HeQTCSDL.BS_Main;
using BanHangNoiThat_HeQTCSDL.DB_main;

namespace BanHangNoiThat_HeQTCSDL
{
    public partial class Admin_Login : Form
    {
        public static string ServerIP = null;
        public static string DataOfServer = null;
        public static string IDname = null;
        public static string Passworld = null;
        public static string TableName = null;

        DataTable dt = null;
        DataSet ds, ds2;
        BS_Connect db = new BS_Connect();
        string err;

        public Admin_Login()
        {
            InitializeComponent();

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    //IPComboBox.Items.Add(addr.Address.ToString());
                }
            }
            PassCheckHint.Checked = false;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void DataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataOfServer = DataComboBox.ValueMember.ToString().Trim();
        }

        private void PassCheckHint_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheckHint.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtIP.Text != "" && txtID.Text != "" && txtPass.Text != "")
            {
                DataComboBox.Items.Clear();
                ServerIP = txtIP.Text.Trim().ToString();
                IDname = txtID.Text.Trim().ToString();
                Passworld = txtPass.Text.Trim().ToString();
                DBmain.Connect();
                if (DBmain.success)
                {
                    MessageBox.Show("Successful!");

                    dt = new DataTable();
                    dt.Clear();

                    ds = db.TakeData();
                    dt = ds.Tables[0];
                    DataComboBox.DataSource = dt;
                    DataComboBox.ValueMember = "name";
                    DataComboBox.DisplayMember = "name";

                }
                else
                {
                    MessageBox.Show("Connected Faile!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập IP, tài khoản hoặc mật khẩu !");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString1 = "Server=" + Admin_Login.ServerIP + ",1433 ;Database=" + Admin_Login.DataOfServer + ";User Id=" + Admin_Login.IDname + ";Password=" + Admin_Login.Passworld + ";";
            Properties.Settings.Default.Save();

            this.Hide();

            GiaoDienAdmin frm = new GiaoDienAdmin();
                frm.ShowDialog();

        }

    }
}
