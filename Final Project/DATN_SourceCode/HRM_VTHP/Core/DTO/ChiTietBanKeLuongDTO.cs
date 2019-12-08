using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class ChiTietBanKeLuongDTO
    {
        public int ChiTietBanKeLuongID { get; set; }
        public char ThangKeLuong { get; set; }
        public int NhanVienID { get; set; }
        public float TienLuongCung { get; set; }
        public float HieuSuat { get; set; }
        public int NgayCongChuan { get; set; }
        public int NgayTinhLuong { get; set; }
        public float PhuCap { get; set; }
        public float TamUng { get; set; }
        public float ThucLinh { get; set; }
        public float TongLuong { get; set; }
        public float ThueThuNhapCaNhan { get; set; }
        public int TrangThai { get; set; }
    }
}
