USE [master]
GO
/****** Object:  Database [ChatApp]    Script Date: 11/12/2022 5:59:29 PM ******/
CREATE DATABASE [ChatApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChatApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ChatApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChatApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ChatApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ChatApp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChatApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChatApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChatApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChatApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChatApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChatApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChatApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ChatApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChatApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChatApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChatApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChatApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChatApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChatApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChatApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChatApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChatApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChatApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChatApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChatApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChatApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChatApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChatApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChatApp] SET RECOVERY FULL 
GO
ALTER DATABASE [ChatApp] SET  MULTI_USER 
GO
ALTER DATABASE [ChatApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChatApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChatApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChatApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChatApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChatApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ChatApp', N'ON'
GO
ALTER DATABASE [ChatApp] SET QUERY_STORE = OFF
GO
USE [ChatApp]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 11/12/2022 5:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[pass] [nvarchar](50) NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinnhan]    Script Date: 11/12/2022 5:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinnhan](
	[ma_tinnhan] [int] IDENTITY(1,1) NOT NULL,
	[nguoigui] [int] NULL,
	[nguoinhan] [int] NULL,
	[noidung] [nvarchar](max) NULL,
	[ngaygiogui] [nvarchar](50) NULL,
 CONSTRAINT [PK_tinnhan] PRIMARY KEY CLUSTERED 
(
	[ma_tinnhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[taikhoan] ON 

INSERT [dbo].[taikhoan] ([userid], [username], [pass], [trangthai]) VALUES (1, N'abc', N'123456', N'offline')
INSERT [dbo].[taikhoan] ([userid], [username], [pass], [trangthai]) VALUES (2, N'def', N'123456', N'offline')
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tinnhan] ON 

INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (1, 2, 1, N'lo abc', N'11/10/2022 4:44:00 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (2, 1, 2, N'lo def :)', N'11/10/2022 4:44:44 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (3, 1, 2, N'abc day', N'11/10/2022 5:01:20 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (4, 2, 1, N'def day', N'11/11/2022 9:02:03 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (5, 1, 2, N'hnay la ngay may', N'11/11/2022 9:04:42 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (6, 1, 2, N'def', N'11/11/2022 9:12:35 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (7, 2, 1, N'abc', N'11/11/2022 9:13:09 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (8, 2, 1, N'mot', N'11/11/2022 9:13:53 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (9, 1, 2, N'hai', N'11/11/2022 9:14:11 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (10, 2, 1, N'ba', N'11/11/2022 9:24:37 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (11, 1, 2, N'bon', N'11/11/2022 9:24:45 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (12, 1, 2, N'alo def', N'11/12/2022 5:35:11 PM')
INSERT [dbo].[tinnhan] ([ma_tinnhan], [nguoigui], [nguoinhan], [noidung], [ngaygiogui]) VALUES (13, 2, 1, N'ola abc', N'11/12/2022 5:35:23 PM')
SET IDENTITY_INSERT [dbo].[tinnhan] OFF
GO
ALTER TABLE [dbo].[tinnhan]  WITH CHECK ADD  CONSTRAINT [fk_tinnhansender] FOREIGN KEY([nguoigui])
REFERENCES [dbo].[taikhoan] ([userid])
GO
ALTER TABLE [dbo].[tinnhan] CHECK CONSTRAINT [fk_tinnhansender]
GO
USE [master]
GO
ALTER DATABASE [ChatApp] SET  READ_WRITE 
GO
