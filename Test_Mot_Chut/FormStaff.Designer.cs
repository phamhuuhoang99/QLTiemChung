namespace Test_Mot_Chut
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.clmnMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnmaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.clmnChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnSua = new System.Windows.Forms.Button();
               this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
               this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
               this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.panel1.SuspendLayout();
               this.metroTabControl1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnMaNV,
            this.clmnHoTen,
            this.clmnNgaySinh,
            this.clmnGioiTinh,
            this.clmnQueQuan,
            this.clmnmaPB,
            this.clmnSDT,
            this.clmnChucVu});
               this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dataGridView1.Location = new System.Drawing.Point(0, 0);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(1114, 650);
               this.dataGridView1.TabIndex = 1;
               // 
               // clmnMaNV
               // 
               this.clmnMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnMaNV.HeaderText = "Ma Nhan Vien";
               this.clmnMaNV.Name = "clmnMaNV";
               // 
               // clmnHoTen
               // 
               this.clmnHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnHoTen.HeaderText = "Ho va Ten";
               this.clmnHoTen.Name = "clmnHoTen";
               // 
               // clmnNgaySinh
               // 
               this.clmnNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnNgaySinh.HeaderText = "Ngay Sinh";
               this.clmnNgaySinh.Name = "clmnNgaySinh";
               // 
               // clmnGioiTinh
               // 
               this.clmnGioiTinh.HeaderText = "Gioi Tinh";
               this.clmnGioiTinh.Name = "clmnGioiTinh";
               // 
               // clmnQueQuan
               // 
               this.clmnQueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnQueQuan.HeaderText = "Que Quan";
               this.clmnQueQuan.Name = "clmnQueQuan";
               // 
               // clmnmaPB
               // 
               this.clmnmaPB.HeaderText = "Ma Phong Ban";
               this.clmnmaPB.Name = "clmnmaPB";
               // 
               // clmnSDT
               // 
               this.clmnSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnSDT.HeaderText = "So Dien Thoai";
               this.clmnSDT.Name = "clmnSDT";
               // 
               // clmnChucVu
               // 
               this.clmnChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.clmnChucVu.HeaderText = "Chuc Vu";
               this.clmnChucVu.Name = "clmnChucVu";
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.btnSua);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel1.Location = new System.Drawing.Point(0, 560);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1114, 90);
               this.panel1.TabIndex = 2;
               // 
               // btnSua
               // 
               this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
               this.btnSua.FlatAppearance.BorderSize = 0;
               this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnSua.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.btnSua.Location = new System.Drawing.Point(517, 28);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(72, 31);
               this.btnSua.TabIndex = 0;
               this.btnSua.Text = "Sua ";
               this.btnSua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               this.btnSua.UseVisualStyleBackColor = false;
               // 
               // metroTabControl1
               // 
               this.metroTabControl1.Controls.Add(this.metroTabPage1);
               this.metroTabControl1.Controls.Add(this.metroTabPage2);
               this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.metroTabControl1.Location = new System.Drawing.Point(0, 305);
               this.metroTabControl1.Name = "metroTabControl1";
               this.metroTabControl1.SelectedIndex = 1;
               this.metroTabControl1.Size = new System.Drawing.Size(1114, 255);
               this.metroTabControl1.TabIndex = 3;
               this.metroTabControl1.UseSelectable = true;
               // 
               // metroTabPage1
               // 
               this.metroTabPage1.HorizontalScrollbarBarColor = true;
               this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
               this.metroTabPage1.HorizontalScrollbarSize = 10;
               this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
               this.metroTabPage1.Name = "metroTabPage1";
               this.metroTabPage1.Size = new System.Drawing.Size(192, 58);
               this.metroTabPage1.TabIndex = 0;
               this.metroTabPage1.Text = "metroTabPage1";
               this.metroTabPage1.VerticalScrollbarBarColor = true;
               this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
               this.metroTabPage1.VerticalScrollbarSize = 10;
               // 
               // metroTabPage2
               // 
               this.metroTabPage2.HorizontalScrollbarBarColor = true;
               this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
               this.metroTabPage2.HorizontalScrollbarSize = 10;
               this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
               this.metroTabPage2.Name = "metroTabPage2";
               this.metroTabPage2.Size = new System.Drawing.Size(1106, 213);
               this.metroTabPage2.TabIndex = 1;
               this.metroTabPage2.Text = "metroTabPage2";
               this.metroTabPage2.VerticalScrollbarBarColor = true;
               this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
               this.metroTabPage2.VerticalScrollbarSize = 10;
               // 
               // FormStaff
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientSize = new System.Drawing.Size(1114, 650);
               this.Controls.Add(this.metroTabControl1);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.dataGridView1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormStaff";
               this.Text = "FormStaff";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.panel1.ResumeLayout(false);
               this.metroTabControl1.ResumeLayout(false);
               this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnmaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnChucVu;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}