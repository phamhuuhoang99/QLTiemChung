using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DTO
{
     class NhanVien
     {
          String maNhanVien, hoTen, email, queQuan, gioiTinh, SDT, chucVu;
          DateTime ngaySinh, ngayVaoLam;

          public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
          public string HoTen { get => hoTen; set => hoTen = value; }
          public string Email { get => email; set => email = value; }
          public string QueQuan { get => queQuan; set => queQuan = value; }
          public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
          public string SDT1 { get => SDT; set => SDT = value; }
          public string ChucVu { get => chucVu; set => chucVu = value; }
          public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
          public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
     }
}
