using DevComponents.DotNetBar;
using QuanLyHocSinhTHPT.Controller;
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
    public partial class F_HocKy : Form
    {
        #region Field
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        #endregion

        public F_HocKy()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void F_HocKy_Load(object sender, EventArgs e)
        {
            m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHocKy.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_HocKyCtrl.ThemDongMoi();
            m_Row["MaHocKy"] = "";
            m_Row["TenHocKy"] = "";
            m_Row["HeSo"] = 0;
            m_HocKyCtrl.ThemHocKy(m_Row);
            bindingNavigatorHocKy.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHocKy.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHocKy.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocKy") == true &&
                KiemTraTruocKhiLuu("colTenHocKy") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HocKyCtrl.LuuHocKy();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocKy.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
