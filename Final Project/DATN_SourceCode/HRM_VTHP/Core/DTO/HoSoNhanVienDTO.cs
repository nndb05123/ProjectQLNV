using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class HoSoNhanVienDTO
    {
        public int NhanVienID { get; set; }
        public DateTime int NgayVaoLam { get; set; }
        public int DanTocID { get; set; }
        public int TonGiaoID { get; set; }
        public int TinhThanhID { get; set; }
        public int NgoaiNguID { get; set; }
        public int TinHocID { get; set; }
        public int BangCapID { get; set; }
        public string GhiChu { get; set; }
        public string ImagePath { get; set; }
    }
}
