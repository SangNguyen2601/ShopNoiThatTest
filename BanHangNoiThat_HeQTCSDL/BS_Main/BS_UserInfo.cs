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
    public class BS_UserInfo
    {
        DBmain db = null;
        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();

        public BS_UserInfo()
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

        public string LoadPicture(string makh)
        {
            string a = "";
            if (dbsm.LoadPic_KH(makh).FirstOrDefault() != null)
            {
               a = Convert.ToString(dbsm.LoadPic_KH(makh).FirstOrDefault().ToString());
            }
            return a;
        }

        public void UploadPicture(string makh, string pic)
        {
            dbsm.UploadPic_KH(makh, pic);
        }

        public void UpdateTTKH(string makh, string tenkh, string gioitinh, string diachi, string mail, int sdt)
        {
            dbsm.CapNhat_Thongtinkhachhang(makh, tenkh, gioitinh, diachi, mail, sdt);
        }

        public DataTable LayDS_DHB(string makh)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DS_DonHangBan_Result);
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
            foreach (DS_DonHangBan_Result item in dbsm.DS_DonHangBan(makh).ToList())
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
    }
}
