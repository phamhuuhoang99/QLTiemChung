using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class ChucVu
     {
          String maChucVu, tenChucVu;
          int luongChucVu;

          public string MaChucVu { get => maChucVu; set => maChucVu = value; }
          public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
          public int LuongChucVu { get => luongChucVu; set => luongChucVu = value; }

          public ChucVu(DataRow row)
          {
               this.maChucVu = row["MaChucVu"].ToString();
               this.tenChucVu = row["TenChucVu"].ToString();
               this.luongChucVu = Int32.Parse(row["LuongChucVu"].ToString());
          }
     }
}
