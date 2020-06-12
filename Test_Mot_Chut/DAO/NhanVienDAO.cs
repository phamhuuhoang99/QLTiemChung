using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Mot_Chut.DTO;

namespace Test_Mot_Chut.DAO
{
     class NhanVienDAO
     {
          public static NhanVienDAO instance;
          public static NhanVienDAO Instance
          {
               get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
               private set { NhanVienDAO.instance = value; }
          }

          public DataTable getListNhanVien()
          {
               DataTable data = DataProvider.Instance.ExcuteQuery("SELECT MaNV,HoTen,DangNhap.Email,NgaySinh,QueQuan,NgayVaoLam,GioiTinh,SDT,MaChucVu,MatKhau FROM dbo.NhanVien LEFT JOIN dbo.DangNhap ON DangNhap.Email = NhanVien.Email");
               int x = data.Rows.Count;
               return data;
          }

          public void InsertNhanVien()
          {

          }

          public Email getEmailnByMa(string id)
          {
               Email loai = null;

               string query = String.Format("select * from DangNhap where Email='{0}'", id);



               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach (DataRow item in data.Rows)
               {
                    loai = new Email(item);
                    return loai;
               }

               return loai;
          }

          public List<ThongKe> getThongKe(DateTime d1,DateTime d2)
          {
               List<ThongKe> ls = new List<ThongKe>();
               string query = String.Format("EXEC dbo.PB_getThongKeTiem @first = '{0}',@sencond = '{1}'",d1.ToString("yyyy-MM-dd"),d2.ToString("yyyy-MM-dd"));
              // string query = "EXEC dbo.PB_getThongKeTiem @first = '2020-01-21',@sencond = '2020-04-21'";
               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach (DataRow item in data.Rows)
               {
                    ThongKe tk = new ThongKe(item);

                    ls.Add(tk);
               }
               return ls;
          }

          public List<ThongKeNhap> getThongKeNhap(DateTime d1, DateTime d2)
          {
               List<ThongKeNhap> ls = new List<ThongKeNhap>();
               string query = String.Format("EXEC dbo.PB_ThongKeNhap @frist = '{0}',@second = '{1}'", d1.ToString("yyyy-MM-dd"), d2.ToString("yyyy-MM-dd"));
               // string query = "EXEC dbo.PB_getThongKeTiem @first = '2020-01-21',@sencond = '2020-04-21'";
               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach (DataRow item in data.Rows)
               {
                    ThongKeNhap tk = new ThongKeNhap(item);

                    ls.Add(tk);
               }
               return ls;
          }
          public List<Email> getEmail()
          {
               List<Email> list = new List<Email>();
               string query = "SELECT * FROM dbo.DangNhap";
               DataTable data = DataProvider.Instance.ExcuteQuery(query);
               foreach (DataRow item in data.Rows)
               {

                    Email e = new Email(item);
                    list.Add(e);
               }

               return list;
          }

          public ChucVu getChucVuByMa(string id)
          {
               ChucVu loai = null;

               string query = String.Format("select * from ChucVu where MaChucVu='{0}'", id);



               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach (DataRow item in data.Rows)
               {
                    loai = new ChucVu(item);
                    return loai;
               }

               return loai;
          }
          public bool InsertEmail(String tk, String mk)
          {
               String query = String.Format("INSERT INTO dbo.DangNhap VALUES  ('{0}', N'{1}')", tk, mk);
               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }

          public bool InsertNhanVien(String ma,String ten,String email,String qq,String ngaySinh,String ngayVao,String gt,String sdt,String cv)
          {
               string query = String.Format("INSERT INTO dbo.NhanVien VALUES  ( '{0}' ,N'{1}' ,'{2}' ,'{3}' ,N'{4}' , '{5}' ,N'{6}' ,'{7}' ,'{8}')", ma, ten, email, ngaySinh, qq, ngayVao, gt, sdt, cv);
               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }

          public List<String> getListMaNhanVien()
          {
               List<String> ls = new List<string>();
               String query = "SELECT  MaNV FROM dbo.NhanVien";

               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach(DataRow item in data.Rows)
               {
                    String str = item["MaNV"].ToString();
                    ls.Add(str);

               }
               return ls;
          }

          public bool UpdateThongTinDangNhap(String ten,String mkCu,String mkMoi)
          {
               String query = String.Format("EXEC dbo.PB_UpdateDangNhap @mkMoi = '{0}',@mkCu = '{1}',@email = '{2}'", mkMoi, mkCu, ten);
               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }

     }
}
