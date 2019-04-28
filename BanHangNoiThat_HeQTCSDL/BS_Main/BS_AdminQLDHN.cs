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

namespace BanHangNoiThat_HeQTCSDL.BS_Main
{
    public class BS_AdminQLDHN
    {
        DBmain db = null;

        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();

        public BS_AdminQLDHN()
        {
            db = new DBmain();
        }

        public void TaoDHN(string maDHN, DateTime ngaynhap)
        {
            dbsm.TaoDonHangNhap(maDHN, ngaynhap);
        }

        public int KTSanPhamTonTai(string masp)
        {
            return Convert.ToInt32(dbsm.KTmaSPtontai(masp).FirstOrDefault().ToString());
        }

        public DataTable LayTTSP(string masp)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(LoadTTSP_nhap_Result);
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
            foreach (LoadTTSP_nhap_Result item in dbsm.LoadTTSP_nhap(masp).ToList())
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

        public void ThemvaoHHN(string masp, string maDHN, int soluong)
        {
            dbsm.ThemvaoHangHoaNhap(masp, maDHN, soluong);
        }

        public void ThemSPMoi(string masp, string tensp, string maloai, string xuatxu, string kickco, int giavon, int giaban, string hinhanh, int soluong)
        {
            dbsm.ThemSPmoi(masp, tensp, maloai, xuatxu, kickco, giavon, giaban, hinhanh, soluong);
        }

        public DataTable LayDSLoaiSP()
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DSLoaisanpham_Result);
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
            foreach (DSLoaisanpham_Result item in dbsm.DSLoaisanpham().ToList())
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

        public DataTable LayDS_DHN()
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DS_DonHangNhap_Result);
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
            foreach (DS_DonHangNhap_Result item in dbsm.DS_DonHangNhap().ToList())
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

        public void Tinh_Tongtien(string madhn)
        {
            dbsm.Tinh_TTDHN(madhn);
        }
    }
}
