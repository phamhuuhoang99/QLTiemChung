namespace Test_Mot_Chut
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbVaccine = new System.Windows.Forms.Label();
            this.btnKhoThuoc = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnKeHoach = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.iconZoomMax = new System.Windows.Forms.PictureBox();
            this.iconZoomMin = new System.Windows.Forms.PictureBox();
            this.iconHide = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnlContain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconZoomMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconZoomMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHide)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbVaccine
            // 
            this.lbVaccine.AutoSize = true;
            this.lbVaccine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVaccine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbVaccine.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVaccine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVaccine.Location = new System.Drawing.Point(45, 19);
            this.lbVaccine.Name = "lbVaccine";
            this.lbVaccine.Size = new System.Drawing.Size(122, 39);
            this.lbVaccine.TabIndex = 2;
            this.lbVaccine.Text = "VACCINE";
            // 
            // btnKhoThuoc
            // 
            this.btnKhoThuoc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKhoThuoc.FlatAppearance.BorderSize = 0;
            this.btnKhoThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoThuoc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoThuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhoThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoThuoc.Image")));
            this.btnKhoThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoThuoc.Location = new System.Drawing.Point(1, 97);
            this.btnKhoThuoc.Name = "btnKhoThuoc";
            this.btnKhoThuoc.Size = new System.Drawing.Size(170, 98);
            this.btnKhoThuoc.TabIndex = 2;
            this.btnKhoThuoc.Text = "    Kho Thuốc";
            this.btnKhoThuoc.UseVisualStyleBackColor = true;
            this.btnKhoThuoc.Click += new System.EventHandler(this.btnKhoThuoc_Click);
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNhapXuat.FlatAppearance.BorderSize = 0;
            this.btnNhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapXuat.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapXuat.Image")));
            this.btnNhapXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapXuat.Location = new System.Drawing.Point(0, 536);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(170, 53);
            this.btnNhapXuat.TabIndex = 3;
            this.btnNhapXuat.Text = "    Bệnh Nhân";
            this.btnNhapXuat.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMenu.Controls.Add(this.btnKeHoach);
            this.pnlMenu.Controls.Add(this.btnNhanVien);
            this.pnlMenu.Controls.Add(this.btnNhapXuat);
            this.pnlMenu.Controls.Add(this.btnKhoThuoc);
            this.pnlMenu.Controls.Add(this.lbVaccine);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 682);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnKeHoach
            // 
            this.btnKeHoach.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKeHoach.FlatAppearance.BorderSize = 0;
            this.btnKeHoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeHoach.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeHoach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKeHoach.Image = ((System.Drawing.Image)(resources.GetObject("btnKeHoach.Image")));
            this.btnKeHoach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeHoach.Location = new System.Drawing.Point(0, 313);
            this.btnKeHoach.Name = "btnKeHoach";
            this.btnKeHoach.Size = new System.Drawing.Size(170, 98);
            this.btnKeHoach.TabIndex = 5;
            this.btnKeHoach.Text = "    Kế Hoạch";
            this.btnKeHoach.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 200);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(170, 98);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "    Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(1169, 3);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(20, 20);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 2;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconZoomMax
            // 
            this.iconZoomMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoomMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconZoomMax.Image = ((System.Drawing.Image)(resources.GetObject("iconZoomMax.Image")));
            this.iconZoomMax.Location = new System.Drawing.Point(1143, 3);
            this.iconZoomMax.Name = "iconZoomMax";
            this.iconZoomMax.Size = new System.Drawing.Size(20, 20);
            this.iconZoomMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconZoomMax.TabIndex = 3;
            this.iconZoomMax.TabStop = false;
            this.iconZoomMax.Click += new System.EventHandler(this.iconZoomMax_Click);
            // 
            // iconZoomMin
            // 
            this.iconZoomMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoomMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconZoomMin.Image = ((System.Drawing.Image)(resources.GetObject("iconZoomMin.Image")));
            this.iconZoomMin.Location = new System.Drawing.Point(1143, 3);
            this.iconZoomMin.Name = "iconZoomMin";
            this.iconZoomMin.Size = new System.Drawing.Size(20, 20);
            this.iconZoomMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconZoomMin.TabIndex = 4;
            this.iconZoomMin.TabStop = false;
            this.iconZoomMin.Visible = false;
            this.iconZoomMin.Click += new System.EventHandler(this.iconZoomMin_Click);
            // 
            // iconHide
            // 
            this.iconHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHide.Image = ((System.Drawing.Image)(resources.GetObject("iconHide.Image")));
            this.iconHide.Location = new System.Drawing.Point(1117, 3);
            this.iconHide.Name = "iconHide";
            this.iconHide.Size = new System.Drawing.Size(20, 20);
            this.iconHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconHide.TabIndex = 5;
            this.iconHide.TabStop = false;
            this.iconHide.Click += new System.EventHandler(this.iconHide_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.iconHide);
            this.pnlControl.Controls.Add(this.iconZoomMin);
            this.pnlControl.Controls.Add(this.iconZoomMax);
            this.pnlControl.Controls.Add(this.iconExit);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(170, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1192, 30);
            this.pnlControl.TabIndex = 1;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            // 
            // btnSlide
            // 
            this.btnSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(170, 0);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(471, 262);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnlContain
            // 
            this.pnlContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContain.Location = new System.Drawing.Point(170, 30);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(1192, 652);
            this.pnlContain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1362, 682);
            this.Controls.Add(this.pnlContain);
            this.Controls.Add(this.btnSlide);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconZoomMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconZoomMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHide)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbVaccine;
        private System.Windows.Forms.Button btnKhoThuoc;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.PictureBox iconZoomMax;
        private System.Windows.Forms.PictureBox iconZoomMin;
        private System.Windows.Forms.PictureBox iconHide;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel pnlContain;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKeHoach;
    }
}