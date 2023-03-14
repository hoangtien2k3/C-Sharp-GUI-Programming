Use QuanLyBenhNhanNoiTru
Go

-- tạo bảng bệnh nhân
Create Table BenhNhan
(
	MaBN nvarchar(20) not null primary key,
	TenBN nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	NgaySinh DateTime not null,
	Tuoi int not null,
	DienThoai nvarchar(15) not null,
	GioiTinh nvarchar(10) not null,
	NhomMau nvarchar(10) not null,
	LoaiBenh nvarchar(70) not null
)
Go


-- tạo bảng bác sĩ
Create Table BacSi
(
	MaBS nvarchar(30) not null primary key,
	MaBN nvarchar(30) not null,
	TenBS nvarchar(50) not null,
	KinhNghiem nvarchar(30) not null,
	TuoiTac int not null,
	ChuyenKhoa nvarchar(50) not null
)
Go

-- tạo bảng tài khoản.
Create Table TaiKhoan
(
	TaiKhoan nvarchar(30) not null primary key,
	MatKhau nvarchar(30) not null,
	Email nvarchar(50) not null
)
Go

