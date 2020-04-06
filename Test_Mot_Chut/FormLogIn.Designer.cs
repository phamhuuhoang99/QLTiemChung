namespace Test_Mot_Chut
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLBNewRegis = new System.Windows.Forms.LinkLabel();
            this.linkLBForgotPassw = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTurnOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng Nhập";
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.FlatAppearance.BorderSize = 0;
            this.btnTurnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTurnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnOff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTurnOff.Location = new System.Drawing.Point(295, 12);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(34, 30);
            this.btnTurnOff.TabIndex = 1;
            this.btnTurnOff.Text = "X";
            this.btnTurnOff.UseVisualStyleBackColor = true;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDangNhap.Location = new System.Drawing.Point(36, 3);
            this.txtDangNhap.Multiline = true;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(223, 30);
            this.txtDangNhap.TabIndex = 1;
            this.txtDangNhap.Text = "Ten Dang Nhap";
            this.txtDangNhap.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtDangNhap.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMatKhau.Location = new System.Drawing.Point(36, 3);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(223, 30);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "Mat Khau";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(82, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtDangNhap);
            this.panel2.Location = new System.Drawing.Point(45, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 35);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Location = new System.Drawing.Point(45, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 32);
            this.panel3.TabIndex = 8;
            // 
            // linkLBNewRegis
            // 
            this.linkLBNewRegis.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLBNewRegis.AutoSize = true;
            this.linkLBNewRegis.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLBNewRegis.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLBNewRegis.Location = new System.Drawing.Point(146, 350);
            this.linkLBNewRegis.Name = "linkLBNewRegis";
            this.linkLBNewRegis.Size = new System.Drawing.Size(75, 19);
            this.linkLBNewRegis.TabIndex = 11;
            this.linkLBNewRegis.TabStop = true;
            this.linkLBNewRegis.Text = "Đăng Ký";
            this.linkLBNewRegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLBNewRegis_LinkClicked);
            // 
            // linkLBForgotPassw
            // 
            this.linkLBForgotPassw.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLBForgotPassw.AutoSize = true;
            this.linkLBForgotPassw.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLBForgotPassw.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLBForgotPassw.Location = new System.Drawing.Point(191, 249);
            this.linkLBForgotPassw.Name = "linkLBForgotPassw";
            this.linkLBForgotPassw.Size = new System.Drawing.Size(118, 16);
            this.linkLBForgotPassw.TabIndex = 12;
            this.linkLBForgotPassw.TabStop = true;
            this.linkLBForgotPassw.Text = "Quên Mật Khẩu ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hoặc";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(341, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLBForgotPassw);
            this.Controls.Add(this.linkLBNewRegis);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTurnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLBNewRegis;
        private System.Windows.Forms.LinkLabel linkLBForgotPassw;
        private System.Windows.Forms.Label label2;
    }
}