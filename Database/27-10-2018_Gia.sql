CREATE DATABASE QuanLyBanXeOTO
go

USE QuanLyBanXeOTO
GO 


CREATE TABLE KhachHang
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenKH NVARCHAR(100) NOT NULL DEFAULT N'Tên khách hàng',
	NgaySinh DATE NOT NULL,-- ngảy sinh
	DiaChi NVARCHAR(1000) NOT NULL,
	HoKhau NVARCHAR(1000),
	CMND INT NOT NULL ,
	SDT INT NOT NULL,
)
GO

CREATE TABLE DongXe -- dòng xe
( 
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenDongXe NVARCHAR(100) NOT NULL DEFAULT N'Tên ô tô',-- tên dòng xe
)
GO


CREATE TABLE Xe -- xe
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenXe NVARCHAR(100), -- tên xe
	MauXe NVARCHAR(100) NOT NULL,
	ThanhTien FLOAT NOT NULL DEFAULT 0,
	idDongXe INT NOT NULL,
	TinhTrang NVARCHAR(10) NOT NULL DEFAULT N'Mới',
	NamSX int NOT NULL,
	SoLuong int NOT NULL,
	SoGhe int NOT NULL,
	HopSo nchar(10) NOT NULL,
	Picture nvarchar(1000) NOT NULL DEFAULT N'icons8_Bug_100px.png',

	FOREIGN KEY (idDongXe) REFERENCES dbo.DongXe(id)	
)
GO


CREATE TABLE HoaDon
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	idKH INT NOT NULL,
	NgayBan DATE NOT NULL DEFAULT GETDATE(), -- ngày bán
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'DONE!!!' -- done --- chưa nhận xe

	FOREIGN KEY (idKH) REFERENCES dbo.KhachHang(id)
) 


GO

CREATE TABLE ThongTinHoaDon
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	idHD INT NOT NULL, -- hóa đơn
	idXe INT NOT NULL, -- xe 

	FOREIGN KEY (idHD) REFERENCES dbo.HoaDon(id),
	FOREIGN KEY (idXe) REFERENCES dbo.Xe(id)
)
GO

------- INSERT --------------------
INSERT dbo.DongXe(TenDongXe) VALUES(N'Hatchback') -- 1
INSERT dbo.DongXe(TenDongXe) VALUES(N'Coupes') -- 2 
INSERT dbo.DongXe(TenDongXe) VALUES(N'SUV/Crossover') -- 3
INSERT dbo.DongXe(TenDongXe) VALUES(N'Sedan') -- 4
INSERT dbo.DongXe(TenDongXe) VALUES(N'Van/Minivan') -- 5 
INSERT dbo.DongXe(TenDongXe) VALUES(N'Truck/Pick up') -- 6

------------ Dòng XE 1 ---------------

INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Prius 1.5 AT 2010', N'Trắng', 1500000000, 1, N'Mới', 2010, 4, 5, N'Tự động', N'Prius 1.5 AT 2010Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Prius 1.5 AT 2010 (Cũ)', N'Trắng', 1300000000, 1, N'Cũ', 2010, 4, 5, N'Tự động', N'Prius 1.5 AT 2010Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Yaris 1.5G 2018', N'Vàng', 720000000, 1, N'Mới', 2018, 7, 5, N'Tự động', N'Yaris 1.5G 2018Vàng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Yaris 1.5G 2018', N'Vàng (Cũ)', 500000000, 1, N'Cũ', 2018, 7, 5, N'Tự động', N'Yaris 1.5G 2018Vàng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Yaris 1.5G 2018', N'Đỏ', 720000000, 1, N'Mới', 2018, 21, 5, N'Tự động', N'Yaris 1.5G 2018Đỏ.jpg')
------------ Dòng XE 2 ---------------
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'86 2.0 AT 2012 (Cũ)', N'Đỏ', 1035000000, 2, N'Cũ', 2012, 3, 4, N'Tự động', N'47.jpg')

------------ Dòng XE 3 ---------------
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Innova 2.0E 2015 (Cũ)', N'Bạc', 700000000, 3, N'Cũ', 2015, 11, 8, N'Số tay', N'Innova 2.0E 2015Bạc.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Prado VX 2.7L 2018', N'Đen', 2340000000, 3, N'Mới', 2018, 22, 7, N'Tự động', N'Prado VX 2.7L 2018Đen.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Fortuner 2.4G 4x2 MT 2017 (Cũ)', N'Đen', 1600000000, 3, N'Cũ', 2017, 33, 7, N'Tự động', N'Fortuner 2.4G 4x2 MT 2017Đen.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Innova 2.0E 2018', N'Bạc', 743500000, 3, N'Mới', 2018, 42, 8, N'Số tay', N'Innova 2.0E 2018Bạc.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Land Cruiser VX 4.6 V8 2015 (Cũ)', N'Nâu', 2790000000, 3, N'Cũ', 2015, 3, 8, N'Số tay', N'Land Cruiser VX 4.6 V8 2015Nâu.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Toyota Fortuner 2.7V 4x2 AT 2018', N'Trắng', 1150000000, 3, N'Mới', 2018, 20, 8, N'Tự động', N'Toyota Fortuner 2.7V 4x2 AT 2018Trắng.png')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Toyota Fortuner 2.7V 4x2 AT 2018', N'Đen', 1150000000, 3, N'Mới', 2018, 11, 8, N'Tự động', N'Toyota Fortuner 2.7V 4x2 AT 2018Đen.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Toyota Fortuner 2.7V 4x2 AT 2018 (Cũ)', N'Bạc', 1050000000, 3, N'Cũ', 2018, 7, 8, N'Tự động', N'Toyota Fortuner 2.7V 4x2 AT 2018Bạc.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Toyota Fortuner 2.7V 4x2 AT 2018 ', N'Bạc', 2550000000, 3, N'Mới', 2018, 7, 8, N'Tự động', N'Toyota Fortuner 2.7V 4x2 AT 2018Bạc.jpg')

------------ Dòng XE 4 ---------------
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Corolla altis 2.0V Sport 2018', N'Đen', 940000000, 4, N'Mới', 2018, 42, 5, N'Tự động', N'Corolla altis 2.0V Sport 2018Đen.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Camry 2.0E 2017', N'Trắng', 985000000, 4, N'Mới ', 2017, 20, 5, N'Tự động', N' Camry 2.0E 2017Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Vios 1.5G 2018', N'Trắng', 780000000, 4, N'Mới', 2018, 55, 5, N'Tự động', N'Vios 1.5G 2018Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Vios 1.5G 2018', N'Đỏ', 780000000, 4, N'Mới', 2018, 30, 5, N'Tự động', N'Vios 1.5G 2018Đỏ.jpg')
------------ Dòng XE 5 ---------------
------------ Dòng XE 6 ---------------
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Hilux 2.4E 4x2 AT 2018 (Cũ)', N'Đỏ', 890000000, 6, N'Cũ', 2018, 17, 5, N'Tự động', N'Hilux 2.4E 4x2 AT 2018Đỏ.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Hilux 2.4E 4x2 AT 2018', N'Đỏ', 990000000, 6, N'Mới', 2018, 17,75, N'Tự động', N'Hilux 2.4E 4x2 AT 2018Đỏ.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Hilux 2.4E 4x2 AT 2018 ', N'Bạc', 950000000, 6, N'Mới', 2018, 13, 5, N'Tự động', N'Hilux 2.4E 4x2 AT 2018Bạc.png')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Hiace 2.5 2015 (Cũ)', N'Trắng', 900000000, 6, N'Cũ', 2015, 4, 16, N'Số tay', N'Hiace 2.5 2015Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Hiace 2.5 2015', N'Trắng', 1000000000, 6, N'Mới', 2015, 10, 16, N'Số tay', N'Hiace 2.5 2015Trắng.jpg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Sienna Limited 3.5 AWD 2014 (Cũ)', N'Kem', 2790000000, 6, N'Cũ', 2014, 5, 7, N'Tự động', N'Sienna Limited 3.5 AWD 2014Kemjpeg')
INSERT dbo.Xe (TenXe,MauXe,ThanhTien,idDongXe,TinhTrang,NamSX,SoLuong,SoGhe,HopSo,Picture) VALUES (N'Sienna Limited 3.5 2009 (Cũ)', N'Kem', 1580000000, 6, N'Cũ', 2009, 2, 7, N'Tự động', N'Sienna Limited 3.5 2009Kem.jpg')
-----------------------------------


GO

SELECT * FROM dbo.Xe


----- Xử lý ------------
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
	DECLARE @SoLuongXe INT = 0
	SELECT @IDXe = x.id,@SoLuongXe = X.SoLuong FROM dbo.Xe AS X
	WHERE X.idDongXe = @IdDoongXe AND X.MauXe = @mauXe AND X.TenXe = @Tenxe AND X.ThanhTien = @ThanhTien

	UPDATE dbo.Xe SET SoLuong = SoLuong - 1 WHERE id = @IDXe


	INSERT dbo.ThongTinHoaDon(idHD,idXe) VALUES(@IdHD,@IDXe)

END
GO

DROP PROC USP_ThemDH_And_HoaDon
Go

ALTER PROC USP_ThemDH_And_HoaDon_Khi_Co_IDKH
@Tenxe NVARCHAR(100),@mauXe NVARCHAR(100),@ThanhTien FLOAT,@IdDoongXe INT,@IdKH int
AS
BEGIN
	----  hoa đơn Table
	INSERT dbo.HoaDon(idKH,NgayBan,TrangThai)VALUES(@IdKH,GETDATE(), N'Đã thanh toán')

	----- thong tin háo đơn table
	DECLARE @IdHD INT = 0
	SELECT @IdHD  = MAX(HD.id) FROM dbo.HoaDon AS HD

	DECLARE @IDXe INT = 0
	DECLARE @SoLuongXe INT = 0
	SELECT @IDXe = x.id,@SoLuongXe = X.SoLuong FROM dbo.Xe AS X
	WHERE X.idDongXe = @IdDoongXe AND X.MauXe = @mauXe AND X.TenXe = @Tenxe AND X.ThanhTien = @ThanhTien
	
	UPDATE dbo.Xe SET SoLuong = SoLuong - 1 WHERE id = @IDXe

	INSERT dbo.ThongTinHoaDon(idHD,idXe) VALUES(@IdHD,@IDXe)
END
GO


CREATE VIEW view_Order as
SELECT KH.TenKH,KH.CMND,DX.TenDongXe,Xe.TenXe,Xe.MauXe,Xe.ThanhTien,HD.NgayBan FROM dbo.ThongTinHoaDon AS TT,dbo.HoaDon AS HD,dbo.Xe AS Xe,dbo.KhachHang AS KH,dbo.DongXe AS DX
WHERE TT.idHD = HD.id AND TT.idXe = Xe.id AND KH.id = HD.idKH AND Xe.idDongXe = DX.id
GO

go
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
	DECLARE @IdDongXe INT = 1

	SELECT @IdDongXe = Dx.id FROM dbo.DongXe AS DX
	WHERE TenDongXe = @TenDongXe

	---- lấy ID Xe 
	DECLARE @idXe INT = 1
	SELECT @idXe = X.id FROM dbo.Xe AS X
	WHERE x.idDongXe = @IdDongXe AND X.TenXe = @Tenxe AND X.MauXe = @Mauxe AND X.ThanhTien = @Thanhtien  
	
	---- lấy thông tin hóa đơn 
	------ lấy ID Khách hàng
	DECLARE @IDKH INT = 1
	SELECT @IDKH = id FROM dbo.KhachHang
	WHERE CMND = @CMND

	----- lấy Id cua đơn hàng
	DECLARE @IdHD INT = 1
	SELECT @IdHD = HD.id FROM dbo.HoaDon AS HD
	WHERE NgayBan = @NgayBan AND idKH = @IDKH
	-----  vô thông tin đơn hàng sửa IDxe
	UPDATE dbo.ThongTinHoaDon SET idXe = @idXe
	WHERE idHD = @IdHD
	----------
END
GO


CREATE PROC USP_Edit_ThongTinKhachHang
@TenKH NVARCHAR(100),@DiaChiKH NVARCHAR(1000),@HoKhauKH NVARCHAR(1000),@SDT INT,@CMND INT,@NgaySinh DATE
AS
BEGIN
	---sửa thông tin của khách hàng
	UPDATE  dbo.KhachHang SET TenKH = @TenKH,NgaySinh = @NgaySinh,DiaChi = @DiaChiKH,CMND = @CMND,SDT = @SDT,HoKhau = @HoKhauKH
	WHERE TenKH = @TenKH 
END
GO
DROP PROC USP_Edit_ThongTinKhachHang
GO

CREATE PROC USP_ThongKe
@NgayBatDau date,@NgayKetThua date
AS
BEGIN
	SELECT * FROM dbo.view_Order WHERE NgayBan >= @NgayBatDau AND NgayBan <= @NgayKetThua
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1]
 ( 
	@strInput NVARCHAR(4000) 
 ) RETURNS NVARCHAR(4000) 
 AS 
 BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
				BEGIN 
					IF @COUNTER=1 
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
					ELSE 
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
				END 
			SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

----------------------


SELECT * FROM dbo.view_Order
SELECT * FROM dbo.KhachHang

DELETE dbo.KhachHang
GO
---
CREATE PROC USP_ThemDH_And_HoaDon
@
