using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class BangLuong
    {
        private string _Thang;
        private string _MaLuong;
        private string _MaNV;
        private string _TenNV;
        private double _HeSoLuong;
        private int _SoNgayLam;
        private double _Thuong;
        private double _Phat;
        private double _PhuCap;
        private double _ThucLinh;

        public string Thang { get => _Thang; set => _Thang = value; }
        public string MaLuong { get => _MaLuong; set => _MaLuong = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public double HeSoLuong { get => _HeSoLuong; set => _HeSoLuong = value; }
        public int SoNgayLam { get => _SoNgayLam; set => _SoNgayLam = value; }
        public double Thuong { get => _Thuong; set => _Thuong = value; }
        public double Phat { get => _Phat; set => _Phat = value; }
        public double PhuCap { get => _PhuCap; set => _PhuCap = value; }
        public double ThucLinh { get => _ThucLinh; set => _ThucLinh = value; }

        public BangLuong () { }
    }
}
