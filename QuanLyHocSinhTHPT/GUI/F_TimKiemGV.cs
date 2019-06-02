using DevComponents.DotNetBar;
using QLHocSinhTHPT.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class F_TimKiemGV : Form
    {
        #region Fields
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public F_TimKiemGV()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_TimKiemGV_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbCMon);
        }
        #endregion



        private void bindingNavigatorExitItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txtHoTen, cmbTheoDChi, txtDiaChi, cmbTheoCMon, cmbCMon, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);

            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có giáo viên cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}