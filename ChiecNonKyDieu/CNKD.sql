USE [master]
GO
/****** Object:  Database [CNKD]    Script Date: 13/5/2018 1:26:18 PM ******/
CREATE DATABASE [CNKD]
 
GO
USE [CNKD]
GO
/****** Object:  Table [dbo].[BangXepHang]    Script Date: 5/17/2018 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangXepHang](
	[TenNguoiChoi] [nvarchar](50) NOT NULL,
	[ThoiGianTao] [datetime] NOT NULL,
	[SoDiem] [int] NOT NULL,
 CONSTRAINT [PK_BangXepHang] PRIMARY KEY CLUSTERED 
(
	[TenNguoiChoi] ASC,
	[ThoiGianTao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 5/17/2018 8:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CauHoi](
	[ID] [varchar](10) NOT NULL,
	[ChuDe] [varchar](10) NOT NULL,
	[NoiDung] [ntext] NOT NULL,
	[DapAn] [nvarchar](50) NOT NULL,
	[DapAnDayDu] [nvarchar] (50) not null,
 CONSTRAINT [PK_CauHoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[ChuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 5/17/2018 8:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChuDe](
	[ID] [varchar](10) NOT NULL,
	[TenChuDe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChuDe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 5/17/2018 8:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ID] [varchar](10) NOT NULL,
	[TenDanhMuc] [nvarchar](20) NOT NULL,
	[GiaTri] [ntext] NOT NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiemThuong]    Script Date: 5/17/2018 8:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DiemThuong](
	[ID] [varchar](10) NOT NULL,
	[TenMuc] [nvarchar](10) NOT NULL,
	[GiaTri] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DiemThuong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 5/17/2018 8:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThamSo](
	[ID] [varchar](10) NOT NULL,
	[TenThamSo] [nvarchar](50) NOT NULL,
	[KieuDuLieu] [varchar](15) NOT NULL,
	[GiaTri] [int] NOT NULL,
	[TinhTrang] [tinyint] NOT NULL,
 CONSTRAINT [PK_ThamSo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'BaThanh', CAST(0x0000A83C00000000 AS DateTime), 2900)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'GiaHuynh', CAST(0x0000A8B800000000 AS DateTime), 4000)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'GiaKhanh', CAST(0x0000A80700000000 AS DateTime), 4000)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'LeHung', CAST(0x0000A88E00000000 AS DateTime), 3700)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'Lucky', CAST(0x0000A85B00000000 AS DateTime), 1500)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'NguyenHung', CAST(0x0000A8AA00000000 AS DateTime), 5800)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'sa', CAST(0x0000A8E401240440 AS DateTime), 6000)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'sad', CAST(0x0000A8E4012274A4 AS DateTime), 5700)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'ThanhCong', CAST(0x0000A86E00000000 AS DateTime), 3600)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'ThanhHung', CAST(0x0000A78E00000000 AS DateTime), 4100)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'ThanhTrung', CAST(0x0000A7FD00000000 AS DateTime), 3000)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'ThuHuong', CAST(0x0000A80800000000 AS DateTime), 2500)
INSERT [dbo].[BangXepHang] ([TenNguoiChoi], [ThoiGianTao], [SoDiem]) VALUES (N'TuanAnh', CAST(0x0000A7AA00000000 AS DateTime), 3500)
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'BangMieng', N'DoVui', N'Vua gọi hoàng hậu bằng gì?', N'MIENG', N'MIỆNG')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'BaTrieu', N'LichSu', N'Có bà nữ tướng Vâng mệnh trời ra
Trị voi một ngà
Dựng cờ mở nước?', N'BATRIEU', N'BÀ TRIỆU')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'BienChet', N'TheGioi', N'Biển có nồng độ muối lớn nhất thế giới? ', N'BIENCHET', N'BIỂN CHẾT')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CaBong', N'ConVat', N'Con gì vốn rất hiền lành
Xưa được cô Tấm dỗ dành nuôi cơm – Là con gì?', N'CABONG', N'CÁ BỐNG')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CangDongA', N'TheGioi', N'Cảng nào lớn nhất Đông Á?', N'THUONGHAI', N'CẢNG THƯỢNG HẢI')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CayChuoi', N'CayCoi', N'Cây gì thân nhắn, lá xanh

Có buồng quả chín, ngọt lành thơm?', N'CHUOI', N'CHUỐI')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CayMia', N'CayCoi', N'Tựa như cây trúc ngoài đồng
Trâu dòm thấy ngán, người trông thấy thèm.', N'MIA', N'MÍA')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CayXauHoi', N'CayCoi', N'Cây gì tên sợ người cười
Hễ ai chạm phải đang tươi, héo liền?', N'XAUHO', N'XẤU HỔ')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'ChuonChuon', N'ConVat', N'Con gì cánh mỏng đuôi dài
Lúc bay lúc đậu cánh thời đều giương?', N'CHUONCHUON', N'CON CHUỒN CHUỒN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'Chuot', N'ConVat', N'Vừa bằng quả mướp ăn cướp cả làng?

Hỏi là con gì?', N'CHUOT', N'CON CHUỘT')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'ConTim', N'DoVui', N'Con gì đập thì sống, không đập thì chết?', N'TIM', N'CON TIM')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'CuMeo', N'ConVat', N'Trông xa tưởng là mèo
Lại gần hóa ra chim
Ban ngày ngủ lim dim
Ban đêm lùng bắt chuột – Là con gì?', N'CUMEO', N'CHIM CÚ MÈO')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'DaoCooc', N'TheGioi', N'Đảo Korsika Cooc thuộc nước nào? (tiếng Việt)', N'PHAP', N'PHÁP')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'DaoLonNhat', N'TheGioi', N'Hòn đảo lớn nhất trên thế giới là gì?', N'GREENLAND', N'GREENLAND')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'DinhBoLinh', N'LichSu', N'Thuở bé chăn trâu đồng nội
Lớn lên dẹp loạn sứ quân
Thống nhất giang sơn một mối
Hoa Lư, lừng lẫy kinh thành?', N'DINHBOLINH', N'ĐINH BỘ LĨNH')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'DoiVN', N'TheThao', N'Đội tuyển của quốc gia nào đạt chức vô địch tại giải bóng chuyền VTV Cup 2014 ? (tiếng Việt)', N'VIETNAM', N'VIỆT NAM')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'DuongDoi', N'DoVui', N'Con đường dài nhất là đường nào?', N'DUONGDOI', N'ĐƯỜNG ĐỜI')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'EoBienHep', N'TheGioi', N'Eo biển hẹp nhất thế giới là gì?', N'BOSPHORUS', N'BOSPHORUS')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'GayTay', N'DoVui', N'Bệnh gì bác sỹ bó tay?', N'GAYTAY', N'GÃY TAY')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'HaiBaTrung', N'LichSu', N'Thù nước, thù nhà oằn nặng gánh
Chị em siết chặt cán gươm thiêng
Chí lớn như trăng tròn vành vạnh
Tô Định cúi đầu trước thuyền quyên?', N'HAIBATRUNG', N'HAI BÀ TRƯNG')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'HinhDangY', N'TheGioi', N'Đất nước có hình dáng chiếc ủng là? (tiếng Anh)', N'ITALIA', N'ITALIA (Ý)')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'HoSauNhat', N'TheGioi', N'Hồ nội địa nào sâu nhất thế giới?', N'BAICAN', N'HỒ BAICAN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'Kien', N'ConVat', N'Con gì tuy bé
Mà biết lo xa
Tha thức ăn về nhà
Phòng khi trời mưa bão – Là con gì?', N'KIEN', N' CON KIẾN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'LichSuDai', N'DoVui', N'Lịch nào dài nhất?', N'LICHSU', N'LỊCH SỬ')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'LinhVat', N'TheThao', N'Thế vận hội mùa đông 2014 tại Sochi (Nga) có ba linh vật được chọn gồm báo tuyết, thỏ rừng và loài nào ?', N'GAU', N'GẤU')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'NgocTrai', N'DoVui', N'Con trai có gì quý nhất?', N'NGOCTRAI', N'NGỌC TRAI')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'Nhen', N'ConVat', N'Không là thợ dệt
Không guồng quay tơ
Không học bao giờ
Chăng tơ bừa bãi – Là con gì?', N'NHEN', N'CON NHỆN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'QGNMGio', N'TheGioi', N'Quốc gia có nhiều múi giờ nhất trên thế giới? (tiếng Việt)', N'PHAP', N'PHÁP')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'QuanDao', N'DoVui', N'Quần rộng nhất là quần gì?', N'QUANDAO', N'QUẦN ĐẢO')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'QuangTrung', N'LichSu', N'Vua nào áo vải
Đánh bại quân Thanh
Lên ngôi Hoàng Đế - Là ai?', N'QUANGTRUNG', N'QUANG TRUNG')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'QuocGiaNho', N'TheGioi', N'Quốc gia nào có diện tích nhỏ nhất thế giới?', N'VANTICAN', N'VANTICAN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'ThacNuoc', N'TheGioi', N'Thác nước tự nhiên cao nhất trên thế giới là gì?', N'ANGEL', N'ANGEL')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'ThaiSon', N'DoVui', N'Núi nào mà bị chặt ra từng khúc?', N'THAISON', N'THÁI SƠN')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'THDao', N'LichSu', N'Vó ngựa quân Nguyên cuồng bạo nhất
Đến đất ta cũng tan tác ba lần
Vị tướng đập tan mưu cướp nước
Tên ông sống mãi với ngàn năm?', N'TRANHUNGDAO', N'TRẦN HƯNG ĐẠO')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'TPVinhCuu', N'TheGioi', N'Thành phố nào ở nước Ý được gọi là thành phố vĩnh cửu?', N'ROMA', N'THÀNH PHỐ ROMA')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'VDVLeague', N'TheThao', N'Câu lạc bộ nào đạt chức vô địch V-League 2014 ?', N'BINHDUONG', N'BÌNH DƯƠNG')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'VDWCNhieu', N'TheThao', N'Quốc gia nào đạt chức vô địch World Cup bóng đá nam nhiều lần nhất ? (tiếng Anh)', N'BRAZIL', N'BRAZIL')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'VoDichEuro', N'TheThao', N'Đội tuyển quốc gia nào vô địch EURO 2012 ? (tiếng Việt)', N'TAYBANNHA', N'TÂY BAN NHA')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'VoDichWC', N'TheThao', N'Quốc gia nào đạt chức vô địch World Cup 2014 ? (tiếng Việt)', N'DUC', N'ĐỨC')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'XaHoi', N'DoVui', N'Xã đông nhất là xã nào?', N'XAHOI', N'XÃ HỘI')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'XeDiaHinh', N'TheThao', N'Jamie Bestwick, vận động viên thể thao mạo hiểm xuất sắc tại giải Laureus World Sports Awards 2014 là ngôi sao ở môn thể thao nào ?', N'XEDAPDIAHINH', N'XE ĐẠP ĐỊA HÌNH')
INSERT [dbo].[CauHoi] ([ID], [ChuDe], [NoiDung], [DapAn], [DapAnDayDu]) VALUES (N'YetKieu', N'LichSu', N'Ai người bơi giỏi, lặn tài
Khoan đục thuyền giặc, đánh tan quân thù?', N'YETKIEU', N'YẾT KIÊU')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'CayCoi', N'Cây Cối')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'ConVat', N'Con Vật')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'DoVui', N'Đố Vui')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'LichSu', N'Anh Hùng Lịch Sử Việt Nam')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'TheGioi', N'Thế Giới')
INSERT [dbo].[ChuDe] ([ID], [TenChuDe]) VALUES (N'TheThao', N'Thể Thao')
INSERT [dbo].[DanhMuc] ([ID], [TenDanhMuc], [GiaTri]) VALUES (N'Luat1', N'Luật chơi 1', N'Trong trò chơi chiếc nón kỳ diệu người chơi sẽ phải trả lời câu hỏi do chương trình đề ra,
trước đó người chơi được chọn chủ đề mà mình muốn để chương trình đưa ra câu hỏi
theo chủ đề phù hợp. Người chơi thực hiện lượt chơi lần lượt và trong lượt người chơi đó
đầu tiên phải quay số, sau đó có hai cách để trả lời là đoán từng chữ cái hoặc trả lời trọn vẹn
đáp án. Người chơi đoán đúng sẽ được điểm tương ứng. Trò chơi sẽ kết thúc sau
3 vòng chơi (người chơi có thể chỉnh lại), người chơi có số điểm cao nhất sẽ chiến thắng.
')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P00', N'Thuong', N'2000')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P01', N'Thuong', N'100')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P02', N'Thuong', N'500')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P03', N'Thuong', N'x2')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P04', N'Thuong', N'200')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P05', N'Thuong', N'700')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P06', N'Thuong', N'1000')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P07', N'Thuong', N'400')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P08', N'Phat', N'miss')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P09', N'Thuong', N'900')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P10', N'Thuong', N'lucky')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P11', N'Thuong', N'300')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P12', N'Thuong', N'800')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P13', N'Phat', N'zero')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P14', N'Thuong', N'1000')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P15', N'Thuong', N'400')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P16', N'Thuong', N'600')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P17', N'Thuong', N'300')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P18', N'Thuong', N'more')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P19', N'Thuong', N'200')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P20', N'Thuong', N'900')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P21', N'Thuong', N'700')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P22', N'Phat', N'/2')
INSERT [dbo].[DiemThuong] ([ID], [TenMuc], [GiaTri]) VALUES (N'P23', N'Thuong', N'300')
INSERT [dbo].[ThamSo] ([ID], [TenThamSo], [KieuDuLieu], [GiaTri], [TinhTrang]) VALUES (N'svong', N'SoVong', N'int', 3, 1)
INSERT [dbo].[ThamSo] ([ID], [TenThamSo], [KieuDuLieu], [GiaTri], [TinhTrang]) VALUES (N'tgcho', N'ThoiGianCho', N'int', 25, 1)
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_ChuDe] FOREIGN KEY([ChuDe])
REFERENCES [dbo].[ChuDe] ([ID])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_ChuDe]
GO


/*drop database CNKD
select top 10 *
from BangXepHang
order by SoDiem desc
select * from CauHoi
select * from ChuDe
select * from DanhMuc
select * from DiemThuong
select * from ThamSo*/
