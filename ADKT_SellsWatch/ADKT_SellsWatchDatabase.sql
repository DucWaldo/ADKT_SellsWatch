USE [master]
GO
/****** Object:  Database [ADKT_SELLSWATCH]    Script Date: 28/08/2021 10:26:43 SA ******/
CREATE DATABASE [ADKT_SELLSWATCH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ADKT_SELLSWATCH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ADKT_SELLSWATCH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ADKT_SELLSWATCH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ADKT_SELLSWATCH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ADKT_SELLSWATCH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ARITHABORT OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET  MULTI_USER 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET QUERY_STORE = OFF
GO
USE [ADKT_SELLSWATCH]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[BrandID] [int] NOT NULL,
	[BrandName] [nvarchar](50) NULL,
	[Info] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Membership]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Membership](
	[CustomerID] [varchar](15) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[BirthDay] [date] NULL,
	[Genner] [bit] NULL,
	[CardDay] [date] NULL,
	[Phone] [int] NULL,
	[RankID] [int] NULL,
 CONSTRAINT [PK_Membership] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rank]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rank](
	[RankID] [int] NOT NULL,
	[RankName] [nvarchar](50) NULL,
	[Info] [nvarchar](max) NULL,
 CONSTRAINT [PK_Rank] PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[ReceiptID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [varchar](15) NULL,
	[StaffID] [varchar](50) NULL,
	[Date] [date] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt_Details]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt_Details](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[WatchID] [varchar](50) NOT NULL,
	[ReceiptID] [int] NOT NULL,
	[numOfWatch] [int] NOT NULL,
 CONSTRAINT [PK_Receipt_Details] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[BirthDay] [datetime] NULL,
	[WorkDay] [datetime] NULL,
	[Phone] [varchar](11) NULL,
	[Salary] [decimal](18, 0) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Watch]    Script Date: 28/08/2021 10:26:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Watch](
	[WatchID] [varchar](50) NOT NULL,
	[WatchName] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[Glass] [nvarchar](50) NULL,
	[Waterproof] [varchar](50) NULL,
	[Strap] [nvarchar](50) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[BrandID] [int] NOT NULL,
	[NumOfItem] [int] NULL,
 CONSTRAINT [PK_Watch] PRIMARY KEY CLUSTERED 
(
	[WatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (1, N'SAGA', N'“Là thương hiệu thời trang đến từ nước Mỹ từ năm 1950, đồng hồ Saga hiện đang sở hữu 4 dòng sản phẩm chính là Saga Safran: dòng cao cấp, được sản xuất tại Thụy Sỹ. Saga Stella: dòng đồng hồ đeo tay kết hợp trang sức, đính pha lê swarovski. Saga Space: dòng đồng hồ nam kết hợp ý tưởng về không gian và hành tinh. Saga Signature: dòng sản phẩm thanh lịch, truyền thống được các doanh nghiệp lựa chọn làm đơn đặt hàng số lượng lớn. Ngoài ra, đồng hồ Saga thể hiện được độ bền thông qua bộ máy Nhật và Thụy Sỹ được trang bị bên trong.”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (2, N'FOUETTÉ', N'“Cuộc sống giống như một sân khấu. Khi ánh đèn bật sáng, nàng vũ công ba lê (Ballerina) bắt đầu thực hiện những vũ điệu hoàn hảo trên sân khấu và giành được trái tim của mọi người. Đó chính ra là cảm hứng để tạo ra những chiếc đồng hồ ba lê Fouetté Ballerina – tác phẩm đoạt giải vô địch cuộc thi thiết kế đồng hồ danh giá – Hong Kong Watch & Clock Design Competition”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (3, N'CASIO', N'“Đồng hồ Casio được biết đến là thương hiệu đồng hồ lâu đời trong ngành công nghiệp đồng hồ tại Nhật Bản. Những mẫu đồng hồ Casio nam và đồng hồ Casio nữ được yêu thích bởi thiết kế đơn giản, dễ dàng để xem giờ, được trang bị đầy đủ các công nghệ mới nhất và có giá bán cực kỳ rẻ. Ngoài ra, đồng hồ Casio chính hãng còn nổi bật với chức năng đa dạng giúp ích cho người dùng vào những hoạt động đời sống thường ngày.')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (4, N'CITIZEN', N'“Được tạo nên từ những chất liệu Hàng Đầu, Citizen giúp đảo bảo song song giữa bộ máy hoạt động mạnh mẽ, bền bỉ và chính xác cùng thiết kế sang trọng, hiện đại và phù hợp với thị hiếu người tiêu dùng. Chưa hết, hãng đồng hồ CITIZEN đã trở thành thương hiệu thời trang hàng đầu nước NHẬT và là người dẫn đầu trong việc sử dụng công nghệ sử dụng năng lượng ánh sáng mặt trời (Citizen ECO-DRIVE). Điều này đã giúp những chiếc đồng hồ Citizen nam nữ chính hãng trở dòng sản phẩm cực kỳ ưa chuộng cho giới Doanh Nhân.”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (5, N'SEIKO', N'“SEIKO, thương hiệu đồng hồ có bề dày lịch sử lâu đời nhất tại Nhật Bản. Với hơn 130 năm kinh nghiệm, hãng đồng hồ SEIKO sẽ đem đến cho bạn những trải nghiệm về sự Tinh Tế, Sang Trọng trong thiết kế cũng như chất lượng hoàn hảo đến từ sản phẩm đồng hồ SEIKO nam nữ chính hãng. Bộ máy đồng hồ SEIKO được tạo nên dựa trên những tinh hoa công nghệ hàng đầu nước Nhật, cho sự “Ổn Định” cũng như độ “Chính Xác” cao trong từng chuyển động. Một số dòng đồng hồ SEIKO nam nữ chính hãng được quan tâm nhiều nhất hiện nay như: Seiko 5, Seiko Kinetic, Seiko Automatic.. vv”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (6, N'G-SHOCK & BABY-G', N'“Đồng hồ G-Shock & Baby-G là sự kết hợp đồng bộ giữa phong cách, cá tính và thời trang. Bằng việc tích hợp nhiều công nhệ hiện đại, đồng hồ G-Shock & Baby-G mang đến cho bạn khung giờ chính xác tuyệt đối với hệ thống tín hiệu lan truyền qua những tần sóng. Những tính năng nổi bật của một chiếc đồng hồ G-Shock & Baby-G có thể nói đến đó là khả năng kháng nước, chống sốc, giờ quốc tế, đo độ cao,  đo số vòng chạy, ….Tại Việt Nam, đồng hồ G-Shock Baby-G được yêu thích rất nhiều bởi những giới trẻ ở độ tuổi từ 16-24, những bạn trẻ muốn thể hiện sự năng động và cá tính của mình”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (7, N'FOSSIL', N'“Fossil được biết đến là thương hiệu sản xuất quần áo và phụ kiện thời trang lớn nhất tại Mỹ hiện nay. Mảng chính của Fossil đó là sản xuất các loại đồng hồ hiệu với mẫu mã đa dạng và thời trang. Phong cách đồng hồ Fossil chính hãng là sự tiếp thu từ truyền thống cổ điển kết hợp với công nghệ hiện đại ngày nay. Nếu như đồng hồ Fossil nam thu hút khách hàng với sự tinh tế và nổi bật từ những mẫu đồng hồ dây da sang trọng. Thì đồng hồ Fossil nữ lại quyến rủ với những mẫu đồng hồ bằng kim loại mạ vàng đầy quý phái….”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (8, N'MICHAEL KORS', N'“Michael Kors – thương hiệu thời trang và phụ kiện cao cấp danh tiếng nhất tại Mỹ… gắn liền với các sản phẩm áo quần, túi xách giá trị lên đến hàng chục triệu đồng. Nhưng riêng với mặt hàng đồng hồ, Michael Kors mở bán ở mức giá chỉ từ 4.600.000 VNĐ cho cộng đồng đam mê. Vốn thừa hưởng phong cách thiết kế hiện đại theo xu hướng thời trang cùng bộ máy được tạo nên từ công nghệ Tiên Tiến, đồng hồ Michael Kors nam nữ chính hãng đã mang đến khả năng vận hành ổn định và chính xác dường như tuyệt đối. Đồng hồ Michael Kors nữ chính hãng hiện nay đang là xu hướng thời trang cao cấp HOT nhất đối với những cô gái yêu thích sự “Nổi Bật”… Đồng hồ MICHAEL KORS giá trị một thương hiệu…”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (9, N'CANDINO', N'“Vẻ đẹp sang trọng đầy lịch lãm được tạo nên bởi đôi tay của những nghệ nhân đồng hồ chuyên nghiệp hàng đầu, theo đó một là quy trình sản xuất và kiểm tra chất lượng nghiêm ngặt theo chuẩn công nghệ Thụy Sỹ. Những chiếc đồng hồ CANDINO nam nữ chính hãng, không chỉ sang trọng về thiết kế mà còn hoàn hảo về chất lượng. “Swiss Made” dòng chữ được in trên tất cả sản phẩm đồng hồ CANDINO chính hãng, đó là biểu mẫu tượng trưng cho một chất lượng tuyệt hảo đối với những chiếc đồng hồ được sản xuất từ Thụy Sĩ”')
INSERT [dbo].[Brand] ([BrandID], [BrandName], [Info]) VALUES (10, N'DANIEL WELLINGTON (DW)', N'“Chào đời vào năm 2011 nhưng đến nay đồng hồ Daniel Wellington chính hãng đã tạo nên một cơn sốt và trào lưu mới dành giới trẻ (cả nam và nữ) trên toàn thế giới. Mỗi chiếc đồng hồ Daniel Wellington chính hãng ra đời đó là một nét đẹp và một phong cách mới mà những người đứng đầu thường hiệu này muốn dành tặng cho những tín đồ của họ, điều này cũng giống như một nút nhạc giao hưởng tạo nên những cung bật muôn màu cho người nghe. Nếu bạn chưa sở hữu chiếc đồng hồ DW chính hãng hãy trải nghiệm “cảm giác” đó ngay tại đây... “')
GO
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'0735542324', N'Trần Ngọc Huyền', CAST(N'2001-01-30' AS Date), 1, CAST(N'2019-02-07' AS Date), 945336547, 1)
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'1344526718', N'Huỳnh Văn Trung', CAST(N'1974-11-15' AS Date), 0, CAST(N'2021-08-22' AS Date), 945668121, 1)
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'154220685', N'Huỳnh Kim Bảo', CAST(N'1994-06-10' AS Date), 0, CAST(N'2021-08-22' AS Date), 953446745, 0)
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'1827652018', N'Trần Ngọc Hoàng', CAST(N'1995-10-11' AS Date), 1, CAST(N'2021-08-24' AS Date), 74332461, 0)
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'285692293', N'Phan Văn Đức', CAST(N'2000-05-09' AS Date), 0, CAST(N'2021-08-23' AS Date), 355420242, 1)
INSERT [dbo].[Membership] ([CustomerID], [CustomerName], [BirthDay], [Genner], [CardDay], [Phone], [RankID]) VALUES (N'352166542', N'Thái Quang Vinh', CAST(N'2000-05-19' AS Date), 0, CAST(N'2021-08-27' AS Date), 95667243, 0)
GO
INSERT [dbo].[Rank] ([RankID], [RankName], [Info]) VALUES (0, N'Hạng Thường', N'Chưa có khuyến mãi gì cho hạng thường')
INSERT [dbo].[Rank] ([RankID], [RankName], [Info]) VALUES (1, N'Hạng Đồng', N'Hạng đồng được trừ 10% vào mỗi đơn hàng')
INSERT [dbo].[Rank] ([RankID], [RankName], [Info]) VALUES (2, N'Hạng Bạc', N'Hạng bạc được trừ 15% vào mỗi đơn hàng')
INSERT [dbo].[Rank] ([RankID], [RankName], [Info]) VALUES (3, N'Hạng Vàng', N'Hạng vàng được trừ 20% vào mỗi đơn hàng')
GO
SET IDENTITY_INSERT [dbo].[Receipt] ON 

INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (1, N'0735542324', NULL, CAST(N'2020-04-12' AS Date), CAST(17943000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (2, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(16494000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (4, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(16494000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (5, N'0735542324', NULL, CAST(N'2021-08-23' AS Date), CAST(16494000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (6, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(16494000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (8, N'0735542324', NULL, CAST(N'2021-08-23' AS Date), CAST(30330000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (9, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(30330000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (10, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(19152000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (11, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(19152000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (12, N'0735542324', NULL, CAST(N'2021-08-23' AS Date), CAST(12874000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (13, N'1344526718', NULL, CAST(N'2021-08-23' AS Date), CAST(31884000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (14, N'0735542324', NULL, CAST(N'2021-08-23' AS Date), CAST(23044000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (15, N'285692293', NULL, CAST(N'2021-08-23' AS Date), CAST(57770000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (16, N'285692293', NULL, CAST(N'2021-08-23' AS Date), CAST(21546000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (17, N'285692293', NULL, CAST(N'2021-08-24' AS Date), CAST(16494000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (19, N'285692293', NULL, CAST(N'2021-08-24' AS Date), CAST(12768000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (20, N'285692293', NULL, CAST(N'2021-08-24' AS Date), CAST(8827000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (22, N'285692293', NULL, CAST(N'2021-08-25' AS Date), CAST(38374000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (23, N'285692293', N'phanvanduc@staff.com', CAST(N'2021-08-27' AS Date), CAST(6384000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (24, N'285692293', N'phanvanduc@staff.com', CAST(N'2021-08-27' AS Date), CAST(3726000 AS Decimal(18, 0)))
INSERT [dbo].[Receipt] ([ReceiptID], [CustomerID], [StaffID], [Date], [TotalPrice]) VALUES (25, N'1344526718', N'nguyenbinhan@staff.com', CAST(N'2021-08-28' AS Date), CAST(2443000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Receipt] OFF
GO
SET IDENTITY_INSERT [dbo].[Receipt_Details] ON 

INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (1, N'MTP-E130L-2A2VDF', 1, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (2, N'OR-LOVE', 1, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (3, N'53766 GPZMGGE-2', 6, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (4, N'53766 SVMBBK-2', 6, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (5, N'GA-2110ET-8ADR', 6, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (6, N'53766 GPZMGGE-2', 8, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (7, N'53766 SVMBBK-2', 8, 2)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (8, N'GA-2110ET-8ADR', 8, 3)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (9, N'53766 SVMBBK-2', 9, 3)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (10, N'53766 SVMBBK-2', 10, 3)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (11, N'53766 GPZMGGE-2', 11, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (12, N'53766 GPZMGGE-2', 11, 2)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (13, N'53766 GPZMGGE-2', 12, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (14, N'MSG-S600G-7ADR', 12, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (15, N'53766 GPZMGGE-2', 13, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (16, N'OR-FAIRY I', 13, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (17, N'53766 GPZMGGE-2', 14, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (18, N'MSG-S600G-7ADR', 14, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (19, N'PC1008-11Y', 14, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (20, N'53766 SVMBBK-2', 15, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (21, N'MTP-E130L-2A2VDF', 15, 2)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (22, N'OR-LOVE', 15, 3)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (23, N'GA-2110ET-8ADR', 16, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (24, N'NJ0120-81E', 16, 2)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (25, N'53766 GPZMGGE-2', 17, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (26, N'53766 SVMBBK-2', 17, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (27, N'GA-2110ET-8ADR', 17, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (28, N'53766 GPZMGGE-2', 19, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (29, N'53766 GPZMGGE-2', 20, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (30, N'MTP-E130L-2A2VDF', 20, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (32, N'53766 SVMBBK-2', 22, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (33, N'OR-FAIRY I', 22, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (34, N'MSG-S600G-7ADR', 22, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (35, N'53766 SVMBBK-2', 23, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (36, N'GA-2110ET-8ADR', 24, 1)
INSERT [dbo].[Receipt_Details] ([Number], [WatchID], [ReceiptID], [numOfWatch]) VALUES (37, N'MTP-E130L-2A2VDF', 25, 1)
SET IDENTITY_INSERT [dbo].[Receipt_Details] OFF
GO
INSERT [dbo].[Staff] ([UserName], [Password], [Name], [Address], [Gender], [BirthDay], [WorkDay], [Phone], [Salary], [Status]) VALUES (N'nguyenbinhan@staff.com', N'61PEyQDxuZUdHWlWBbAjBA==', N'Nguyễn Bình An', N'Vĩnh Long', 0, CAST(N'1998-12-15T00:00:00.000' AS DateTime), CAST(N'2016-05-04T00:00:00.000' AS DateTime), N'0948644278', CAST(5000000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Staff] ([UserName], [Password], [Name], [Address], [Gender], [BirthDay], [WorkDay], [Phone], [Salary], [Status]) VALUES (N'phanvanduc@staff.com', N'VacQMEgW+yDgG4O5PiC+lg==', N'Phan Văn Đức', N'Tp.HCM', 0, CAST(N'2000-05-09T00:00:00.000' AS DateTime), CAST(N'2016-12-20T00:00:00.000' AS DateTime), N'0355420242', CAST(5000000 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'53766 GPZMGGE-2', N'SAGA 53766 GPZMGGE-2 – NỮ – QUARTZ (PIN) – DÂY DA – MẶT SỐ 39MM', 1, N'Mineral Crystal (Kính Cứng)', N'5 ATM', N'Dây Da', CAST(6384000 AS Decimal(18, 0)), 1, 0)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'53766 SVMBBK-2', N'SAGA 53766 SVMBBK-2 – NỮ – QUARTZ (PIN) – DÂY DA – MẶT SỐ 39MM', 1, N'Mineral Crystal (Kính Cứng)', N'5 ATM', N'Dây Da', CAST(6384000 AS Decimal(18, 0)), 1, 4)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'GA-2110ET-8ADR', N'G-SHOCK GA-2110ET-8ADR – NAM – QUARTZ (PIN) – DÂY CAO SU', 0, N'Mineral Crystal (Kính Cứng)', N'20 ATM', N'Dây Cao Su', CAST(3726000 AS Decimal(18, 0)), 6, 5)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'MSG-S600G-7ADR', N'CASIO MSG-S600G-7ADR – NỮ – SOLAR (NĂNG LƯỢNG ÁNH SÁNG) – DÂY CAO SU – MẶT SỐ 40.2MM', 1, N'
Mineral Crystal (Kính Cứng)', N'10 ATM', N'Dây Cao Su', CAST(6490000 AS Decimal(18, 0)), 3, 2)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'MTP-E130L-2A2VDF', N'CASIO MTP-E130L-2A2VDF – NAM – QUARTZ (PIN) – DÂY DA – MẶT SỐ 47.1MM', 0, N'Mineral Crystal (Kính Cứng)', N'
5 ATM', N'Dây Da', CAST(2443000 AS Decimal(18, 0)), 3, 4)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'NJ0120-81E', N'CITIZEN NJ0120-81E – NAM – AUTOMATIC (TỰ ĐỘNG) – DÂY KIM LOẠI – MẶT SỐ 43MM', 0, N'Mineral Crystal (Kính Cứng)', N'10 ATM', N'Thép Không Gỉ', CAST(8910000 AS Decimal(18, 0)), 4, 8)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'OR-FAIRY I', N'FOUETTÉ OR-FAIRY I – NỮ – KÍNH SAPPHIRE – QUARTZ (PIN) – DÂY DA – LIMITED EDITION', 1, N'Sapphire (Kính Chống Trầy)', N'3 ATM', N'Dây Da', CAST(25500000 AS Decimal(18, 0)), 2, 3)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'OR-LOVE', N'FOUETTÉ OR-LOVE – NỮ – QUARTZ (PIN) – DÂY DA', 1, N'Mineral Crystal (Kính Cứng)', N'3 ATM', N'Dây Da', CAST(15500000 AS Decimal(18, 0)), 2, 5)
INSERT [dbo].[Watch] ([WatchID], [WatchName], [Gender], [Glass], [Waterproof], [Strap], [Price], [BrandID], [NumOfItem]) VALUES (N'PC1008-11Y', N'CITIZEN PC1008-11Y – NỮ – KÍNH SAPPHIRE – AUTOMATIC (TỰ ĐỘNG) – DÂY DA – MẶT SỐ 34MM', 1, N'Sapphire (Kính Chống Trầy)', N'10 ATM', N'Thép Không Gỉ', CAST(10170000 AS Decimal(18, 0)), 4, 0)
GO
ALTER TABLE [dbo].[Membership]  WITH CHECK ADD  CONSTRAINT [FK_Membership_Rank] FOREIGN KEY([RankID])
REFERENCES [dbo].[Rank] ([RankID])
GO
ALTER TABLE [dbo].[Membership] CHECK CONSTRAINT [FK_Membership_Rank]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Membership] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Membership] ([CustomerID])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Membership]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([UserName])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Staff]
GO
ALTER TABLE [dbo].[Receipt_Details]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Details_Receipt] FOREIGN KEY([ReceiptID])
REFERENCES [dbo].[Receipt] ([ReceiptID])
GO
ALTER TABLE [dbo].[Receipt_Details] CHECK CONSTRAINT [FK_Receipt_Details_Receipt]
GO
ALTER TABLE [dbo].[Receipt_Details]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Details_Watch] FOREIGN KEY([WatchID])
REFERENCES [dbo].[Watch] ([WatchID])
GO
ALTER TABLE [dbo].[Receipt_Details] CHECK CONSTRAINT [FK_Receipt_Details_Watch]
GO
ALTER TABLE [dbo].[Watch]  WITH CHECK ADD  CONSTRAINT [FK_Watch_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brand] ([BrandID])
GO
ALTER TABLE [dbo].[Watch] CHECK CONSTRAINT [FK_Watch_Brand]
GO
USE [master]
GO
ALTER DATABASE [ADKT_SELLSWATCH] SET  READ_WRITE 
GO
