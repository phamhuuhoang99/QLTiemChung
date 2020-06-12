using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class ThongKe
     {
          private DateTime Ngay;
          private int tongTienTiem;
         
          public int TongTienTiem { get => tongTienTiem; set => tongTienTiem = value; }
          public DateTime Ngay1 { get => Ngay; set => Ngay = value; }
        
          public ThongKe(DataRow row)
          {
               this.Ngay = DateTime.Parse(row["NgayTiem"].ToString());
               this.tongTienTiem = Int32.Parse(row["TienTiem"].ToString());
               
          }


     }
}
