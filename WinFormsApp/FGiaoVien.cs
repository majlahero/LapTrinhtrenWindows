using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FGiaoVien : Form
    {
        public FGiaoVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDao gvDao = new GiaoVienDao();



        private void FLogin_Load(object sender, EventArgs e)
        {
            conn.Close();
            DataGV.DataSource = gvDao.FloadGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }













        private void btnThem_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            gvDao.ThemGV(gv);
            DataGV.DataSource = gvDao.FloadGV();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            gvDao.Xoa(gv);
            DataGV.DataSource = gvDao.FloadGV();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            DataGV.DataSource = gvDao.FloadGV();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            DataGV.DataSource = gvDao.FloadGV();
        }
    }
}
