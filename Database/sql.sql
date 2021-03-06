USE [master]
GO
/****** Object:  Database [QuanLyBanXeOTO]    Script Date: 18-10-2018 10:12:21 CH ******/
CREATE DATABASE [QuanLyBanXeOTO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanXeOTO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyBanXeOTO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBanXeOTO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyBanXeOTO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyBanXeOTO] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanXeOTO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanXeOTO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBanXeOTO] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanXeOTO', N'ON'
GO
ALTER DATABASE [QuanLyBanXeOTO] SET QUERY_STORE = OFF
GO
USE [QuanLyBanXeOTO]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 18-10-2018 10:12:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](1000) NOT NULL,
	[HoKhau] [nvarchar](1000) NULL,
	[CMND] [int] NOT NULL,
	[SDT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DongXe]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DongXe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDongXe] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenXe] [nvarchar](100) NULL,
	[MauXe] [nvarchar](100) NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[idDongXe] [int] NOT NULL,
	[TinhTrang] [nchar](10) NULL,
	[NamSX] [int] NULL,
	[SoLuong] [int] NULL,
	[SoGhe] [int] NULL,
	[HopSo] [nchar](10) NULL,
	[Picture] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idKH] [int] NOT NULL,
	[NgayBan] [date] NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinHoaDon]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinHoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idHD] [int] NOT NULL,
	[idXe] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_Order]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Order] as
SELECT KH.TenKH,DX.TenDongXe,Xe.TenXe,Xe.MauXe,Xe.ThanhTien FROM dbo.ThongTinHoaDon AS TT,dbo.HoaDon AS HD,dbo.Xe AS Xe,dbo.KhachHang AS KH,dbo.DongXe AS DX
WHERE TT.idHD = HD.id AND TT.idXe = Xe.id AND KH.id = HD.idKH AND Xe.idDongXe = DX.id
GO
/****** Object:  View [dbo].[lolfs]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lolfs] AS
SELECT TT.id AS N'IDThongTinHD',TT.idHD,TT.idXe,HD.id AS N'IDHopDdong',HD.idKH,HD.NgayBan,Xe.id AS N'IDOFXe',Xe.TenXe,Xe.MauXe,Xe.ThanhTien,Xe.idDongXe,
KH.id AS N'IDKachHang',KH.TenKH,KH.NgaySinh,KH.DiaChi,KH.CMND,KH.SDT,KH.HoKhau,DX.id AS N'IDOFDongXe',DX.TenDongXe
FROM dbo.ThongTinHoaDon AS TT,dbo.HoaDon AS HD,dbo.Xe AS Xe,dbo.KhachHang AS KH,dbo.DongXe AS DX
WHERE TT.idHD = HD.id AND TT.idXe = Xe.id AND KH.id = HD.idKH AND Xe.idDongXe = DX.id 

GO
SET IDENTITY_INSERT [dbo].[DongXe] ON 

INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (1, N'Hatchback')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (2, N'Coupes')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (3, N'Convertible')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (4, N'SUV/Crossover')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (5, N'MPVs')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (7, N'Sedan')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (8, N'Van/Minivan')
INSERT [dbo].[DongXe] ([id], [TenDongXe]) VALUES (9, N'Truck/Pick up')
SET IDENTITY_INSERT [dbo].[DongXe] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([id], [idKH], [NgayBan], [TrangThai]) VALUES (1, 1, CAST(N'2018-10-18' AS Date), N'Đã thanh toán')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id], [TenKH], [NgaySinh], [DiaChi], [HoKhau], [CMND], [SDT]) VALUES (1, N'huy', CAST(N'2018-10-18' AS Date), N'huhuh', N'huhuu', 1111, 33333)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] ON 

INSERT [dbo].[ThongTinHoaDon] ([id], [idHD], [idXe]) VALUES (1, 1, 42)
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] OFF
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([id], [TenXe], [MauXe], [ThanhTien], [idDongXe], [TinhTrang], [NamSX], [SoLuong], [SoGhe], [HopSo], [Picture]) VALUES (41, N'huy vios', N'ggg', 10000000000, 1, N'Mới       ', 2018, 5, 5, N'Tự động   ', NULL)
INSERT [dbo].[Xe] ([id], [TenXe], [MauXe], [ThanhTien], [idDongXe], [TinhTrang], [NamSX], [SoLuong], [SoGhe], [HopSo], [Picture]) VALUES (42, N'chro', N'xanh', 3000000000, 1, N'Mới       ', 2016, 4, 3, N'Tự động   ', N'C:\Users\micky\OneDrive\Desktop\project\Quan-LY-Ban-O-To\Resources\Quinn_OriginalSkin2.jpg')
INSERT [dbo].[Xe] ([id], [TenXe], [MauXe], [ThanhTien], [idDongXe], [TinhTrang], [NamSX], [SoLuong], [SoGhe], [HopSo], [Picture]) VALUES (43, N'Vios Pro', N'xanh', 560000000, 7, N'Mới       ', 2017, 5, 4, N'Số tay    ', N'C:\Users\micky\OneDrive\Desktop\project\Quan-LY-Ban-O-To\Resources\images.jpg')
SET IDENTITY_INSERT [dbo].[Xe] OFF
ALTER TABLE [dbo].[DongXe] ADD  DEFAULT (N'Tên ô tô') FOR [TenDongXe]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayBan]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (N'DONE!!!') FOR [TrangThai]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Tên khách hàng') FOR [TenKH]
GO
ALTER TABLE [dbo].[Xe] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idHD])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idHD])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([id])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([idDongXe])
REFERENCES [dbo].[DongXe] ([id])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([idDongXe])
REFERENCES [dbo].[DongXe] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemDH_And_HoaDon]    Script Date: 18-10-2018 10:12:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemDH_And_HoaDon]
@TenKH NVARCHAR(100),@NgaySinh DATE,@DiaChi NVARCHAR(1000),@CMND INT,@SDT INT,@HoKhau NVARCHAR(1000),@Tenxe NVARCHAR(100),@mauXe NVARCHAR(100),@ThanhTien FLOAT,@IdDoongXe int
AS
BEGIN
	INSERT dbo.KhachHang(TenKH,NgaySinh,DiaChi,CMND,SDT,HoKhau) 
	VALUES(@TenKH, @NgaySinh, @DiaChi,@CMND, @SDT,@HoKhau)	

	DECLARE @IDKH INT = 0
	SELECT @IDKH = MAX(KH.id) FROM dbo.KhachHang AS KH


	INSERT dbo.HoaDon(idKH,NgayBan,TrangThai)VALUES( @IDKH,GETDATE(), N'Đã thanh toán')
	---------
	DECLARE @IdHD INT = 0
	SELECT @IdHD  = MAX(HD.id) FROM dbo.HoaDon AS HD

	DECLARE @IDXe INT = 0
	SELECT @IDXe = x.id FROM dbo.Xe AS X
	WHERE X.idDongXe = @IdDoongXe AND X.MauXe = @mauXe AND X.TenXe = @Tenxe AND X.ThanhTien = @ThanhTien

	INSERT dbo.ThongTinHoaDon(idHD,idXe) VALUES(@IdHD,@IDXe)

END
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanXeOTO] SET  READ_WRITE 
GO
