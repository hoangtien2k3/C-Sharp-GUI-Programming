-- Kiểm tra xem database đã tồn tại hay chưa
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuanLyBenhNhanNoiTru')
BEGIN
    -- Tạo database mới
    CREATE DATABASE QuanLyBenhNhanNoiTru
END
GO


USE QuanLyBenhNhanNoiTru
GO


-- tạo bảng tài khoản.
CREATE TABLE TaiKhoan 
(
    TaiKhoan NVARCHAR(30) NOT NULL,
    MatKhau NVARCHAR(30) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    PRIMARY KEY (TaiKhoan, Email)
);


-- tạo bảng bệnh nhân
CREATE TABLE BenhNhan 
(
    MaBN NVARCHAR(30) NOT NULL PRIMARY KEY,
    TenBN NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NOT NULL,
	Tuoi INT NOT NULL,
    DienThoai NVARCHAR(15) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    NhomMau NVARCHAR(10) NOT NULL,
    LoaiBenh NVARCHAR(70) NOT NULL,
    ImageData VARBINARY(MAX) NOT NULL
);
GO


-- tạo bảng bác sĩ
CREATE TABLE BacSi
(
    MaBS NVARCHAR(30) NOT NULL PRIMARY KEY,
    TenBS NVARCHAR(50) NOT NULL,
    KinhNghiem NVARCHAR(30) NOT NULL,
    TuoiTac INT NOT NULL,
	ChuyenKhoa NVARCHAR(50) NOT NULL
);
GO


-- tạo bảng bệnh án
CREATE TABLE BenhAn
(
    MaBN NVARCHAR(30) NOT NULL,
    DoiTuong INT NOT NULL,
    CCCD VARCHAR(14) NOT NULL,
    Khoa NVARCHAR(40) NOT NULL,
    BHYT NVARCHAR(50) NOT NULL,
    DanToc NVARCHAR(20) NOT NULL,
    QuocTich NVARCHAR(50) NOT NULL,
    NgheNghiep NVARCHAR(60) NOT NULL,
    TienSuBenh NVARCHAR(40) NOT NULL,
    LoaiBenh NVARCHAR(50) NOT NULL,
    ChieuCao NVARCHAR(20) NOT NULL,
    CanNang NVARCHAR(20) NOT NULL,
    NgayKhamBenh DATETIME,
    PRIMARY KEY(MaBN, CCCD),
    UNIQUE(CCCD)
);
GO


-- tạo bảng lễ tân
CREATE TABLE LeTan 
(
    MaBN NVARCHAR(30) NOT NULL,
    MaBA NVARCHAR(30) NOT NULL,
    HoTen NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NOT NULL,
	ImageData VARBINARY(MAX) NOT NULL,
	PRIMARY KEY(MaBN, MaBA)
);
GO


-- tạo bảng khám bệnh
CREATE TABLE ThongTinKhamBenh
(
	NgayKham DATETIME NOT NULL,
	MaBS NVARCHAR(30)NOT NULL,
	PhongKham NVARCHAR(10)NOT NULL,
	MaBN NVARCHAR(30) NOT NULL,
	CanNang VARCHAR(50) NOT NULL,
	NhomMau VARCHAR(5) NOT NULL,
	NhietDo NVARCHAR(30) NOT NULL,
	Mach VARCHAR(30) NOT NULL,
	HuyetAp VARCHAR(20) NOT NULL,
	NhipTho NVARCHAR(30) NOT NULL,
	LyDoKham NVARCHAR(500) NOT NULL,
	TinhTrangHienTai NVARCHAR(500) NOT NULL,
	PRIMARY KEY(MaBN, MaBS)
);
GO


-- tạo bảng nội dung khám bệnh
CREATE TABLE NoiDungKhamBenh
(
	MaBN NVARCHAR(30) PRIMARY KEY NOT NULL,
	ChuanDoanSoBo NVARCHAR(500)NOT NULL,
	TrieuChungThem NVARCHAR(500) NOT NULL,
	HuongDieuTri NVARCHAR(500) NOT NULL
);
GO


-- tạo bảng báo cáo viện phí
CREATE TABLE BaoCaoVienPhi
(
	MaBN NVARCHAR(30) PRIMARY KEY NOT NULL,
	TenBN NVARCHAR(50) NOT NULL,
	TienTamUng FLOAT NOT NULL,
	TienPhatSinh FLOAT NOT NULL,
	TongChiPhi FLOAT NOT NULL
);
GO


-- tạo bảng giường bệnh
CREATE TABLE GiuongBenh
(
	MaBN NVARCHAR(30) PRIMARY KEY NOT NULL,
	SoTang NVARCHAR(50) NOT NULL,
	SoPhong NVARCHAR(50) NOT NULL,
	SoGiuong NVARCHAR(50) NOT NULL
);
GO

/*
-- Tạo khóa ngoại giữa bảng BenhNhan và bảng BenhAn:
ALTER TABLE BenhAn
ADD CONSTRAINT fk_BenhAn_BenhNhan 
FOREIGN KEY (MaBN) 
REFERENCES BenhNhan(MaBN) ON DELETE CASCADE;


-- Tạo khóa ngoại giữa bảng BenhNhan và bảng LeTan:
ALTER TABLE LeTan
ADD CONSTRAINT FK_LeTan_BenhNhan
FOREIGN KEY (MaBN)
REFERENCES BenhNhan(MaBN) ON DELETE CASCADE;


-- Tạo khóa ngoại giữa bảng ThongTinKhamBenh và bảng BenhNhan:
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_ThongTinKhamBenh_BenhNhan
FOREIGN KEY (MaBN)
REFERENCES ThongTinKhamBenh(MaBN) ON DELETE CASCADE;


-- Tạo khóa ngoại giữa bảng ThongTinKhamBenh và bảng BacSi:
ALTER TABLE BacSi
ADD CONSTRAINT FK_ThongTinKhamBenh_BacSi
FOREIGN KEY (MaBS)
REFERENCES ThongTinKhamBenh(MaBS);


-- Tạo khóa ngoại giữa bảng NoiDungKhamBenh và bảng BenhNhan:
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_NoiDungKhamBenh_BenhNhan
FOREIGN KEY (MaBN)
REFERENCES NoiDungKhamBenh(MaBN) ON DELETE CASCADE;


-- Tạo khóa ngoại giữa bảng BaoCaoVienPhi và bảng BenhNhan:
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_BaoCaoVienPhi_BenhNhan
FOREIGN KEY (MaBN)
REFERENCES BaoCaoVienPhi(MaBN) ON DELETE CASCADE;


-- Tạo khóa ngoại giữa bảng GiuongBenh và bảng BenhNhan:
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_GiuongBenh_BenhNhan
FOREIGN KEY (MaBN)
REFERENCES GiuongBenh(MaBN) ON DELETE CASCADE;
*/

