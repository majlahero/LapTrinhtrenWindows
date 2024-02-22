using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class ConNguoi
    {
        private string ten;
        private string dc;
        private string cmnd;
        private DateTime ngaysinh;
        public ConNguoi(string ten, string dc, string cmnd, DateTime ngaysinh)
        {
            this.ten = ten;
            this.dc = dc;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
        }
        public string Ten{ get { return ten; } }
        public string Dc { get { return dc; } }
        public string Cmnd { get {  return cmnd; } }
        public DateTime NgaySinh { get { return ngaysinh; } }  
    }
}
