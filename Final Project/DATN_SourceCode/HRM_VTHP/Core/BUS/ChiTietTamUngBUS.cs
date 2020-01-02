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
    class ChiTietTamUngBUS
    {
        private static ChiTietTamUngBUS instance;

        internal static ChiTietTamUngBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietTamUngBUS(); return HRM_VTHP.Core.BUS.ChiTietTamUngBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.ChiTietTamUngBUS.instance = value;
            }
        }
        public DataTable LoadData_ChiTietTamUng()
        {
           
            DataTable dt = Core.GetData(ChiTietTamUngDAO.Instance.LoadData_ChiTietTamUng());
            return dt;
        }
        public int Add_ChiTietTamUng(ChiTietTamUngDTO chiTietTamUngDTO)
        {
            return Core.RunSql(ChiTietTamUngDAO.Instance.Add_ChiTietTamUng(chiTietTamUngDTO));
        }
        public void Update_ChiTietTamUng(ChiTietTamUngDTO chiTietTamUngDTO,int PhieuTamUngID)
        {
            Core.RunSql(ChiTietTamUngDAO.Instance.Update_ChiTietTamUng(chiTietTamUngDTO, PhieuTamUngID));
        }
        public void Delete_ChiTietTamUng(int PhieuTamUngID)
        {
            Core.RunSql(ChiTietTamUngDAO.Instance.Delete_ChiTietTamUng( PhieuTamUngID));
        }
    }
}
