using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Test_Mot_Chut.DAO;
using Test_Mot_Chut.DTO;

namespace Test_Mot_Chut
{
     public partial class FormDrugStore : Form
     {
          BindingSource loaiVaxinList = new BindingSource();
          public FormDrugStore()
          {
               InitializeComponent();
          }

          private void FormDrugStore_Load(object sender, EventArgs e)
          {
               dataListLoai.DataSource = loaiVaxinList;
               updataTreeView();
               loadLoaiVacxin();
               AddLoaiVaxinBinding();
          }


          private void btnClose_Click(object sender, EventArgs e)
          {
               this.Close();
          }


          #region Method
          private void updataTreeView()
          {

               nhomThuoc.Nodes.Clear();

               List<LoaiVacxin> listLoai = LoaiVacxinDAO.Instance.getListLoaiVacxin();

               for (int i = 0; i < listLoai.Count; i++)
               {
                    TreeNode nodeNhom = new TreeNode(listLoai[i].TenLoai);

                    nhomThuoc.Nodes.Add(nodeNhom);
               }


          }

          public DataTable getPhieuByDate(DateTime t1)
          {
               string query= "EXEC dbo.USP_GetTotalPrice @date ";

               return DataProvider.Instance.ExcuteQuery(query, new object[] { t1 });

          } 

          public void loadLoaiVacxin()
          {
               loaiVaxinList.DataSource = LoaiVacxinDAO.Instance.getDataLoaiVacxin();
          }

          public void AddLoaiVaxinBinding()
          {
               txtTenLoai.DataBindings.Add(new Binding("Text", dataListLoai.DataSource, "TenLoai"));
               txtMaLoai.DataBindings.Add(new Binding("Text", dataListLoai.DataSource, "MaLoai"));
          }
          #endregion

          #region Events
          private void nhomThuoc_AfterSelect_1(object sender, TreeViewEventArgs e)
          {

               //lvThuoc.Items.Clear();
               if (e.Node != null)
               {

                    if (e.Node.Level == 0)
                    {
                         String tenLoai = e.Node.Text;

                         string query = "EXEC dbo.USP_GetVacxinInLoai @tenLoai ";

                         DataTable data=DataProvider.Instance.ExcuteQuery(query, new object[] { tenLoai });

                         dtListVacxin.DataSource = data;




                    }
               }

          }

          private void btnThongke_Click(object sender, EventArgs e)
          {
               dataThongKe.DataSource = getPhieuByDate(date.Value);
          }

          private void btnXemLoai_Click(object sender, EventArgs e)
          {
               loadLoaiVacxin();
          }
     }
     #endregion
}
