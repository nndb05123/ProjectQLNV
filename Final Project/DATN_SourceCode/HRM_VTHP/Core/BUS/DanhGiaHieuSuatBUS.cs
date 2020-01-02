using HRM_VTHP.Core.DAO;
using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class DanhGiaHieuSuatBUS
    {
        private static DanhGiaHieuSuatBUS instance;

        internal static DanhGiaHieuSuatBUS Instance
        {
            get
            {
                if (instance == null) instance = new DanhGiaHieuSuatBUS(); return HRM_VTHP.Core.BUS.DanhGiaHieuSuatBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.DanhGiaHieuSuatBUS.instance = value;
            }
        }
        public DataTable LoadData_DanhGiaHieuSuat()
        {
            DataTable dt = Core.GetData(DanhGiaHieuSuatDAO.Instance.LoadData_DanhGiaHieuSuat());
            return dt;
        }
        public int Add_DanhGiaHieuSuat(DanhGiaHieuSuatDTO danhGiaHieuSuatDTO)
        {
            return Core.RunSql(DanhGiaHieuSuatDAO.Instance.Add_DanhGiaHieuSuat(danhGiaHieuSuatDTO));
        }
        public void Update_DanhGiaHieuSuat(DanhGiaHieuSuatDTO danhGiaHieuSuatDTO, int DanhGiaHieuSuatID)
        {
            Core.RunSql(DanhGiaHieuSuatDAO.Instance.Update_DanhGiaHieuSuat(danhGiaHieuSuatDTO,DanhGiaHieuSuatID));
        }
        public void Delete_DanhGiaHieuSuat(int DanhGiaHieuSuatID)
        {
            Core.RunSql(DanhGiaHieuSuatDAO.Instance.Delete_DanhGiaHieuSuat( DanhGiaHieuSuatID));
        }


    }
}
