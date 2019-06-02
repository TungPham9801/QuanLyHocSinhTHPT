using DevComponents.DotNetBar;
using QLHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Component;
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
    public partial class F_DanToc : Form
    {
        #region Fields
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public F_DanToc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_DanToc_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThi(dGVDanToc, bindingNavigatorDanToc);
        }
        #endregion

 





   

        #region DataError event
        private void dGVDanToc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            if (dGVDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_DanTocCtrl.ThemDongMoi();
            m_Row["MaDanToc"] = "DT" + quyDinh.LaySTT(dGVDanToc.Rows.Count + 1);
            m_Row["TenDanToc"] = "";
            m_DanTocCtrl.ThemDanToc(m_Row);
            bindingNavigatorDanToc.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (dGVDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDanToc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaDanToc") == true &&
                    KiemTraTruocKhiLuu("colTenDanToc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DanTocCtrl.LuuDanToc();
            }
        }

        private void bindingNavigatorExitItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVDanToc.Rows)
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

        private void bindingNavigatorDanToc_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}