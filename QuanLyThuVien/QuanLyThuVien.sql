USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 8/6/2020 7:27:29 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[LoaiDocGia] [char](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NgayLapThe] [date] NOT NULL,
	[idNguoiLap] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GhiNhanMatSach]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GhiNhanMatSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idSach] [int] NOT NULL,
	[NgayGhiNhan] [date] NOT NULL,
	[idDocGia] [int] NOT NULL,
	[TienPhat] [float] NOT NULL,
	[idNguoiGhiNhan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[BangCap] [nvarchar](30) NOT NULL,
	[ChucVu] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[BoPhan] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuonSach]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDocGia] [int] NOT NULL,
	[idSach] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuTienPhat]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTienPhat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDocGia] [int] NOT NULL,
	[idPhieuTraSach] [int] NOT NULL,
	[SoTienThu] [int] NOT NULL,
	[idNguoiThuTien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTraSach]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDocGia] [int] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[TienPhatKyNay] [float] NOT NULL,
	[TienNo] [float] NOT NULL,
	[TongNo] [float] NOT NULL,
	[idSach] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[SoNgayMuon] [int] NOT NULL,
	[TienPhat] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[TheLoai] [char](10) NOT NULL,
	[TacGia] [nvarchar](100) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[NhaXuatBan] [nvarchar](100) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[TriGia] [float] NOT NULL,
	[TinhTrang] [nvarchar](100) NULL,
	[idNguoiTiepNhan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhLySach]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhLySach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NgayThanhLy] [date] NOT NULL,
	[idSach] [int] NOT NULL,
	[LyDoThanhLy] [nvarchar](100) NOT NULL,
	[idNguoiThanhLy] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'DTH', N'Đồng Trung Héo', N'1', N'Ban giám đốc')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'HKD', N'Huỳnh Khang Dơ', N'1', N'Thủ thư')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'NDV', N'Ngô Đại Vẽo', N'1', N'Ban giám đốc')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'NPB', N'Nguyễn Phúc Bo', N'1', N'Thủ quỹ')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'THS', N'Trần Hào Say', N'1', N'Thủ kho')
GO
SET IDENTITY_INSERT [dbo].[DocGia] ON 

INSERT [dbo].[DocGia] ([id], [HoTen], [LoaiDocGia], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [idNguoiLap]) VALUES (1, N'Ngô Đại Vẽo', N'X         ', CAST(N'1949-01-29' AS Date), N'53 Trần Xuân Soạn-Q7-TPHCM', N'ngovy16@gmail.com', CAST(N'2019-02-11' AS Date), 1)
INSERT [dbo].[DocGia] ([id], [HoTen], [LoaiDocGia], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [idNguoiLap]) VALUES (2, N'Đồng Trung Héo', N'Y         ', CAST(N'1952-12-23' AS Date), N'95 Tôn Đản-Q4-TPHCM', N'linheobede@gmail.com', CAST(N'2018-06-08' AS Date), 1)
SET IDENTITY_INSERT [dbo].[DocGia] OFF
GO
SET IDENTITY_INSERT [dbo].[GhiNhanMatSach] ON 

INSERT [dbo].[GhiNhanMatSach] ([id], [idSach], [NgayGhiNhan], [idDocGia], [TienPhat], [idNguoiGhiNhan]) VALUES (1, 1, CAST(N'2020-08-15' AS Date), 1, 1020000, 1)
INSERT [dbo].[GhiNhanMatSach] ([id], [idSach], [NgayGhiNhan], [idDocGia], [TienPhat], [idNguoiGhiNhan]) VALUES (2, 3, CAST(N'2020-08-15' AS Date), 2, 3050000, 1)
SET IDENTITY_INSERT [dbo].[GhiNhanMatSach] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [BangCap], [ChucVu], [DiaChi], [DienThoai], [BoPhan]) VALUES (1, N'Huỳnh Khang Dơ', CAST(N'1990-11-16' AS Date), N'Đại Học', N'Nhân viên', N'165 Nguyễn Tri Phương-Q10-TPHCM', 836419452, N'Thủ thư')
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [BangCap], [ChucVu], [DiaChi], [DienThoai], [BoPhan]) VALUES (2, N'Trần Hào Say', CAST(N'1987-04-22' AS Date), N'Cao Đẳng', N'Phó phòng', N'76 Sư Vạn Hạnh-Q10-TPHCM', 621584368, N'Thủ kho')
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [BangCap], [ChucVu], [DiaChi], [DienThoai], [BoPhan]) VALUES (3, N'Nguyễn Phúc Bo', CAST(N'1992-07-29' AS Date), N'Trung Cấp', N'Trưởng phòng', N'125 Nguyễn Đình Chiểu-Q3-TPHCM', 546317956, N'Thủ quỹ')
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [BangCap], [ChucVu], [DiaChi], [DienThoai], [BoPhan]) VALUES (4, N'Ngô Đại Vẽo', CAST(N'1949-01-29' AS Date), N'Thạc sĩ', N'Giám đốc', N'53 Trần Xuân Soạn-Q7-TPHCM', 635945222, N'Ban giám đốc')
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [BangCap], [ChucVu], [DiaChi], [DienThoai], [BoPhan]) VALUES (5, N'Đồng Trung Héo', CAST(N'1952-12-23' AS Date), N'Tiến sĩ', N'Phó Giám đốc', N'95 Tôn Đản-Q4-TPHCM', 651384972, N'Ban giám đốc')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuMuonSach] ON 

INSERT [dbo].[PhieuMuonSach] ([id], [idDocGia], [idSach], [NgayMuon]) VALUES (2, 1, 1, CAST(N'2020-08-03' AS Date))
INSERT [dbo].[PhieuMuonSach] ([id], [idDocGia], [idSach], [NgayMuon]) VALUES (3, 1, 2, CAST(N'2020-08-03' AS Date))
INSERT [dbo].[PhieuMuonSach] ([id], [idDocGia], [idSach], [NgayMuon]) VALUES (4, 2, 2, CAST(N'2020-08-04' AS Date))
INSERT [dbo].[PhieuMuonSach] ([id], [idDocGia], [idSach], [NgayMuon]) VALUES (5, 2, 3, CAST(N'2020-08-04' AS Date))
SET IDENTITY_INSERT [dbo].[PhieuMuonSach] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuThuTienPhat] ON 

INSERT [dbo].[PhieuThuTienPhat] ([id], [idDocGia], [idPhieuTraSach], [SoTienThu], [idNguoiThuTien]) VALUES (1, 1, 1, 50000, 3)
INSERT [dbo].[PhieuThuTienPhat] ([id], [idDocGia], [idPhieuTraSach], [SoTienThu], [idNguoiThuTien]) VALUES (2, 2, 3, 60000, 3)
SET IDENTITY_INSERT [dbo].[PhieuThuTienPhat] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuTraSach] ON 

INSERT [dbo].[PhieuTraSach] ([id], [idDocGia], [NgayTra], [TienPhatKyNay], [TienNo], [TongNo], [idSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (1, 1, CAST(N'2020-08-10' AS Date), 7000, 2000, 9000, 1, CAST(N'2020-08-03' AS Date), 7, 7000)
INSERT [dbo].[PhieuTraSach] ([id], [idDocGia], [NgayTra], [TienPhatKyNay], [TienNo], [TongNo], [idSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (2, 1, CAST(N'2020-08-10' AS Date), 7000, 2000, 9000, 2, CAST(N'2020-08-03' AS Date), 7, 7000)
INSERT [dbo].[PhieuTraSach] ([id], [idDocGia], [NgayTra], [TienPhatKyNay], [TienNo], [TongNo], [idSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (3, 2, CAST(N'2020-08-11' AS Date), 7000, 2000, 9000, 2, CAST(N'2020-08-04' AS Date), 7, 7000)
INSERT [dbo].[PhieuTraSach] ([id], [idDocGia], [NgayTra], [TienPhatKyNay], [TienNo], [TongNo], [idSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (4, 2, CAST(N'2020-08-11' AS Date), 7000, 2000, 9000, 3, CAST(N'2020-08-04' AS Date), 7, 7000)
SET IDENTITY_INSERT [dbo].[PhieuTraSach] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([id], [TenSach], [TheLoai], [TacGia], [NamXuatBan], [NhaXuatBan], [NgayNhap], [TriGia], [TinhTrang], [idNguoiTiepNhan]) VALUES (1, N'LOL', N'A         ', N'Đức Nhật', 2014, N'NXB Trẻ', CAST(N'2019-10-30' AS Date), 1000000, N'Mới', 2)
INSERT [dbo].[Sach] ([id], [TenSach], [TheLoai], [TacGia], [NamXuatBan], [NhaXuatBan], [NgayNhap], [TriGia], [TinhTrang], [idNguoiTiepNhan]) VALUES (2, N'GTA5', N'B         ', N'Phúc Bo', 2015, N'NXB Già', CAST(N'2017-01-31' AS Date), 2000000, N'Cũ', 2)
INSERT [dbo].[Sach] ([id], [TenSach], [TheLoai], [TacGia], [NamXuatBan], [NhaXuatBan], [NgayNhap], [TriGia], [TinhTrang], [idNguoiTiepNhan]) VALUES (3, N'FO4', N'C         ', N'Dinh Bê Đê', 2017, N'NXB Trung', CAST(N'2018-12-12' AS Date), 3000000, N'Cũ', 2)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[ThanhLySach] ON 

INSERT [dbo].[ThanhLySach] ([id], [NgayThanhLy], [idSach], [LyDoThanhLy], [idNguoiThanhLy]) VALUES (1, CAST(N'2020-08-16' AS Date), 1, N'Người dùng làm mất', 2)
INSERT [dbo].[ThanhLySach] ([id], [NgayThanhLy], [idSach], [LyDoThanhLy], [idNguoiThanhLy]) VALUES (2, CAST(N'2020-08-17' AS Date), 2, N'Hư hỏng', 2)
INSERT [dbo].[ThanhLySach] ([id], [NgayThanhLy], [idSach], [LyDoThanhLy], [idNguoiThanhLy]) VALUES (3, CAST(N'2020-08-17' AS Date), 3, N'Mất', 2)
SET IDENTITY_INSERT [dbo].[ThanhLySach] OFF
GO
ALTER TABLE [dbo].[DocGia] ADD  CONSTRAINT [DF_DocGia_idNguoiLap]  DEFAULT ((1)) FOR [idNguoiLap]
GO
ALTER TABLE [dbo].[GhiNhanMatSach] ADD  CONSTRAINT [DF_GhiNhanMatSach_idNguoiGhiNhan]  DEFAULT ((1)) FOR [idNguoiGhiNhan]
GO
ALTER TABLE [dbo].[PhieuThuTienPhat] ADD  CONSTRAINT [DF_PhieuThuTienPhat_idNguoiThuTien]  DEFAULT ((3)) FOR [idNguoiThuTien]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_NamXuatBan]  DEFAULT ((0)) FOR [NamXuatBan]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_NhaXuatBan]  DEFAULT (N'Chưa có') FOR [NhaXuatBan]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_NgayNhap]  DEFAULT ('2000-11-20') FOR [NgayNhap]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_TriGia]  DEFAULT ((0)) FOR [TriGia]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_idNguoiTiepNhan]  DEFAULT ((2)) FOR [idNguoiTiepNhan]
GO
ALTER TABLE [dbo].[ThanhLySach] ADD  CONSTRAINT [DF_ThanhLySach_idNguoiThanhLy]  DEFAULT ((2)) FOR [idNguoiThanhLy]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD FOREIGN KEY([idNguoiLap])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[GhiNhanMatSach]  WITH CHECK ADD FOREIGN KEY([idDocGia])
REFERENCES [dbo].[DocGia] ([id])
GO
ALTER TABLE [dbo].[GhiNhanMatSach]  WITH CHECK ADD FOREIGN KEY([idSach])
REFERENCES [dbo].[Sach] ([id])
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD FOREIGN KEY([idSach])
REFERENCES [dbo].[Sach] ([id])
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD FOREIGN KEY([idDocGia])
REFERENCES [dbo].[DocGia] ([id])
GO
ALTER TABLE [dbo].[PhieuTraSach]  WITH CHECK ADD FOREIGN KEY([idSach])
REFERENCES [dbo].[Sach] ([id])
GO
ALTER TABLE [dbo].[PhieuTraSach]  WITH CHECK ADD FOREIGN KEY([idDocGia])
REFERENCES [dbo].[DocGia] ([id])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([idNguoiTiepNhan])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[ThanhLySach]  WITH CHECK ADD FOREIGN KEY([idSach])
REFERENCES [dbo].[Sach] ([id])
GO
ALTER TABLE [dbo].[ThanhLySach]  WITH CHECK ADD FOREIGN KEY([idNguoiThanhLy])
REFERENCES [dbo].[NhanVien] ([id])
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 8/6/2020 7:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateAccount] @userName NVARCHAR(100), @displayName NVARCHAR(100), @passWord NVARCHAR(1000), @newPassWord NVARCHAR(1000)
AS
BEGIN
    DECLARE @isRightPass INT
    SELECT @isRightPass = COUNT (*) FROM Account WHERE UserName = @userName AND PassWord = @passWord
    IF (@isRightPass = 1)
       BEGIN
         IF (@newPassWord = NULL OR @newPassWord = '')
            BEGIN
                 UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
            END
            ELSE
            UPDATE Account SET DisplayName = @displayName, PassWord = @newPassWord WHERE UserName = @userName
       END
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
