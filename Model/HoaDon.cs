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
        private int _SoLuong;
        private float _DonGia;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public DateTime NgayBan { get => _NgayBan; set => _NgayBan = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public float DonGia { get => _DonGia; set => _DonGia = value; }

        public HoaDon() { }
    }
}
