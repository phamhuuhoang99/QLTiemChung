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
     }
}
