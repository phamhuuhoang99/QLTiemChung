using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Test_Mot_Chut
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wsmg, int wparam, int lparam);


        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

      

        private void iconZoomMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconZoomMin.Visible = true;
            iconZoomMax.Visible = false;
        }

        private void iconZoomMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconZoomMin.Visible = false;
            iconZoomMax.Visible = true;
        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 170)
            {
                pnlMenu.Width = 58;
                btnSlide.Location = new Point(60, 1);
                lbVaccine.Visible = false;

                //pnlControl.Width = 819;
            }
            else
            {
                pnlMenu.Width = 170;
                btnSlide.Location = new Point(170, 0);
                lbVaccine.Visible = true;
                //pnlControl.Width = 661;
            }
            
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // di chuot de di chuyen
        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // mo 1 form tren 1 panel
        private void openFormInPanel(object FormChild)
        {
            // neu panelContain dang chua cai gi thi xoa di de hien thi form moi len
            if (this.pnlContain.Controls.Count > 0)
            {
                this.pnlContain.Controls.RemoveAt(0);
            }
            Form fc = FormChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.pnlContain.Controls.Add(fc);
            this.pnlContain.Tag = fc;
            fc.Show();
        }

        private void btnKhoThuoc_Click(object sender, EventArgs e)
        {
            openFormInPanel(new FormDrugStore());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openFormInPanel(new FormStaff());
        }
    }
}
