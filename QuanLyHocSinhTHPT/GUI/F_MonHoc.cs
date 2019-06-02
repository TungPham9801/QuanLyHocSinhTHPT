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
    public partial class F_MonHoc : Form
    {
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public F_MonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void F_MonHoc_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThi(dGVMonHoc, bindingNavigatorMonHoc);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVMonHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_MonHocCtrl.ThemDongMoi();
            m_Row["MaMonHoc"] = "MH" + quyDinh.LaySTT(dGVMonHoc.Rows.Count + 1);
            m_Row["TenMonHoc"] = "";
            m_Row["SoTiet"] = 0;
            m_Row["HeSo"] = 0;
            m_MonHocCtrl.ThemMonHoc(m_Row);
            bindingNavigatorMonHoc.BindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(dGVMonHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorMonHoc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaMonHoc") == true &&
                KiemTraTruocKhiLuu("colTenMonHoc") == true &&
                KiemTraTruocKhiLuu("colSoTiet") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_MonHocCtrl.LuuMonHoc();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVMonHoc.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng, số tiết và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
