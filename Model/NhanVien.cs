using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _Sdt;
        private double _HeSoLuong;
        private string _TaiKhoan;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public double HeSoLuong { get => _HeSoLuong; set => _HeSoLuong = value; }
        public string TaiKhoan { get => _TaiKhoan; set => _TaiKhoan = value; }

        public NhanVien() { }
    }
}
