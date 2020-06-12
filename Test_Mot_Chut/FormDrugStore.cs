using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Test_Mot_Chut.DAO;
using Test_Mot_Chut.DTO;

namespace Test_Mot_Chut
{
     public partial class FormDrugStore : Form
     {
          BindingSource loaiVaxinList = new BindingSource();
          BindingSource loaiVaxin = new BindingSource();
          BindingSource nhanVien = new BindingSource();

          public FormDrugStore()
          {
               InitializeComponent();
          }

          private void FormDrugStore_Load(object sender, EventArgs e)
          {
               dataListLoai.DataSource = loaiVaxinList;
               dtListVacxin.DataSource = loaiVaxin;
               dataListNhanVien.DataSource = nhanVien;
             
               loadCboChucVu();

               loadListNhanVien();
               loadCbbLoaiVaxin(cboLoaiVacxin);
               loadLoaiVacxin();
               loadVacxin();
               AddLoaiVaxinBinding();
               AddVacXinBinding();
               AddNhanVienBinding();                          
          }


          private void btnClose_Click(object sender, EventArgs e)
          {
               this.Close();
          }


          #region Method

          private List<Vacxin> SearchVacxinByName(String name)
          {
               List<Vacxin> listVx = new List<Vacxin>();
               listVx = VacxinDAO.Instance.SearchVacxinByName(name);
               return listVx;
          }
          public DataTable getPhieuByDate(DateTime t1)
          {
               string query = "EXEC dbo.USP_GetTotalPrice @date ";

               return DataProvider.Instance.ExcuteQuery(query, new object[] { t1 });

          }

          public void loadLoaiVacxin()
          {
               loaiVaxinList.DataSource = LoaiVacxinDAO.Instance.getDataLoaiVacxin();

          }
          public void loadVacxin()
          {
               loaiVaxin.DataSource = VacxinDAO.Instance.GetVacxin();
          }
          public void AddLoaiVaxinBinding()
          {
               txtTenLoai.DataBindings.Add(new Binding("Text", dataListLoai.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
               txtMaLoai.DataBindings.Add(new Binding("Text", dataListLoai.DataSource, "MaLoai", true, DataSourceUpdateMode.Never));
          }

          public void AddVacXinBinding()
          {
               txtMaVacxin.DataBindings.Add(new Binding("Text", dtListVacxin.DataSource, "MaVacxin", true, DataSourceUpdateMode.Never));
               txtTenVacxin.DataBindings.Add(new Binding("Text", dtListVacxin.DataSource, "TenVacxin", true, DataSourceUpdateMode.Never));
               txtXuatXu.DataBindings.Add(new Binding("Text", dtListVacxin.DataSource, "XuatXu", true, DataSourceUpdateMode.Never));

          }

          void loadCbbLoaiVaxin(ComboBox cb)
          {
               List<LoaiVacxin> loai = LoaiVacxinDAO.Instance.getListLoaiVacxin();

               cb.DataSource = loai;
               //cb.DataSource = LoaiVacxinDAO.Instance.getDataLoaiVacxin();
               cb.DisplayMember = "TenLoai";
          }

          void loadListNhanVien()
          {
               nhanVien.DataSource = NhanVienDAO.Instance.getListNhanVien();
          }

          void AddNhanVienBinding()
          {
               txtMaNhanVien.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
               txtTenNhanVien.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
               txtQueQuan.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "QueQuan", true, DataSourceUpdateMode.Never));
               TPNgaySinh.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
               TPNgayVaoLam.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "NgayVaoLam", true, DataSourceUpdateMode.Never));
               txtGioiTinh.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
               txtSoDienThoai.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
               txtEmailNhanVien.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "Email", true, DataSourceUpdateMode.Never));
               txtMatKhau.DataBindings.Add(new Binding("Text", dataListNhanVien.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));

          }

         

          List<ChucVu> getChucVu()
          {
               List<ChucVu> list = new List<ChucVu>();
               string query = "SELECT * FROM dbo.ChucVu";
               DataTable data = DataProvider.Instance.ExcuteQuery(query);
               foreach (DataRow item in data.Rows)
               {

                    ChucVu e = new ChucVu(item);

                    list.Add(e);
               }

               return list;
          }
         
          void loadCboChucVu()
          {
               cboChucVu.DataSource = getChucVu();
               cboChucVu.DisplayMember = "TenChucVu";
          }

          private void SplineChartExample(List<ThongKe> ls,List<ThongKeNhap>ls1)
          {
               chart2.Series["Tổng tiền"].Points.Clear();
               chart2.Titles.Clear();
               chart2.Titles.Add("Tiền tiêm thống kê theo Ngày");

               chart1.Series["Tổng tiền"].Points.Clear();
               chart1.Titles.Clear();
               chart1.Titles.Add("Tổng tiền nhập thống kê theo ngày");

               for(int i = 0; i < ls1.Count; i++)
               {
                    chart1.Series["Tổng tiền"].Points.AddXY(ls1[i].NgayNhap.ToString("dd/MM/yyyy"), ls1[i].TongTienNhap);
               }

               
                               
               for(int i = 0; i < ls.Count; i++)
               {
                    chart2.Series["Tổng tiền"].Points.AddXY(ls[i].Ngay1.ToString("dd/MM/yyyy"), ls[i].TongTienTiem);
               }                            
          }

          #endregion

          #region Events


          private void btnThongke_Click(object sender, EventArgs e)
          {
               DateTime d1 = datefrom.Value;
               DateTime d2 = dateTo.Value;
               List<ThongKe> ls=NhanVienDAO.Instance.getThongKe(d1, d2);
               List<ThongKeNhap> ls1 = NhanVienDAO.Instance.getThongKeNhap(d1, d2);
               SplineChartExample(ls,ls1);
              
          }

          private void btnXemLoai_Click(object sender, EventArgs e)
          {
               loadLoaiVacxin();
          }

          private void btnThemLoaiVacxin_Click(object sender, EventArgs e)
          {
               String ma = txtMaLoai.Text;
               String name = txtTenLoai.Text;

               if (LoaiVacxinDAO.Instance.InsertLoaiVacxin(name, ma))
               {
                    MessageBox.Show("Thêm thành công");
                    loadLoaiVacxin();
               }
               else
               {
                    MessageBox.Show("Có lỗi khi thêm");
               }

          }

          private void btnSuaLoaiThuoc_Click(object sender, EventArgs e)
          {

               String ma = txtMaLoai.Text;
               String name = txtTenLoai.Text;
               if (ma.Equals(""))
               {
                    MessageBox.Show("Nhập mã loại mới");
               }
               else if (name.Equals(""))
               {
                    MessageBox.Show("Nhập Tên loại mới");
               }
               else
               {
                    if (LoaiVacxinDAO.Instance.UpdateLoaiVacxin(name, ma))
                    {
                         MessageBox.Show("Sửa thành công");
                         loadLoaiVacxin();
                    }
                    else
                    {
                         MessageBox.Show("Có lỗi khi Sửa");
                    }
               }

          }


          private void dataListLoai_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               //  idLoaiThuoc = dataListLoai.SelectedRows[0].Cells[0].Value.ToString();

          }

          private void btnXoaLoaiVacxin_Click(object sender, EventArgs e)
          {
               String id = txtMaLoai.Text;

               if (LoaiVacxinDAO.Instance.DeleteLoaiVacxin(id))
               {
                    MessageBox.Show("Xóa Thành Công");
                    loadLoaiVacxin();
               }
               else
               {
                    MessageBox.Show("Có lỗi khi xóa");
               }
          }

          private void txtMaVacxin_TextChanged(object sender, EventArgs e)
          {
               if (dtListVacxin.SelectedCells.Count > 0)
               {
                    String id = dtListVacxin.SelectedCells[0].OwningRow.Cells["MaLoai"].Value.ToString();
                    LoaiVacxin loai = LoaiVacxinDAO.Instance.getLoaiVacxinByMa(id);

                    cboLoaiVacxin.SelectedItem = loai;

                    int index = -1;
                    int i = 0;


                    foreach (LoaiVacxin item in cboLoaiVacxin.Items)
                    {

                         if (item.MaLoai == loai.MaLoai)
                         {
                              index = i;
                              break;
                         }

                         i++;
                    }

                    cboLoaiVacxin.SelectedIndex = index;
               }
          }

          private void btnXem_Click(object sender, EventArgs e)
      {
               loadVacxin();
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               String ma = txtMaVacxin.Text;
               String name = txtTenVacxin.Text;
               String xuatxu = txtXuatXu.Text;
               String loai = (cboLoaiVacxin.SelectedItem as LoaiVacxin).MaLoai;


               if (ma.Equals(""))
               {
                    MessageBox.Show("Nhập Mã Vacxin");
               }
               else if (name.Equals(""))
               {
                    MessageBox.Show("Nhập Tên Vacxin");
               }
               else if (xuatxu.Equals(""))
               {
                    MessageBox.Show("Nhập nơi xuất xứ");
               }
               else
               {
                    if (VacxinDAO.Instance.insertVacxin(ma, name, xuatxu, loai))
                    {
                         MessageBox.Show("Thêm thành công");
                         loadLoaiVacxin();
                    }
                    else
                    {
                         MessageBox.Show("Có lỗi khi thêm");
                    }

               }


          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               String id = txtMaVacxin.Text;

               if (VacxinDAO.Instance.DeleteVacxin(id))
               {
                    MessageBox.Show("Xóa Thành Công");
                    loadLoaiVacxin();
               }
               else
               {
                    MessageBox.Show("Có lỗi khi xóa");
               }
          }

          private void btnThoat_Click(object sender, EventArgs e)
          {
               String ma = txtMaVacxin.Text;
               String name = txtTenVacxin.Text;
               String xuatxu = txtXuatXu.Text;
               String loai = (cboLoaiVacxin.SelectedItem as LoaiVacxin).MaLoai;


               if (ma.Equals(""))
               {
                    MessageBox.Show("Nhập Mã Vacxin");
               }
               else if (name.Equals(""))
               {
                    MessageBox.Show("Nhập Tên Vacxin");
               }
               else if (xuatxu.Equals(""))
               {
                    MessageBox.Show("Nhập nơi xuất xứ");
               }
               else
               {
                    if (VacxinDAO.Instance.UpdateVacxin(ma, name, loai, xuatxu))
                    {
                         MessageBox.Show("Sửa thành công");
                         loadLoaiVacxin();
                    }
                    else
                    {
                         MessageBox.Show("Có lỗi khi Sửa");
                    }

               }
          }

          private void btnXemNhanVien_Click(object sender, EventArgs e)
          {
               loadListNhanVien();
          }

          private void btnThemNhanVien_Click(object sender, EventArgs e)
          {
               List<Email> list = NhanVienDAO.Instance.getEmail();

               String gmail = txtEmailNhanVien.Text;
               String ma = txtMaNhanVien.Text;

               foreach (Email email in list)
               {
                    if (gmail.Equals(email.TaiKhoan))
                    {
                         MessageBox.Show("Tài khoản đã tồn tại ");
                         return;
                    }
               }
               foreach(String m in NhanVienDAO.Instance.getListMaNhanVien())
               {
                    if (m.Equals(ma))
                    {
                         MessageBox.Show("Mã Nhân viên đã tồn tại");
                         return;
                    }
               }
               
               String ten = txtTenNhanVien.Text;
               String gt = txtGioiTinh.Text;
               String dt = txtQueQuan.Text;
               String mk = txtMatKhau.Text;
               String ngayVao = TPNgayVaoLam.Value.ToString();
               String ngaySinh = TPNgaySinh.Value.ToString();
               String sdt = txtSoDienThoai.Text;
               String chucVu = (cboChucVu.SelectedItem as ChucVu).MaChucVu;

               NhanVienDAO.Instance.InsertEmail(gmail, mk);

               if (NhanVienDAO.Instance.InsertNhanVien(ma, ten, gmail, dt, ngaySinh, ngayVao, gt, sdt, chucVu))
               {
                    MessageBox.Show("Thêm Thành Công");
               }
               else
               {
                    MessageBox.Show("Lỗi Thêm");
               }


               
              
               
                             
          }

          private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
          {
               if (dataListNhanVien.SelectedCells.Count > 0)
               {                   
                    String id1= dataListNhanVien.SelectedCells[0].OwningRow.Cells["MaChucVu"].Value.ToString();
                    

                    ChucVu cv = NhanVienDAO.Instance.getChucVuByMa(id1);

                   
                    cboChucVu.SelectedItem = cv;

                    
                    int index2 = -1;
                    int i = 0;

                    foreach(ChucVu item in cboChucVu.Items)
                    {
                         if(item.MaChucVu == cv.MaChucVu)
                         {
                              index2 = i;
                              break;
                         }
                         i++;
                    }
              
      
                  
                    cboChucVu.SelectedIndex = index2;
               }
          }

        private void btnTim_Click(object sender, EventArgs e)
        {
              dtListVacxin.DataSource= SearchVacxinByName(txtSearch.Text);
        }

          private void btnOk_Click(object sender, EventArgs e)
          {
               String tenTaiKhoan = txtTenTaiKhoan.Text;
               String mkCu = txtMauKhauCu.Text;
               String mkMoi = txtMatKhauMoi.Text;
               String xacNhanMk = txtXacNhanMatKhau.Text;
               if (tenTaiKhoan.Equals(""))
               {
                    MessageBox.Show("Nhập tên tài khoản");
               }
               else if(mkCu.Equals(""))
               {
                    MessageBox.Show("Nhập Mật Khẩu cũ");
               }
               else if(mkMoi.Equals(""))
               {
                    MessageBox.Show("Nhập Mật Khẩu mới");
               }else if (xacNhanMk.Equals(""))
               {
                    MessageBox.Show("Xác nhận mật khẩu");
               }
               else
               {
                    if (!mkMoi.Equals(xacNhanMk))
                    {
                         MessageBox.Show("Mật khẩu xác nhận không khớp");
                         
                         txtXacNhanMatKhau.Focus();
                         txtXacNhanMatKhau.SelectAll();

                    }
                    else
                    {
                         if (NhanVienDAO.Instance.UpdateThongTinDangNhap(tenTaiKhoan, mkCu, mkMoi))
                         {
                              MessageBox.Show("Update thành công");
                              txtMauKhauCu.Clear();                              
                              txtMatKhauMoi.Clear();
                              txtXacNhanMatKhau.Clear();
                         }
                         else
                         {
                              MessageBox.Show("Kiểm tra lại tên đăng nhập và Mật Khẩu cũ");
                         }
                    }
               }
          }

          private void chart1_Click(object sender, EventArgs e)
          {

          }
     }
     #endregion
}
