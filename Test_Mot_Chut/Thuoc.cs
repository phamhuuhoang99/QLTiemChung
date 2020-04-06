using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut
{
    class Thuoc
    {
        private String maThuoc { get; set; }
        private String tenThuoc { get; set; }
        private String xuatXu { get; set; }
        private String maNhomThuoc { get; set; }
        private int soLuong { get; set; }

        public String MaThuoc   // property
        {
            get { return maThuoc; }
            set { maThuoc = value; }
        }
        public String TenThuoc {
            get { return tenThuoc; }
            set { tenThuoc = value; }
        }
        public String XuatXu
        {
            get { return xuatXu; }
            set { xuatXu = value; }
        }
        public String MaNhomThuoc
        {
            get { return maNhomThuoc; }
            set { maNhomThuoc = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public Thuoc(String ma,String ten,String noiSx,int so,String nhom)
        {
            maThuoc = ma;
            tenThuoc=ten;
            xuatXu = noiSx;
            maNhomThuoc = nhom;
            soLuong = so;
        }
    }
}
