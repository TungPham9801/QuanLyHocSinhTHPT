using DevComponents.DotNetBar;
using QLHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Controller;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class F_TimKiemHS : Form
    {
        #region Fields
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        #endregion

        #region Constructor
        public F_TimKiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_TimKiemHS_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cmbDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cmbTonGiao);
        }
        #endregion

 

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txtHoTen, cmbTheoNSinh, txtNoiSinh, cmbTheoDToc, cmbDanToc, cmbTheoTGiao, cmbTonGiao, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);

            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có học sinh cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorExitItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
