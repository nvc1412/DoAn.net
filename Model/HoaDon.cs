using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class HoaDon
    {
        private string _MaHD;
        private DateTime _NgayBan;
        private string _MaNV;
        private string _MaSP;
        private string _TenSP;
        private int _SoLuong;
        private double _DonGia;
        private double _ThanhTien;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public DateTime NgayBan { get => _NgayBan; set => _NgayBan = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public double DonGia { get => _DonGia; set => _DonGia = value; }
        public double ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        
        public HoaDon() { }
    }
}
