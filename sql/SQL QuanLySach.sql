create database QLYSach1
go
use QLYSach1
go
-- Tạo bảng Nhà cung cấp
CREATE TABLE tblNhaCungCap (
    MaNhaCungCap INT IDENTITY(1,1) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(255),
    SoDienThoai CHAR(12),
    DiaChi NVARCHAR(255)
);

-- Tạo bảng Thể loại
CREATE TABLE tblTheLoai (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(255)
);

-- Tạo bảng Nhà xuất bản
CREATE TABLE tblNhaXuatBan (
    MaNhaXB INT IDENTITY(1,1) PRIMARY KEY,
    TenNhaXB NVARCHAR(255),
    GhiChu NVARCHAR(255)
);

-- Tạo bảng Ngôn ngữ
CREATE TABLE tblNgonNgu (
    MaNgonNgu INT IDENTITY(1,1) PRIMARY KEY,
    LoaiNgonNgu NVARCHAR(255)
);

-- Tạo bảng Sách
CREATE TABLE tblSach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(255),
    TacGia NVARCHAR(255),
    MaTheLoai INT,
    MaNhaXB INT,
    NamXB DATE,
    SoLuong INT,
    MaNgonNgu INT,
    GiaBia MONEY,
	GiaNhap MONEY,
    FOREIGN KEY (MaTheLoai) REFERENCES tblTheLoai(MaTheLoai),
    FOREIGN KEY (MaNhaXB) REFERENCES tblNhaXuatBan(MaNhaXB),
    FOREIGN KEY (MaNgonNgu) REFERENCES tblNgonNgu(MaNgonNgu)
);

-- Tạo bảng Nhân viên
CREATE TABLE tblNhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(255),
    TenDangNhap NVARCHAR(255),
    MatKhau CHAR(30),
    SoDienThoai CHAR(12),
    DiaChi NVARCHAR(255),
    PhanQuyen NVARCHAR(255)
);

-- Tạo bảng Khách hàng
CREATE TABLE tblKhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(250),
    SoDienThoai CHAR(12),
    DiaChi NVARCHAR(255)
);

-- Tạo bảng Nhập sách
CREATE TABLE tblNhapSach (
    MaNhapSach INT IDENTITY(1,1) PRIMARY KEY,
    NgayNhap DATETIME,
    MaNhanVien INT,
    MaNhaCungCap INT,
    ThanhTien MONEY,
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaNhanVien) REFERENCES tblNhanVien(MaNhanVien),
    FOREIGN KEY (MaNhaCungCap) REFERENCES tblNhaCungCap(MaNhaCungCap)
);

-- Tạo bảng Hóa đơn bán
CREATE TABLE tblHoaDonBan (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayBan DATE,
    MaKhachHang INT,
    MaNhanVien INT,
    ThanhTien MONEY,
    MoTa NVARCHAR(255),
    FOREIGN KEY (MaKhachHang) REFERENCES tblKhachHang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES tblNhanVien(MaNhanVien)
);

-- Tạo bảng Chi tiết hóa đơn nhập
CREATE TABLE tblCTHDNhap (
    MaCTHDNhap INT IDENTITY(1,1) PRIMARY KEY,
    MaNhapSach INT,
    MaSach INT,
    SoLuong INT,
    GiaNhap MONEY,
    GhiChu NVARCHAR(255),
    TongTien INT,
    FOREIGN KEY (MaNhapSach) REFERENCES tblNhapSach(MaNhapSach),
    FOREIGN KEY (MaSach) REFERENCES tblSach(MaSach)
);

-- Tạo bảng Chi tiết hóa đơn bán
CREATE TABLE tblCTHoaDonBan (
    MaCTHDBan INT IDENTITY(1,1) PRIMARY KEY,
    SoLuong INT,
    GiaBia MONEY,
    TongTien MONEY,
    MaHoaDon INT,
    MaSach INT,
    FOREIGN KEY (MaHoaDon) REFERENCES tblHoaDonBan(MaHoaDon),
    FOREIGN KEY (MaSach) REFERENCES tblSach(MaSach)
);

-- Tạo bảng Ca làm
CREATE TABLE tblCaLam (
    MaCa INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien INT,
    MoTa NVARCHAR(255),
    TinhTrang NVARCHAR(255),
    ThoiGian DATE,
    FOREIGN KEY (MaNhanVien) REFERENCES tblNhanVien(MaNhanVien)
);
-- Tạo bảng Lí do huỷ đơn
CREATE TABLE tblLiDoHD (
    MaLDHD INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien INT,
	MaHoaDon INT,
    LiDo NVARCHAR(255),
    ThoiGian DATE,
   FOREIGN KEY (MaNhanVien) REFERENCES tblNhanVien(MaNhanVien),
   FOREIGN KEY (MaHoaDon) REFERENCES tblHoaDonBan(MaHoaDon)
);


-- Thêm 10 dữ liệu vào bảng Nhà cung cấp
INSERT INTO tblNhaCungCap (TenNhaCungCap, SoDienThoai, DiaChi) VALUES (N'TechBooks', '0901234567', N'123 Đường Nguyễn Văn Cừ, Quận 1, TP.HCM'),
(N'Hoàng Hương', '0912345678', N'456 Đường Nguyễn Trãi, Quận 2, TP.HCM'), 
(N'FPT Shop', '0923456789', N'789 Đường Lê Lợi, Quận 3, TP.HCM'), 
(N'SmartTech', '0934567890', N'101 Đường Phan Đăng Lưu, Quận 4, TP.HCM'), 
(N'Phong Vũ', '0945678901', N'234 Đường Tôn Đức Thắng, Quận 5, TP.HCM'), 
(N'Văn Lang', '0956789012', N'567 Đường Nguyễn Thị Minh Khai, Quận 6, TP.HCM'), 
(N'Digital World', '0967890123', N'890 Đường Điện Biên Phủ, Quận 7, TP.HCM'), 
(N'Hoàng Hà', '0978901234', N'123 Đường Nam Kỳ Khởi Nghĩa, Quận 8, TP.HCM'),
(N'TechnoMart', '0989012345', N'456 Đường Lê Quang Đạo, Quận 9, TP.HCM'), 
(N'Viettel Store', '0990123456', N'789 Đường Quang Trung, Quận 10, TP.HCM');
-- Thêm 10 dữ liệu vào bảng Thể loại
INSERT INTO tblTheLoai (TenTheLoai) VALUES
(N'Tiểu thuyết'),
(N'Truyện ngắn'),
(N'Thơ'),
(N'Khoa học viễn tưởng'),
(N'Kinh dị'),
(N'Lãng mạn'),
(N'Trinh thám'),
(N'Lịch sử'),
(N'Tâm lý'),
(N'Tự truyện');

-- Thêm 10 dữ liệu vào bảng Nhà xuất bản
INSERT INTO tblNhaXuatBan (TenNhaXB, GhiChu) VALUES
(N'Nhà xuất bản Kim Đồng', N'Chuyên sách thiếu nhi'),
(N'Nhà xuất bản Trẻ', N'Chuyên sách văn học'),
(N'Nhà xuất bản Văn học', N'Chuyên sách văn học kinh điển'),
(N'Nhà xuất bản Giáo dục', N'Chuyên sách giáo khoa'),
(N'Nhà xuất bản Tổng hợp TP.HCM', N'Chuyên sách đa dạng'),
(N'Nhà xuất bản Phụ nữ', N'Chuyên sách dành cho phụ nữ'),
(N'Nhà xuất bản Lao động', N'Chuyên sách kinh tế, xã hội'),
(N'Nhà xuất bản  Thế giới', N'Chuyên sách ngoại văn'),
(N'Nhà xuất bản Chính trị quốc gia', N'Chuyên sách chính trị'),
(N'Nhà xuất bản Khoa học xã hội', N'Chuyên sách khoa học xã hội');

-- Thêm 10 dữ liệu vào bảng Ngôn ngữ
INSERT INTO tblNgonNgu (LoaiNgonNgu) VALUES
(N'Tiếng Việt'),
(N'Tiếng Anh'),
(N'Tiếng Pháp'),
(N'Tiếng Trung'),
(N'Tiếng Nhật'),
(N'Tiếng Hàn'),
(N'Tiếng Nga'),
(N'Tiếng Đức'),
(N'Tiếng Tây Ban Nha'),
(N'Tiếng Ý');

-- Thêm 20 dữ liệu vào bảng Sách
INSERT INTO tblSach (TenSach, TacGia, MaTheLoai, MaNhaXB, NamXB, SoLuong, MaNgonNgu, GiaBia, GiaNhap) VALUES
(N'Mật mã Da Vinci', N'Dan Brown', 7, 3, '2003-03-18', 100, 2, 50000, 40000),
(N'Harry Potter và hòn đá phù thủy', N'J.K. Rowling', 4, 1, '1997-06-26', 200, 2, 100000, 70000),
(N'Đắc nhân tâm', N'Dale Carnegie', 9, 5, '1936-10-11', 150, 2, 30000, 50000),
(N'Nhà giả kim', N'Paulo Coelho', 1, 8, '1988-01-01', 80, 3, 40000, 350000),
(N'Cho tôi xin một vé đi tuổi thơ', N'Nguyễn Nhật Ánh', 1, 2, '2008-01-01', 120, 1, 75000, 30000),
(N'Steve Jobs', N'Walter Isaacson', 10, 5, '2011-10-24', 60, 2, 30000, 250000),
(N'Sapiens: Lược sử loài người', N'Yuval Noah Harari', 8, 8, '2011-01-01', 90, 2, 40000, 550000),
(N'Bắt trẻ đồng xanh', N'J.D. Salinger', 1, 3, '1951-07-16', 70, 2, 20000, 40000),
(N'Kiêu hãnh và định kiến', N'Jane Austen', 6, 3, '1813-01-28', 110, 2, 60000, 45000),
(N'Rừng Nauy', N'Haruki Murakami', 1, 8, '1987-09-01', 50, 5, 30000, 50000),
(N'Số phận con người', N'Mikhail Sholokhov', 1, 3, '1956-01-01', 40, 7, 20000, 60000),
(N'Hoàng tử bé', N'Antoine de Saint-Exupéry', 1, 8, '1943-04-06', 130, 3, 250000, 250000),
(N'Biên niên ký chim vặn dây cót', N'Haruki Murakami', 1, 8, '1994-07-01', 60, 5, 15000, 70000),
(N'Trăm năm cô đơn', N'Gabriel García Márquez', 1, 8, '1967-01-01', 80, 9, 20000, 350000),
(N'Lolita', N'Vladimir Nabokov', 1, 3, '1955-09-01', 30, 2, 55000, 60000),
(N'Người đua diều', N'Khaled Hosseini', 1, 8, '2003-05-29', 100, 2, 25000, 250000),
(N'Giết con chim nhại', N'Harper Lee', 1, 3, '1960-07-11', 120, 2, 15000, 50000),
(N'Cuốn theo chiều gió', N'Margaret Mitchell', 1, 3, '1936-06-30', 90, 2, 20000, 40000),
(N'Anna Karenina', N'Leo Tolstoy', 1, 3, '1878-01-01', 50, 7, 10000, 55000),
(N'Tội ác và hình phạt', N'Fyodor Dostoevsky', 1, 3, '1866-01-01', 70, 7, 8000, 45000);


-- Thêm 10 dữ liệu vào bảng Nhân viên
INSERT INTO tblNhanVien (TenNhanVien, TenDangNhap, MatKhau, SoDienThoai, DiaChi, PhanQuyen) VALUES 
(N'Nguyễn Văn Hòa', 'nvho', '123456', '0901234567', N'123 Đường Nguyễn Văn Cừ, Quận 1, TP.HCM', 'Admin'), 
(N'Trần Thị Lý', 'ttl', '123456', '0912345678', N'456 Đường Nguyễn Trãi, Quận 2, TP.HCM', N'Nhân viên'), 
(N'Lê Văn Hậu', 'lvh', '123456', '0923456789', N'789 Đường Lê Lợi, Quận 3, TP.HCM', N'Nhân viên'), 
(N'Phạm Thị Lan', 'ptl', '123456', '0934567890', N'101 Đường Phan Đăng Lưu, Quận 4, TP.HCM', N'Nhân viên'), 
(N'Hồ Văn Mai', 'hvm', '123456', '0945678901', N'234 Đường Tôn Đức Thắng, Quận 5, TP.HCM', N'Nhân viên'), 
(N'Võ Thị Thu', 'vtt', '123456', '0956789012', N'567 Đường Nguyễn Thị Minh Khai, Quận 6, TP.HCM', N'Nhân viên'), 
(N'Đặng Văn Khoa', 'dvk', '123456', '0967890123', N'890 Đường Điện Biên Phủ, Quận 7, TP.HCM', N'Nhân viên'), 
(N'Bùi Thị Quý', 'btq', '123456', '0978901234', N'123 Đường Nam Kỳ Khởi Nghĩa, Quận 8, TP.HCM', N'Nhân viên'), 
(N'Nguyễn Thị Hương', 'nht', '123456', '0989012345', N'456 Đường Lê Quang Đạo, Quận 9, TP.HCM', N'Nhân viên'), 
(N'Hoàng Văn Tâm', 'hvt', '123456', '0990123456', N'789 Đường Quang Trung, Quận 10, TP.HCM', N'Nhân viên');
-- Thêm 10 dữ liệu vào bảng Khách hàng
INSERT INTO tblKhachHang (TenKhachHang, SoDienThoai, DiaChi) VALUES
(N'Nguyễn Thị Minh Anh', '0901123456', N'123 Đường A, Quận 1, TP.HCM'),
(N'Phạm Quang Huy', '0912234567', N'456 Đường B, Quận 2, TP.HCM'),
(N'Lê Thanh Tùng', '0923345678', N'789 Đường C, Quận 3, TP.HCM'),
(N'Vũ Hương Lan', '0934456789', N'101 Đường D, Quận 4, TP.HCM'),
(N'Trần Minh Tuấn', '0945567890', N'234 Đường E, Quận 5, TP.HCM'),
(N'Hồ Thị Thanh', '0956678901', N'567 Đường F, Quận 6, TP.HCM'),
(N'Bùi Minh Châu', '0967789012', N'890 Đường G, Quận 7, TP.HCM'),
(N'Nguyễn Văn Tâm', '0978890123', N'123 Đường H, Quận 8, TP.HCM'),
(N'Võ Thị Thuỳ Linh', '0989901234', N'456 Đường I, Quận 9, TP.HCM'),
(N'Đặng Thiện Nam', '0990012345', N'789 Đường J, Quận 10, TP.HCM');

-- Thêm 10 dữ liệu vào bảng Nhập sách
INSERT INTO tblNhapSach (NgayNhap, MaNhanVien, MaNhaCungCap, ThanhTien, GhiChu) VALUES
('2023-03-01', 1, 1, 1000000, N'Nhập sách mới'),
('2023-03-05', 2, 2, 2000000, N'Nhập sách bán chạy'),
('2023-03-10', 3, 3, 1500000, N'Nhập sách theo yêu cầu'),
('2023-03-15', 4, 4, 800000, N'Nhập sách khuyến mãi'),
('2023-03-20', 5, 5, 1200000, N'Nhập sách mới nhất'),
('2023-03-25', 6, 6, 600000, N'Nhập sách ngoại văn'),
('2023-03-30', 7, 7, 900000, N'Nhập sách khoa học'),
('2023-04-05', 8, 8, 700000, N'Nhập sách văn học'),
('2023-04-10', 9, 9, 1100000, N'Nhập sách kinh điển'),
('2023-04-15', 10, 10, 500000, N'Nhập sách bán chạy nhất');

INSERT INTO tblCTHDNhap (MaNhapSach, MaSach, SoLuong, GiaNhap, GhiChu, TongTien) VALUES
(1, 1, 10, 40000, N'Mua sách Mật mã Da Vinci', 400000),
(2, 2, 15, 70000, N'Mua sách Harry Potter và hòn đá phù thủy', 1050000),
(3, 3, 20, 50000, N'Mua sách Đắc nhân tâm', 1000000),
(4, 4, 8, 350000, N'Mua sách Nhà giả kim', 2800000),
(5, 5, 12, 30000, N'Mua sách Cho tôi xin một vé đi tuổi thơ', 360000),
(6, 6, 10, 250000, N'Mua sách Steve Jobs', 2500000),
(7, 7, 15, 550000, N'Mua sách Sapiens: Lược sử loài người', 8250000),
(8, 8, 20, 40000, N'Mua sách Bắt trẻ đồng xanh', 800000),
(9, 9, 18, 45000, N'Mua sách Kiêu hãnh và định kiến', 810000),
(10, 10, 25, 50000, N'Mua sách Rừng Nauy', 1250000),
(11, 11, 10, 60000, N'Mua sách Số phận con người', 600000),
(12, 12, 5, 250000, N'Mua sách Hoàng tử bé', 1250000),
(13, 13, 12, 70000, N'Mua sách Biên niên ký chim vặn dây cót', 840000),
(14, 14, 8, 350000, N'Mua sách Trăm năm cô đơn', 2800000),
(15, 15, 20, 60000, N'Mua sách Lolita', 1200000),
(16, 16, 10, 250000, N'Mua sách Người đua diều', 2500000),
(17, 17, 18, 50000, N'Mua sách Giết con chim nhại', 900000),
(18, 18, 12, 40000, N'Mua sách Cuốn theo chiều gió', 480000),
(19, 19, 10, 55000, N'Mua sách Anna Karenina', 550000),
(20, 20, 15, 45000, N'Mua sách Tội ác và hình phạt', 675000);
-- Thêm 10 dữ liệu vào bảng Hóa đơn bán
INSERT INTO tblHoaDonBan (NgayBan, MaKhachHang, MaNhanVien, ThanhTien, MoTa) VALUES
('2023-03-02', 1, 1, 500000, N'Bán sách cho khách hàng #23'),
('2023-03-06', 2, 2, 1000000, N'Bán sách cho khách hàng #2'),
('2023-03-11', 3, 3, 750000, N'Bán sách cho khách hàng #1'),
('2023-03-16', 4, 4, 400000, N'Bán sách cho khách hàng #20'),
('2023-03-21', 5, 5, 600000, N'Bán sách cho khách hàng #20'),
('2023-03-26', 6, 6, 300000, N'Bán sách cho khách hàng #1'),
('2023-03-31', 7, 7, 450000, N'Bán sách cho khách hàng #4'),
('2023-04-06', 8, 8, 350000, N'Bán sách cho khách hàng #5'),
('2023-04-11', 9, 9, 550000, N'Bán sách cho khách hàng #9'),
('2023-04-16', 10, 10, 250000, N'Bán sách cho khách hàng #9');


-- Thêm 20 dữ liệu vào bảng Chi tiết hóa đơn bán
INSERT INTO tblCTHoaDonBan (SoLuong, GiaBia, TongTien, MaHoaDon, MaSach) VALUES
(2, 50000, 100000, 1, 1),
(1, 100000, 100000, 1, 2),
(3, 30000, 90000, 2, 3),
(2, 40000, 80000, 2, 4),
(1, 75000, 75000, 3, 5),
(2, 30000, 60000, 3, 6),
(1, 40000, 40000, 4, 7),
(2, 20000, 40000, 4, 8),
(1, 60000, 60000, 5, 9),
(1, 30000, 30000, 6, 10),
(2, 20000, 40000, 6, 11),
(3, 15000, 45000, 7, 12),
(1, 35000, 35000, 8, 13),
(2, 20000, 40000, 8, 14),
(1, 55000, 55000, 9, 15),
(1, 25000, 25000, 10, 16),
(2, 15000, 30000, 10, 17),
(1, 20000, 20000, 1, 18),
(2, 10000, 20000, 2, 19),
(3, 8000, 24000, 3, 20);
INSERT INTO tblLiDoHD (MaNhanVien, MaHoaDon, LiDo, ThoiGian) VALUES
(1, 1, N'Khách hàng thay đổi ý định', '2023-12-01'),
(2, 2, N'Hàng hóa bị lỗi', '2023-12-02'),
(3, 3, N'Hóa đơn ghi sai thông tin', '2023-12-03'),
(4, 4, N'Khách hàng không đủ khả năng thanh toán', '2023-12-04');

