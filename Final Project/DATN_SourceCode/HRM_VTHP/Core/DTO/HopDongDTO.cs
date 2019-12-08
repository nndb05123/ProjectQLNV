using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class HopDongDTO
    {
        public int HopDongID { get; set; }
        public string MaHopDong { get; set; }
        public int LoaiHopDongID { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int NhanVienID { get; set; }
        public bool TrangThai { get; set; }
    }
}
