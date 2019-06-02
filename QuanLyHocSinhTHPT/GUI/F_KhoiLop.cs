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
    public partial class F_KhoiLop : Form
    {
        #region Field
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        #endregion

        #region constructor
        public F_KhoiLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_KhoiLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
        }
        #endregion

       
        

        


        #region DataError event
        private void dGVKhoiLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_KhoiLopCtrl.ThemDongMoi();
            m_Row["MaKhoiLop"] = "";
            m_Row["TenKhoiLop"] = "";
            m_KhoiLopCtrl.ThemKhoiLop(m_Row);
            bindingNavigatorKhoiLop.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoiLop.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhoiLopCtrl.LuuKhoiLop();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVKhoiLop.Rows)
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

        private void bindingNavigatorExitItem_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
