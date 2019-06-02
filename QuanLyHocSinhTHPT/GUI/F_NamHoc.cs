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
    public partial class F_NamHoc : Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();

        public F_NamHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void F_NamHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThi(dGVNamHoc, bindingNavigatorNamHoc);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVNamHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NamHocCtrl.ThemDongMoi();
            m_Row["MaNamHoc"] = "";
            m_Row["TenNamHoc"] = "";
            m_NamHocCtrl.ThemNamHoc(m_Row);
            bindingNavigatorNamHoc.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVNamHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNamHoc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaNamHoc") == true &&
                KiemTraTruocKhiLuu("colTenNamHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NamHocCtrl.LuuNamHoc();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVNamHoc.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
