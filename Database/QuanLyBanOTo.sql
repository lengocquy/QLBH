CREATE DATABASE QuanLyBanXE
GO 

USE QuanLyBanXE
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
	CMND INT NOT NULL,
	SDT INT NOT NULL,
	Gioitinh INT NOT NULL,
)
GO

CREATE TABLE DongXe -- dòng xe
( 
	id INT IDENTITY PRIMARY KEY,
	TenDongXe NVARCHAR(100) NOT NULL DEFAULT N'Tên ô tô',-- tên dòng xe
)
GO
CREATE TABLE MauXe
(
	id INT IDENTITY PRIMARY KEY,
	Mau NVARCHAR(100)
)
GO

CREATE TABLE Xe -- xe
(
	id INT IDENTITY PRIMARY KEY,
	TenXe NVARCHAR(100), -- tên xe
	idMauXe INT NOT NULL,
	ThanhTien FLOAT NOT NULL DEFAULT 0,
	idDongXe INT NOT NULL

	FOREIGN KEY (idMauXe) REFERENCES dbo.MauXe(id),
	FOREIGN KEY (idDongXe) REFERENCES dbo.DongXe(id)	
)
GO
SELECT * FROM dbo.Xe


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
SELECT *FROM dbo.Xe
-----------------------------------------Màu xe-----------------------------------------
INSERT dbo.MauXe (Mau) VALUES(N'Đỏ')
INSERT dbo.MauXe (Mau) VALUES(N'Trăng')
INSERT dbo.MauXe (Mau) VALUES(N'Xanh')
INSERT dbo.MauXe (Mau) VALUES(N'Bạc')
INSERT dbo.MauXe (Mau) VALUES(N'Đen')
INSERT dbo.MauXe (Mau) VALUES(N'Hồng')
INSERT dbo.MauXe (Mau) VALUES(N'Xanh Nước Biên')
INSERT dbo.MauXe (Mau) VALUES(N'Cam')
SELECT * FROM dbo.MauXe
--------------------------------------------------------------------------------------
----------------------------------------- dòng xe ---------------------------------------
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Saloons' ) -- 7
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Coupes' ) -- 8
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'Cabriolets/ Roadsters' ) -- 9 
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'SUV' ) -- 10
INSERT dbo.DongXe ( TenDongXe ) VALUES ( N'MPVs' ) -- 11

-----------------------------------------------------------------------------------------
---------------------------------------- XE----------------------------------------------
---------------------- Loại Saloons -------------------------------------
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(N'', N'',0.0,0)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Aston Martin Vanquish',  N'Đen', 950000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Aston Martin Vanquish',  N'Trắng', 950000000, 7)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Đen', 199220000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Đỏ', 159220000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Demon',  N'Trắng', 159220000, 7)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari 812 Superfast',  N'Đen', 925000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari 812 Superfast',  N'Xanh', 965000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari 812 Superfast',  N'Trắng', 925000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ferrari 812 Superfast',  N'Đỏ', 9250030000, 7)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ford Mustang',  N'Đen', 102000000, 7)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đen', 140000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Trắng', 145000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đỏ', 140000000, 7)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đen', 160000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Trắng', 160000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đỏ', 190000000, 7)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Xanh', 160000000, 7)
GO
SELECT * FROM dbo.Xe
-------------------------------------------------------------------------------------------
---------------------- Loại Coupes -------------------------------------
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette',  N'Xanh', 160000000, 8)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette',  N'Bạc', 160000000, 8)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Chevrolet Corvette',  N'Đen', 160000000, 8) 

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Trắng', 160000000, 8)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Xanh đen', 160000000, 8)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Dodge Rampage',  N'Hồng', 160000000, 8)

--------------------- Loại Cabriolets/ Roadsters-------------------------------------------------
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Ford Mustang',  N'Đen', 102000000, 9)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đen', 140000000, 9)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Trắng', 145000000,9)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'AMC Javelin',  N'Đỏ', 140000000, 9)

INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đen', 160000000, 9)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Trắng', 160000000, 9)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Đỏ', 190000000, 9)
INSERT dbo.Xe(TenXe,MauXe,ThanhTien,idDongXe) VALUES(   N'Buick Roadmaster',  N'Xanh', 160000000, 9)
-------------------------------------------------------------------------
-----------------------------------------------------------------------------------------



SELECT MauXe FROM dbo.Xe  WHERE TenXe = N'Dodge Rampage'

SELECT * FROM dbo.Xe 
WHERE idDongXe = 7
