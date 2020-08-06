using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string userName;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string UserName = txbDangNhap.Text;
            string PassWord = txbMatKhau.Text;
            if (DangNhap(UserName, PassWord))
            {
                userName = txbDangNhap.Text;
                DTO.AccountDTO loginAccount = DAO.AccountDAO.Instance.GetAccount(UserName);
                fQuanLyThuVien f = new fQuanLyThuVien(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }    
        }
        bool DangNhap(string UserName, string PassWord)
        {
            return DAO.AccountDAO.Instance.DangNhap(UserName, PassWord);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true; 
        }
    }
}
