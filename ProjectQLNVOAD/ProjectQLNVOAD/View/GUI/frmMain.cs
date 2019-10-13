using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectQLNVOAD.APIManager;
using DevComponents.DotNetBar;
using ProjectQLNVOAD.View.GUI;

namespace ProjectQLNVOAD
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (APIManager.ConnectionSQL.OpenConnection() == false)

            {
                ReConnection();

            }
        }

        #region frmConnection

        frmConnection m_Connection = null;

        //frmLogin m_FrmLogin = null;

        public void ReConnection()

        {

            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            //m_Connection = new frmConnection();

            if (m_Connection == null || m_Connection.IsDisposed)

                m_Connection = new frmConnection();



            if (m_Connection.ShowDialog() == DialogResult.OK)

            {

                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
            else
                return;
        }

        #endregion
    }
}
