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
     }
}
