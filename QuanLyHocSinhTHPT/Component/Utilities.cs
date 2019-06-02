using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Bussiness;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using QuanLyHocSinhTHPT.GUI;

namespace QuanLyHocSinhTHPT.Component
{
    #region Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    #endregion
    #region QuyDinh
    public class QuyDinh
    {
        public static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }

        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
        }

        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    #endregion

    #region ThamSo
    public static class ThamSo
    {
        #region Fields
        public static F_Connection m_FrmConnection = null;
        public static F_DanToc m_FrmDanToc = null;
        public static F_GiaoVien m_FrmGiaoVien = null;
        public static F_HocKy m_FrmHocKy = null;
        public static F_HocSinh m_FrmHocSinh = null;
        public static F_KhoiLop m_FrmKhoiLop = null;
        public static F_Lop m_FrmLop = null;
        public static F_Main m_Frm_Main = null;
        public static F_MonHoc m_FrmMonHoc = null;
        public static F_XemDiem m_FrmXemDiem = null;
        public static F_NgheNghiep m_FrmNgheNghiep = null;
        public static F_PhanCong m_FrmPhanCong = null;
        public static F_TonGiao m_FrmTonGiao = null;
        public static F_LoaiNguoiDung m_FrmLoaiNguoiDung = null;
        public static F_TimKiemGV m_TimKiemGV = null;
        public static F_TimKiemHS m_TimKiemHS = null;
        public static F_NhapDiem m_FrmNhapDiemRieng = null;
        public static F_PhanLop m_FrmPhanLop = null;


        public static F_QuyDinh m_FrmQuyDinh = null;

        //public static F_DanhSachGiaoVien m_FrmDSGiaoVien = null;
        //public static F_DanhSachHocSinh m_FrmDSHocSinh = null;
        //public static F_DanhSachLopHoc m_FrmDSLopHoc = null;
        public static F_NamHoc m_FrmNamHoc = null;
        public static F_LoaiDiem m_FrmLoaiDiem = null;

        #endregion

        #region Ham goi hien form
        #region Menu start
        public static void ShowFormLoaiNguoiDung()
        {
            if (m_FrmLoaiNguoiDung == null || m_FrmLoaiNguoiDung.IsDisposed)
            {
                m_FrmLoaiNguoiDung = new F_LoaiNguoiDung();
              
                m_FrmLoaiNguoiDung.Show();
            }
            else
                m_FrmLoaiNguoiDung.Activate();
        }
        #endregion

        #region Menu quan ly
        public static void ShowFormLopHoc()
        {
            if (m_FrmLop == null || m_FrmLop.IsDisposed)
            {
                m_FrmLop = new F_Lop();
                
                m_FrmLop.Show();
            }
            else
                m_FrmLop.Activate();
        }

        public static void ShowFormKhoiLop()
        {
            if (m_FrmKhoiLop == null || m_FrmKhoiLop.IsDisposed)
            {
                m_FrmKhoiLop = new F_KhoiLop();
               
                m_FrmKhoiLop.Show();
            }
            else
                m_FrmKhoiLop.Activate();
        }

        public static void ShowFormHocKy()
        {
            if (m_FrmHocKy == null || m_FrmHocKy.IsDisposed)
            {
                m_FrmHocKy = new F_HocKy();
               
                m_FrmHocKy.Show();
            }
            else
                m_FrmHocKy.Activate();
        }

        public static void ShowFormNamHoc()
        {
            if (m_FrmNamHoc == null || m_FrmNamHoc.IsDisposed)
            {
                m_FrmNamHoc = new F_NamHoc();
                
                m_FrmNamHoc.Show();
            }
            else
                m_FrmNamHoc.Activate();
        }

        public static void ShowFormMonHoc()
        {
            if (m_FrmMonHoc == null || m_FrmMonHoc.IsDisposed)
            {
                m_FrmMonHoc = new F_MonHoc();
               
                m_FrmMonHoc.Show();
            }
            else
                m_FrmMonHoc.Activate();
        }
        public static void ShowFormLoaiDiem()
        {
            if (m_FrmLoaiDiem == null || m_FrmLoaiDiem.IsDisposed)
            {
                m_FrmLoaiDiem = new F_LoaiDiem();
                
                m_FrmLoaiDiem.Show();
            }
            else
                m_FrmLoaiDiem.Activate();
        }

        public static void ShowFormXemDiem()
        {
            if (m_FrmXemDiem == null || m_FrmXemDiem.IsDisposed)
            {
                m_FrmXemDiem = new F_XemDiem();
               
                m_FrmXemDiem.Show();
            }
            else
                m_FrmXemDiem.Activate();
        }



        public static void ShowFormHocSinh()
        {
            if (m_FrmHocSinh == null || m_FrmHocSinh.IsDisposed)
            {
                m_FrmHocSinh = new F_HocSinh();
               
                m_FrmHocSinh.Show();
            }
            else
                m_FrmHocSinh.Activate();
        }
        public static void ShowFormPhanLop()
        {
            if (m_FrmPhanLop == null || m_FrmPhanLop.IsDisposed)
            {
                m_FrmPhanLop = new F_PhanLop();
               // m_FrmPhanLop.MdiParent = F_Main.ActiveForm;
                m_FrmPhanLop.Show();
            }
            else
                m_FrmPhanLop.Activate();
        }

        public static void ShowFormDanToc()
        {
            if (m_FrmDanToc == null || m_FrmDanToc.IsDisposed)
            {
                m_FrmDanToc = new F_DanToc();
                
                m_FrmDanToc.Show();
            }
            else
                m_FrmDanToc.Activate();
        }

        public static void ShowFormTonGiao()
        {
            if (m_FrmTonGiao == null || m_FrmTonGiao.IsDisposed)
            {
                m_FrmTonGiao = new F_TonGiao();
                
                m_FrmTonGiao.Show();
            }
            else
                m_FrmTonGiao.Activate();
        }

        public static void ShowFormNgheNghiep()
        {
            if (m_FrmNgheNghiep == null || m_FrmNgheNghiep.IsDisposed)
            {
                m_FrmNgheNghiep = new F_NgheNghiep();
               
                m_FrmNgheNghiep.Show();
            }
            else
                m_FrmNgheNghiep.Activate();
        }

        public static void ShowFormGiaoVien()
        {
            if (m_FrmGiaoVien == null || m_FrmGiaoVien.IsDisposed)
            {
                m_FrmGiaoVien = new F_GiaoVien();
                
                m_FrmGiaoVien.Show();
            }
            else
                m_FrmGiaoVien.Activate();
        }

        public static void ShowFormPhanCong()
        {
            if (m_FrmPhanCong == null || m_FrmPhanCong.IsDisposed)
            {
                m_FrmPhanCong = new F_PhanCong();
                
                m_FrmPhanCong.Show();
            }
            else
                m_FrmPhanCong.Activate();
        }
        public static void ShowFormNhapDiem()
        {
            if (m_FrmNhapDiemRieng == null || m_FrmNhapDiemRieng.IsDisposed)
            {
                m_FrmNhapDiemRieng = new F_NhapDiem();
               // m_FrmNhapDiemRieng.MdiParent = F_Main.ActiveForm;
                m_FrmNhapDiemRieng.Show();
            }
            else
                m_FrmNhapDiemRieng.Activate();
        }
        #endregion

        #region Menu thong ke



        //public static void ShowFormDanhSachHocSinh()
        //{
        //    if (m_FrmDSHocSinh == null || m_FrmDSHocSinh.IsDisposed)
        //    {
        //        m_FrmDSHocSinh = new F_DanhSachHocSinh();

        //        m_FrmDSHocSinh.Show();
        //    }
        //    else
        //        m_FrmDSHocSinh.Activate();
        //}

        //public static void ShowFormDanhSachGiaoVien()
        //{
        //    if (m_FrmDSGiaoVien == null || m_FrmDSGiaoVien.IsDisposed)
        //    {
        //        m_FrmDSGiaoVien = new F_DanhSachGiaoVien();

        //        m_FrmDSGiaoVien.Show();
        //    }
        //    else
        //        m_FrmDSGiaoVien.Activate();
        //}

        //public static void ShowFormDanhSachLopHoc()
        //{
        //    if (m_FrmDSLopHoc == null || m_FrmDSLopHoc.IsDisposed)
        //    {
        //        m_FrmDSLopHoc = new F_DanhSachLopHoc();

        //        m_FrmDSLopHoc.Show();
        //    }
        //    else
        //        m_FrmDSLopHoc.Activate();
        //}
        #endregion

        #region Menu tra cuu
        public static void ShowFormTimKiemHS()
        {
            if (m_TimKiemHS == null || m_TimKiemHS.IsDisposed)
            {
                m_TimKiemHS = new F_TimKiemHS();
                
                m_TimKiemHS.Show();
            }
            else
                m_TimKiemHS.Activate();
        }

        public static void ShowFormTimKiemGV()
        {
            if (m_TimKiemGV == null || m_TimKiemGV.IsDisposed)
            {
                m_TimKiemGV = new F_TimKiemGV();
               
                m_TimKiemGV.Show();
            }
            else
                m_TimKiemGV.Activate();
        }
        #endregion

        #region Menu quy dinh
        public static void ShowFormQuyDinh()
        {
            if (m_FrmQuyDinh == null || m_FrmQuyDinh.IsDisposed)
            {
                m_FrmQuyDinh = new F_QuyDinh();
                m_FrmQuyDinh.Show();
            }
            else
                m_FrmQuyDinh.Activate();
        }

        public static void ShowFormKetNoi()
        {
            if (m_FrmConnection == null || m_FrmConnection.IsDisposed)
            {
                m_FrmConnection = new F_Connection();
                m_FrmConnection.Show();
            }
            else
                m_FrmConnection.Activate();
        }
        #endregion


        #endregion
    }
    #endregion

    #region Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    #endregion
}
