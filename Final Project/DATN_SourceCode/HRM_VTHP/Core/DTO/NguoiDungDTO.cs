using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DTO
{
    class NguoiDungDTO
    {
        public int NguoiDungID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool QuanTri { get; set; }
        public int NhanVienID { get; set; }
    }
}
