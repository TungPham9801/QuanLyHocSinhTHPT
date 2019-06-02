using DevComponents.DotNetBar;
using QLHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Component;
using QuanLyHocSinhTHPT.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class F_NguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public F_NguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_NguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
        }
        #endregion


        #region DataError event
        private void dGVNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion


        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            if (dGVNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaND"] = "ND" + quyDinh.LaySTT(dGVNguoiDung.Rows.Count + 1);
            m_Row["MaLoai"] = "";
            m_Row["TenND"] = "";
            m_Row["TenDNhap"] = "";
            m_Row["MatKhau"] = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bindingNavigatorNguoiDung.BindingSource.MoveLast();
        }

        private void btnThemLoaiND_Click_1(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiNguoiDung();
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (dGVNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaND") == true &&
               KiemTraTruocKhiLuu("colMaLoai") == true &&
               KiemTraTruocKhiLuu("colTenND") == true &&
               KiemTraTruocKhiLuu("colTenDNhap") == true &&
               KiemTraTruocKhiLuu("colMatKhau") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NguoiDungCtrl.LuuNguoiDung();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorExitItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}