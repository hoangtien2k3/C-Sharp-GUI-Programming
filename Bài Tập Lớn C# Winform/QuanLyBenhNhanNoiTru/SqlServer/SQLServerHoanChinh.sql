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

-- tạo bảng lễ tân
CREATE TABLE LeTan 
(
    MaBN NVARCHAR(30) NOT NULL PRIMARY KEY,
    TenBN NVARCHAR(50) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	CCCD VARCHAR(20) NOT NULL, 
    DiaChi NVARCHAR(20) NOT NULL,
	BHYT NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(15) NOT NULL,
    ImageData VARBINARY(MAX) NOT NULL
);
GO

-- tạo bảng bệnh nhân
CREATE TABLE BenhNhan 
(
    MaBN NVARCHAR(30) NOT NULL PRIMARY KEY,
    TenBN NVARCHAR(50) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,

	CCCD VARCHAR(20) NOT NULL, 

    DiaChi NVARCHAR(20) NOT NULL,
	BHYT NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(15) NOT NULL,
    ImageData VARBINARY(MAX) NOT NULL
);
GO


-- tạo bảng bác sĩ
CREATE TABLE BacSi
(
    MaBS NVARCHAR(30) NOT NULL PRIMARY KEY,
    TenBS NVARCHAR(50) NOT NULL,
    KinhNghiem NVARCHAR(30) NOT NULL,
	ChuyenKhoa NVARCHAR(50) NOT NULL
);
GO


-- tạo bảng giường bệnh
CREATE TABLE GiuongBenh
(
	ChuyenKhoa NVARCHAR(50) NOT NULL,		
	LoaiPhong VARCHAR(50) NOT NULL,
	SoPhong VARCHAR(50) NOT NULL,
	SoGiuong VARCHAR(50) NOT NULL,
	MaBN NVARCHAR(30) NOT NULL,
	MaBS NVARCHAR(30) NOT NULL
);
GO

-- tạo bảng khám bệnh
CREATE TABLE ThongTinKhamBenh
(
	MaBS NVARCHAR(30)NOT NULL,
	NgayKham DATE NOT NULL,
	PhongKham NVARCHAR(10)NOT NULL,

	MaBN NVARCHAR(30) NOT NULL,
	ChuyenKhoa NVARCHAR(50) NOT NULL,

	CanNang VARCHAR(50) NOT NULL,
	NhomMau VARCHAR(5) NOT NULL,
	NhietDo NVARCHAR(30) NOT NULL,
	Mach VARCHAR(30) NOT NULL,
	HuyetAp VARCHAR(20) NOT NULL,
	NhipTho NVARCHAR(30) NOT NULL,
	LyDoKham NVARCHAR(500) NOT NULL,
	TinhTrangHienTai NVARCHAR(500) NOT NULL,
	ChuanDoanSoBo NVARCHAR(500) NOT NULL,
	SoNgayNhapVien NVARCHAR(50)NOT NULL,
	HuongDieuTri NVARCHAR(500) NOT NULL,

	PRIMARY KEY(MaBN)
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


CREATE TABLE DieuTri
(
	MaBN NVARCHAR(30) NOT NULL,
	SoNgayNhapVien NVARCHAR(50) NOT NULL,
	Ngay VARCHAR(50) NOT NULL,
	Thuoc NVARCHAR(50) NOT NULL,
	SoLuongThuoc NVARCHAR(50) NOT NULL,
	ThanhTien int NOT NULL
)
GO


CREATE TABLE GiaThuoc
(
	Thuoc NVARCHAR(50) NOT NULL,
	GiaTien NVARCHAR(15) NOT NULL
)
GO


INSERT INTO GiaThuoc(Thuoc, GiaTien) 
VALUES ('Metoprolol', '10000'),
		('Atenolol', '20000'),
		('Nebivolol', '15000'),
		('Amlodipine', '25000'),
		('Nebivolol', '50000'),
		('Divalproex', '1000'),
		('Olanzapine', '13000'),
		('Fluconazole', '12000'),
		('Zolpidem', '10000'),
		('Eszopiclone', '11000'),
		('Ticagrelor', '17000'),
		('Vitamin', '20000'),
		('Meclizine', '10000'),
		('Tolterodine', '15000'),
		('Trazodone', '20000'),
		('Duloxetine', '30000'),
		('Losartan', '35000'),
		('Ramipril', '45000'),
		('Estrogen', '43000'),
		('Niacin', '15000');