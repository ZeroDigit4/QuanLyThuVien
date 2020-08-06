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
    public partial class fQuanLyThuVien : Form
    {


        private DTO.AccountDTO loginAccount;

        public AccountDTO LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); } 
        }

        public fQuanLyThuVien(DTO.AccountDTO acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(string type)
        {
            
            menuTaiKhoan.Text += " (" + loginAccount.DisplayName + ")";       
        }

        private void menuChiTiet_Click(object sender, EventArgs e)
        {
            DTO.AccountDTO loginAccount = DAO.AccountDAO.Instance.GetAccount(fDangNhap.userName);
            fChiTiet f = new fChiTiet(loginAccount);
            f.ShowDialog();
        }

        private void menuThongTinCaNhan_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan f = new fThongTinCaNhan(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            menuTaiKhoan.Text = "Tài khoản (" + e.Acc.DisplayName + ")";
        }
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadQLTV()
        {
            dtgvQLTV.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("SELECT id as MaSach, TenSach, TheLoai, TacGia, TinhTrang FROM Sach");
        }


        void QLTVBinding()
        {
            txbMaSachQLTV.DataBindings.Clear();
            txbMaSachQLTV.DataBindings.Add(new Binding("Text", dtgvQLTV.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbTenSachQLTV.DataBindings.Clear();
            txbTenSachQLTV.DataBindings.Add(new Binding("Text", dtgvQLTV.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txbTheLoaiQLTV.DataBindings.Clear();
            txbTheLoaiQLTV.DataBindings.Add(new Binding("Text", dtgvQLTV.DataSource, "TheLoai", true, DataSourceUpdateMode.Never));
            txbTacGiaQLTV.DataBindings.Clear();
            txbTacGiaQLTV.DataBindings.Add(new Binding("Text", dtgvQLTV.DataSource, "TacGia", true, DataSourceUpdateMode.Never));
            txbTinhTrangQLTV.DataBindings.Clear();
            txbTinhTrangQLTV.DataBindings.Add(new Binding("Text", dtgvQLTV.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            
        }

        private void btnXemQLTV_Click(object sender, EventArgs e)
        {
            LoadQLTV();
            QLTVBinding();
        }

        private void btnThemQLTV_Click(object sender, EventArgs e)
        {
            if(DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO Sach(TenSach, TheLoai, TacGia, TinhTrang) VALUES (N'" + txbTenSachQLTV.Text + "', N'" + txbTheLoaiQLTV.Text + "', N'" + txbTacGiaQLTV.Text + "', N'" + txbTinhTrangQLTV.Text + "')") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadQLTV();
                QLTVBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaQLTV_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE Sach SET TenSach = N'" + txbTenSachQLTV.Text + "', TheLoai = N'" + txbTheLoaiQLTV.Text + "',TacGia =  N'" + txbTacGiaQLTV.Text + "', TinhTrang = N'" + txbTinhTrangQLTV.Text + "' where id = " + txbMaSachQLTV.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadQLTV();
                QLTVBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaQLTV_Click(object sender, EventArgs e)
        {

            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM Sach WHERE id = " + txbMaSachQLTV.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadQLTV();
                    QLTVBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
           
        }

        void LoadTimQLTV()
        {
            dtgvQLTV.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("SELECT id as MaSach, TenSach, TheLoai, TacGia, TinhTrang FROM Sach where TenSach like '%" + txbTimQLTV.Text + "%'");
        }
        private void btnTimQLTV_Click(object sender, EventArgs e)
        {

                    LoadTimQLTV();
                    QLTVBinding();

        }
    }
}
