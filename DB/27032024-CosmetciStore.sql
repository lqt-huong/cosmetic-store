USE [master]
GO
/****** Object:  Database [cosmetic-store]    Script Date: 28/03/2024 12:00:42 SA ******/
CREATE DATABASE [cosmetic-store]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cosmetic-store', FILENAME = N'F:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cosmetic-store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cosmetic-store_log', FILENAME = N'F:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cosmetic-store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [cosmetic-store] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cosmetic-store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cosmetic-store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cosmetic-store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cosmetic-store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cosmetic-store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cosmetic-store] SET ARITHABORT OFF 
GO
ALTER DATABASE [cosmetic-store] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cosmetic-store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cosmetic-store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cosmetic-store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cosmetic-store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cosmetic-store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cosmetic-store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cosmetic-store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cosmetic-store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cosmetic-store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cosmetic-store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cosmetic-store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cosmetic-store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cosmetic-store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cosmetic-store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cosmetic-store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cosmetic-store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cosmetic-store] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cosmetic-store] SET  MULTI_USER 
GO
ALTER DATABASE [cosmetic-store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cosmetic-store] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cosmetic-store] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cosmetic-store] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cosmetic-store] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cosmetic-store] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cosmetic-store] SET QUERY_STORE = ON
GO
ALTER DATABASE [cosmetic-store] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cosmetic-store]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[StaffID] [int] NULL,
	[PermissionID] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillID] [int] NOT NULL,
	[VarietyID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[VarietyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[NumberOfItems] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractNo] [int] NOT NULL,
	[StartingDate] [datetime] NULL,
	[EndingDate] [datetime] NULL,
	[StaffID] [int] NULL,
	[PositionID] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ContractNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Function]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Function](
	[FunctionID] [int] NOT NULL,
	[FunctionName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Function] PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportBill]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportBill](
	[ImportBillID] [int] NOT NULL,
	[Date] [datetime] NULL,
	[TotalValue] [int] NULL,
	[ProducerID] [int] NULL,
	[StaffID] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_ImportBill] PRIMARY KEY CLUSTERED 
(
	[ImportBillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetails]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetails](
	[ImportBillID] [int] NOT NULL,
	[VarietyID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_ImportDetails] PRIMARY KEY CLUSTERED 
(
	[ImportBillID] ASC,
	[VarietyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeaveRequest]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaveRequest](
	[RequestID] [int] NOT NULL,
	[ApproveStatus] [int] NULL,
	[RequestContent] [nvarchar](50) NULL,
	[LeavingDays] [int] NULL,
	[LeavingType] [int] NULL,
	[StaffID] [int] NULL,
 CONSTRAINT [PK_LeaveRequest] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonthlySalary]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlySalary](
	[StaffID] [int] NOT NULL,
	[Month] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[PositionID] [int] NULL,
	[TotalLeavingDays] [int] NULL,
	[ActualReceiving] [int] NULL,
 CONSTRAINT [PK_MonthlySalary] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[Month] ASC,
	[Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionID] [int] NOT NULL,
	[PermissionName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionGranting]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionGranting](
	[PermissionID] [int] NOT NULL,
	[FunctionID] [int] NOT NULL,
 CONSTRAINT [PK_PermissionGranting] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC,
	[FunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionID] [int] NOT NULL,
	[PositionName] [nvarchar](50) NULL,
	[Salary] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[ProducerID] [int] NOT NULL,
	[ProducerName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED 
(
	[ProducerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[CategoryID] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductVariety]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductVariety](
	[VarietyID] [int] NOT NULL,
	[Volume] [int] NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
	[ProductID] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_ProductVariety] PRIMARY KEY CLUSTERED 
(
	[VarietyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleBill]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleBill](
	[BillID] [int] NOT NULL,
	[Date] [datetime] NULL,
	[TotalValue] [int] NULL,
	[StaffID] [int] NULL,
	[isDeleted] [bit] NULL,
 CONSTRAINT [PK_SaleBill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 28/03/2024 12:00:42 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[DoB] [datetime] NULL,
	[Address] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([PermissionID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Permission]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Staff]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_ProductVariety] FOREIGN KEY([VarietyID])
REFERENCES [dbo].[ProductVariety] ([VarietyID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_ProductVariety]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_SaleBill] FOREIGN KEY([BillID])
REFERENCES [dbo].[SaleBill] ([BillID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_SaleBill]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([PositionID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Position]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Staff]
GO
ALTER TABLE [dbo].[ImportBill]  WITH CHECK ADD  CONSTRAINT [FK_ImportBill_Producer] FOREIGN KEY([ProducerID])
REFERENCES [dbo].[Producer] ([ProducerID])
GO
ALTER TABLE [dbo].[ImportBill] CHECK CONSTRAINT [FK_ImportBill_Producer]
GO
ALTER TABLE [dbo].[ImportBill]  WITH CHECK ADD  CONSTRAINT [FK_ImportBill_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[ImportBill] CHECK CONSTRAINT [FK_ImportBill_Staff]
GO
ALTER TABLE [dbo].[ImportDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetails_ImportBill] FOREIGN KEY([ImportBillID])
REFERENCES [dbo].[ImportBill] ([ImportBillID])
GO
ALTER TABLE [dbo].[ImportDetails] CHECK CONSTRAINT [FK_ImportDetails_ImportBill]
GO
ALTER TABLE [dbo].[ImportDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetails_ProductVariety] FOREIGN KEY([VarietyID])
REFERENCES [dbo].[ProductVariety] ([VarietyID])
GO
ALTER TABLE [dbo].[ImportDetails] CHECK CONSTRAINT [FK_ImportDetails_ProductVariety]
GO
ALTER TABLE [dbo].[LeaveRequest]  WITH CHECK ADD  CONSTRAINT [FK_LeaveRequest_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[LeaveRequest] CHECK CONSTRAINT [FK_LeaveRequest_Staff]
GO
ALTER TABLE [dbo].[MonthlySalary]  WITH CHECK ADD  CONSTRAINT [FK_MonthlySalary_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([PositionID])
GO
ALTER TABLE [dbo].[MonthlySalary] CHECK CONSTRAINT [FK_MonthlySalary_Position]
GO
ALTER TABLE [dbo].[MonthlySalary]  WITH CHECK ADD  CONSTRAINT [FK_MonthlySalary_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[MonthlySalary] CHECK CONSTRAINT [FK_MonthlySalary_Staff]
GO
ALTER TABLE [dbo].[PermissionGranting]  WITH CHECK ADD  CONSTRAINT [FK_PermissionGranting_Function] FOREIGN KEY([FunctionID])
REFERENCES [dbo].[Function] ([FunctionID])
GO
ALTER TABLE [dbo].[PermissionGranting] CHECK CONSTRAINT [FK_PermissionGranting_Function]
GO
ALTER TABLE [dbo].[PermissionGranting]  WITH CHECK ADD  CONSTRAINT [FK_PermissionGranting_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([PermissionID])
GO
ALTER TABLE [dbo].[PermissionGranting] CHECK CONSTRAINT [FK_PermissionGranting_Permission]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[ProductVariety]  WITH CHECK ADD  CONSTRAINT [FK_ProductVariety_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ProductVariety] CHECK CONSTRAINT [FK_ProductVariety_Product]
GO
ALTER TABLE [dbo].[SaleBill]  WITH CHECK ADD  CONSTRAINT [FK_SaleBill_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[SaleBill] CHECK CONSTRAINT [FK_SaleBill_Staff]
GO
USE [master]
GO
ALTER DATABASE [cosmetic-store] SET  READ_WRITE 
GO
