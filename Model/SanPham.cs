using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class SanPham
    {
        private string _MaSP;
        private string _TenSP;
        private string _Loai;
        private double _GiaBan;
        private string _DVT;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string Loai { get => _Loai; set => _Loai = value; }
        public double GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public string DVT { get => _DVT; set => _DVT = value; }

        public SanPham() { }
    }
}
