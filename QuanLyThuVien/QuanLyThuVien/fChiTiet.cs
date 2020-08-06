using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.DTO;
using System.Activities.Expressions;

namespace QuanLyThuVien
{
    public partial class fChiTiet : Form
    {

        private DTO.AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }


        public fChiTiet(DTO.AccountDTO acc)
        {
            InitializeComponent();           
            this.LoginAccount = acc;
        }

        void ChangeAccount(string type)
        {
            tabHoSoNhanVien.Enabled = type == "Ban giám đốc";
            tabTheDocGia.Enabled = ((type == "Ban giám đốc") || (type == "Thủ thư"));
            tabThongTinSach.Enabled = ((type == "Ban giám đốc") || (type == "Thủ kho"));
            tabPhieuThuTienPhat.Enabled = ((type == "Ban giám đốc") || (type == "Thủ quỹ"));
            tabGhiNhanMatSach.Enabled = ((type == "Ban giám đốc") || (type == "Thủ thư"));
            tabThanhLySach.Enabled = ((type == "Ban giám đốc") || (type == "Thủ kho"));
        }


        void LoadHSNV()
        {
            dtgvHSNV.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("SELECT id as MaNhanVien, HoTen, NgaySinh, BangCap, ChucVu, DiaChi, BoPhan, DienThoai=RIGHT('0000000000' + CONVERT(VARCHAR,DienThoai), 10)  FROM NhanVien ");       
        }


        void HSNVBinding()
        {
            txbMaNhanVienHSNV.DataBindings.Clear();
            txbMaNhanVienHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
            txbHoVaTenHSNV.DataBindings.Clear();
            txbHoVaTenHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txbNgaySinhHSNV.DataBindings.Clear();
            txbNgaySinhHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txbBangCapHSNV.DataBindings.Clear();
            txbBangCapHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "BangCap", true, DataSourceUpdateMode.Never));
            txbChucVuHSNV.DataBindings.Clear();
            txbChucVuHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
            txbDiaChiHSNV.DataBindings.Clear();
            txbDiaChiHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbDienThoaiHSNV.DataBindings.Clear();
            txbDienThoaiHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "DienThoai", true, DataSourceUpdateMode.Never));
            txbBoPhanHSNV.DataBindings.Clear();
            txbBoPhanHSNV.DataBindings.Add(new Binding("Text", dtgvHSNV.DataSource, "BoPhan", true, DataSourceUpdateMode.Never));
        }

        void LoadTTS()
        {
            dtgvTTS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select s.id as MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, n.HoTen as NguoiTiepNhan from Sach s, NhanVien n where n.id = s.idNguoiTiepNhan");
        }


        void TTSBinding()
        {
            txbMaSachTTS.DataBindings.Clear();
            txbMaSachTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbTenSachTTS.DataBindings.Clear();
            txbTenSachTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "tenSach", true, DataSourceUpdateMode.Never));
            txbTheLoaiTTS.DataBindings.Clear();
            txbTheLoaiTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "theLoai", true, DataSourceUpdateMode.Never));
            txbTacGiaTTS.DataBindings.Clear();
            txbTacGiaTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "tacGia", true, DataSourceUpdateMode.Never));
            txbNamXuatBanTTS.DataBindings.Clear();
            txbNamXuatBanTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "namXuatBan", true, DataSourceUpdateMode.Never));
            txbNhaXuatBanTTS.DataBindings.Clear();
            txbNhaXuatBanTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "nhaXuatBan", true, DataSourceUpdateMode.Never));
            txbNgayNhapTTS.DataBindings.Clear();
            txbNgayNhapTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "ngayNhap", true, DataSourceUpdateMode.Never));
            txbTriGiaTTS.DataBindings.Clear();
            txbTriGiaTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "triGia", true, DataSourceUpdateMode.Never));
            txbNguoiTiepNhanTTS.DataBindings.Clear();
            txbNguoiTiepNhanTTS.DataBindings.Add(new Binding("Text", dtgvTTS.DataSource, "nguoiTiepNhan", true, DataSourceUpdateMode.Never));
        }

        void LoadTDG()
        {
            dtgvTDG.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select d.id as MaDocGia, d.HoTen, LoaiDocGia, d.NgaySinh, d.DiaChi, Email,NgayLapThe, n.HoTen as NguoiLap   from DocGia d, NhanVien n where  n.id = d.idNguoiLap");
        }

        void TDGBinding()
        {
            txbMaDocGiaTDG.DataBindings.Clear();
            txbMaDocGiaTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            txbHoVaTenTDG.DataBindings.Clear();
            txbHoVaTenTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "hoTen", true, DataSourceUpdateMode.Never));
            txbNgaySinhTDG.DataBindings.Clear();
            txbNgaySinhTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never));
            txbLoaiDocGiaTDG.DataBindings.Clear();
            txbLoaiDocGiaTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "loaiDocGia", true, DataSourceUpdateMode.Never));
            txbNgayLapTheTDG.DataBindings.Clear();
            txbNgayLapTheTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "ngayLapThe", true, DataSourceUpdateMode.Never));
            txbNguoiLapTDG.DataBindings.Clear();
            txbNguoiLapTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "nguoiLap", true, DataSourceUpdateMode.Never));
            txbDiaChiTDG.DataBindings.Clear();
            txbDiaChiTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "diaChi", true, DataSourceUpdateMode.Never));
            txbEmailTDG.DataBindings.Clear();
            txbEmailTDG.DataBindings.Add(new Binding("Text", dtgvTDG.DataSource, "email", true, DataSourceUpdateMode.Never));
        }

        void LoadPMS()
        {
            dtgvPMS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, HoTen as HoTenDocGia, NgayMuon, idSach as MaSach, TenSach, TheLoai, TacGia from PhieuMuonSach p, DocGia d, sach s where p.idSach = s.id and p.idDocGia = d.id");
        }

        void PMSBinding()
        {
            txbMaPhieuPMS.DataBindings.Clear();
            txbMaPhieuPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbMaDocGiaPMS.DataBindings.Clear();
            txbMaDocGiaPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            txbHoTenDocGiaPMS.DataBindings.Clear();
            txbHoTenDocGiaPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "HoTenDocGia", true, DataSourceUpdateMode.Never));
            txbNgayMuonPMS.DataBindings.Clear();
            txbNgayMuonPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "NgayMuon", true, DataSourceUpdateMode.Never));
            txbMaSachPMS.DataBindings.Clear();
            txbMaSachPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbTenSachPMS.DataBindings.Clear();
            txbTenSachPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txbTheLoaiPMS.DataBindings.Clear();
            txbTheLoaiPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "TheLoai", true, DataSourceUpdateMode.Never));
            txbTacGiaPMS.DataBindings.Clear();
            txbTacGiaPMS.DataBindings.Add(new Binding("Text", dtgvPMS.DataSource, "TacGia", true, DataSourceUpdateMode.Never));
        }

        void LoadPTS()
        {
            dtgvPTS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, HoTen as HoTenDocGia, NgayTra, TienPhatKyNay, TienNo, TongNo, idSach as MaSach, NgayMuon, SoNgayMuon, TienPhat  from PhieuTraSach p, DocGia d, sach s where p.idSach = s.id and p.idDocGia = d.id");
        }

        void PTSBinding()
        {
            txbMaPhieuPTS.DataBindings.Clear();
            txbMaPhieuPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbMaDocGiaPTS.DataBindings.Clear();
            txbMaDocGiaPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            txbHoTenDocGiaPTS.DataBindings.Clear();
            txbHoTenDocGiaPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "HoTenDocGia", true, DataSourceUpdateMode.Never));
            txbNgayTraPTS.DataBindings.Clear();
            txbNgayTraPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "NgayTra", true, DataSourceUpdateMode.Never));
            txbTienPhatKyNayPTS.DataBindings.Clear();
            txbTienPhatKyNayPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "TienPhatKyNay", true, DataSourceUpdateMode.Never));
            txbTienNoPTS.DataBindings.Clear();
            txbTienNoPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "TienNo", true, DataSourceUpdateMode.Never));
            txbTongNoPTS.DataBindings.Clear();
            txbTongNoPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "TongNo", true, DataSourceUpdateMode.Never));
            txbMaSachPTS.DataBindings.Clear();
            txbMaSachPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbNgayMuonPTS.DataBindings.Clear();
            txbNgayMuonPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "NgayMuon", true, DataSourceUpdateMode.Never));
            txbSoNgayMuonPTS.DataBindings.Clear();
            txbSoNgayMuonPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "SoNgayMuon", true, DataSourceUpdateMode.Never));
            txbTienPhatPTS.DataBindings.Clear();
            txbTienPhatPTS.DataBindings.Add(new Binding("Text", dtgvPTS.DataSource, "TienPhat", true, DataSourceUpdateMode.Never));
        }

        void LoadPTTP()
        {
            dtgvPTTP.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, pt.id as MaPhieuTra, d.HoTen, pt.TienNo, SoTienThu, (SoTienThu- TienNo) as ConLai, n.HoTen AS NguoiThuTien  from PhieuThuTienPhat p, NhanVien n, DocGia d, PhieuTraSach pt where p.idDocGia = d.id and p.idNguoiThuTien = n.id and p.idPhieuTraSach = pt.id");
        }

        void PTTPBinding()
        {
            txbMaPhieuPTTP.DataBindings.Clear();
            txbMaPhieuPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbMaDocGiaPTTP.DataBindings.Clear();
            txbMaDocGiaPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            txbMaPhieuTraPTTP.DataBindings.Clear();
            txbMaPhieuTraPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "MaPhieuTra", true, DataSourceUpdateMode.Never));
            txbHoTenPTTP.DataBindings.Clear();
            txbHoTenPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txbTienNoPTTP.DataBindings.Clear();
            txbTienNoPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "TienNo", true, DataSourceUpdateMode.Never));
            txbSoTienThuPTTP.DataBindings.Clear();
            txbSoTienThuPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "SoTienThu", true, DataSourceUpdateMode.Never));
            txbConLaiPTTP.DataBindings.Clear();
            txbConLaiPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "ConLai", true, DataSourceUpdateMode.Never));
            txbNguoiThuTienPTTP.DataBindings.Clear();
            txbNguoiThuTienPTTP.DataBindings.Add(new Binding("Text", dtgvPTTP.DataSource, "NguoiThuTien", true, DataSourceUpdateMode.Never));
        }

        void LoadGNMS()
        {
            dtgvGNMS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select g.id as MaPhieu, d.id as MaDocGia, s.id as MaSach, TenSach, NgayGhiNhan, d.HoTen as HoTenDocGia, TienPhat, n.HoTen as NguoiGhiNhan from GhiNhanMatSach g, Sach s, DocGia d, NhanVien n where g.idSach = s.id and g.idDocGia = d.id and g.idNguoiGhiNhan = n.id");
        }

        void GNMSBinding()
        {
            txbMaPhieuGNMS.DataBindings.Clear();
            txbMaPhieuGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbMaDocGiaGNMS.DataBindings.Clear();
            txbMaDocGiaGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            txbMaSachGNMS.DataBindings.Clear();
            txbMaSachGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbTenSachGNMS.DataBindings.Clear();
            txbTenSachGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txbNgayGhiNhanGNMS.DataBindings.Clear();
            txbNgayGhiNhanGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "NgayGhiNhan", true, DataSourceUpdateMode.Never));
            txbHoTenDocGiaGNMS.DataBindings.Clear();
            txbHoTenDocGiaGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "HoTenDocGia", true, DataSourceUpdateMode.Never));
            txbTienPhatGNMS.DataBindings.Clear();
            txbTienPhatGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "TienPhat", true, DataSourceUpdateMode.Never));
            txbNguoiGhiNhanGNMS.DataBindings.Clear();
            txbNguoiGhiNhanGNMS.DataBindings.Add(new Binding("Text", dtgvGNMS.DataSource, "NguoiGhiNhan", true, DataSourceUpdateMode.Never));
        }

        void LoadTLS()
        {
            dtgvTLS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select t.id as MaPhieu, HoTen as HoTenNguoiThanhLy, NgayThanhLy, idSach as MaSach, TenSach, LyDoThanhLy from ThanhLySach t, NhanVien n, Sach s where t.idNguoiThanhLy = n.id and t.idSach = s.id");
        }

        void TLSBinding()
        {
            txbMaPhieuTLS.DataBindings.Clear();
            txbMaPhieuTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbHoTenNguoiThanhLyTLS.DataBindings.Clear();
            txbHoTenNguoiThanhLyTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "HoTenNguoiThanhLy", true, DataSourceUpdateMode.Never));
            txbNgayThanhLyTLS.DataBindings.Clear();
            txbNgayThanhLyTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "NgayThanhLy", true, DataSourceUpdateMode.Never));
            txbMaSachTLS.DataBindings.Clear();
            txbMaSachTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txbTenSachTLS.DataBindings.Clear();
            txbTenSachTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txbLyDoThanhLyTLS.DataBindings.Clear();
            txbLyDoThanhLyTLS.DataBindings.Add(new Binding("Text", dtgvTLS.DataSource, "LyDoThanhLy", true, DataSourceUpdateMode.Never));
        }

        void LoadBC1()
        {
            dtgvBC1.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select TenSach, count(p.id) as SoLuotMuon from PhieuMuonSach p, Sach s WHERE p.idSach = s.id and NgayMuon > '" + StartDate.Value.Date.ToString("yyyy-MM-dd") + "'  and NgayMuon < '" + FinishDate.Value.Date.ToString("yyyy-MM-dd") + "' group by TenSach");
        }

        void LoadSumBC1()
        {
            dtgvSumBC1.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select count(id) as TongSoLuotMuon from PhieuMuonSach where NgayMuon > '" + StartDate.Value.Date.ToString("yyyy-MM-dd") + "'  and NgayMuon < '" + FinishDate.Value.Date.ToString("yyyy-MM-dd") + "'");
        }
      
        void LoadBC2()
        {
            dtgvBC2.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select TenSach, NgayMuon, datediff(day, dateadd(day, 4, NgayMuon), NgayTra) as SoNgayTraTre from PhieuTraSach p, Sach s where p.idSach = s.id and NgayMuon > '" + StartDate.Value.Date.ToString("yyyy-MM-dd") + "'  and NgayMuon < '" + FinishDate.Value.Date.ToString("yyyy-MM-dd") + "'");
        }

        void LoadBC3()
        {
            dtgvBC3.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select HoTen, sum(TienNo) as TienNo from PhieuTraSach p, DocGia d where p.idDocGia = d.id and NgayMuon > '" + StartDate.Value.Date.ToString("yyyy-MM-dd") + "'  and NgayMuon < '" + FinishDate.Value.Date.ToString("yyyy-MM-dd") + "' group by HoTen");
        }

        void LoadSumBC3()
        {
            dtgvSumBC3.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select sum(TienNo) as TongTienNo from PhieuTraSach where NgayMuon > '" + StartDate.Value.Date.ToString("yyyy-MM-dd") + "'  and NgayMuon < '" + FinishDate.Value.Date.ToString("yyyy-MM-dd") + "'");
        }

        private void btnXemTTS_Click(object sender, EventArgs e)
        {
            LoadTTS();
            TTSBinding();
        }

        private void btnXemHSNV_Click(object sender, EventArgs e)
        {
            LoadHSNV();
            HSNVBinding();
        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tabChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel55_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel54_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel50_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXemTDG_Click(object sender, EventArgs e)
        {
            LoadTDG();
            TDGBinding();
        }

        private void btnXemPMS_Click(object sender, EventArgs e)
        {
            LoadPMS();
            PMSBinding();
        }

        private void btnXemPTS_Click(object sender, EventArgs e)
        {
            LoadPTS();
            PTSBinding();
        }

        private void btnXemPTTP_Click(object sender, EventArgs e)
        {
            LoadPTTP();
            PTTPBinding();
        }

        private void btnXemGNMS_Click(object sender, EventArgs e)
        {
            LoadGNMS();
            GNMSBinding();
        }

        private void btnXemTLS_Click(object sender, EventArgs e)
        {
            LoadTLS();
            TLSBinding();
        }

        private void btnXoaHSNV_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM NhanVien WHERE id = " + txbMaNhanVienHSNV.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadHSNV();
                    HSNVBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
        }

        private void btnThemHSNV_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO NhanVien(HoTen, NgaySinh, BangCap, ChucVu, DiaChi, DienThoai, BoPhan) VALUES (N'" + txbHoVaTenHSNV.Text + "', N'" + txbNgaySinhHSNV.Text + "', N'" + txbBangCapHSNV.Text + "', N'" + txbChucVuHSNV.Text + "', N'" + txbDiaChiHSNV.Text + "', N'" + txbDienThoaiHSNV.Text + "', N'" + txbBoPhanHSNV.Text + "')") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadHSNV();
                HSNVBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaHSNV_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE NhanVien SET HoTen = N'" + txbHoVaTenHSNV.Text + "', NgaySinh = N'" + txbNgaySinhHSNV.Text + "',BangCap =  N'" + txbBangCapHSNV.Text + "', ChucVu = N'" + txbChucVuHSNV.Text + "',DiaChi =  N'" + txbDiaChiHSNV.Text + "',DienThoai =  N'" + txbDienThoaiHSNV.Text + "',BoPhan =  N'" + txbBoPhanHSNV.Text + "' where id = " + txbMaNhanVienHSNV.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadHSNV();
                HSNVBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        void LoadTimHSNV()
        {
            dtgvHSNV.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("SELECT id as MaNhanVien, HoTen, NgaySinh, BangCap, ChucVu, DiaChi, BoPhan, DienThoai=RIGHT('0000000000' + CONVERT(VARCHAR,DienThoai), 10)  FROM NhanVien WHERE HoTen like '%" + txbTimHSNV.Text + "%'");
        }

        private void btnTimHSNV_Click(object sender, EventArgs e)
        {
            LoadTimHSNV();
            HSNVBinding();
        }

        private void btnThemTDG_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO DocGia(HoTen, NgaySinh, LoaiDocGia, NgayLapThe, DiaChi, Email) VALUES (N'" + txbHoVaTenTDG.Text + "', N'" + txbNgaySinhTDG.Text + "', N'" + txbLoaiDocGiaTDG.Text + "', N'" + txbNgayLapTheTDG.Text + "', N'" + txbDiaChiTDG.Text + "', N'" + txbEmailTDG.Text + "')") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadTDG();
                TDGBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaTDG_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE DocGia SET HoTen = N'" + txbHoVaTenTDG.Text + "', NgaySinh = N'" + txbNgaySinhTDG.Text + "',LoaiDocGia =  N'" + txbLoaiDocGiaTDG.Text + "', NgayLapThe = N'" + txbNgayLapTheTDG.Text + "',DiaChi =  N'" + txbDiaChiTDG.Text + "',Email =  N'" + txbEmailTDG.Text + "' where id = " + txbMaDocGiaTDG.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadTDG();
                TDGBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaTDG_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM DocGia WHERE id = " + txbMaDocGiaTDG.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadTDG();
                    TDGBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
   
        }

        void LoadTimTDG()
        {
            dtgvTDG.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select d.id as MaDocGia, d.HoTen, LoaiDocGia, d.NgaySinh, d.DiaChi, Email,NgayLapThe, n.HoTen as NguoiLap   from DocGia d, NhanVien n where  n.id = d.idNguoiLap and  d.HoTen like '%" + txbTimTDG.Text + "%'");
        }
        private void btnTimTDG_Click(object sender, EventArgs e)
        {
            LoadTimTDG();
            TDGBinding();
        }

        private void btnThemTTS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO Sach(TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia) VALUES (N'" + txbTenSachTTS.Text + "', N'" + txbTheLoaiTTS.Text + "', N'" + txbTacGiaTTS.Text + "', " + txbNamXuatBanTTS.Text + ", N'" + txbNhaXuatBanTTS.Text + "', N'" + txbNgayNhapTTS.Text + "', " + txbTriGiaTTS.Text + ")") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadTTS();
                TTSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaTTS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE Sach SET TenSach = N'" + txbTenSachTTS.Text + "', TheLoai = N'" + txbTheLoaiTTS.Text + "',TacGia =  N'" + txbTacGiaTTS.Text + "', NamXuatBan = " + txbNamXuatBanTTS.Text + ",NhaXuatBan =  N'" + txbNhaXuatBanTTS.Text + "',NgayNhap = N'" + txbNgayNhapTTS.Text + "',TriGia = " + txbTriGiaTTS.Text + " where id = " + txbMaSachTTS.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadTTS();
                TTSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaTTS_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM Sach WHERE id = " + txbMaSachTTS.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadTTS();
                    TTSBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
        }

        void LoadTimTTS()
        {
            dtgvTTS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select s.id as MaSach, TenSach, TheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, n.HoTen as NguoiTiepNhan from Sach s, NhanVien n where n.id = s.idNguoiTiepNhan AND TenSach like '%" + txbTimTTS.Text + "%'");
        }

        private void btnTimTTS_Click(object sender, EventArgs e)
        {
            LoadTimTTS();
            TTSBinding();
        }

        private void btnThemPMS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO PhieuMuonSach(idDocGia, idSach, NgayMuon) VALUES (" + txbMaDocGiaPMS.Text + ", " + txbMaSachPMS.Text + ", N'" + txbNgayMuonPMS.Text + "')") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadPMS();
                PMSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaPMS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE PhieuMuonSach SET idDocGia = " + txbMaDocGiaPMS.Text + ", idSach = " + txbMaSachPMS.Text + ",NgayMuon =  N'" + txbNgayMuonPMS.Text + "' where id = " + txbMaPhieuPMS.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadPMS();
                PMSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaPMS_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM PhieuMuonSach WHERE id = " + txbMaPhieuPMS.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadPMS();
                    PMSBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
        }

        void LoadTimPMS()
        {
            dtgvPMS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, HoTen as HoTenDocGia, NgayMuon, idSach as MaSach, TenSach, TheLoai, TacGia from PhieuMuonSach p, DocGia d, sach s where p.idSach = s.id and p.idDocGia = d.id AND HoTen like '%" + txbTimPMS.Text + "%'");
        }

        private void btnTimPMS_Click(object sender, EventArgs e)
        {
            LoadTimPMS();
            PMSBinding();
        }

        private void btnThemPTS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO PhieuTraSach(idDocGia, NgayTra, TienPhatKyNay, TienNo, TongNo, idSach, NgayMuon, SoNgayMuon, TienPhat) VALUES (" + txbMaDocGiaPTS.Text + ", N'" + txbNgayTraPTS.Text + "', " + txbTienPhatKyNayPTS.Text + ", " + txbTienNoPTS.Text + ", " + txbTongNoPTS.Text + ", " + txbMaSachPTS.Text + ", N'" + txbNgayMuonPTS.Text + "', " + txbSoNgayMuonPTS.Text + ", " + txbTienPhatPTS.Text + ")") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadPTS();
                PTSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaPTS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE PhieuTraSach SET idDocGia = " + txbMaDocGiaPTS.Text + ", NgayTra = N'" + txbNgayTraPTS.Text + "',TienPhatKyNay = " + txbTienPhatKyNayPTS.Text + ", TienNo = " + txbTienNoPTS.Text + ",TongNo = " + txbTongNoPTS.Text + ",idSach = " + txbMaSachPTS.Text + ",NgayMuon = N'" + txbNgayMuonPTS.Text + "',SoNgayMuon = " + txbSoNgayMuonPTS.Text + ",TienPhat = " + txbTienPhatPTS.Text + " where id = " + txbMaPhieuPTS.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadPTS();
                PTSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaPTS_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM PhieuTraSach WHERE id = " + txbMaPhieuPTS.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadPTS();
                    PTSBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
        }

        void LoadTimPTS()
        {
            dtgvPTS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, HoTen as HoTenDocGia, NgayTra, TienPhatKyNay, TienNo, TongNo, idSach as MaSach, NgayMuon, SoNgayMuon, TienPhat  from PhieuTraSach p, DocGia d, sach s where p.idSach = s.id and p.idDocGia = d.id AND HoTen like '%" + txbTimPTS.Text + "%'");
        }

        private void btnTimPTS_Click(object sender, EventArgs e)
        {
            LoadTimPTS();
            PTSBinding();
        }

        private void btnThemPTTP_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO PhieuThuTienPhat(idDocGia, idPhieuTraSach, SoTienThu) VALUES (" + txbMaDocGiaPTTP.Text + ", " + txbMaPhieuTraPTTP.Text + ", " + txbSoTienThuPTTP.Text + ")") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadPTTP();
                PTTPBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaPTTP_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE PhieuThuTienPhat SET idDocGia = " + txbMaDocGiaPTTP.Text + ", idPhieuTraSach = " + txbMaPhieuTraPTTP.Text + ",SoTienThu = " + txbSoTienThuPTTP.Text + " where id = " + txbMaPhieuPTTP.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadPTTP();
                PTTPBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaPTTP_Click(object sender, EventArgs e)
        {
            {
                if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM PhieuThuTienPhat WHERE id = " + txbMaPhieuPTTP.Text) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadPTTP();
                    PTTPBinding();
                }
                else
                    MessageBox.Show("Có lỗi khi xóa dữ liệu!");
            }
        }

        void LoadTimPTTP()
        {
            dtgvPTTP.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select p.id as MaPhieu, d.id as MaDocGia, pt.id as MaPhieuTra, d.HoTen, pt.TienNo, SoTienThu, (SoTienThu- TienNo) as ConLai, n.HoTen AS NguoiThuTien  from PhieuThuTienPhat p, NhanVien n, DocGia d, PhieuTraSach pt where p.idDocGia = d.id and p.idNguoiThuTien = n.id and p.idPhieuTraSach = pt.id AND d.HoTen like '%" + txbTimPTTP.Text + "%'");
        }

        private void btnTimPTTP_Click(object sender, EventArgs e)
        {
            LoadTimPTTP();
            PTTPBinding();
        }

        private void btnThemGNMS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO GhiNhanMatSach(idDocGia, idSach, TienPhat, NgayGhiNhan) VALUES (" + txbMaDocGiaGNMS.Text + ", " + txbMaSachGNMS.Text + ", " + txbTienPhatGNMS.Text + ", N'" + txbNgayGhiNhanGNMS.Text + "')") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadGNMS();
                GNMSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaGNMS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE GhiNhanMatSach SET idDocGia = " + txbMaDocGiaGNMS.Text + ", idSach = " + txbMaSachGNMS.Text + ",TienPhat = " + txbTienPhatGNMS.Text + ",NgayGhiNhan = N'" + txbNgayGhiNhanGNMS.Text + "' where id = " + txbMaPhieuGNMS.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadGNMS();
                GNMSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaGNMS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM GhiNhanMatSach WHERE id = " + txbMaPhieuGNMS.Text) > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
                LoadGNMS();
                GNMSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi xóa dữ liệu!");
        }

        void LoadTimGNMS()
        {
            dtgvGNMS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select g.id as MaPhieu, d.id as MaDocGia, s.id as MaSach, TenSach, NgayGhiNhan, d.HoTen as HoTenDocGia, TienPhat, n.HoTen as NguoiGhiNhan from GhiNhanMatSach g, Sach s, DocGia d, NhanVien n where g.idSach = s.id and g.idDocGia = d.id and g.idNguoiGhiNhan = n.id AND d.HoTen like '%" + txbTimGNMS.Text + "%'");
        }

        private void btnTimGNMS_Click(object sender, EventArgs e)
        {
            LoadTimGNMS();
            GNMSBinding();
        }

        private void btnThemTLS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("INSERT INTO ThanhLySach(idSach, NgayThanhLy, LyDoThanhLy) VALUES (" + txbMaSachTLS.Text + ", N'" + txbNgayThanhLyTLS.Text + "', N'" + txbLyDoThanhLyTLS.Text + "' )") > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadTLS();
                TLSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi thêm dữ liệu!");
        }

        private void btnSuaTLS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("UPDATE ThanhLySach SET idSach = " + txbMaSachTLS.Text + ", NgayThanhLy = N'" + txbNgayThanhLyTLS.Text + "',LyDoThanhLy = N'" + txbLyDoThanhLyTLS.Text + "' where id = " + txbMaPhieuTLS.Text) > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
                LoadTLS();
                TLSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi sửa dữ liệu!");
        }

        private void btnXoaTLS_Click(object sender, EventArgs e)
        {
            if (DAO.DataProvider.Instance.ExcecuteNonQuery("DELETE FROM ThanhLySach WHERE id = " + txbMaPhieuTLS.Text ) > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
                LoadTLS();
                TLSBinding();
            }
            else
                MessageBox.Show("Có lỗi khi xóa dữ liệu!");
        }

        void LoadTimTLS()
        {
            dtgvTLS.DataSource = DAO.DataProvider.Instance.ExcecuteQuery("select t.id as MaPhieu, HoTen as HoTenNguoiThanhLy, NgayThanhLy, idSach as MaSach, TenSach, LyDoThanhLy from ThanhLySach t, NhanVien n, Sach s where t.idNguoiThanhLy = n.id and t.idSach = s.id AND TenSach like '%" + txbTimTLS.Text + "%'");
        }

        private void btnTimTLS_Click(object sender, EventArgs e)
        {
            LoadTimTLS();
            TLSBinding();
      
        }

        private void btnThongKeBC_Click(object sender, EventArgs e)
        {
            LoadBC1();
            LoadSumBC1();
            LoadBC2();
            LoadBC3();
            LoadSumBC3();
        }
    }
}
