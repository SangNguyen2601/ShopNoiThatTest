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
    public class BS_AdminQLSP
    {
        DBmain db = null;

        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();

        public BS_AdminQLSP()
        {
            db = new DBmain();
        }

        public DataTable LayDSLoaiSP()
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DSLoaisanpham_Result);
            PropertyInfo[] pia =t.GetProperties();
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

        public DataTable LayDSSP(string maLoai)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(DSSP_theoLoaiSP_Result);
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
            /////Lấy dữ liệu từng dòng, thêm vào datatable
            foreach (DSSP_theoLoaiSP_Result item in dbsm.DSSP_theoLoaiSP(maLoai).ToList())
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

        public void XoaSP(string masp)
        {
            dbsm.XoaSanPham(masp);
        }

        public void EditSP(string masp, string maloai, string tensp, string kickco, string mausac, string xuatxu, string mota, int soluong, int giavon, int giaban)
        {
            dbsm.EditSP(masp, maloai, tensp, kickco, mausac, xuatxu, mota, soluong, giavon, giaban);
        }

        public string LoadPicture(string masp)
        {
            return Convert.ToString(dbsm.LoadPic(masp).FirstOrDefault().ToString());
        }

        public void UploadPicture(string masp, string pic)
        {
            dbsm.UploadPic(masp, pic);
        }


    }
}
