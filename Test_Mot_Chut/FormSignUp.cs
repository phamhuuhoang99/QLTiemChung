using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Mot_Chut
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        #region Nhap,tha chuot vao cac o Text: Enter: nhap chuot vao thi mat chu co san, Leave: tha chuot ra thi chu co san lai hien ra
        private void txtDangNhap_Enter(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }

        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "")
            {
                txtDangNhap.Text = "Ten Dang Nhap";
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mat Khau";
            }
        }

        private void txtHoVaTen_Enter(object sender, EventArgs e)
        {
            txtHoVaTen.Text = "";
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                txtHoVaTen.Text = "Ho va Ten";
            }
        }

        

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "")
            {
                txtQueQuan.Text = "Que Quan";
            }
        }

        private void txtQueQuan_Enter(object sender, EventArgs e)
        {
            txtQueQuan.Text = "";
        }

        private void txtNgaySinh_Enter(object sender, EventArgs e)
        {
            txtNgaySinh.Text = "";
        }

        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Text = "Ngay Sinh";
            }
        }


        private void txtSDT_Enter(object sender, EventArgs e)
        {
            txtSDT.Text = "";
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "So Dien Thoai";
            }
        }

        private void txtChucVu_Enter(object sender, EventArgs e)
        {
            txtChucVu.Text = "";
        }

        private void txtChucVu_Leave(object sender, EventArgs e)
        {
            if (txtChucVu.Text == "")
            {
                txtChucVu.Text = "Chuc Vu";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                txtMaNV.Text = "Ma Nhan Vien";
            }
        }
        #endregion





        // Them thong tin cac o Text vao bang SQL 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "Ten Dang Nhap" || txtMatKhau.Text == "Mat Khau" || txtHoVaTen.Text == "Ho va Ten" || txtMaNV.Text == "Ma Nhan Vien")
            {
                MessageBox.Show("Dien day du nhung muc co dau *");
            }

            int dem_TenDangNhap = 0;
            int dem_MaNV = 0;
            int dem_SDT = 0;
            int dem_Email = 0;
            
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-PS6R480;Initial Catalog=QuanLiTiemChung;Integrated Security=True");
            cn.Open();
            SqlCommand cmd_CheckTenDangNhap = new SqlCommand("select * from DangNhap where tenDangNhap = '" + txtDangNhap.Text + "'", cn);
            SqlCommand cmd_CheckMaNV = new SqlCommand("select * from NhanVien where maNV = '" + txtMaNV.Text + "'", cn);
            SqlCommand cmd_CheckSDT = new SqlCommand("select * from NhanVien where sdt = '" + txtSDT.Text + "'", cn);
            SqlCommand cmd_CheckEmail = new SqlCommand("select * from NhanVien where email = '" + txtEmail.Text + "'", cn);
            SqlDataReader dr_CheckTenDangNhap;
            SqlDataReader dr_CheckMaNV;
            SqlDataReader dr_CheckSDT;
            SqlDataReader dr_CheckEmail;
            dr_CheckTenDangNhap = cmd_CheckTenDangNhap.ExecuteReader();
            while (dr_CheckTenDangNhap.Read())
            {
                dem_TenDangNhap += 1;
            }
            if (dem_TenDangNhap >= 1) MessageBox.Show("Ten Dang Nhap da duoc dang ki");
            //cmd_CheckTenDangNhap.Cancel();
            dr_CheckTenDangNhap.Close();

            dr_CheckMaNV = cmd_CheckMaNV.ExecuteReader();
            while (dr_CheckMaNV.Read())
            {
                dem_MaNV += 1;
            }
            if (dem_MaNV >= 1) MessageBox.Show("Ma nhan vien da duoc dang ki");
            //cmd_CheckMaNV.Cancel();
            dr_CheckMaNV.Close();

            dr_CheckSDT = cmd_CheckSDT.ExecuteReader();
            while (dr_CheckSDT.Read())
            {
                dem_SDT += 1;
            }
            if (dem_SDT >= 1) MessageBox.Show("So dien thoai da duoc dang ki");
            //cmd_CheckSDT.Cancel();
            dr_CheckSDT.Close();

            dr_CheckEmail = cmd_CheckEmail.ExecuteReader();
            while (dr_CheckEmail.Read())
            {
                dem_Email += 1;
            }
            if (dem_Email >= 1) MessageBox.Show("Email da duoc dang ki");
            dr_CheckEmail.Close();

            cn.Close();

            cn.Open();

            String qry_1 = "insert into DangNhap (tenDangNhap,matKhau) values ('"+txtDangNhap.Text+"','"+txtMatKhau.Text+"')";
            SqlCommand cmd_1 = new SqlCommand(qry_1, cn);
            cmd_1.ExecuteNonQuery();
            String qry_2 = "insert into NhanVien (maNV ,hoTen ,ngaySinh ,gioiTinh ,queQuan ,sdt ,chucVu, email) values ('" + txtMaNV.Text + "',N'" + txtHoVaTen.Text + "','" + txtNgaySinh.Text + "','" + cbxGioiTinh.Text + "',N'" + txtQueQuan.Text + "','" + txtSDT.Text + "','" + txtChucVu.Text + "','" + txtEmail.Text + "')";
            SqlCommand cmd_2= new SqlCommand(qry_2, cn);
            cmd_2.ExecuteNonQuery();
            MessageBox.Show("Successful");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
