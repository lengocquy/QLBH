CREATE DATABASE QuanLyBanXeOTO
GO 

USE QuanLyBanXeOTO
GO 

--- XE 
--- Dòng XE
--- Tài Khoảng
--- Hóa đơn 
--- Thông tin hóa đơn 
--- khách hàng
--- Kho



CREATE TABLE KhachHang
(
	id INT IDENTITY PRIMARY KEY,
	TenKH NVARCHAR(100) NOT NULL DEFAULT N'Tên khách hàng',
	NgaySinh DATE NOT NULL,-- ngảy sinh
	DiaChi NVARCHAR(1000) NOT NULL,
	HoKhau NVARCHAR(1000),
	CMND INT NOT NULL,
	SDT INT NOT NULL,
)
GO

CREATE TABLE DongXe -- dòng xe
( 
	id INT IDENTITY PRIMARY KEY,
	TenDongXe NVARCHAR(100) NOT NULL DEFAULT N'Tên ô tô',-- tên dòng xe
)
GO

CREATE TABLE Xe -- xe
(
	id INT IDENTITY PRIMARY KEY,
	TenXe NVARCHAR(100), -- tên xe
	MauXe NVARCHAR(100) NOT NULL,
	ThanhTien FLOAT NOT NULL DEFAULT 0,
	idDongXe INT NOT NULL
	
	FOREIGN KEY (idDongXe) REFERENCES dbo.DongXe(id)	
)
GO



CREATE TABLE KHO
(
	id INT IDENTITY PRIMARY KEY,
	idXe INT NOT NULL,	
	SoLuong INT NOT NULL DEFAULT 0,
	Nam DATE NOT NULL

	FOREIGN KEY(idXe) REFERENCES dbo.Xe(id)
)
GO

CREATE TABLE HoaDon
(
	id INT IDENTITY PRIMARY KEY,
	idKH INT NOT NULL,
	NgayBan DATE NOT NULL DEFAULT GETDATE(), -- ngày bán
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'DONE!!!' -- done --- chưa nhận xe

	FOREIGN KEY (idKH) REFERENCES dbo.KhachHang(id)
) 


GO

CREATE TABLE ThongTinHoaDon
(
	id INT IDENTITY PRIMARY KEY,
	idHD INT NOT NULL, -- hóa đơn
	idXe INT NOT NULL, -- xe 

	FOREIGN KEY (idHD) REFERENCES dbo.HoaDon(id),
	FOREIGN KEY (idXe) REFERENCES dbo.Xe(id)
)
GO


----------------------------------------- dòng xe ---------------------------------------
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Saloons' ) -- 1
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Coupes' ) -- Trăng
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Cabriolets/ Roadsters' ) -- 3 
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'SUV' ) -- 10
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'MPVs' ) -- 11

-----------------------------------------------------------------------------------------
---------------------------------------- XE----------------------------------------------
---------------------- Loại Saloons -------------------------------------

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Aston Martin Vanquish',  N'Trăng', 350000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Aston Martin Vanquish',  N'Đỏ', 350000000, 1)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Xanh', 133000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Đỏ', 153000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Vàng', 153000000, 1)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari Superfast',  N'Trăng', 350000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari Superfast',  N'Đỏ', 3650000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari Superfast',  N'Đen', 3650000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari Superfast',  N'Xanh', 3350000000, 1)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ford Mustang', N'Trăng', 101400000, 1)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Xanh', 140000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đỏ', 145000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đen', 140000000, 1)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Tím', 160000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đỏ', 160000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Xanh', 130000000, 1)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Vàng', 160000000, 1)
GO
SELECT * FROM dbo.Xe
-------------------------------------------------------------------------------------------
---------------------- Loại Coupes -------------------------------------
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette',  N'Đen', 160000000, 2)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette',  N'Xanh', 160000000, 2)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette', N'Vàng', 160000000, 2) 

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Đen', 160000000, 2)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Đỏ', 160000000, 2)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Xanh', 160000000, 2)

--------------------- Loại Cabriolets/ Roadsters-------------------------------------------------
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ford Mustang',  N'Đen', 140000000, 3)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đỏ', 140000000, 3)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Xanh', 145000000,3)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đen', 140000000, 3)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Vàng', 160000000, 3)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Xanh', 160000000, 3)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Trăng', 130000000, 3)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đen', 160000000, 3)
-------------------------------------------------------------------------
-----------------------------------------------------------------------------------------

CREATE PROC USP_ThemDH_And_HoaDon
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

CREATE VIEW view_Order as
SELECT KH.TenKH,KH.CMND,DX.TenDongXe,Xe.TenXe,Xe.MauXe,Xe.ThanhTien,HD.NgayBan FROM dbo.ThongTinHoaDon AS TT,dbo.HoaDon AS HD,dbo.Xe AS Xe,dbo.KhachHang AS KH,dbo.DongXe AS DX
WHERE TT.idHD = HD.id AND TT.idXe = Xe.id AND KH.id = HD.idKH AND Xe.idDongXe = DX.id
GO
SELECT * FROM dbo.view_Order

---------------
SELECT * FROM dbo.ThongTinHoaDon
UPDATE dbo.ThongTinHoaDon SET idXe = 50 WHERE idHD = 59
SELECT * FROM dbo.HoaDon


DECLARE @IdDongXe INT = 0

SELECT @IdDongXe = Dx.id FROM dbo.DongXe AS DX
WHERE TenDongXe = N'Coupes'
PRINT @IdDongXe

DECLARE @idXe INT = 0

SELECT @idXe = X.id FROM dbo.Xe AS X
WHERE x.idDongXe = @IdDongXe AND X.TenXe = N'Chevrolet Corvette' AND X.MauXe = N'Xanh' AND X.ThanhTien = 160000000  -- 58 
PRINT @idXe

SELECT * FROM dbo.Xe AS X
WHERE x.idDongXe = 2 AND X.TenXe = N'Chevrolet Corvette' AND X.MauXe = N'Xanh' AND X.ThanhTien = 160000000  -- 58

SELECT * FROM dbo.ThongTinHoaDon
SELECT * FROM dbo.HoaDon
GO

CREATE PROC USP_Edit_ThongTinHoaDonVaThongTinKhachHang
@Tenxe NVARCHAR(100),@TenDongXe NVARCHAR(100),@Mauxe NVARCHAR(100),@Thanhtien FLOAT,@TenKH NVARCHAR(100),@DiaChiKH NVARCHAR(1000),@HoKhauKH NVARCHAR(1000),@SDT INT,@CMND INT,@NgaySinh DATE,@NgayBan DATE
AS
BEGIN
	---sửa thông tin của khách hàng
	UPDATE dbo.KhachHang SET TenKH = @TenKH,NgaySinh = @NgaySinh,DiaChi = @DiaChiKH,CMND = @CMND,SDT = @SDT,HoKhau = @HoKhauKH
	WHERE TenKH = @TenKH
	--------------------

	------------------------ sửa thông tin đơn hàng 

	----- lấy ID dòng xe ()
	DECLARE @IdDongXe INT = 0

	SELECT @IdDongXe = Dx.id FROM dbo.DongXe AS DX
	WHERE TenDongXe = @TenDongXe

	---- lấy ID Xe 
	DECLARE @idXe INT = 0
	SELECT @idXe = X.id FROM dbo.Xe AS X
	WHERE x.idDongXe = @IdDongXe AND X.TenXe = @Tenxe AND X.MauXe = @Mauxe AND X.ThanhTien = @Thanhtien  
	
	---- lấy thông tin hóa đơn 
	------ lấy ID Khách hàng
	DECLARE @IDKH INT = 0
	SELECT @IDKH = id FROM dbo.KhachHang
	WHERE CMND = @CMND

	----- lấy Id cua đơn hàng
	DECLARE @IdHD INT = 0
	SELECT @IdHD = HD.id FROM dbo.HoaDon AS HD
	WHERE NgayBan = @NgayBan AND idKH = @IDKH
	-----  vô thông tin đơn hàng sửa IDxe
	UPDATE dbo.ThongTinHoaDon SET idXe = @idXe
	WHERE idHD = @IdHD
	----------
END
GO


CREATE PROC USP_ThongKe
@NgayBatDau date,@NgayKetThua date
AS
BEGIN
	SELECT * FROM dbo.view_Order WHERE NgayBan >= @NgayBatDau AND NgayBan <= @NgayKetThua
END
go

EXECUTE dbo.USP_ThongKe @NgayBatDau = '2018-10-01',  @NgayKetThua = '2018-10-19'



SELECT * FROM dbo.view_Order
