namespace QuanLyThuVien
{
    partial class fQuanLyThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyThuVien));
            this.menuQLTV = new System.Windows.Forms.MenuStrip();
            this.menuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaQLTV = new System.Windows.Forms.Button();
            this.btnSuaQLTV = new System.Windows.Forms.Button();
            this.btnXemQLTV = new System.Windows.Forms.Button();
            this.btnThemQLTV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbTimQLTV = new System.Windows.Forms.TextBox();
            this.btnTimQLTV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvQLTV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbTinhTrangQLTV = new System.Windows.Forms.TextBox();
            this.lbTinhTrangQLTV = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbTacGiaQLTV = new System.Windows.Forms.TextBox();
            this.lbTacGiaQLTV = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbTheLoaiQLTV = new System.Windows.Forms.TextBox();
            this.lbTheLoaiQLTV = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbTenSachQLTV = new System.Windows.Forms.TextBox();
            this.lbTenSachQLTV = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbMaSachQLTV = new System.Windows.Forms.TextBox();
            this.lbMaSachQLTV = new System.Windows.Forms.Label();
            this.menuQLTV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQLTV
            // 
            this.menuQLTV.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuQLTV.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuQLTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChiTiet,
            this.menuTaiKhoan});
            this.menuQLTV.Location = new System.Drawing.Point(0, 0);
            this.menuQLTV.Name = "menuQLTV";
            this.menuQLTV.Size = new System.Drawing.Size(1216, 33);
            this.menuQLTV.TabIndex = 0;
            this.menuQLTV.Text = "menuStrip1";
            // 
            // menuChiTiet
            // 
            this.menuChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuChiTiet.Name = "menuChiTiet";
            this.menuChiTiet.Size = new System.Drawing.Size(83, 29);
            this.menuChiTiet.Text = "Chi tiết";
            this.menuChiTiet.Click += new System.EventHandler(this.menuChiTiet_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTTCN,
            this.menuDangXuat});
            this.menuTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(102, 29);
            this.menuTaiKhoan.Text = "Tài khoản";
            // 
            // menuTTCN
            // 
            this.menuTTCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuTTCN.Name = "menuTTCN";
            this.menuTTCN.Size = new System.Drawing.Size(256, 34);
            this.menuTTCN.Text = "Thông tin cá nhân";
            this.menuTTCN.Click += new System.EventHandler(this.menuThongTinCaNhan_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(256, 34);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaQLTV);
            this.panel1.Controls.Add(this.btnSuaQLTV);
            this.panel1.Controls.Add(this.btnXemQLTV);
            this.panel1.Controls.Add(this.btnThemQLTV);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnXoaQLTV
            // 
            this.btnXoaQLTV.Location = new System.Drawing.Point(79, 19);
            this.btnXoaQLTV.Name = "btnXoaQLTV";
            this.btnXoaQLTV.Size = new System.Drawing.Size(70, 46);
            this.btnXoaQLTV.TabIndex = 5;
            this.btnXoaQLTV.Text = "Xóa";
            this.btnXoaQLTV.UseVisualStyleBackColor = true;
            this.btnXoaQLTV.Click += new System.EventHandler(this.btnXoaQLTV_Click);
            // 
            // btnSuaQLTV
            // 
            this.btnSuaQLTV.Location = new System.Drawing.Point(225, 19);
            this.btnSuaQLTV.Name = "btnSuaQLTV";
            this.btnSuaQLTV.Size = new System.Drawing.Size(65, 46);
            this.btnSuaQLTV.TabIndex = 7;
            this.btnSuaQLTV.Text = "Sửa";
            this.btnSuaQLTV.UseVisualStyleBackColor = true;
            this.btnSuaQLTV.Click += new System.EventHandler(this.btnSuaQLTV_Click);
            // 
            // btnXemQLTV
            // 
            this.btnXemQLTV.Location = new System.Drawing.Point(154, 19);
            this.btnXemQLTV.Name = "btnXemQLTV";
            this.btnXemQLTV.Size = new System.Drawing.Size(65, 46);
            this.btnXemQLTV.TabIndex = 6;
            this.btnXemQLTV.Text = "Xem";
            this.btnXemQLTV.UseVisualStyleBackColor = true;
            this.btnXemQLTV.Click += new System.EventHandler(this.btnXemQLTV_Click);
            // 
            // btnThemQLTV
            // 
            this.btnThemQLTV.Location = new System.Drawing.Point(3, 19);
            this.btnThemQLTV.Name = "btnThemQLTV";
            this.btnThemQLTV.Size = new System.Drawing.Size(70, 46);
            this.btnThemQLTV.TabIndex = 4;
            this.btnThemQLTV.Text = "Thêm";
            this.btnThemQLTV.UseVisualStyleBackColor = true;
            this.btnThemQLTV.Click += new System.EventHandler(this.btnThemQLTV_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 93);
            this.panel3.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbTimQLTV);
            this.panel11.Controls.Add(this.btnTimQLTV);
            this.panel11.Location = new System.Drawing.Point(914, 48);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(290, 81);
            this.panel11.TabIndex = 2;
            // 
            // txbTimQLTV
            // 
            this.txbTimQLTV.Location = new System.Drawing.Point(12, 28);
            this.txbTimQLTV.Name = "txbTimQLTV";
            this.txbTimQLTV.Size = new System.Drawing.Size(204, 26);
            this.txbTimQLTV.TabIndex = 9;
            // 
            // btnTimQLTV
            // 
            this.btnTimQLTV.Location = new System.Drawing.Point(222, 19);
            this.btnTimQLTV.Name = "btnTimQLTV";
            this.btnTimQLTV.Size = new System.Drawing.Size(65, 46);
            this.btnTimQLTV.TabIndex = 8;
            this.btnTimQLTV.Text = "Tìm";
            this.btnTimQLTV.UseVisualStyleBackColor = true;
            this.btnTimQLTV.Click += new System.EventHandler(this.btnTimQLTV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvQLTV);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 328);
            this.panel2.TabIndex = 4;
            // 
            // dtgvQLTV
            // 
            this.dtgvQLTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLTV.Location = new System.Drawing.Point(3, 3);
            this.dtgvQLTV.Name = "dtgvQLTV";
            this.dtgvQLTV.ReadOnly = true;
            this.dtgvQLTV.RowHeadersWidth = 62;
            this.dtgvQLTV.RowTemplate.Height = 28;
            this.dtgvQLTV.Size = new System.Drawing.Size(846, 322);
            this.dtgvQLTV.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(914, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 328);
            this.panel4.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbTinhTrangQLTV);
            this.panel10.Controls.Add(this.lbTinhTrangQLTV);
            this.panel10.Location = new System.Drawing.Point(4, 241);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(277, 51);
            this.panel10.TabIndex = 10;
            // 
            // txbTinhTrangQLTV
            // 
            this.txbTinhTrangQLTV.Location = new System.Drawing.Point(116, 5);
            this.txbTinhTrangQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTinhTrangQLTV.Name = "txbTinhTrangQLTV";
            this.txbTinhTrangQLTV.Size = new System.Drawing.Size(149, 26);
            this.txbTinhTrangQLTV.TabIndex = 1;
            // 
            // lbTinhTrangQLTV
            // 
            this.lbTinhTrangQLTV.AutoSize = true;
            this.lbTinhTrangQLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangQLTV.Location = new System.Drawing.Point(4, 5);
            this.lbTinhTrangQLTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTinhTrangQLTV.Name = "lbTinhTrangQLTV";
            this.lbTinhTrangQLTV.Size = new System.Drawing.Size(117, 25);
            this.lbTinhTrangQLTV.TabIndex = 0;
            this.lbTinhTrangQLTV.Text = "Tình trạng:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbTacGiaQLTV);
            this.panel9.Controls.Add(this.lbTacGiaQLTV);
            this.panel9.Location = new System.Drawing.Point(4, 190);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(277, 51);
            this.panel9.TabIndex = 9;
            // 
            // txbTacGiaQLTV
            // 
            this.txbTacGiaQLTV.Location = new System.Drawing.Point(116, 5);
            this.txbTacGiaQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTacGiaQLTV.Name = "txbTacGiaQLTV";
            this.txbTacGiaQLTV.Size = new System.Drawing.Size(149, 26);
            this.txbTacGiaQLTV.TabIndex = 1;
            // 
            // lbTacGiaQLTV
            // 
            this.lbTacGiaQLTV.AutoSize = true;
            this.lbTacGiaQLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGiaQLTV.Location = new System.Drawing.Point(4, 5);
            this.lbTacGiaQLTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTacGiaQLTV.Name = "lbTacGiaQLTV";
            this.lbTacGiaQLTV.Size = new System.Drawing.Size(91, 25);
            this.lbTacGiaQLTV.TabIndex = 0;
            this.lbTacGiaQLTV.Text = "Tác giả:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbTheLoaiQLTV);
            this.panel8.Controls.Add(this.lbTheLoaiQLTV);
            this.panel8.Location = new System.Drawing.Point(4, 139);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 51);
            this.panel8.TabIndex = 8;
            // 
            // txbTheLoaiQLTV
            // 
            this.txbTheLoaiQLTV.Location = new System.Drawing.Point(116, 5);
            this.txbTheLoaiQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTheLoaiQLTV.Name = "txbTheLoaiQLTV";
            this.txbTheLoaiQLTV.Size = new System.Drawing.Size(149, 26);
            this.txbTheLoaiQLTV.TabIndex = 1;
            // 
            // lbTheLoaiQLTV
            // 
            this.lbTheLoaiQLTV.AutoSize = true;
            this.lbTheLoaiQLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoaiQLTV.Location = new System.Drawing.Point(4, 5);
            this.lbTheLoaiQLTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTheLoaiQLTV.Name = "lbTheLoaiQLTV";
            this.lbTheLoaiQLTV.Size = new System.Drawing.Size(97, 25);
            this.lbTheLoaiQLTV.TabIndex = 0;
            this.lbTheLoaiQLTV.Text = "Thể loại:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbTenSachQLTV);
            this.panel7.Controls.Add(this.lbTenSachQLTV);
            this.panel7.Location = new System.Drawing.Point(4, 88);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(277, 51);
            this.panel7.TabIndex = 7;
            // 
            // txbTenSachQLTV
            // 
            this.txbTenSachQLTV.Location = new System.Drawing.Point(116, 5);
            this.txbTenSachQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenSachQLTV.Name = "txbTenSachQLTV";
            this.txbTenSachQLTV.Size = new System.Drawing.Size(149, 26);
            this.txbTenSachQLTV.TabIndex = 1;
            // 
            // lbTenSachQLTV
            // 
            this.lbTenSachQLTV.AutoSize = true;
            this.lbTenSachQLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSachQLTV.Location = new System.Drawing.Point(4, 5);
            this.lbTenSachQLTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSachQLTV.Name = "lbTenSachQLTV";
            this.lbTenSachQLTV.Size = new System.Drawing.Size(109, 25);
            this.lbTenSachQLTV.TabIndex = 0;
            this.lbTenSachQLTV.Text = "Tên sách:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbMaSachQLTV);
            this.panel6.Controls.Add(this.lbMaSachQLTV);
            this.panel6.Location = new System.Drawing.Point(4, 37);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 51);
            this.panel6.TabIndex = 6;
            // 
            // txbMaSachQLTV
            // 
            this.txbMaSachQLTV.Location = new System.Drawing.Point(116, 5);
            this.txbMaSachQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaSachQLTV.Name = "txbMaSachQLTV";
            this.txbMaSachQLTV.ReadOnly = true;
            this.txbMaSachQLTV.Size = new System.Drawing.Size(149, 26);
            this.txbMaSachQLTV.TabIndex = 1;
            // 
            // lbMaSachQLTV
            // 
            this.lbMaSachQLTV.AutoSize = true;
            this.lbMaSachQLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSachQLTV.Location = new System.Drawing.Point(4, 5);
            this.lbMaSachQLTV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSachQLTV.Name = "lbMaSachQLTV";
            this.lbMaSachQLTV.Size = new System.Drawing.Size(101, 25);
            this.lbMaSachQLTV.TabIndex = 0;
            this.lbMaSachQLTV.Text = "Mã sách:";
            // 
            // fQuanLyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuQLTV);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuQLTV;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fQuanLyThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Thư Viện";
            this.menuQLTV.ResumeLayout(false);
            this.menuQLTV.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQLTV;
        private System.Windows.Forms.ToolStripMenuItem menuChiTiet;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuTTCN;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaQLTV;
        private System.Windows.Forms.Button btnSuaQLTV;
        private System.Windows.Forms.Button btnXemQLTV;
        private System.Windows.Forms.Button btnThemQLTV;
        private System.Windows.Forms.TextBox txbTimQLTV;
        private System.Windows.Forms.Button btnTimQLTV;
        private System.Windows.Forms.DataGridView dtgvQLTV;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbTinhTrangQLTV;
        private System.Windows.Forms.Label lbTinhTrangQLTV;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbTacGiaQLTV;
        private System.Windows.Forms.Label lbTacGiaQLTV;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbTheLoaiQLTV;
        private System.Windows.Forms.Label lbTheLoaiQLTV;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbTenSachQLTV;
        private System.Windows.Forms.Label lbTenSachQLTV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbMaSachQLTV;
        private System.Windows.Forms.Label lbMaSachQLTV;
    }
}