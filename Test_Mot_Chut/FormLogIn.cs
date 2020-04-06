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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        #region Khi nhap, tha chuot vao cac o Text: Enter la nhan vao, Leave la tha chuot ra
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Password";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "")
            {
                txtDangNhap.Text = "Username";
            }
        }

        #endregion 

       
        
         
        // Nhan vao link dang ki (New Register) hien bang dang ki (Sign Up)
        private void linkLBNewRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp form3 = new FormSignUp();
            form3.ShowDialog();
        }

        // Kiem tra xem trong bang SQL co thong tin phu hop voi cac o Text vua nhap k 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection("Data Source=DESKTOP-PS6R480;Initial Catalog=QuanLiTiemChung;Integrated Security=True");
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from DangNhap where tenDangNhap = '"+txtDangNhap.Text+"' and matKhau = '"+txtMatKhau.Text+"'",cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //int dem = 0;
            //while(dr.Read())
            //{
            //    dem += 1;
            //}

            //if (dem == 1)
            //{
                //MessageBox.Show("Ok");
               // this.Hide();
                FormMain fMain = new FormMain();
                fMain.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Ten dang nhap hoac mat khau sai !");
            //}
            //dr.Close();
        }

        bool Login(string userName,string passWord)
        {
            return true;
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
