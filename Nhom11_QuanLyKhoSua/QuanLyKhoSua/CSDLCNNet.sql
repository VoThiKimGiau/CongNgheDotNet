create database QLKhoCHSua
go
use QLKhoCHSua
go

create table NhaCungCap(
  MaNCC char(6),
  TenNCC Nvarchar(30),
  DiaChi Nvarchar(100),
  SDT char(10),
  Email varchar(30),
  constraint PK_NhaCungCap primary key (MaNCC)
)

create table DanhMucSP(
  MaDM char(5),
  TenDM Nvarchar(50),
  constraint PK_DanhMucSP primary key (MaDM)
)

create table SanPham(
  MaSP char(5),
  MaNCC char(6),
  MaDM char(5),
  TenSP Nvarchar(100),
  SoLuong int,
  DVT Nvarchar(10),
  DonGia DECIMAL(18, 2),
  constraint PK_SanPham primary key (MaSP)
)

create table LoaiPhieu(
  MaLoaiPhieu char(5),
  TenLoaiPhieu Nvarchar(10),
  constraint PK_LoaiPhieu primary key (MaLoaiPhieu)
)

create table Phieu (
  MaPhieu char(4),
  MaLoaiPhieu char(5),
  Ngay date,
  TongTien int,
  constraint PK_Phieu primary key (MaPhieu)
)

create table ChiTiet (
  MaCT char(5),
  MaPhieu char(4),
  MaSP char(5),
  SoLuong int,
  DonGia int,
  constraint PK_ChiTiet primary key (MaCT)
)

CREATE TABLE NhanVien(
	MaNV char(5),
	Pass varchar(12),
	TenNV Nvarchar(50),
	SDT varchar(15),
	Email varchar(50),
	DiaChi Nvarchar(80),
	ChucVu Nvarchar(50),
	TrinhDo Nvarchar(50),
	NamSinh int,
	GioiTinh Nvarchar(5),
	constraint PK_NHANVIEN primary key (MaNV)
)

alter table SanPham
add constraint FK_SanPham_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC),
constraint FK_SanPham_DanhMucSP foreign key (MaDM) references DanhMucSP(MaDM)

alter table Phieu
add constraint FK_Phieu_LoaiPhieu foreign key (MaLoaiPhieu) references LoaiPhieu(MaLoaiPhieu)

alter table ChiTiet
add constraint FK_ChiTiet_Phieu foreign key (MaPhieu) references Phieu(MaPhieu),
constraint FK_ChiTiet_SanPham foreign key (MaSP) references SanPham(MaSP)

alter table NhanVien
add constraint CK_NhanVien_GioiTinh check (GioiTinh in ('Nam', N'Nữ')),
constraint CK_NhanVien_NamSinh check (year(getdate() - NamSinh) >= 18),
constraint DF_NhanVien_Pass default '123' for Pass

GO
CREATE TRIGGER UPD_TONGTIEN1 ON ChiTiet
AFTER INSERT, UPDATE
AS
	BEGIN
		UPDATE Phieu
			SET Tongtien = S.DonGia * inserted.SoLuong 
			FROM SANPHAM S,inserted 
			WHERE S.MaSP = inserted.MaSP
	END
GO
/*Thêm dữ liệu*/

INSERT INTO NhanVien(MaNV, Pass, TenNV, SDT, Email, DiaChi, ChucVu, TrinhDo, NamSinh, GioiTinh)
VALUES
('NV001', '123456', N'Nguyễn Văn Hùng', '0234567890', 'hungnguyen123@mail.com', N'123 Đường Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1', N'Nhân viên', N'12/12', 1980, N'Nam'),
('NV002', 'abcd', N'Lê Thị Mai', '0876543210', 'maile234@mail.com', N'100 Đường Điện Biên Phủ, Phường 10, Quận Bình Thạnh', N'Nhân viên', N'12/12', 1985, N'Nữ'),
('NV003', '123456', N'Trần Ngọc Huyền', '0112223333', 'huyentran123@mail.com', N'789 Đường Nguyễn Văn Cừ, Phường 2, Quận 5', N'Quản lí', N'12/12', 1990, N'Nữ'),
('NV004', '0123ab', N'Phạm Đức Thành', '0445556666', 'thanhphamduc@mail.com', N'1011 Đường Nguyễn Trãi, Phường 2, Quận 5', N'Nhân viên', N'12/12', 1995, N'Nam'),
('NV005', '147cbd', N'Huỳnh Khánh Ly', '0778889999', 'lykhanhhuynh@mail.com', N'1213 Đường Điện Biên Phủ, Phường 15, Quận Bình Thạnh', N'Nhân viên', '12/12', 2000, N'Nữ');

-- Thêm dữ liệu cho bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email)
VALUES
  ('NCC01', N'Giấc mơ sữa Việt', N'Số 131 Tây Thạnh, P. Tây Thạnh, Q. Tân Phú, TP. Hồ Chí Minh', '0917369977', 'vinamilk@vinamilk.com.vn'),
  ('NCC02', N'HT Sài Gòn', N'P. Bình Hưng Hòa, Q. Bình Tân, TP. HCM', '0888030777', 'htsaigon54@gmail.com'),
  ('NCC03', N'Thế giới sữa Đức Huy', N'78A3 Cao Văn Lầu, Phường 2, Quận 6, Phường 02, Hồ Chí Minh - Quận 6', '0902300106', null)

-- Thêm dữ liệu cho bảng DanhMucSP
INSERT INTO DanhMucSP (MaDM, TenDM)
VALUES
  ('DM01', N'Sữa tươi'),
  ('DM02', N'Sữa đậu nành/ hạt'),
  ('DM03', N'Sữa bột'),
  ('DM04', N'Sản phẩm chế tác từ sữa')

-- Thêm dữ liệu cho bảng SanPham
INSERT INTO SanPham (MaSP, MaNCC, MaDM, TenSP, SoLuong, DVT, DonGia) -- Đơn giá là giá bán
VALUES
  ('SP01', 'NCC01', 'DM01', N'Sữa tươi tiệt trùng có đường Vinamilk bịch 220ml', 102, N'Bịch', 8000),-- Nhập 192 L1: xuất 40 L2: xuất 50
  ('SP02', 'NCC01', 'DM01', N'Sữa tươi tiệt trùng Vinamilk 100% có đường hộp 180ml', 192, N'Hộp', 8000),
  ('SP07', 'NCC01', 'DM01', N'Sữa Tươi Tiệt Trùng Vinamilk Có Chứa Tổ Yến Hộp 180ml', 96, N'Hộp', 11000),
  ('SP05', 'NCC02', 'DM02', N'ĐẬU NÀNH ÓC CHÓ VINAMILK 180ML', 144, N'Hộp', 6000),
  ('SP03', 'NCC02', 'DM01', N'TH TRUE MILK BỊCH 220ML ÍT ĐƯỜNG', 94, N'Bịch', 7500),-- Nhập 144 xuất 50
  ('SP04', 'NCC02', 'DM03', N'NUTI IQ GOLD MOM 900G', 15, N'Lon', 181000),-- Nhập 20 xuất 5
  ('SP08', 'NCC02', 'DM04', N'PHÔ MAI BELCUBE 24 MIẾNG', 15, N'Hộp', 56000),
  ('SP06', 'NCC03', 'DM03', N'Sữa bột Anlene Gold 3X 400g', 8, N'Hộp', 188000), -- Nhập 15 xuất 7
  ('SP09', 'NCC03', 'DM02', N'Sữa Hạt Yến Mạch Nguyên Chất 137 Degrees 180ml', 20, N'Hộp', 20000),
  ('SP10', 'NCC03', 'DM03', N'Sữa non tiểu đường DiaSure 850g (Mới)', 15, N'Lon', 641000)

-- Thêm dữ liệu cho bảng LoaiPhieu
INSERT INTO LoaiPhieu (MaLoaiPhieu, TenLoaiPhieu)
VALUES
	('PNhap', N'Phiếu nhập'),
	('PXuat', N'Phiếu xuất')

-- Thêm dữ liệu cho bảng Phieu
INSERT INTO Phieu (MaPhieu, MaLoaiPhieu, Ngay, TongTien)-- Tổng tiền nhập là giá nhập. Tổng tiền bán là giá bán
VALUES
  ('P001', 'PNhap', '2023-11-01', 1392940),
  ('P002', 'PNhap', '2023-11-02', 1447920),
  ('P003', 'PNhap', '2023-11-03', 968756),
  ('P004', 'PNhap', '2023-11-04', 2051000),
  ('P005', 'PNhap', '2023-11-05', 1005000),
  ('P006', 'PNhap', '2023-11-06', 3600000),
  ('P007', 'PNhap', '2023-11-07', 825000),
  ('P008', 'PNhap', '2023-11-08', 9600000),
  ('P009', 'PNhap', '2023-11-09', 2805000),
  ('P010', 'PNhap', '2023-11-10', 390000),
  ('P011', 'PXuat', '2023-11-11', 320000),
  ('P012', 'PXuat', '2023-11-12', 905000),
  ('P013', 'PXuat', '2023-11-13', 400000),
  ('P014', 'PXuat', '2023-11-14', 1316000),
  ('P015', 'PXuat', '2023-11-15', 375000)

-- Thêm dữ liệu cho bảng ChiTiet Sửa
INSERT INTO ChiTiet (MaCT, MaPhieu, MaSP, SoLuong, DonGia)-- Đơn giá của phiếu nhập là giá nhập, xuất là giá bán
VALUES
  ('CT01', 'P001', 'SP01', 192, 7200),
  ('CT02', 'P002', 'SP02', 192, 7500),
  ('CT03', 'P003', 'SP07', 96, 10000),
  ('CT04', 'P004', 'SP05', 144, 14200),
  ('CT05', 'P005', 'SP03', 144, 6900),
  ('CT06', 'P006', 'SP04', 20, 180000),
  ('CT07', 'P007', 'SP08', 15, 55000),
  ('CT08', 'P008', 'SP10', 15, 640000),
  ('CT09', 'P009', 'SP06', 15, 187000),
  ('CT10', 'P010', 'SP09', 20, 19500),
  ('CT11', 'P011', 'SP01', 40, 8000),
  ('CT12', 'P012', 'SP04', 5, 181000),
  ('CT13', 'P013', 'SP01', 50, 8000),
  ('CT14', 'P014', 'SP06', 7, 188000),
  ('CT15', 'P015', 'SP03', 50, 7500)