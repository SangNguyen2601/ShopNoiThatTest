using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using BanHangNoiThat_HeQTCSDL.DB_Main;
using BanHangNoiThat_HeQTCSDL.DB_main;

namespace BanHangNoiThat_HeQTCSDL.BS_Main
{
    public class BS_Login
    {
        DBmain db = null;

        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();

        public BS_Login()
        {
            db = new DBmain();
        }

        public void ThemIDmoi(string makh, string tenkh, string email, int tuoi, string gioitinh, string pass, string avatar, int sdt, string diachi)
        {
            dbsm.InsertNewID(makh, tenkh, email, tuoi, gioitinh, pass, avatar, sdt, diachi);
        }

        public int KiemtraIDtontai(string makh)
        {
            int a;
             a = Convert.ToInt32(dbsm.ProcCheckID(makh).FirstOrDefault().ToString());
            return a;
        }

        public int KiemtraDangNhap(string taikhoan, string matkhau)
        {
            int a;
            a = Convert.ToInt32(dbsm.CheckLogin(taikhoan, matkhau).FirstOrDefault().ToString());
            return a;
        }

        public int KiemtraTK_Email(string taikhoan, string email)
        {
            return Convert.ToInt32(dbsm.checkIdEmail(taikhoan, email).FirstOrDefault().ToString());
        }

        public void UpdatePass(string matkhaumoi, string taikhoan)
        {
            dbsm.UpdateNewPass(matkhaumoi, taikhoan);
        }
    }
}
