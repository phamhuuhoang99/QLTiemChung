using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class ThongKeNhap
     {
          private DateTime ngayNhap;
          private int tongTienNhap;

          public int TongTienNhap { get => tongTienNhap; set => tongTienNhap = value; }
          public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

          public ThongKeNhap(DataRow row)
          {
               this.ngayNhap = DateTime.Parse(row["NgayNhap"].ToString());
               this.tongTienNhap = Int32.Parse(row["TienTien"].ToString());

          }
     }
}
