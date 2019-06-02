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
    public partial class F_QuyDinh : Form
    {
        QuyDinhCtrl m_QuyDinhCtrl = new QuyDinhCtrl();

        public F_QuyDinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void F_QuyDinh_Load(object sender, EventArgs e)
        {
            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);

        }

        //private void btnDongY_Click(object sender, EventArgs e)
        //{
        //    if (tabControlPanelSiSo.CanSelect)
        //    {
        //        if (txtSiSoCanDuoi.Value <= 10 || txtSiSoCanTren.Value >= 60)
        //            MessageBoxEx.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //        {
        //            m_QuyDinhCtrl.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
        //            MessageBoxEx.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        //        }
        //    }
        //    else if (tabControlPanelDoTuoi.CanSelect)
        //    {
        //        if (txtDoTuoiCanDuoi.Value <= 10 || txtDoTuoiCanTren.Value >= 30)
        //            MessageBoxEx.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //        {
        //            m_QuyDinhCtrl.CapNhatQuyDinhDoTuoi(txtDoTuoiCanDuoi.Value, txtDoTuoiCanTren.Value);
        //            MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        //        }
        //    }
        //    else if (tabControlPanelTruong.CanSelect)
        //    {
        //        if (txtTenTruong.Text == "")
        //            MessageBoxEx.Show("Tên trường học là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else if (txtDiaChiTruong.Text == "")
        //            MessageBoxEx.Show("Địa chỉ trường là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //        {
        //            m_QuyDinhCtrl.CapNhatQuyDinhTruong(txtTenTruong.Text, txtDiaChiTruong.Text);
        //            MessageBoxEx.Show("Cập nhật thành công thông tin trường học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        //        }
        //    }
        //    else if (tabControlPanelThangDiem.CanSelect)
        //    {
        //        if (ckbThang10.Checked == true)
        //        {
        //            m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(10);
        //            MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        //        }
        //        else
        //        {
        //            m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(100);
        //            MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        //        }
        //    }
        //}

        //private void btnHuyBo_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnDongY_Click_1(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.CanSelect)
            {
                if (txtSiSoCanDuoi.Value <= 10 || txtSiSoCanTren.Value >= 60)
                    MessageBoxEx.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelDoTuoi.CanSelect)
            {
                if (txtDoTuoiCanDuoi.Value <= 10 || txtDoTuoiCanTren.Value >= 30)
                    MessageBoxEx.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhDoTuoi(txtDoTuoiCanDuoi.Value, txtDoTuoiCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelTruong.CanSelect)
            {
                if (txtTenTruong.Text == "")
                    MessageBoxEx.Show("Tên trường học là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtDiaChiTruong.Text == "")
                    MessageBoxEx.Show("Địa chỉ trường là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhTruong(txtTenTruong.Text, txtDiaChiTruong.Text);
                    MessageBoxEx.Show("Cập nhật thành công thông tin trường học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelThangDiem.CanSelect)
            {
                if (ckbThang10.Checked == true)
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(10);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(100);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
