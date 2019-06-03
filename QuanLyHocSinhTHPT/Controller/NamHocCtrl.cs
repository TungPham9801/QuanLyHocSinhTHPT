﻿using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QuanLyHocSinhTHPT.DataLayer;
using QuanLyHocSinhTHPT.Bussiness;

namespace QLHocSinhTHPT.Controller
{
    //Nguyễn Thị Linh thực hiện phần này
    public class NamHocCtrl
    {
        NamHocData m_NamHocData = new NamHocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            NamHocData m_NHData = new NamHocData();

            comboBox.DataSource = m_NHData.LayDsNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NamHocData.LayDsNamHoc();
            cmbColumn.DisplayMember = "TenNamHoc";
            cmbColumn.ValueMember = "MaNamHoc";
            cmbColumn.DataPropertyName = "MaNamHoc";
            cmbColumn.HeaderText = "Năm học";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NamHocData.LayDsNamHoc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NamHocData.ThemDongMoi();
        }

        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.ThemNamHoc(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNamHoc()
        {
            return m_NamHocData.LuuNamHoc();
        }
        #endregion
    }
}
