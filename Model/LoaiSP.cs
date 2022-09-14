using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class LoaiSP
    {
        private string _MaLoai;
        private string _TenLoai;

        public string MaLoai { get => _MaLoai; set => _MaLoai = value; }
        public string TenLoai { get => _TenLoai; set => _TenLoai = value; }

        public LoaiSP() { }
    }
}
