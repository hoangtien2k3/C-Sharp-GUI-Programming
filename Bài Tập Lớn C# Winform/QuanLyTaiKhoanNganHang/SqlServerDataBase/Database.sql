CREATE DATABASE QuanLyTaiKhoanNganHang;
GO

USE QuanLyTaiKhoanNganHang;
GO

CREATE TABLE TaiKhoan
(
    TenTaiKhoan NVARCHAR(50) NOT NULL,
    SoTaiKhoan VARCHAR(14) NOT NULL,
    MatKhau VARCHAR(12) NOT NULL,
    LoaiTaiKhoan NVARCHAR(50) NOT NULL,
    DiaChiEmail VARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    CCCD VARCHAR(20) NOT NULL,
    SoDienThoai VARCHAR(12) NOT NULL,
    NgaySinh DATETIME NOT NULL,
    QuocTich NVARCHAR(50) NOT NULL,
    NgheNghiep NVARCHAR(100) NULL,
    ImageData VARBINARY(MAX) NULL,
    CONSTRAINT PK_TaiKhoan PRIMARY KEY (TenTaiKhoan),
    CONSTRAINT UQ_SoTaiKhoan UNIQUE (SoTaiKhoan),
    CONSTRAINT CK_MatKhau CHECK (LEN(MatKhau) >= 6 AND LEN(MatKhau) <= 12),
    CONSTRAINT CK_NgaySinh CHECK (NgaySinh <= GETDATE())
);
GO



CREATE TABLE SoDuTaiKhoan
(
	TenTaiKhoan NVARCHAR(50) NOT NULL,
	SoTaiKhoan VARCHAR(14) NOT NULL,
	CCCD VARCHAR(20) NOT NULL,
	SoTienHienTai VARCHAR(50) DEFAULT '0',
	PRIMARY KEY (TenTaiKhoan)
)
GO


-- Tạo bảng Giao dịch (Transaction):
CREATE TABLE GiaoDich (
    TenTaiKhoan NVARCHAR(50) NOT NULL,
	SoTaiKhoan VARCHAR(14) NOT NULL,
    NgayGiaoDich DATETIME NOT NULL,
    GhiChu NVARCHAR(500) NOT NULL,
	PRIMARY KEY (TenTaiKhoan)
);



-- bảng lưu thông tin giao dịch khi gửi tiền
CREATE TABLE GiaoDichGuiTien (
    SoLanGui INT IDENTITY(1,1) PRIMARY KEY,
    SoTaiKhoan NVARCHAR(50) NOT NULL,
    SoTien DECIMAL(18, 2) NOT NULL,
    NgayGiaoDich VARCHAR(50) NOT NULL,
	GioGiaoDich VARCHAR(50) NOT NULL
);


-- bảng lưu thông tin giao dịch khi gửi tiền
CREATE TABLE GiaoDichChuyenTien (
    SoLanChuyen INT IDENTITY(1,1) PRIMARY KEY,
    SoTaiKhoan NVARCHAR(50) NOT NULL,
    SoTien DECIMAL(18, 2) NOT NULL,
    NgayGiaoDich VARCHAR(50) NOT NULL,
	GioGiaoDich VARCHAR(50) NOT NULL
);


-- bảng lưu thông tin giao dịch khi gửi tiền
CREATE TABLE GiaoDichRutTien (
    SoLanRut INT IDENTITY(1,1) PRIMARY KEY,
    SoTaiKhoan NVARCHAR(50) NOT NULL,
    SoTien DECIMAL(18, 2) NOT NULL,
    NgayGiaoDich VARCHAR(50) NOT NULL,
	GioGiaoDich VARCHAR(50) NOT NULL
);








-- thêm
CREATE TABLE ThongTinTaiKhoan
(
	TenTaiKhoan NVARCHAR(50) NOT NULL,
	SoTaiKhoan VARCHAR(14) NOT NULL,
	MaPin INT NOT NULL
)
GO





CREATE TABLE [User] (
    UserID INT PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    AccountID INT,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

















