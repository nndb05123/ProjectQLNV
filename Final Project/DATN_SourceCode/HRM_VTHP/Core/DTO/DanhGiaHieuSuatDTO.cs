using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class DanhGiaHieuSuatDTO
    {
        public int DanhGiaHieuSuatID { get; set; }
        public string Thang { get; set; }
        public int NhanVienID { get; set; }
        public float HieuSuat { get; set; }
    }
}
