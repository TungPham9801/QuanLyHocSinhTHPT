using DevComponents.DotNetBar;
using QuanLyHocSinhTHPT.Component;
using System;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Controller;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class F_Main : DevComponents.DotNetBar.Office2007RibbonForm 
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        F_DoiMatKhau m_FrmDoiMatKhau = null;
        F_DangNhap m_FrmLogin = null;
        F_NguoiDung m_FrmNguoiDung = null;
        F_Connection m_Connection = null;
        
        #endregion
        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            if(DataService.OpenConnection())
            {
                Default();
                DangNhap();

                //this.Cursor = MyCursors.Create(System.IO.Path.Combine(Application.StartupPath, "Pointer.cur"));

                // Create the list of frequently used commands for the QAT Customize menu
                ribbonControl.QatFrequentCommands.Add(btnDangNhap);
                ribbonControl.QatFrequentCommands.Add(btnDangXuat);
                ribbonControl.QatFrequentCommands.Add(btnThoat);

                // Load Quick Access Toolbar layout if one is saved from last session...
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
                if (key != null)
                {
                    try
                    {
                        string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                        if (layout != "" && layout != null)
                            ribbonControl.QatLayout = layout;
                    }
                    finally
                    {
                        key.Close();
                    }
                }

                // Pulse the Application Button
                buttonFile1.Pulse(11);
            }
            else
            {
                Default();
                ReConnection();
            }
        }
        

        #region Kết nối lại CSDL
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new F_Connection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        #endregion

        #region Lưu lại trạng thái khi thoát chương trình
        private void F_Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }
        #endregion

        #region DangNhap
        
    public void DangNhap()
    {
        Cont:
        if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
            m_FrmLogin = new F_DangNhap();

        if (m_FrmLogin.ShowDialog() == DialogResult.OK)
        {
            if (m_FrmLogin.txtUsername.Text == "")
            {
                m_FrmLogin.lblPassError.Text = "";
                m_FrmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                goto Cont;
            }

            if (m_FrmLogin.txtPassword.Text == "")
            {
                m_FrmLogin.lblUserError.Text = "";
                m_FrmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu!";
                goto Cont;
            }

            int ketQua = m_NguoiDungCtrl.DangNhap(m_FrmLogin.txtUsername.Text, m_FrmLogin.txtPassword.Text);

            switch (ketQua)
            {
                case 0:
                    m_FrmLogin.lblPassError.Text = "";
                    m_FrmLogin.lblUserError.Text = "Người dùng này không tồn tại!";
                    goto Cont;
                case 1:
                    m_FrmLogin.lblUserError.Text = "";
                    m_FrmLogin.lblPassError.Text = "Mật khẩu không hợp lệ!";
                    goto Cont;
                case 2:

                    break;
            }
        }
        else
            return;
    }
        #endregion

        #region DoiMatKhau
        public void DoiMatKhau()
        {
            Cont:
            if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDoiMatKhau.txtOldPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtNewPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtReNPassword.Text == "")
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                    goto Cont;
                }

                String m_Username = m_FrmLogin.txtUsername.Text;
                String m_Password = m_FrmLogin.txtPassword.Text;

                String m_OldPassword = m_FrmDoiMatKhau.txtOldPassword.Text;
                String m_NewPassword = m_FrmDoiMatKhau.txtNewPassword.Text;
                String m_ReNPassword = m_FrmDoiMatKhau.txtReNPassword.Text;

                if (m_Password != m_OldPassword)
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }
                else if (m_NewPassword != m_ReNPassword)
                {
                    m_FrmDoiMatKhau.lblOldPassError.Text = "";
                    m_FrmDoiMatKhau.lblNewPassError.Text = "";
                    m_FrmDoiMatKhau.lblReNPassError.Text = "Nhập xác nhận không khớp!";
                    goto Cont;
                }
                else
                {
                    m_NguoiDungCtrl.ChangePassword(m_Username, m_NewPassword);
                    MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                return;
        }
        #endregion

        /*#region Phân quyền
        public void Permissions(String m_Per)
        {
            switch (m_Per)
            {
                case "LND001": IsBGH(); break;
                case "LND002": IsGiaoVien(); break;
                case "LND003": IsGiaoVu(); break;
                default: Default(); break;
            }
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền BGH
        public void IsBGH()
        {
            //true
            btnDangNhap.Enabled = true;
            btnDangNhapContext.Enabled = true;

            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnQLNguoiDung.Enabled = true;
           
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            rbbMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            
            btnHocSinh.Enabled = true;
           
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            
            btnDSHocSinh.Enabled = true;
            btnDSGiaoVien.Enabled = true;
            btnDSLopHoc.Enabled = true;

            btnTCHocSinh.Enabled = true;
            btnTCGiaoVien.Enabled = true;

        
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo viên
        public void IsGiaoVien()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            rbbMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;

            
            btnDSHocSinh.Enabled = true;
            btnDSGiaoVien.Enabled = true;
            btnDSLopHoc.Enabled = true;

            btnTCHocSinh.Enabled = true;
            btnTCGiaoVien.Enabled = true;

   

            //true
            btnDangNhap.Enabled = true;
            btnDangNhapContext.Enabled = true;
            btnQLNguoiDung.Enabled = true;
           
            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            
            btnHocSinh.Enabled = true;
            
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo vụ
        public void IsGiaoVu()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            
            rbbMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnHocSinh.Enabled = true;
           
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;

            
            btnDSHocSinh.Enabled = true;
            btnDSGiaoVien.Enabled = true;
            btnDSLopHoc.Enabled = true;

            btnTCHocSinh.Enabled = true;
            btnTCGiaoVien.Enabled = true;

           

            //true
            btnDangNhap.Enabled = true;
            btnDangNhapContext.Enabled = true;
            btnQLNguoiDung.Enabled = true;
            

            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            
        }
        #endregion

*/
        #region Giao diện mặc định
        public void Default()
        {
            //True
            btnDangNhap.Enabled = true;
            
            btnThoat.Enabled = true;
            


            btnDangXuat.Enabled = true;
            
            btnDoiMatKhau.Enabled = true;
           
            btnQLNguoiDung.Enabled = true;
           

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnLoaiDiem.Enabled = true;
            rbbMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
           
            btnHocSinh.Enabled = true;
     
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            //btnDSHocSinh.Enabled = true;
            //btnDSGiaoVien.Enabled = true;
            //btnDSLopHoc.Enabled = true;

            btnTCHocSinh.Enabled = true;
            btnTCGiaoVien.Enabled = true;
            

        }


        #endregion

        #region Menu Start
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new F_DangNhap();

            m_FrmLogin.txtUsername.Text = "";
            m_FrmLogin.txtPassword.Text = "";
            m_FrmLogin.lblUserError.Text = "";
            m_FrmLogin.lblPassError.Text = "";

            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
                m_FrmDoiMatKhau = new F_DoiMatKhau();

            m_FrmDoiMatKhau.txtOldPassword.Text = "";
            m_FrmDoiMatKhau.txtNewPassword.Text = "";
            m_FrmDoiMatKhau.txtReNPassword.Text = "";
            m_FrmDoiMatKhau.lblOldPassError.Text = "";
            m_FrmDoiMatKhau.lblNewPassError.Text = "";
            m_FrmDoiMatKhau.lblReNPassError.Text = "";

            DoiMatKhau();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new F_NguoiDung();
               // m_FrmNguoiDung.MdiParent = this;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Quản Lý


        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLopHoc();
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiem();
        }

        private void btnLoaiDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiDiem();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocSinh();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanCong();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanToc();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTonGiao();
        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
        }

        #endregion

        #region Thống Kê
        //private void btnDSGiaoVien_Click(object sender, EventArgs e)
        //{
        //    ThamSo.ShowFormDanhSachGiaoVien();
        //}

        //private void btnDSHocSinh_Click(object sender, EventArgs e)
        //{
        //   // ThamSo.ShowFormDanhSachHocSinh();
        //}

        //private void btnDSLopHoc_Click(object sender, EventArgs e)
        //{
        //   // ThamSo.ShowFormDanhSachLopHoc();
        //}
        #endregion

        #region Tra Cứu
        private void btnTCGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemGV();
        }

        private void btnTCHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemHS();
        }
        #endregion

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLop();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinh();
        }
    }

}
