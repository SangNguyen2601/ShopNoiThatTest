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
    public class BS_AdminQLKH
    {
        DBmain db = null;

        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();

        public BS_AdminQLKH()
        {
            db = new DBmain();
        }

        public DataTable LayDSKH()
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(ViewKhachHang_Result);
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
            foreach (ViewKhachHang_Result item in dbsm.ViewKhachHang().ToList())
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

        public DataTable LayDS_DonhangOfKH(string makh)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DonHangofKH_Result);
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
            foreach (DonHangofKH_Result item in dbsm.DonHangofKH(makh).ToList())
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

        public string LoadPicture(string masp)
        {
            return Convert.ToString(dbsm.LoadPic_KH(masp).FirstOrDefault().ToString());
        }

    }
}
