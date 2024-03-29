using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace QuanLyHocSinhTHPT.Component
{
    public partial class F_DoiMatKhau : Form
    {
        #region Constructor
        public F_DoiMatKhau()
        {
            InitializeComponent();
        }
        #endregion

        #region Click event
        private void btnDongY_Click(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region Key event
        private void txtReNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}