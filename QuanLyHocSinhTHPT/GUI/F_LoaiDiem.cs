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
    public partial class F_LoaiDiem : Form
    {
        #region Fields
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion
        public F_LoaiDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void F_LoaiDiem_Load(object sender, EventArgs e)
        {
            m_LoaiDiemCtrl.HienThi(dGVLoaiDiem, bindingNavigatorLoaiDiem);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLoai") == true &&
                KiemTraTruocKhiLuu("colTenLoai") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiDiemCtrl.LuuLoaiDiem();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVLoaiDiem.Rows)
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
