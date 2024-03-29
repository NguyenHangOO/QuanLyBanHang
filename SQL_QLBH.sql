CREATE DATABASE QLBHang
GO
USE [QLBHang]
GO
/****** Object:  Table [dbo].[tblCHITIETHD]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCHITIETHD](
	[Ma_HD] [nvarchar](20) NOT NULL,
	[Ma_HH] [char](4) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[GiamGia] [float] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HD] ASC,
	[Ma_HH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCHITIETNHAP]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCHITIETNHAP](
	[Ma_PNhap] [nvarchar](20) NOT NULL,
	[Ma_HH] [char](4) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_PNhap] ASC,
	[Ma_HH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHANGHOA]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHANGHOA](
	[Ma_HH] [char](4) NOT NULL,
	[TenHH] [nvarchar](30) NOT NULL,
	[Ma_NCC] [char](4) NOT NULL,
	[Soluong] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
	[img] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHOADON]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHOADON](
	[Ma_HD] [nvarchar](20) NOT NULL,
	[Ma_KH] [char](5) NOT NULL,
	[USERNAME] [varchar](30) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [float] NULL,
	[hinhthuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKHACHHANG]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKHACHHANG](
	[Ma_KH] [char](5) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](4) NULL DEFAULT ('Nam'),
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](12) NOT NULL,
	[Ma_LKH] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKM]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKM](
	[MaKM] [char](5) NOT NULL,
	[TenKM] [nvarchar](100) NOT NULL,
	[PhanTram] [nvarchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLOAIKH]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLOAIKH](
	[Ma_LKH] [char](5) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_LKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMOILIENHE]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMOILIENHE](
	[ID_MLH] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME_LH] [varchar](30) NOT NULL,
	[ID_QH] [int] NOT NULL,
	[DP] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME_LH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[Ma_NCC] [char](4) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[SDT_NCC] [varchar](11) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoThe] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNHANVIEN]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNHANVIEN](
	[Ho_Lot] [nvarchar](30) NULL,
	[Ten] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL DEFAULT ('Nam'),
	[SDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Luong] [float] NULL,
	[USERNAME] [varchar](30) NOT NULL,
	[PASS] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[Ma_PNhap] [nvarchar](20) NOT NULL,
	[Ma_NCC] [char](4) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[NguoiNhap] [varchar](30) NOT NULL,
	[TongTien] [float] NULL,
	[hinhthuc] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_PNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblQUYENCHITIET]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblQUYENCHITIET](
	[ID_CT] [int] IDENTITY(1,1) NOT NULL,
	[TEN_CT] [nvarchar](50) NULL,
	[MA] [varchar](50) NOT NULL,
	[USERNAME] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[HD]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HD] AS
SELECT hd.Ma_HD,hd.NgayLap,hd.hinhthuc,kh.HoTen,kh.DiaChi,kh.SDT,nv.Ho_Lot+' '+nv.Ten as HoTenNV,hh.TenHH,ct.SoLuong,ct.DonGia,ct.GiamGia,ct.ThanhTien,hd.TongTien
FROM tblKHACHHANG kh , tblHANGHOA hh, tblNHANVIEN nv, tblHOADON hd , tblCHITIETHD ct
WHERE hd.Ma_HD=ct.Ma_HD and hd.Ma_KH=kh.Ma_KH and hd.USERNAME=nv.USERNAME and hh.Ma_HH=ct.Ma_HH
GO
/****** Object:  View [dbo].[HD_Nhap]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HD_Nhap] AS
SELECT n.Ma_PNhap,n.NgayNhap,ncc.TenNCC,ncc.DiaChi,ncc.SDT_NCC,nv.Ho_Lot+' '+nv.Ten as HoTenNv, hh.TenHH,ct.SoLuong,ct.DonGia,ct.ThanhTien,n.TongTien,n.hinhthuc
FROM tblHANGHOA hh, tblNhaCungCap ncc, tblNHANVIEN nv, tblCHITIETNHAP ct , tblPhieuNhap n
WHERE hh.Ma_HH=ct.Ma_HH and ncc.Ma_NCC=n.Ma_NCC and nv.USERNAME=n.NguoiNhap and ct.Ma_PNhap=n.Ma_PNhap

GO
/****** Object:  View [dbo].[TienMat]    Script Date: 5/24/2021 12:44:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TienMat] as
select hd.Ma_HD, hd.NgayLap,hd.TongTien ,pn.Ma_PNhap, pn.NgayNhap,pn.TongTien as Tongchi
from tblHOADON hd,tblPhieuNhap pn
Where hd.hinhthuc like N'Tiền mặt' and pn.hinhthuc like N'%Tiền mặt%'
GO
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5212021_191757', N'ATHH', 2, 55000, 2200, 107800)
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5212021_191757', N'DDMT', 1, 165000, 0, 330000)
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5212021_191915', N'ATNN', 2, 65000, 0, 130000)
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5212021_192012', N'DDMT', 1, 165000, 0, 165000)
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5222021_185623', N'ATHH', 1, 55000, 1100, 53900)
INSERT [dbo].[tblCHITIETHD] ([Ma_HD], [Ma_HH], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDB5232021_194527', N'DDMT', 2, 165000, 0, 330000)
INSERT [dbo].[tblCHITIETNHAP] ([Ma_PNhap], [Ma_HH], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDN5232021_012048', N'ATNN', 5, 56000, 224000)
INSERT [dbo].[tblCHITIETNHAP] ([Ma_PNhap], [Ma_HH], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDN5232021_012048', N'DDMT', 3, 150000, 450000)
INSERT [dbo].[tblCHITIETNHAP] ([Ma_PNhap], [Ma_HH], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDN5232021_012827', N'ATHH', 2, 45000, 90000)
INSERT [dbo].[tblCHITIETNHAP] ([Ma_PNhap], [Ma_HH], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDN5232021_194554', N'DDMT', 1, 150000, 150000)
INSERT [dbo].[tblCHITIETNHAP] ([Ma_PNhap], [Ma_HH], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDN5242021_021546', N'ADAI', 2, 125000, 125000)
INSERT [dbo].[tblHANGHOA] ([Ma_HH], [TenHH], [Ma_NCC], [Soluong], [DonGiaNhap], [DonGiaBan], [GhiChu], [img]) VALUES (N'ADAI', N'Áo dài', N'N001', 22, 125000, 140000, N'Áo dài đẹp', N'E:\BanNhap\QLBH\Images\aodai3.jpg')
INSERT [dbo].[tblHANGHOA] ([Ma_HH], [TenHH], [Ma_NCC], [Soluong], [DonGiaNhap], [DonGiaBan], [GhiChu], [img]) VALUES (N'ATHH', N'Áo thun nữ', N'N002', 13, 45000, 55000, N'', N'E:\BanNhap\QLBH\Images\aothunnu.jpg')
INSERT [dbo].[tblHANGHOA] ([Ma_HH], [TenHH], [Ma_NCC], [Soluong], [DonGiaNhap], [DonGiaBan], [GhiChu], [img]) VALUES (N'ATNN', N'Áo thun nam', N'N002', 13, 56000, 65000, N'', N'E:\BanNhap\QLBH\Images\Aothunnam.jpg')
INSERT [dbo].[tblHANGHOA] ([Ma_HH], [TenHH], [Ma_NCC], [Soluong], [DonGiaNhap], [DonGiaBan], [GhiChu], [img]) VALUES (N'DDMT', N'Đầm dài nữ', N'N004', 13, 150000, 165000, N'Màu trắng phối đen', N'E:\BanNhap\QLBH\Images\damden.jpg')
INSERT [dbo].[tblHOADON] ([Ma_HD], [Ma_KH], [USERNAME], [NgayLap], [TongTien], [hinhthuc]) VALUES (N'HDB5212021_191757', N'KH001', N'QuanLi', CAST(N'2021-05-21 00:00:00.000' AS DateTime), 437800, N'null')
INSERT [dbo].[tblHOADON] ([Ma_HD], [Ma_KH], [USERNAME], [NgayLap], [TongTien], [hinhthuc]) VALUES (N'HDB5212021_191915', N'KH005', N'NV1', CAST(N'2021-05-21 00:00:00.000' AS DateTime), 130000, N'null')
INSERT [dbo].[tblHOADON] ([Ma_HD], [Ma_KH], [USERNAME], [NgayLap], [TongTien], [hinhthuc]) VALUES (N'HDB5212021_192012', N'KH003', N'NV1', CAST(N'2021-05-21 00:00:00.000' AS DateTime), 165000, N'Tiền mặt')
INSERT [dbo].[tblHOADON] ([Ma_HD], [Ma_KH], [USERNAME], [NgayLap], [TongTien], [hinhthuc]) VALUES (N'HDB5222021_185623', N'KH001', N'NV1', CAST(N'2021-05-22 00:00:00.000' AS DateTime), 53900, N'null')
INSERT [dbo].[tblHOADON] ([Ma_HD], [Ma_KH], [USERNAME], [NgayLap], [TongTien], [hinhthuc]) VALUES (N'HDB5232021_194527', N'KH005', N'QuanLi', CAST(N'2021-05-23 00:00:00.000' AS DateTime), 330000, N'null')
INSERT [dbo].[tblKHACHHANG] ([Ma_KH], [HoTen], [GioiTinh], [DiaChi], [SDT], [Ma_LKH]) VALUES (N'KH001', N'Nguyễn Văn A', N'Nam', N'Châu Thành, An Giang', N'0945236120', N'KHBAC')
INSERT [dbo].[tblKHACHHANG] ([Ma_KH], [HoTen], [GioiTinh], [DiaChi], [SDT], [Ma_LKH]) VALUES (N'KH002', N'Phạm Thị Lan', N'Nữ', N'An Phú, An Giang', N'0312412328', N'KHTHG')
INSERT [dbo].[tblKHACHHANG] ([Ma_KH], [HoTen], [GioiTinh], [DiaChi], [SDT], [Ma_LKH]) VALUES (N'KH003', N'Nguyễn Văn Tèo', N'Nam', N'Long Xuyên, An Giang', N'0541252362', N'KHTHG')
INSERT [dbo].[tblKHACHHANG] ([Ma_KH], [HoTen], [GioiTinh], [DiaChi], [SDT], [Ma_LKH]) VALUES (N'KH004', N'Nguyễn Văn A', N'Nam', N'Long Xuyên, An Giang', N'0475812365', N'KHVAG')
INSERT [dbo].[tblKHACHHANG] ([Ma_KH], [HoTen], [GioiTinh], [DiaChi], [SDT], [Ma_LKH]) VALUES (N'KH005', N'Nguyễn Văn B', N'Nam', N'Long Xuyên, An Giang', N'0965214230', N'KHDOG')
INSERT [dbo].[tblKM] ([MaKM], [TenKM], [PhanTram]) VALUES (N'KHBAC', N'Ưu đãi khách hàng bạc', N'2')
INSERT [dbo].[tblKM] ([MaKM], [TenKM], [PhanTram]) VALUES (N'KHVAG', N'Ưu đãi khách hàng vàng', N'2.5')
INSERT [dbo].[tblKM] ([MaKM], [TenKM], [PhanTram]) VALUES (N'KHVIP', N'Ưu đãi khách hàng VIP', N'3.5')
INSERT [dbo].[tblKM] ([MaKM], [TenKM], [PhanTram]) VALUES (N'KHBKM', N'Ưu đãi khách hàng bạch kim', N'3')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHBAC', N'Bạc')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHBKM', N'Bạch Kim')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHDOG', N'Đồng')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHTHG', N'Thường')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHVAG', N'Vàng')
INSERT [dbo].[tblLOAIKH] ([Ma_LKH], [TenLoaiKH]) VALUES (N'KHVIP', N'VIP')
SET IDENTITY_INSERT [dbo].[tblMOILIENHE] ON 

INSERT [dbo].[tblMOILIENHE] ([ID_MLH], [USERNAME_LH], [ID_QH], [DP]) VALUES (9, N'HangNguyen', 1, 1)
INSERT [dbo].[tblMOILIENHE] ([ID_MLH], [USERNAME_LH], [ID_QH], [DP]) VALUES (3, N'NV1', 1, 1)
INSERT [dbo].[tblMOILIENHE] ([ID_MLH], [USERNAME_LH], [ID_QH], [DP]) VALUES (2, N'NV2', 1, 1)
INSERT [dbo].[tblMOILIENHE] ([ID_MLH], [USERNAME_LH], [ID_QH], [DP]) VALUES (1, N'QuanLi', 2, 1)
SET IDENTITY_INSERT [dbo].[tblMOILIENHE] OFF
INSERT [dbo].[tblNhaCungCap] ([Ma_NCC], [TenNCC], [SDT_NCC], [DiaChi], [SoThe]) VALUES (N'N001', N'Áo dài Mỹ Phương', N'0945632126', N'Long Xuyên, An Giang', NULL)
INSERT [dbo].[tblNhaCungCap] ([Ma_NCC], [TenNCC], [SDT_NCC], [DiaChi], [SoThe]) VALUES (N'N002', N'Áo thun trơn Nhơn Mỹ', N'0974562135', N'Quận 5, TP HCM', N'0124125362')
INSERT [dbo].[tblNhaCungCap] ([Ma_NCC], [TenNCC], [SDT_NCC], [DiaChi], [SoThe]) VALUES (N'N003', N' Quần short Phương Hoa', N'0974523621', N'Quận 3, TP HCM', N'0114524256')
INSERT [dbo].[tblNhaCungCap] ([Ma_NCC], [TenNCC], [SDT_NCC], [DiaChi], [SoThe]) VALUES (N'N004', N' Đầm Nhật Phương', N'0978541236', N'Quận 3, TP HCM', N'0123456789')
INSERT [dbo].[tblNHANVIEN] ([Ho_Lot], [Ten], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Luong], [USERNAME], [PASS]) VALUES (N'Nguyễn Thị Lệ', N'Hằng', CAST(N'2000-02-24' AS Date), N'Nữ', N'0522952765', N'An Giang', 5000000, N'HangNguyen', N'9sRxmjN1OK0=')
INSERT [dbo].[tblNHANVIEN] ([Ho_Lot], [Ten], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Luong], [USERNAME], [PASS]) VALUES (N'Nguyễn Văn', N'A', CAST(N'1998-04-23' AS Date), N'Nữ', N'0758425398', N'AN Giang', 2000000, N'NV1', N'Fkq2w2s+OJoxN9lpG/ihtQ==')
INSERT [dbo].[tblNHANVIEN] ([Ho_Lot], [Ten], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Luong], [USERNAME], [PASS]) VALUES (N'Trần', N'B', CAST(N'1890-07-11' AS Date), N'Nam', N'0124758775', N'AN Giang', 2000000, N'NV2', N'Fkq2w2s+OJrYy2iiyz6hfg==')
INSERT [dbo].[tblNHANVIEN] ([Ho_Lot], [Ten], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Luong], [USERNAME], [PASS]) VALUES (N'Nguyễn Long', N'Hùng', CAST(N'1999-02-24' AS Date), N'Nam', N'0354867152', N'AN Giang', 5000000, N'QuanLi', N'9sRxmjN1OK0=')
INSERT [dbo].[tblNHANVIEN] ([Ho_Lot], [Ten], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Luong], [USERNAME], [PASS]) VALUES (N'Trần Văn', N'Văn', CAST(N'1995-06-21' AS Date), N'Nam', N'0124523659', N'An Giang', 3000000, N'vanvan', N'9sRxmjN1OK0=')
INSERT [dbo].[tblPhieuNhap] ([Ma_PNhap], [Ma_NCC], [NgayNhap], [NguoiNhap], [TongTien], [hinhthuc]) VALUES (N'HDN5232021_012048', N'N004', CAST(N'2021-05-23' AS Date), N'NV2', 674000, N'null')
INSERT [dbo].[tblPhieuNhap] ([Ma_PNhap], [Ma_NCC], [NgayNhap], [NguoiNhap], [TongTien], [hinhthuc]) VALUES (N'HDN5232021_012827', N'N001', CAST(N'2021-05-23' AS Date), N'NV2', 90000, N'null')
INSERT [dbo].[tblPhieuNhap] ([Ma_PNhap], [Ma_NCC], [NgayNhap], [NguoiNhap], [TongTien], [hinhthuc]) VALUES (N'HDN5232021_194554', N'N004', CAST(N'2021-05-23' AS Date), N'QuanLi', 150000, N'null')
INSERT [dbo].[tblPhieuNhap] ([Ma_PNhap], [Ma_NCC], [NgayNhap], [NguoiNhap], [TongTien], [hinhthuc]) VALUES (N'HDN5242021_021546', N'N001', CAST(N'2021-05-24' AS Date), N'NV2', 125000, N'Tiền mặt')
SET IDENTITY_INSERT [dbo].[tblQUYENCHITIET] ON 

INSERT [dbo].[tblQUYENCHITIET] ([ID_CT], [TEN_CT], [MA], [USERNAME]) VALUES (1, N'Quản lý', N'QL', N'QuanLi')
INSERT [dbo].[tblQUYENCHITIET] ([ID_CT], [TEN_CT], [MA], [USERNAME]) VALUES (2, N'Nhân viên bán hàng', N'NVBH', N'NV1')
INSERT [dbo].[tblQUYENCHITIET] ([ID_CT], [TEN_CT], [MA], [USERNAME]) VALUES (3, N'Nhân viên kho hàng', N'NVKH', N'NV2')
INSERT [dbo].[tblQUYENCHITIET] ([ID_CT], [TEN_CT], [MA], [USERNAME]) VALUES (10, N'Nhân viên', N'NV', N'HangNguyen')
SET IDENTITY_INSERT [dbo].[tblQUYENCHITIET] OFF
ALTER TABLE [dbo].[tblCHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HH] FOREIGN KEY([Ma_HH])
REFERENCES [dbo].[tblHANGHOA] ([Ma_HH])
GO
ALTER TABLE [dbo].[tblCHITIETHD] CHECK CONSTRAINT [FK_CTHD_HH]
GO
ALTER TABLE [dbo].[tblCHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_HD_CTHD] FOREIGN KEY([Ma_HD])
REFERENCES [dbo].[tblHOADON] ([Ma_HD])
GO
ALTER TABLE [dbo].[tblCHITIETHD] CHECK CONSTRAINT [FK_HD_CTHD]
GO
ALTER TABLE [dbo].[tblCHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTN_HH] FOREIGN KEY([Ma_HH])
REFERENCES [dbo].[tblHANGHOA] ([Ma_HH])
GO
ALTER TABLE [dbo].[tblCHITIETNHAP] CHECK CONSTRAINT [FK_CTN_HH]
GO
ALTER TABLE [dbo].[tblCHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTN_PN] FOREIGN KEY([Ma_PNhap])
REFERENCES [dbo].[tblPhieuNhap] ([Ma_PNhap])
GO
ALTER TABLE [dbo].[tblCHITIETNHAP] CHECK CONSTRAINT [FK_CTN_PN]
GO
ALTER TABLE [dbo].[tblHOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_KH] FOREIGN KEY([Ma_KH])
REFERENCES [dbo].[tblKHACHHANG] ([Ma_KH])
GO
ALTER TABLE [dbo].[tblHOADON] CHECK CONSTRAINT [FK_HD_KH]
GO
ALTER TABLE [dbo].[tblHOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_NV] FOREIGN KEY([USERNAME])
REFERENCES [dbo].[tblNHANVIEN] ([USERNAME])
GO
ALTER TABLE [dbo].[tblHOADON] CHECK CONSTRAINT [FK_HD_NV]
GO
ALTER TABLE [dbo].[tblKHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KH_LKH] FOREIGN KEY([Ma_LKH])
REFERENCES [dbo].[tblLOAIKH] ([Ma_LKH])
GO
ALTER TABLE [dbo].[tblKHACHHANG] CHECK CONSTRAINT [FK_KH_LKH]
GO
ALTER TABLE [dbo].[tblKM]  WITH CHECK ADD  CONSTRAINT [FK_tblKM_tblLOAIKH] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblLOAIKH] ([Ma_LKH])
GO
ALTER TABLE [dbo].[tblKM] CHECK CONSTRAINT [FK_tblKM_tblLOAIKH]
GO
ALTER TABLE [dbo].[tblMOILIENHE]  WITH CHECK ADD  CONSTRAINT [FK_MLH_U] FOREIGN KEY([USERNAME_LH])
REFERENCES [dbo].[tblNHANVIEN] ([USERNAME])
GO
ALTER TABLE [dbo].[tblMOILIENHE] CHECK CONSTRAINT [FK_MLH_U]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PN_NCC] FOREIGN KEY([Ma_NCC])
REFERENCES [dbo].[tblNhaCungCap] ([Ma_NCC])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_PN_NCC]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PN_NV] FOREIGN KEY([NguoiNhap])
REFERENCES [dbo].[tblNHANVIEN] ([USERNAME])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_PN_NV]
GO
ALTER TABLE [dbo].[tblQUYENCHITIET]  WITH CHECK ADD  CONSTRAINT [FK_QHCT_QH] FOREIGN KEY([USERNAME])
REFERENCES [dbo].[tblNHANVIEN] ([USERNAME])
GO
ALTER TABLE [dbo].[tblQUYENCHITIET] CHECK CONSTRAINT [FK_QHCT_QH]
GO
ALTER TABLE [dbo].[tblKHACHHANG]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[tblKHACHHANG]  WITH CHECK ADD CHECK  (([SDT] like '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[tblNhaCungCap]  WITH CHECK ADD CHECK  (([SDT_NCC] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [SDT_NCC] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[tblNHANVIEN]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[tblNHANVIEN]  WITH CHECK ADD CHECK  (([SDT] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
