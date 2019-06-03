using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QuanLyHocSinhTHPT.Bussiness
{
    //Xây dựng đối tượng nĂM HỌC với các thuộc tính sau
    public class NamHocInfo
    {
        public NamHocInfo()
        {

        }

        private String m_MaNamHoc;
        public String MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }

        private String m_TenNamHoc;
        public String TenNamHoc
        {
            get { return m_TenNamHoc; }
            set { m_TenNamHoc = value; }
        }
    }
}
