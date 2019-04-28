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
    public class BS_DetailProduct
    {
        DBmain db = null;
        BanHangNoiThatEntities dbsm = new BanHangNoiThatEntities();
        public BS_DetailProduct()
        {
            db = new DBmain();
        }

        public DataTable Lay_CTSP(string masp)
        {
            DataTable table = new DataTable();

            ////Lấy cột, thêm vào datatable
            Type t = typeof(CTsanpham_ThongTinCTsp_Result);
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
            foreach (CTsanpham_ThongTinCTsp_Result item in dbsm.CTsanpham_ThongTinCTsp(masp).ToList())
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
            return Convert.ToString(dbsm.LoadPic(masp).FirstOrDefault().ToString());
        }

        public void ThemvaoGioHang(string masp, string makh, int soluong)
        {
            dbsm.ThemSpVaoGioHang(masp, makh, soluong);
        }
    }
}
