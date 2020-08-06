using QuanLyThuVien.DTO;
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
    public partial class fThongTinCaNhan : Form
    {
        private DTO.AccountDTO loginAccount;

        public DTO.AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fThongTinCaNhan(DTO.AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(DTO.AccountDTO acc)
        {
            txbTenDangNhapTTCN.Text = LoginAccount.UserName;
            txbTenHienThiTTCN.Text = LoginAccount.DisplayName;           
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        void UpdateAccountInfo()
        {
            string displayName = txbTenHienThiTTCN.Text;
            string passWord = txbMatKhauTTCN.Text;
            string newPassWord = txbMatKhauMoiTTCN.Text;
            string reenterPass = txbNhapLaiTTCN.Text;
            string userName = txbTenDangNhapTTCN.Text;
            if (!newPassWord.Equals(reenterPass)) 
            {
                MessageBox.Show("Xin vui lòng nhập lại mật khẩu trùng với mật khẩu mới!");
            }
            else 
            { 
                if(DAO.AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPassWord))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if(updateAccount!=null)
                    {
                        updateAccount(this, new AccountEvent(DAO.AccountDAO.Instance.GetAccount(userName)));
                    }    
                }    
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu!");
                }    
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }

    public class AccountEvent:EventArgs
    {
        private DTO.AccountDTO acc;

        public AccountDTO Acc 
        {
            get { return acc; }
            set { acc = value; } 
        }
        public AccountEvent(DTO.AccountDTO acc)
        {
            this.Acc = acc;
        }
    }
}
