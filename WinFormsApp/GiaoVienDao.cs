using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class GiaoVienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dbc = new DBconnection();
        public DataTable FloadGV()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            DataTable dt = dbc.Fload(sqlStr);
            return dt;
        }
        private void ThucThi(string sqlStr)
        {
            dbc.ThucThi(sqlStr);
        }
        public void ThemGV(GiaoVien them)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten, DiaChi, CMND, NgaySinh) VALUES ('{0}', '{1}'," +
                    " '{2}', '{3}')", them.Ten, them.Dc, them.Cmnd, them.NgaySinh.ToString("yyyy-MM-dd"));
            ThucThi(sqlStr);
        }
        public void Xoa(GiaoVien xoa)
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE CMND = '{0}'", xoa.Cmnd);
            ThucThi(sqlStr);
        }
        public void Sua(GiaoVien sua)
        {

            string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{2}' WHERE CMND = '{3}'",
                    sua.Ten, sua.Dc, sua.NgaySinh.ToString("yyyy-MM-dd"), sua.Cmnd);

            ThucThi(sqlStr);
        }
    }

}
