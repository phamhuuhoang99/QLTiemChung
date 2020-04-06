using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut
{
    class NhomThuoc
    {
        private String maNhomThuoc;
        private String tenNhomThuoc;

        public String MaNhomThuoc
        {
            get { return maNhomThuoc; }
            set { maNhomThuoc = value; }

        }
        public String TenNhomThuoc
        {
            get { return tenNhomThuoc; }
            set { tenNhomThuoc = value; }
        }

        public NhomThuoc(String ma,String ten)
        {
            maNhomThuoc = ma;
            tenNhomThuoc = ten;
        }
    }
}
