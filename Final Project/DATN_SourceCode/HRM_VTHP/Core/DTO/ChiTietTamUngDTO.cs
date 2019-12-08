using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class ChiTietTamUngDTO
    {
        public int PhieuTamUngID { get; set; }
        public string MaPhieuTamUng { get; set; }
        public char ThangTamUng { get; set; }
        public int TamUngID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayLap { get; set; }
        public float TamUng { get; set; }
        public string GhiChu { get; set; }
        public int TrangThaiID { get; set; }
    }
}
