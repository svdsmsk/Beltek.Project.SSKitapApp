USE [master]
GO
/****** Object:  Database [SSKitapDB]    Script Date: 30.12.2021 00:05:20 ******/
CREATE DATABASE [SSKitapDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SSKitapDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SSKitapDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SSKitapDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SSKitapDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SSKitapDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SSKitapDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SSKitapDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SSKitapDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SSKitapDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SSKitapDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SSKitapDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SSKitapDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SSKitapDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SSKitapDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SSKitapDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SSKitapDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SSKitapDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SSKitapDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SSKitapDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SSKitapDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SSKitapDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SSKitapDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SSKitapDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SSKitapDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SSKitapDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SSKitapDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SSKitapDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SSKitapDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SSKitapDB] SET  MULTI_USER 
GO
ALTER DATABASE [SSKitapDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SSKitapDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SSKitapDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SSKitapDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SSKitapDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SSKitapDB', N'ON'
GO
USE [SSKitapDB]
GO
/****** Object:  Table [dbo].[tblBooks]    Script Date: 30.12.2021 00:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Writer] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Printing] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_tblBooks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBooktypes]    Script Date: 30.12.2021 00:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooktypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblBooktypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStationary]    Script Date: 30.12.2021 00:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStationary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Product] [varchar](50) NOT NULL,
	[ProductPrice] [int] NOT NULL,
 CONSTRAINT [PK_tblStationary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWriters]    Script Date: 30.12.2021 00:05:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWriters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WriterName] [varchar](50) NOT NULL,
	[WriterSurname] [varchar](50) NOT NULL,
	[DateTime] [date] NOT NULL,
 CONSTRAINT [PK_tblWriters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblBooks] ON 

INSERT [dbo].[tblBooks] ([Id], [Type], [Writer], [Name], [Printing], [Price]) VALUES (2, N'Polisiye', N'Sir Arthur Conan Doyle', N'Sherlock Holmes', N'2020', 16)
INSERT [dbo].[tblBooks] ([Id], [Type], [Writer], [Name], [Printing], [Price]) VALUES (3, N'Aşk', N'Jojo Moyes', N'Senden Önce Ben', N'2012', 25)
INSERT [dbo].[tblBooks] ([Id], [Type], [Writer], [Name], [Printing], [Price]) VALUES (4, N'Bilim Kurgu', N'Adam Fawer', N'Olasılıksız', N'2005', 35)
INSERT [dbo].[tblBooks] ([Id], [Type], [Writer], [Name], [Printing], [Price]) VALUES (5, N'Kurgu', N'Stefan Zweig', N'Satranç', N'1943', 25)
SET IDENTITY_INSERT [dbo].[tblBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[tblBooktypes] ON 

INSERT [dbo].[tblBooktypes] ([Id], [BookType]) VALUES (1, N'Korku ve Gerilim')
INSERT [dbo].[tblBooktypes] ([Id], [BookType]) VALUES (2, N'Aşk')
INSERT [dbo].[tblBooktypes] ([Id], [BookType]) VALUES (3, N'Bilim Kurgu')
SET IDENTITY_INSERT [dbo].[tblBooktypes] OFF
GO
SET IDENTITY_INSERT [dbo].[tblStationary] ON 

INSERT [dbo].[tblStationary] ([Id], [Product], [ProductPrice]) VALUES (1, N'Faber Castel Kalem', 40)
INSERT [dbo].[tblStationary] ([Id], [Product], [ProductPrice]) VALUES (2, N'Faber Castel Defter', 55)
INSERT [dbo].[tblStationary] ([Id], [Product], [ProductPrice]) VALUES (3, N'Adel Kalem', 45)
SET IDENTITY_INSERT [dbo].[tblStationary] OFF
GO
SET IDENTITY_INSERT [dbo].[tblWriters] ON 

INSERT [dbo].[tblWriters] ([Id], [WriterName], [WriterSurname], [DateTime]) VALUES (1, N'Ahmet', N'Ümit', CAST(N'1960-09-30' AS Date))
INSERT [dbo].[tblWriters] ([Id], [WriterName], [WriterSurname], [DateTime]) VALUES (2, N'Adam', N'Fawer', CAST(N'1970-01-30' AS Date))
SET IDENTITY_INSERT [dbo].[tblWriters] OFF
GO
USE [master]
GO
ALTER DATABASE [SSKitapDB] SET  READ_WRITE 
GO
