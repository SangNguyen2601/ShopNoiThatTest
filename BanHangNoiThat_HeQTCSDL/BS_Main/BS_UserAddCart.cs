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
using System.Reflection;
using System.Drawing;

namespace BanHangNoiThat_HeQTCSDL.BS_Main
{
    public class BS_UserAddCart
    {
        DBmain db = null;
        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();
        public BS_UserAddCart()
        {
            db = new DBmain();
        }

        public DataTable LayTTKH(string makh)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(TTKH_Result);
            PropertyInfo[] pia = t.GetProperties();
            foreach (PropertyInfo pi in pia)
            {
                Type ColumnType = pi.PropertyType;
                if ((ColumnType.IsGenericType))
                {
                    ColumnType = ColumnType.GetGenericArguments()[0];
                }
                table.Columns.Add(pi.Name, ColumnType);
            }
            /////Lấy dữ liệu từng dòng, thêm voà datatable
            foreach (TTKH_Result item in dbsm.TTKH(makh).ToList())
            {
                DataRow dr = table.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo pi in pia)
                {
                    if (pi.GetValue(item, null) != null)
                    {
                        dr[pi.Name] = pi.GetValue(item, null);
                    }
                }
                dr.EndEdit();
                table.Rows.Add(dr);
            }
            return table;
        }

        public DataTable LayGioHang(string makh)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(ViewGioHang_Result);
            PropertyInfo[] pia = t.GetProperties();
            foreach (PropertyInfo pi in pia)
            {
                Type ColumnType = pi.PropertyType;
                if ((ColumnType.IsGenericType))
                {
                    ColumnType = ColumnType.GetGenericArguments()[0];
                }
                table.Columns.Add(pi.Name, ColumnType);
            }
            /////Lấy dữ liệu từng dòng, thêm voà datatable
            foreach (ViewGioHang_Result item in dbsm.ViewGioHang(makh).ToList())
            {
                DataRow dr = table.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo pi in pia)
                {
                    if (pi.GetValue(item, null) != null)
                    {
                        dr[pi.Name] = pi.GetValue(item, null);
                    }
                }
                dr.EndEdit();
                table.Rows.Add(dr);
            }
            return table;
        }

        public void Capnhat_TTThanhToan(string makh, string hoten, string diachi, string mail, int sdt)
        {
            dbsm.CapNhat_TTThanhToan(makh, hoten, diachi, mail, sdt);
        }

        public void capnhat_SoLuong(int soluong, string masp, string makh)
        {
            dbsm.Capnhatsoluong1sptronggio(soluong, masp, makh);
        }

        public void themdonhangban(string makh, DateTime ngay, int tongtien)
        {
            dbsm.ThemDonHangBan(makh, ngay, tongtien);
        }

        public void XoaGioHang(string makh)
        {
            dbsm.Delete_GioHang(makh);
        }
    }
}
