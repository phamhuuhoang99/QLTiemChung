using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class LoaiVacxin
     {
          private String maLoai, tenLoai;
          private object v;

          public string MaLoai { get => maLoai; set => maLoai = value; }
          public string TenLoai { get => tenLoai; set => tenLoai = value; }

          public LoaiVacxin(String ma,String ten)
          {
               maLoai = ma;
               tenLoai = ten;
          }

          public LoaiVacxin(DataRow row)
          {
               this.maLoai = row["MaLoai"].ToString();
               this.tenLoai = row["TenLoai"].ToString();
          }

          public LoaiVacxin(DataRowView row)
          {
               this.maLoai = row["MaLoai"].ToString();
               this.tenLoai = row["TenLoai"].ToString();
          }


     }
}
