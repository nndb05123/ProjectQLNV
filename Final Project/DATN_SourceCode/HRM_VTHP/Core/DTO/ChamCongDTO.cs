using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class ChamCongDTO
    {
        public int ChamCongID { get; set; }
        public int NgayCongChuan { get; set; }
        public int NhanVienID { get; set; }
        public int BoPhanID { get; set; }
        public int NgayDiLam { get; set; }
        public int NgayNghiLe { get; set; }
        public int NgayNghiPhepTinhLuong { get; set; }
        public int NgayKhongLuong { get; set; }
        public int NgayTinhLuong { get; set; }
        public int NgayChamCong { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string Thang { get; set; }
    }
}
