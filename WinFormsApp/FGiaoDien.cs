using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FGiaoDien : Form
    {
        public FGiaoDien()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:/Users/Administrator/Source/Repos/WinFormsApp/WinFormsApp/bin/Debug/net8.0-windows/background-hoc-tap.jpg");
        }

     

        private void btnGiaoVien_Click_1(object sender, EventArgs e)
        {
            FGiaoVien gv = new FGiaoVien();
            gv.Show();
        }

        private void btnHocSinh_Click_1(object sender, EventArgs e)
        {
            FHocSinh hs = new FHocSinh();
            hs.Show();
        }
    }
}
