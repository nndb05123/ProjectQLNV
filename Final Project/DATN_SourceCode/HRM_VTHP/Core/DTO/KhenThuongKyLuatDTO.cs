using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class KhenThuongKyLuatDTO
    {
        public int KhenThuongKyLuatID { get; set; }
        public int NhanVienID { get; set; }
        public int LoaiQuyetDinhID { get; set; }
        public DateTime NgayQuyetDinh { get; set; }
        public string GhiChu { get; set; }
    }
}
