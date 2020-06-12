using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class Email
     {
          private String taiKhoan, matKhau;

          public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
          public string MatKhau { get => matKhau; set => matKhau = value; }

          public Email(String tk,String mk)
          {
               this.taiKhoan = tk;
               this.matKhau = mk;
          }
          public Email(DataRow row)
          {
               this.taiKhoan = row["Email"].ToString();
               this.matKhau= row["MatKhau"].ToString();
          }

     }
}
