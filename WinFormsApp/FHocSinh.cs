using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO hsDao = new HocSinhDAO();
        public FHocSinh()
        {
            InitializeComponent();
        }

        
        private void FLogin_Load(object sender, EventArgs e)
        {
            conn.Close();
            Data.DataSource = hsDao.Fload();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            hsDao.Them(hs);
            Data.DataSource = hsDao.Fload();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            hsDao.Xoa(hs);
            Data.DataSource = hsDao.Fload();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            
            HocSinh hs = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, date.Value);
            hsDao.Sua(hs);
            Data.DataSource = hsDao.Fload();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Data.DataSource = hsDao.Fload();
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
