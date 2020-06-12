using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Mot_Chut.DTO;

namespace Test_Mot_Chut.DAO
{
     class VacxinDAO
     {
          public static VacxinDAO instance;
          public static VacxinDAO Instance
          {
               get { if (instance == null) instance = new VacxinDAO(); return VacxinDAO.instance; }
               private set { VacxinDAO.instance = value; }
          }

          private VacxinDAO() { }

          
          public List<Vacxin> LoadVacxinList()
          {
               List<Vacxin> list = new List<Vacxin>();
               DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_GetVacxin");

               foreach(DataRow item in data.Rows)
               {
                    Vacxin vx = new Vacxin(item);
                    list.Add(vx);
               }
               return list;
               
          }

          public void DeleteVacxinByLoai(String id)
          {
               DataProvider.Instance.ExcuteQuery(String.Format("DELETE FROM dbo.Vacxin WHERE MaLoai='{0}'", id));
          }

          public DataTable GetVacxin()
          {
               return DataProvider.Instance.ExcuteQuery("select * from Vacxin");
          }

          public bool insertVacxin(String ma,String ten,String xuatxu,String loai)
          {
               String query = String.Format("INSERT INTO dbo.Vacxin VALUES ( '{0}', '{1}','{2}',N'{3}')", ma, ten,loai,xuatxu);
               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
          }

          public bool DeleteVacxin(string id)
          {
               
               String query = String.Format("DELETE FROM dbo.Vacxin WHERE MaVacxin='{0}'", id);

               int result = DataProvider.Instance.ExcuteNoneQuery(query);

               return result > 0;
          }

         public bool UpdateVacxin(string ma, string name, string loai, string xuatxu)
          {
               String query = String.Format("UPDATE dbo.Vacxin SET TenVacxin='{0}',MaLoai='{1}',XuatXu=N'{2}' WHERE MaVacxin LIKE '{3}'",name,loai,xuatxu,ma);
               

               int result = DataProvider.Instance.ExcuteNoneQuery(query);
               return result > 0;
              // return query;
          }

          public List<Vacxin> SearchVacxinByName(string name)
          {
               List<Vacxin> list = new List<Vacxin>();
               String query = string.Format( "select * from Vacxin where TenVacxin like N'%{0}%'",name);
               DataTable data = DataProvider.Instance.ExcuteQuery(query);

               foreach (DataRow item in data.Rows)
               {
                    Vacxin vx = new Vacxin(item);
                    list.Add(vx);
               }
               return list;

          }

     }
}
