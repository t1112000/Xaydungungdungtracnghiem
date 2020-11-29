------------------------ Tạo database ----------------------------
create database Quiz_v3
use Quiz_v3
------------------------ Tạo bảng ----------------------------

create table ThiSinh(
       MaTS varchar(10) not null,        -- mã sinh viên
       Ten nvarchar(40),                 -- Họ tên thí sinh
       DN nvarchar(40),                  -- Tên đăng nhập
       MK nvarchar(50),                  -- Mật khẩu
       NgaySinh varchar(22),             -- Ngày sinh
       Lop varchar(10),                  -- Lớp
       Khoa varchar(10),                 -- Khoa
       HinhAnh image,                    -- ảnh thẻ chuẩn 4:3
       TrangThai bit,                    -- 0: offline; 1: online
       Quyen bit,                        -- 0: cấm đăng nhập, đình chỉ;
       Mess nvarchar(200),               -- dùng khi thông báo đình chỉ
       primary key clustered (MaTS)
)
create table Khoa(
       MaKhoa varchar(10),
       TenKhoa nvarchar(50),
       primary key clustered(MaKhoa)
)
create table Lop(
       MaLop varchar(10),
       TenLop nvarchar(50),
       MaKhoa varchar(10),
       primary key clustered(MaLop)
)
create table NhanVien(
       MaNV varchar(10) not null,        -- mã giảng viên
       Ten nvarchar(50),
       DN nvarchar(40),
       MK nvarchar(40),
       NgaySinh varchar(20),
       DonViCongTac nvarchar(30),        -- Phòng/khoa/chức vụ
       Quyen bit,           -- 0: cấm đăng nhập, đình chỉ; 1: Được phép đăng nhập
       PhanQuyen char(1),         -- 1: Sếp lơn; 2: giám thị; 3: giáo viên
       HinhAnh image,                            -- Ảnh thẻ
       primary key clustered (MaNV)
)

create table CauHoi(
       MaCH int identity not null,       -- tự động tạo id
       HinhThucCH char(2),               -- Hình thức câu hỏi: M(4 da, chọn 1); N(nhiều DA, nhiều TL); D(điền đáp án)
       NoiDung nvarchar(300),            -- Nội dung câu hỏi
       Hinh image,                       -- Hình ảnh minh họa
       MaMon nvarchar(10),               -- Mã môn học
       DoKho char(1),                    -- 3 độ khó, 1(dễ), 2(trung bình), 3(khó)
       primary key clustered (MaCH)
)
create table DapAn(
       MaDA int identity not null,       -- tự động tạo id
       MaCH int,                         -- Mã câu hỏi
       NoiDung nvarchar(300),            -- Nội dung đáp án
       DungSai bit,                      -- Đáp án đúng hay sai: 0 sai, 1 đúng
       primary key clustered (MaDA)
)
create table Mon(
       MaMon nvarchar(10) not null,
       Ten nvarchar(30),
       primary key clustered(MaMon)
)
create table KyThi(
       MaKyThi int identity not null,    -- tự động tạo id
       MaMon nvarchar(10) not null,      -- Mã môn học
       TenKT nvarchar(20),               -- Tên của kỳ thi
       DoiTuong nvarchar(10),            -- Đối tượng thi đề này
       MaNV varchar(10),                 -- Mã nhân viên tạo kỳ thi này
       TGLamBai int,                      -- Thời gian làm bài (tính bằng phút)
       TGMoDe smalldatetime,             -- Thời gian mở đề
       TGDongDe smalldatetime,           -- Thời gian đóng đề
       TongSoCau int,                    -- Tổng số câu hỏi
       TLDe int,                         -- Tỉ lệ câu dễ
       TLKho int,                        -- Tỉ lệ câu khó
       -- TLTB = [100 - (TLDe + TLTKho)]
       TDDe int,                         -- Tính điểm dễ -- thang điểm 10
       TDKho int,                        -- Tính điểm khó
       CauMDA bit,                       -- Câu hỏi một đáp án
       CauNDA bit,                       -- Câu hỏi nhiều đáp án
       CauDT bit,                        -- Câu hỏi điền đáp án
       Chat bit,                         -- Cho phép chat khi thi: 0(không cho)
       TienLui bit,               -- Chặn quay lại câu hỏi trước: 0 (không cho)
       Mat bit,                    -- Cho phép thi thử trước giờ thi: 0(không cho)
       MatKhau nvarchar(20),                    -- Phòng khi yêu cầu password
       primary key clustered (MaKyThi)
)
create table KetQua(
       MaKQ int identity not null,       -- tự động tạo id
       MaTS varchar(10) not null,
       MaKyThi int not null,
       NgayThi varchar(25), --12/12/1212 12:12:12.0 PM
       Diem float,
       TongTGThi int, -- Tổng thời gian thi, tính bằng giây.
       TGTraLoiDe int, -- Tổng thời gian trả lời các câu hỏi đễ, tính bằng giây.
       TGTraLoiTrungBinh int, -- Tổng thời gian trả lời các câu hỏi trung bình.
       Loai bit, --0: thi thử, 1: thi chính thức
       primary key clustered (MaKQ)
)
create table BaoCaoLoi(
       MaSo int identity not null, -- tự động tạo id
       Loai nvarchar(30), -- quên mk/ câu hỏi bị lỗi/ phát hiện gian lận/ ....
       MoTa nvarchar(300),
       MaTS varchar(10), -- Người báo lỗi
       TinhTrang nvarchar (20),
       primary key clustered (MaSo)
)
create table ChatBox(
       IDBox int identity not null,
       Loai char(1), -- 3 loại: 1(ts - ts) 2(nv - ts) 3(nv - nv)
       MaN1 varchar(10),
       MaN2 varchar(10),
       primary key clustered (IDBox)
)
create table ChatMess(
       IDBox int,
       IDMess int identity,
       MaN nvarchar(10),
       NoiDung nvarchar(200),
       primary key clustered (IDMess)
)
create table PhieuTraLoi(
       MaKQ int,
       STT int,
       HinhThucCH char(2),
       MaCH int,
       DapAn nvarchar(100),
       ChuoiDapAn nvarchar(200),
       primary key clustered (MaKQ, STT)
)
create table LogThi(
       MaTS varchar(10),
       MaKyThi varchar(10),
       Thi bit, -- 0: cấm thi, 1: được tiếp tục thi.
)
------------------------ Quan hệ ----------------------------

alter table Lop add constraint FK_L_K foreign key (MaKhoa) references Khoa
alter table ThiSinh add constraint FK_TS_K foreign key (Khoa) references Khoa
alter table ThiSinh add constraint FK_TS_L foreign key (Lop) references Lop

alter table DapAn add constraint FK_DA_CH foreign key (MaCH) references CauHoi

alter table CauHoi add constraint FK_CH_M foreign key (MaMon) references Mon

alter table KyThi add constraint FK_KT_M foreign key (MaMon) references Mon
alter table KyThi add constraint FK_KT_NV foreign key (MaNV) references NhanVien

alter table KetQua add constraint FK_KQ_TS foreign key (MaTS) references ThiSinh
alter table KetQua add constraint FK_KQ_KT foreign key (MaKyThi) references KyThi