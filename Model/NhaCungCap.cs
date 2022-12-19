using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGiaDung.Model
{
    public class NhaCungCap
    {
        private string _MaNCC;
        private string _TenNCC;
        private string _DiaChi;
        private string _Sdt;

        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }

        public NhaCungCap() { }
    }
}
