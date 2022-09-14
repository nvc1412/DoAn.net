using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class TK
    {
        private string _TaiKhoan;
        private string _MatKhau;
        private string _Quyen;

        public string TaiKhoan { get => _TaiKhoan; set => _TaiKhoan = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string Quyen { get => _Quyen; set => _Quyen = value; }

        public TK() { }
    }
}
