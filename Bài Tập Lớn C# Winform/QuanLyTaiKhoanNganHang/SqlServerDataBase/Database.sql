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
    CONSTRAINT CK_GioiTinh CHECK (GioiTinh IN ('Nam', 'Nữ', 'Khác')),
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




















