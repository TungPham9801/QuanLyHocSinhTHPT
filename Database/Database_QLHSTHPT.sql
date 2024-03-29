USE [master]
GO
/****** Object:  Database [QuanLyHocSinhTHPT]    Script Date: 5/24/2019 3:13:56 PM ******/
CREATE DATABASE [QuanLyHocSinhTHPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHocSinhTHPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHocSinhTHPT.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHocSinhTHPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHocSinhTHPT_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHocSinhTHPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyHocSinhTHPT]
GO
/****** Object:  StoredProcedure [dbo].[Proc_DSGiaoVien]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Proc_DSGiaoVien]
	
AS
BEGIN
	
	SELECT * FROM [dbo].[GIAOVIEN]
END

GO
/****** Object:  StoredProcedure [dbo].[Proc_DSHocSinh]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Proc_DSHocSinh]
AS
BEGIN
	
	SELECT * FROM [dbo].[HOCSINH]
END

GO
/****** Object:  StoredProcedure [dbo].[Proc_DSHStheoGV]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Proc_DSHStheoGV]
	@magv varchar(6),
	@malop varchar(10),
	@manamhoc varchar(10) 
AS
BEGIN
	select hs.* , gv.TenGiaoVien
	from [dbo].[HOCSINH] hs, [dbo].[LOP] l ,[dbo].[GIAOVIEN] gv, [dbo].[PHANLOP] pl
	where hs.MaHocSinh = pl.MaHocSinh and pl.MaLop=l.MaLop and gv.MaGiaoVien = l.MaGiaoVien and gv.MaGiaoVien = @magv and l.MaLop =@malop and pl.MaNamHoc =@manamhoc
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_DSLopHoc]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Proc_DSLopHoc]
AS
BEGIN
	
	SELECT * FROM [dbo].[LOP]
END

GO
/****** Object:  StoredProcedure [dbo].[Proc_XemDiem]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Proc_XemDiem]
AS
BEGIN

	SELECT * FROM [dbo].[DIEM]
END

GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANTOC](
	[MaDanToc] [varchar](6) NOT NULL,
	[TenDanToc] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIEM](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHocSinh] [varchar](6) NOT NULL,
	[MaMonHoc] [varchar](6) NOT NULL,
	[MaHocKy] [varchar](3) NOT NULL,
	[MaNamHoc] [varchar](6) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaLoai] [varchar](6) NOT NULL,
	[Diem] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGiaoVien] [varchar](6) NOT NULL,
	[TenGiaoVien] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[MaMonHoc] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCKY]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCKY](
	[MaHocKy] [varchar](3) NOT NULL,
	[TenHocKy] [nvarchar](30) NOT NULL,
	[HeSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHocSinh] [varchar](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](50) NOT NULL,
	[MaDanToc] [varchar](6) NOT NULL,
	[MaTonGiao] [varchar](6) NOT NULL,
	[HoTenCha] [nvarchar](30) NOT NULL,
	[MaNNghiepCha] [varchar](6) NOT NULL,
	[HoTenMe] [nvarchar](30) NOT NULL,
	[MaNNghiepMe] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOILOP]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOILOP](
	[MaKhoiLop] [varchar](6) NOT NULL,
	[TenKhoiLop] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoiLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIDIEM]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIDIEM](
	[MaLoai] [varchar](6) NOT NULL,
	[TenLoai] [nvarchar](30) NOT NULL,
	[HeSo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAINGUOIDUNG]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAINGUOIDUNG](
	[MaLoai] [varchar](6) NOT NULL,
	[TenLoaiND] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
	[MaKhoiLop] [varchar](6) NOT NULL,
	[MaNamHoc] [varchar](6) NOT NULL,
	[SiSo] [int] NOT NULL,
	[MaGiaoVien] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMonHoc] [varchar](6) NOT NULL,
	[TenMonHoc] [nvarchar](30) NOT NULL,
	[SoTiet] [int] NOT NULL,
	[HeSo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NAMHOC]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NAMHOC](
	[MaNamHoc] [varchar](6) NOT NULL,
	[TenNamHoc] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGHENGHIEP]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGHENGHIEP](
	[MaNghe] [varchar](6) NOT NULL,
	[TenNghe] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaND] [varchar](6) NOT NULL,
	[MaLoai] [varchar](6) NOT NULL,
	[TenND] [nvarchar](30) NOT NULL,
	[TenDNhap] [varchar](30) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANCONG]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANCONG](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNamHoc] [varchar](6) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaMonHoc] [varchar](6) NOT NULL,
	[MaGiaoVien] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANLOP]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANLOP](
	[MaNamHoc] [varchar](6) NOT NULL,
	[MaKhoiLop] [varchar](6) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaHocSinh] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC,
	[MaKhoiLop] ASC,
	[MaLop] ASC,
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[TuoiCanDuoi] [int] NOT NULL,
	[TuoiCanTren] [int] NOT NULL,
	[SiSoCanDuoi] [int] NOT NULL,
	[SiSoCanTren] [int] NOT NULL,
	[ThangDiem] [int] NOT NULL,
	[TenTruong] [nvarchar](100) NULL,
	[DiaChiTruong] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TONGIAO]    Script Date: 5/24/2019 3:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TONGIAO](
	[MaTonGiao] [varchar](6) NOT NULL,
	[TenTonGiao] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTonGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0001', N'Kinh')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0002', N'Hoa')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0003', N'Khome')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0004', N'Cham')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0005', N'mong')
SET IDENTITY_INSERT [dbo].[DIEM] ON 

INSERT [dbo].[DIEM] ([STT], [MaHocSinh], [MaMonHoc], [MaHocKy], [MaNamHoc], [MaLop], [MaLoai], [Diem]) VALUES (1, N'HS0001', N'MH0003', N'HK1', N'NH0708', N'LOP1010708', N'LD0001', 5)
INSERT [dbo].[DIEM] ([STT], [MaHocSinh], [MaMonHoc], [MaHocKy], [MaNamHoc], [MaLop], [MaLoai], [Diem]) VALUES (2, N'HS0003', N'MH0002', N'HK1', N'NH0708', N'LOP1010708', N'LD0003', 6)
SET IDENTITY_INSERT [dbo].[DIEM] OFF
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0001', N'Pham Tung', N'100 Tran Hung Dao, Ha Noi ', N'0975058876', N'MH0001')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0002', N'Phan Hong Nhung', N'Nguyen Du, Nam Dinh', N'0976630315', N'MH0002')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0003', N'Huynh Thanh Truc', N'Hai ba Trung, Ha Noi ', N'0699015456', N'MH0003')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0004', N'Lam Trung Toan', N'Tran QuocTuan, Nam Dinh', N'0845241566', N'MH0004')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0005', N'Huynh Tuc Tri', N'Xuan Dinh, Ha Noi', N'0123456789', N'MH0005')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0006', N'Le Thi Minh Nguyet', N'Hang Bai, Ha Noi ', N'0123456789', N'MH0006')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0007', N'Pham Van Tùng', N'Hang Bai, Ha Noi ', N'0123456789', N'MH0006')
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [HeSo]) VALUES (N'HK1', N'Hoc ky 1', 1)
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [HeSo]) VALUES (N'HK2', N'Hoc ky 2', 2)
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0001', N'Nguyen Van Tu', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0002', N'Nguyen Ngoc An', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0003', N'Le Hoang Anh', 0, CAST(0x00008C3A00000000 AS DateTime), N'Hai Phong', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0004', N'Huynh Thien Chi', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0005', N'Ly Ngoc Duy', 0, CAST(0x00008BD300000000 AS DateTime), N'Quang Ninh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0006', N'Huynh Ngoc Diep', 1, CAST(0x00008BD300000000 AS DateTime), N'Tuyen Quang', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0007', N'Tran Thi Hue', 1, CAST(0x00008C3A00000000 AS DateTime), N'Bac Ninh', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0008', N'Nguyen Thanh Huy', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0009', N'Tran Phuoc Lap', 0, CAST(0x00008BD300000000 AS DateTime), N'Ninh Binh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0010', N'Truong Thi Nga', 1, CAST(0x00008BD300000000 AS DateTime), N'Ha Nam', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0011', N'Nguyen Thi Nga', 1, CAST(0x00008C3A00000000 AS DateTime), N'Hai Phong', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0012', N'Tran Thi Hong Nghi', 1, CAST(0x00008BD300000000 AS DateTime), N'Phu Tho', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0013', N'Huynh Thi My Ngoc', 1, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0014', N'Tran Thi My Nhan', 1, CAST(0x00008BD300000000 AS DateTime), N'Bac Giang', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0015', N'Truong Thi Ngoc Nhung', 1, CAST(0x00008C3A00000000 AS DateTime), N'Thai Binh', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0016', N'Huynh Quoc Phuong', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Nam ', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0017', N'Ly Ngoc Phuong', 1, CAST(0x00008BD300000000 AS DateTime), N'Ninh Binh ', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0018', N'Nguyen Thi Phuong', 1, CAST(0x00008BD300000000 AS DateTime), N'Thai NGuyen', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0019', N'Nguyen Phu Quoc', 0, CAST(0x00008C3A00000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0020', N'Vo Thien Quoc', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0021', N'Tran Van Rang', 0, CAST(0x00008BD300000000 AS DateTime), N'Hai Phong', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0022', N'Vo Huu Tanh', 0, CAST(0x00008BD300000000 AS DateTime), N'Hai Duong', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0023', N'Le Minh Tam', 0, CAST(0x00008C3A00000000 AS DateTime), N'Quang Ninh', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0024', N'Nguyen Duc Tam', 0, CAST(0x00008BD300000000 AS DateTime), N'Thai Bình', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0025', N'Nguyen Thanh Tam', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0026', N'Tran Ngoc Minh Tan', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0027', N'Duong Kim Thanh', 1, CAST(0x00008C3A00000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0028', N'Vang Si Thanh', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Nam', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0029', N'Do Thi Bich Thao', 1, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0030', N'Ho Minh Thien', 0, CAST(0x00008BD300000000 AS DateTime), N'Quang Ninh', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0031', N'Nguyen Thi Anh Thu', 1, CAST(0x00008C3A00000000 AS DateTime), N'Thai Binh', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0032', N'Pham Nguyen B.Trinh', 1, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0033', N'Vo Ngoc Trinh', 1, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0034', N'Nguyen Huynh Minh Tri', 0, CAST(0x00008BD300000000 AS DateTime), N'Quang Ninh', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0035', N'Do Xuan Trinh', 0, CAST(0x00008C3A00000000 AS DateTime), N'Tuyen Quang', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0036', N'Nguyen Hieu Trung', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Giang', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0037', N'Nguyen Thanh Trung', 0, CAST(0x00008BD300000000 AS DateTime), N'Thai Binh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0038', N'Tran Thanh Truc', 1, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0039', N'Cao Minh Tuan', 0, CAST(0x00008C3A00000000 AS DateTime), N'Ha Nam', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0040', N'Nguyen Hoang Tuan', 0, CAST(0x00008BD300000000 AS DateTime), N'Ninh Binh', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0041', N'Truong Minh Tuyen', 0, CAST(0x00008BD300000000 AS DateTime), N'Thai Binh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0042', N'Le Thanh Tung', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0043', N'Pham Thi Bich Vi', 1, CAST(0x00008C3A00000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0044', N'Dang Quang Vinh', 0, CAST(0x00008BD300000000 AS DateTime), N'Ha Noi', N'DT0001', N'TG0003', N'Biet chet lien', N'NN0002', N'Biet chet lien', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0045', N'Au Ngoc Vu', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0005', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0046', N'Ho Thanh Vu', 0, CAST(0x00008BD300000000 AS DateTime), N'Nam Dinh', N'DT0001', N'TG0002', N'Biet chet lien', N'NN0003', N'Biet chet lien', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0047', N'Phan Quoc Vuong', 0, CAST(0x00008C3A00000000 AS DateTime), N'Ha Nam', N'DT0001', N'TG0004', N'Biet chet lien', N'NN0005', N'Biet chet lien', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0048', N'tung', 0, CAST(0x00008DBB00000000 AS DateTime), N'w', N'DT0003', N'TG0003', N'w', N'NN0002', N'w', N'NN0003')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0049', N'tung ee', 0, CAST(0x000090A100000000 AS DateTime), N'w', N'DT0003', N'TG0003', N'w', N'NN0002', N'w', N'NN0003')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI10', N'Khoi 10')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI11', N'Khoi 11')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI12', N'Khoi 12')
INSERT [dbo].[LOAIDIEM] ([MaLoai], [TenLoai], [HeSo]) VALUES (N'LD0001', N'Kiem tra mieng', 1)
INSERT [dbo].[LOAIDIEM] ([MaLoai], [TenLoai], [HeSo]) VALUES (N'LD0002', N'Kiem tra 15 phut', 1)
INSERT [dbo].[LOAIDIEM] ([MaLoai], [TenLoai], [HeSo]) VALUES (N'LD0003', N'Kiem tra 1 tiet', 2)
INSERT [dbo].[LOAIDIEM] ([MaLoai], [TenLoai], [HeSo]) VALUES (N'LD0004', N'Thi hoc ky', 1)
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND001', N'Ban giam hieu')
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND002', N'Giao vien')
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND003', N'Nhan vien giao vu')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP', N'tung', N'KHOI12', N'NH0708', 39, N'GV0003')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1010708', N'10A1', N'KHOI10', N'NH0708', 35, N'GV0006')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1010809', N'10A1', N'KHOI10', N'NH0809', 39, N'GV0001')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1020708', N'10A2', N'KHOI10', N'NH0708', 36, N'GV0005')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1020809', N'10A2', N'KHOI10', N'NH0809', 38, N'GV0002')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1030708', N'10A3', N'KHOI10', N'NH0708', 34, N'GV0004')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1030809', N'10A3', N'KHOI10', N'NH0809', 35, N'GV0003')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1110708', N'11A1', N'KHOI11', N'NH0708', 37, N'GV0003')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1110809', N'11A1', N'KHOI11', N'NH0809', 40, N'GV0004')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1120708', N'11A2', N'KHOI11', N'NH0708', 38, N'GV0002')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1120809', N'11A2', N'KHOI11', N'NH0809', 38, N'GV0005')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1210708', N'12A1', N'KHOI12', N'NH0708', 39, N'GV0001')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1210809', N'12A1', N'KHOI12', N'NH0809', 38, N'GV0006')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1210810', N'12A10', N'KHOI12', N'NH0809', 38, N'GV0003')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0001', N'Toan Hoc', 90, 2)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0002', N'Vat Ly', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0003', N'Hoa Hoc', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0004', N'Sinh Hoc', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0005', N'Ngu Van', 90, 2)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0006', N'Lich Su', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0007', N'Dia Ly', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0008', N'Anh Van', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0009', N'GD Cong Dan', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0010', N'Tin Hoc', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0011', N'The Duc', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0012', N'Quoc Phong', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0013', N'Cong Nghe', 30, 1)
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH0708', N'2017 - 2018')
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH0809', N'2018 - 2019')
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH1920', N'2019-2020')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0001', N'Noi tro')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0002', N'Giao vien')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0003', N'Cong nhan')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0004', N'Lam ruong')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0005', N'Buon ban')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0001', N'LND001', N'Nguyen Hoang Tung', N'admin', N'minhtung')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0002', N'LND002', N'Phan Hong Nhung', N'hongnhung', N'hongnhung')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0003', N'LND003', N'Lam Trung Toan', N'trungtoan', N'toantrung')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0004', N'LND002', N'Pham Van Tung', N'tung', N'tung')
SET IDENTITY_INSERT [dbo].[PHANCONG] ON 

INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (13, N'NH0708', N'LOP1010708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (14, N'NH0708', N'LOP1010708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (15, N'NH0708', N'LOP1010708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (16, N'NH0708', N'LOP1010708', N'MH0004', N'GV0004')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (17, N'NH0708', N'LOP1020708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (18, N'NH0708', N'LOP1020708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (19, N'NH0708', N'LOP1020708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (20, N'NH0708', N'LOP1020708', N'MH0004', N'GV0004')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (21, N'NH0708', N'LOP1110708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (22, N'NH0708', N'LOP1110708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (23, N'NH0708', N'LOP1110708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (24, N'NH0708', N'LOP1110708', N'MH0004', N'GV0004')
SET IDENTITY_INSERT [dbo].[PHANCONG] OFF
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0001')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0002')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0003')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0004')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0005')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0006')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0007')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0008')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0009')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1010708', N'HS0010')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0011')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0012')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0013')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0014')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0015')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0016')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0017')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0018')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0019')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI10', N'LOP1020708', N'HS0020')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0021')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0022')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0023')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0024')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0025')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0026')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0027')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0028')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0029')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1110708', N'HS0030')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0031')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0032')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0033')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0034')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0035')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0036')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0037')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0038')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0039')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI11', N'LOP1120708', N'HS0040')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0041')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0042')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0043')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0044')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0045')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0046')
INSERT [dbo].[PHANLOP] ([MaNamHoc], [MaKhoiLop], [MaLop], [MaHocSinh]) VALUES (N'NH0708', N'KHOI12', N'LOP1210708', N'HS0047')
INSERT [dbo].[QUYDINH] ([TuoiCanDuoi], [TuoiCanTren], [SiSoCanDuoi], [SiSoCanTren], [ThangDiem], [TenTruong], [DiaChiTruong]) VALUES (15, 20, 30, 40, 10, N'THPT CHUYÊN LÊ HỒNG PHONG', N'38, Bến Ngự, P. Phan Đình Phùng, Thành phố Nam Định, T. Nam Định')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0001', N'Khong')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0002', N'Phat')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0003', N'PG Hoa Hao')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0004', N'Thien Chua')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0005', N'Tin Lanh')
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [F_DIEM_LOAIDIEM] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIDIEM] ([MaLoai])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [F_DIEM_LOAIDIEM]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_HOCKY] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_HOCKY]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [F_GV_MHOC] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [F_GV_MHOC]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HOCSINH_NNC] FOREIGN KEY([MaNNghiepCha])
REFERENCES [dbo].[NGHENGHIEP] ([MaNghe])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HOCSINH_NNC]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HOCSINH_NNM] FOREIGN KEY([MaNNghiepMe])
REFERENCES [dbo].[NGHENGHIEP] ([MaNghe])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HOCSINH_NNM]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HOCSINH_TG] FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[TONGIAO] ([MaTonGiao])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HOCSINH_TG]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HS_DANTOC] FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[DANTOC] ([MaDanToc])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HS_DANTOC]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_GIAOVIEN] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_GIAOVIEN]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_KHOILOP] FOREIGN KEY([MaKhoiLop])
REFERENCES [dbo].[KHOILOP] ([MaKhoiLop])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_KHOILOP]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_NAMHOC] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_NAMHOC]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [F_NGUOIDUNG_LND] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAINGUOIDUNG] ([MaLoai])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [F_NGUOIDUNG_LND]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [F_PC_NAMHOC] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [F_PC_NAMHOC]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_GVIEN] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_GVIEN]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_L]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_MH] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_MH]
GO
ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [F_PL_HS] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
GO
ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [F_PL_HS]
GO
ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [F_PL_KHOI] FOREIGN KEY([MaKhoiLop])
REFERENCES [dbo].[KHOILOP] ([MaKhoiLop])
GO
ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [F_PL_KHOI]
GO
ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [F_PL_LOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [F_PL_LOP]
GO
ALTER TABLE [dbo].[PHANLOP]  WITH CHECK ADD  CONSTRAINT [F_PL_NH] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[PHANLOP] CHECK CONSTRAINT [F_PL_NH]
GO
USE [master]
GO
ALTER DATABASE [QuanLyHocSinhTHPT] SET  READ_WRITE 
GO
