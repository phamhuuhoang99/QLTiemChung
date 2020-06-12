using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mot_Chut.DAO
{
     public class DataProvider
     {
          //DataProvider chỉ tạo ra 1 lần sử dụng cho toàn bộ chương trình
          private static DataProvider instance;//Ctrl+R+E
          public static DataProvider Instance {
               get { if (instance == null) instance = new DataProvider(); return DataProvider.instance;}
               private set { DataProvider.instance = value; }  //nội bộ class mới được thay đổi giá trị, bên ngoài ko đc đụng vào
          }
          //Hàm dụng private chắc chắn bên ngoài ko lấy được
          private DataProvider() { }
          private String sqlConnectionStr = "Server=HUUHOANG;Database=QuanLiTiemChung;User Id=sa;pwd=123456";
         
          public DataTable ExcuteQuery(String query, object[] parameter = null)
          {
               DataTable data = new DataTable();
               //TODO:khi kết thúc khối lệnh thì  dữ liêu khai báo tự giải phóng
               using (SqlConnection sqlConnect = new SqlConnection(sqlConnectionStr)) { 

                    sqlConnect.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnect);

                    if (parameter != null)
                    {
                         string[] listPara = query.Split(' ');
                         int i = 0;
                         foreach(string item in listPara)
                         {
                              if (item.Contains('@'))
                              {
                                   command.Parameters.AddWithValue(item, parameter[i]);
                                   i++;
                              }
                         }

                    }

                
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    sqlConnect.Close();
               }
               return data;
          }


          //trả về insert được bao nhiều dòng dữ liêu
          public int ExcuteNoneQuery(String query, object[] parameter = null)
          {
               int data = 0;
               //TODO:khi kết thúc khối lệnh thì  dữ liêu khai báo tự giải phóng
               using (SqlConnection sqlConnect = new SqlConnection(sqlConnectionStr))
               {

                    sqlConnect.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnect);

                    if (parameter != null)
                    {
                         string[] listPara = query.Split(' ');
                         int i = 0;
                         foreach (string item in listPara)
                         {
                              if (item.Contains('@'))
                              {
                                   command.Parameters.AddWithValue(item, parameter[i]);
                                   i++;
                              }
                         }

                    }

                    data = command.ExecuteNonQuery();

                    sqlConnect.Close();
               }
               return data;
          }

          public object ExcuteScalar(String query, object[] parameter = null)
          {
               object data = 0;
               //TODO:khi kết thúc khối lệnh thì  dữ liêu khai báo tự giải phóng
               using (SqlConnection sqlConnect = new SqlConnection(sqlConnectionStr))
               {

                    sqlConnect.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnect);
                command.
                    if (parameter != null)
                    {
                         string[] listPara = query.Split(' ');
                         int i = 0;
                         foreach (string item in listPara)
                         {
                              if (item.Contains('@'))
                              {
                                   command.Parameters.AddWithValue(item, parameter[i]);
                                   i++;
                              }
                         }

                    }
                    //trả về dòng đầu tiên phù hợp tính count
                    data = command.ExecuteScalar();

                    sqlConnect.Close();
               }
               return data;
          }
     }
}
