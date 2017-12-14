create database QL_BanSach
on
(name = 'Sach_Data', filename = 'F:\CongNghePhanMem\Sach.MDF')
log on
(name = 'Sach_Log', filename = 'F:\CongNghePhanMem\Sach.LDF')

use QL_BanSach
----------------------
set dateformat dmy
--create table DangNhap
--(
--	TaiKhoan nvarchar(50) primary key,
--	MatKhau  nvarchar(50)
--)
create table Kho
(
	MaSach		char(4),
	TheLoai		nvarchar(50),
	TenSach		nvarchar(70),
	QuocGia		nvarchar(10),
	TenTacGia	nvarchar(50),
	NXB			nvarchar(50),
	Gia			float,
	SlCon		int
)
create table GioHang -- Bảng Tạm
(
	STT			int identity(1,1),
	Ngay		datetime,
	TheLoai		nvarchar(50),
	TenSach		nvarchar(70),
	TenTacGia	nvarchar(50),
	NXB			nvarchar(50),
	Gia			float,
	Sl			int,
	Tong		float
)
set dateformat dmy
create table ChiTietBanHang
(
	Ngay		datetime,
	TheLoai		nvarchar(50),
	TenSach		nvarchar(70),
	TenTacGia	nvarchar(50),
	NXB			nvarchar(50),
	Gia			float,
	Sl			int,
	Tong		float
)
---------------------------
--drop table GioHang
--drop table ChiTietBanHang
---------------------------
select * from DangNhap
INSERT DangNhap(TaiKhoan, MatKhau) VALUES (N'sach','1234')
---------------------------
INSERT into Kho VALUES ('TTUS', N'Tiểu Thuyết', N'Mật Mã Da Vinci', N'Mỹ',N'Dan Brown',N'Văn hóa Thông tin',80,20 )
INSERT into Kho VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 1)', N'Anh',N'J.K.Rowling',N'Trẻ',95,30 )
INSERT into Kho VALUES ('MGJP', N'Manga', N'Bảy Viên Ngọc Rồng', N'Nhật Bản',N'Toriyama Akira',N'Kim Đồng',16,10 )
INSERT into Kho VALUES ('MGJP', N'Manga', N'Doraemon', N'Nhật Bản',N'Fujiko-F-Fujio',N'Kim Đồng',16,20 )
INSERT into Kho VALUES ('TDVN',N'Truyện Dài',N'Vừa Nhắm Mắt Vừa Mở Cửa Sổ',N'Việt Nam',N'Nguyễn Ngọc Thuần',N'Trẻ',16,40)
---------------------------

--INSERT ThongTinSach(TheLoai, TenSach,TenTacGia, NXB, Gia) VALUES (N'Thiếu Nhi',N'Doraemon',N'Fujiko-F-Fujio',N'Kim Đồng',16)
--INSERT ThongTinSach(TheLoai, TenSach,TenTacGia, NXB, Gia) VALUES (N'Trinh Thám',N'Thám Tử Lừng Danh Conan',N'Aoyama Gosho',N'Kim Đồng',16)
--INSERT ThongTinSach(TheLoai, TenSach,TenTacGia, NXB, Gia) VALUES (N'Thiếu Nhi',N'Kính Vạn Hoa',N'Nguyễn Nhật Ánh',N'Kim Đồng',16)
--INSERT ThongTinSach(TheLoai, TenSach,TenTacGia, NXB, Gia) VALUES (N'Truyện Dài',N'Vừa Nhắm Mắt Vừa Mở Cửa Sổ',N'Nguyễn Ngọc Thuần',N'Trẻ',16)
---------------------------
INSERT ChiTietBanHang(Ngay,TheLoai, TenSach,TenTacGia, NXB, Gia, Sl, Tong) VALUES ('20/11/2017',N'Thiếu Nhi',N'Doraemon',N'Fujiko-F-Fujio',N'Kim Đồng',16,2, 32)
INSERT ChiTietBanHang(Ngay,TheLoai, TenSach,TenTacGia, NXB, Gia, Sl, Tong) VALUES ('20/11/2017',N'Thiếu Nhi',N'Thám Tử Lừng Danh Conan',N'Aoyama Gosho',N'Kim Đồng',16,1,16)
---------------------------
--INSERT GioHang(Ngay,TheLoai, TenSach,TenTacGia, NXB, Gia, Sl, Tong) VALUES (N'Thiếu Nhi',N'Doraemon',N'Fujiko-F-Fujio',N'Kim Đồng',16,2, 32)
--INSERT GioHang(Ngay,TheLoai, TenSach,TenTacGia, NXB, Gia, Sl, Tong) VALUES (N'Thiếu Nhi',N'Thám Tử Lừng Danh Conan',N'Aoyama Gosho',N'Kim Đồng',16,1,16)
---------------------------
-- Chọn mục Để tìm sách
select * from ThongTinSach
---------------------------
-- tính tiền trong giỏ hàng
select * from GioHang
select sum(Tong) as [Tổng] from GioHang 
---------------------------

select * from GioHang
select * from ChiTietBanHang
delete from GioHang	 where TenSach = N'Kính Vạn Hoa'
delete from GioHang	where STT = '6'
Delete from GioHang where STT = '15'
------------------------- Reset lai STT
DBCC CHECKIDENT ('GioHang', RESEED, 1)

------------Thống kê
select * from ChiTietBanHang
--- Số lượng các sách bán trong tháng
select month(Ngay)as[Thang], sum(Sl)as[Sl] from ChiTietBanHang group by month(Ngay)
--- Doanh thu Tháng
select month(Ngay)as[Thang], sum(Tong)as[Tong] from ChiTietBanHang group by month(Ngay)
--- Số Lượng bán trong năm
select year(Ngay)as[Thang], sum(Sl)as[Sl] from ChiTietBanHang group by year(Ngay)
--- Doanh thu Năm
select year(Ngay)as[Thang], sum(Tong)as[Tong] from ChiTietBanHang group by year(Ngay)
--- Số Lượng Sách bán ra nhiều nhất
select top 9 TenSach,sum(Sl) as [Sl] from ChiTietBanHang group by TenSach order by sum(Sl) desc
--- Số Lượng Sách bán ra ít nhất
select top 9 TenSach,sum(Sl) as [Sl] from ChiTietBanHang group by TenSach order by sum(Sl) 
-- Doanh THu Nhieu Nhất
select top 9 TenSach,sum(Tong) as [Tong] from ChiTietBanHang group by TenSach order by sum(Tong) desc
-- Doanh THu ít Nhất
select top 9 TenSach,sum(Tong) as [Tong] from ChiTietBanHang group by TenSach order by sum(Tong) 
-- Thể Loại được mua nhiều nhât
select top 9 TheLoai,sum(Sl) as [Sl] from ChiTietBanHang group by TheLoai order by sum(Sl) desc
--- Thể Loại bán ra ít nhất
select top 9 TheLoai,sum(Sl) as [Sl] from ChiTietBanHang group by TheLoai order by sum(Sl) 
--------------------------------------------------------------------------------------------
---
-- ghi chú: Mã Nhân Viên: Kho: k1, k2
--		                  Bán Hàng: b1,b2,b3,b4
---						  Quản Lý : ql	
create table NhanVien
(
	MaNV			char(2) primary key,
	TenNhanVien		nvarchar(50),	
)
create table PhanQuyen
(
	TaiKhoan nvarchar(50) , -- chọn trong Combobox
	MaNV	 nvarchar(50),-- tên nhân viên có dấu
	QuanLy	 varchar(5),-- trang Quản Lý
	BanHang	 varchar(5),
	Kho		 varchar(5),
	TongKet	 varchar(5),
)
-----------------------------
Insert into NhanVien Values(N'ql',N'Doraemon')
Insert into NhanVien Values(N'b1',N'Nobita')
Insert into NhanVien Values(N'b2',N'Xuka')
Insert into NhanVien Values(N'b3',N'Chaien')
Insert into NhanVien Values(N'b4',N'Xeko')
Insert into NhanVien Values(N'k1',N'Conan')
Insert into NhanVien Values(N'k2',N'Songoku')


------------------------------Tài Khoản, Mật Khẩu,QuanLy, Ban,  Kho,  TongKet 
insert into PhanQuyen Values (N'Quản Lý', N'ql', 'true','true', 'true', 'true')
insert into PhanQuyen Values (N'Bán Hàng',N'b1','false','true','false','false')
insert into PhanQuyen Values (N'Bán Hàng',N'b2','false','true','false','false')
insert into PhanQuyen Values (N'Bán Hàng',N'b3','false','true','false','false')
insert into PhanQuyen Values (N'Bán Hàng',N'b4','false','true','false','false')
insert into PhanQuyen Values (N'Kho',     N'k1','false','false','true','false')
insert into PhanQuyen Values (N'Kho',     N'k2','false','false','true','false')

---------------------------------
select * from NhanVien
select * from PhanQuyen

select QuanLy from PhanQuyen where TaiKhoan=N'Quản Lý' and MaNV='ql'
select BanHang from PhanQuyen where TaiKhoan=N'Quản Lý' and MaNV='ql'
select Kho from PhanQuyen where TaiKhoan=N'Quản Lý' and MaNV='ql'
select TongKet from PhanQuyen where TaiKhoan=N'Quản Lý' and MaNV='ql'

select * from ChiTietBanHang
select * from PhanQuyen where TaiKhoan = N'Bán Hàng' and MaNV='b1'
update PhanQuyen set BanHang = 'true',Kho = 'false',TongKet = 'false'  where TaiKhoan =N'Bán Hàng' and MaNV='b1'

select NhanVien.MaNV,TenNhanVien from PhanQuyen,NhanVien where PhanQuyen.MaNV=NhanVien.MaNV and PhanQuyen.MaNV='b1'
select * from PhanQuyen where MaNV = 'b1'
---------------------------------
-- có 2 combobox: thể loại sách -> 2 kí tự đầu của Mã Sách ra textbox , Quốc Gia -> 2 kí tự sau của Mã Sách ra text box
-------------- gộp 2 textbox vào dl.MaSach
create table VietTatTheLoai
(
	TheLoai nvarchar(50),
	VietTatTheLoai	char(2)
)
INSERT into VietTatTheLoai VALUES (N'Manga', 'MG')
INSERT into VietTatTheLoai VALUES (N'Truyện Dài', 'TD')
INSERT into VietTatTheLoai VALUES (N'Tiểu Thuyết', 'TT')
INSERT into VietTatTheLoai VALUES (N'Kinh Dị', 'KD')
INSERT into VietTatTheLoai VALUES (N'Khoa Học', 'KH')
create table VietTatTenNuoc
(
	QuocGia nvarchar(10),
	VietTatTenNuoc	char(2)
)
INSERT into VietTatTenNuoc VALUES (N'Mỹ', 'US')
INSERT into VietTatTenNuoc VALUES (N'Anh', 'UK')
INSERT into VietTatTenNuoc VALUES (N'Việt Nam', 'VN')
INSERT into VietTatTenNuoc VALUES (N'Nhật Bản', 'JP')
INSERT into VietTatTenNuoc VALUES (N'Hàn Quốc', 'KR')
create table  NhapSach
(
	STT			int identity (1,1),
	MaSach		char(4),
	TheLoai		nvarchar(50),
	TenSach		nvarchar(70),
	QuocGia		nvarchar(10),
	TenTacGia	nvarchar(50),
	NXB			nvarchar(50),
	Gia			float,
	SlNhap		int
)
INSERT into NhapSach VALUES ('TTUS', N'Tiểu Thuyết', N'Mật Mã Da Vinci', N'Mỹ',N'Dan Brown',N'Văn hóa Thông tin',80,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 1)', N'Anh',N'J.K.Rowling',N'Trẻ',95,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 2)', N'Anh',N'J.K.Rowling',N'Trẻ',105,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 3)', N'Anh',N'J.K.Rowling',N'Trẻ',126,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 4)', N'Anh',N'J.K.Rowling',N'Trẻ',189,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 5)', N'Anh',N'J.K.Rowling',N'Trẻ',249,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 6)', N'Anh',N'J.K.Rowling',N'Trẻ',151,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 7)', N'Anh',N'J.K.Rowling',N'Trẻ',172,50 )
INSERT into NhapSach VALUES ('TTUK', N'Tiểu Thuyết', N'Harry Potter(Tập 7)', N'Anh',N'J.K.Rowling',N'Trẻ',172,50 )
INSERT into NhapSach VALUES ('TDVN', N'Truyện Dài', N'Cô Gái Đến Từ Hôm Qua', N'Việt Nam',N'Nguyễn Nhật Ánh',N'Trẻ',56,50 )
INSERT into NhapSach VALUES ('TDVN', N'Truyện Dài', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Việt Nam',N'Nguyễn Nhật Ánh',N'Trẻ',66,50 )
INSERT into NhapSach VALUES ('TDVN', N'Truyện Dài', N'Ngồi Khóc Trên Cây', N'Việt Nam',N'Nguyễn Nhật Ánh',N'Trẻ',76,50 )
INSERT into NhapSach VALUES ('TDVN', N'Truyện Dài', N'Sương Khói Quê Nhà', N'Việt Nam',N'Nguyễn Nhật Ánh',N'Trẻ',48,50 )
INSERT into NhapSach VALUES ('KHUK', N'Khoa Học', N'Nguồn Gốc Các Loài', N'Anh',N'Charles Darwin',N'Trẻ',98,50 )
INSERT into NhapSach VALUES ('KHUK', N'Khoa Học', N'Lược Sử Thời Gian', N'Anh',N'Stephen Hawking',N'Trẻ',70,50 )
INSERT into NhapSach VALUES ('KHUK', N'Khoa Học', N'George Và Vụ Nổ BigBang', N'Anh',N'Stephen Hawking',N'Trẻ',80,50 )
INSERT into NhapSach VALUES ('MGJP', N'Manga', N'Bảy Viên Ngọc Rồng', N'Nhật Bản',N'Toriyama Akira',N'Kim Đồng',16,50 )
--------------------------
select * from VietTatTenNuoc
select * from VietTatTheLoai
select * from NhapSach
-----------------------------------------------------------

select * from Kho where TheLoai like N'%Ti%'
select Right(MaSach,2) from NhapSach where QuocGia = N'Nhật Bản'

INSERT into NhapSach VALUES ('MGJP', N'Manga', N'Doraemon', N'Nhật Bản',N'Fujiko',N'Kim Đồng','16','50')
update NhapSach set  MaSach = 'TNVN', TheLoai = N'Truyện Ngắn', TenSach = N'Chi Phu', QuocGia = N'Việt Nam', TenTacGia = N'Luận', NXB = N'kakkaka', Gia = '12', SlNhap = '12' where TenSach = N'Chi Dân' 
Delete from NhapSach where TenSach = N'Chi Dân'