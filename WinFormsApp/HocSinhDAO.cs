using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp
{
    

    internal class HocSinhDAO
    {
        public HocSinhDAO()
        { 
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Fload()
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM HocSinh");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                
                adapter.Fill(dtSinhVien);
    
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            return dtSinhVien;
        }
        private void ThucThi(string sqlStr)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thuc thi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Them(HocSinh them)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten, DiaChi, CMND, NgaySinh) VALUES ('{0}', '{1}'," +
                    " '{2}', '{3}')", them.Ten, them.Dc, them.Cmnd, them.NgaySinh.ToString("yyyy-MM-dd"));
            ThucThi(sqlStr);
        }
        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE CMND = '{0}'", hs.Cmnd);
            ThucThi(sqlStr);
        }
        public void Sua(HocSinh hs)
        {
           
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', NgaySinh = '{2}' WHERE CMND = '{3}'",
                    hs.Ten, hs.Dc, hs.NgaySinh.ToString("yyyy-MM-dd"), hs.Cmnd);

            ThucThi(sqlStr);
        }
    }
    
}
