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
    public partial class F_NgheNghiep : Form
    {
        #region Fields
        NgheNghiepCtrl m_NgheNghiepCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public F_NgheNghiep()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void F_NgheNghiep_Load(object sender, EventArgs e)
        {
            m_NgheNghiepCtrl.HienThi(dGVNgheNghiep, bindingNavigatorNgheNghiep);
        }
        #endregion

        #region DataError event
        private void dGVNgheNghiep_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        #endregion

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            if (dGVNgheNghiep.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NgheNghiepCtrl.ThemDongMoi();
            m_Row["MaNghe"] = "NN" + quyDinh.LaySTT(dGVNgheNghiep.Rows.Count + 1);
            m_Row["TenNghe"] = "";
            m_NgheNghiepCtrl.ThemNgheNghiep(m_Row);
            bindingNavigatorNgheNghiep.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (dGVNgheNghiep.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNgheNghiep.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (dGVNgheNghiep.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NgheNghiepCtrl.ThemDongMoi();
            m_Row["MaNghe"] = "NN" + quyDinh.LaySTT(dGVNgheNghiep.Rows.Count + 1);
            m_Row["TenNghe"] = "";
            m_NgheNghiepCtrl.ThemNgheNghiep(m_Row);
            bindingNavigatorNgheNghiep.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVNgheNghiep.Rows)
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