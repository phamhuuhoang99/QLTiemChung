using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Mot_Chut.DTO;

namespace Test_Mot_Chut.DAO
{
     class LoaiVacxinDAO
     {
          public static LoaiVacxinDAO instance;
          public static LoaiVacxinDAO Instance
          {
               get { if (instance == null) instance = new LoaiVacxinDAO(); return LoaiVacxinDAO.instance; }
               private set { LoaiVacxinDAO.instance = value; }
          }

          public List<LoaiVacxin> getListLoaiVacxin()
          {
               List<LoaiVacxin> loaiVx = new List<LoaiVacxin>();

               DataTable data= DataProvider.Instance.ExcuteQuery("EXEC USP_GetLoai");

               
               foreach(DataRow item in data.Rows)
               {
                    LoaiVacxin loai = new LoaiVacxin(item);

                    loaiVx.Add(loai);
               }

               return loaiVx;
          }

          public DataTable getDataLoaiVacxin()
          {
               return DataProvider.Instance.ExcuteQuery("EXEC USP_GetLoai");
          }

          public bool InsertLoaiVacxin(String name,String ma)
          {
              String query =String.Format( "INSERT INTO dbo.LoaiVacxin VALUES  ('{0}', N'{1}')",ma,name);
              int result= DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }
          public bool UpdateLoaiVacxin(String name, String ma)
          {
               String query = String.Format("UPDATE dbo.LoaiVacxin SET TenLoai=N'{0}'WHERE MaLoai LIKE '{1}'",name, ma);
               
               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }

          public bool DeleteLoaiVacxin(String id)
          {
               VacxinDAO.Instance.DeleteVacxinByLoai(id);
               String query =String.Format( "DELETE FROM dbo.LoaiVacxin WHERE MaLoai='{0}'",id);

               int result = DataProvider.Instance.ExcuteNoneQuery(query);

               return result > 0;
          }
          public LoaiVacxin getLoaiVacxinByMa(String id)
          {
               LoaiVacxin loai = null;

               string query = String.Format("select * from LoaiVacxin where MaLoai='{0}'", id);

               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach(DataRow item in data.Rows)
               {
                    loai = new LoaiVacxin(item);
                    return loai;
               }

               return loai;
          }
     }
}
