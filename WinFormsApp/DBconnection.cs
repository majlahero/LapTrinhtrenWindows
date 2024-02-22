using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class DBconnection
    {
        public DBconnection() { }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Fload(string sqlStr)
        {
            DataTable dtGV = new DataTable();
            conn.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtGV);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            return dtGV;
        }

        public void ThucThi(string sqlStr)
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
    }
}
