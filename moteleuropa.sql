USE [master]
GO
/****** Object:  Database [Motel]    Script Date: 29.01.2023 02:14:11 ******/
CREATE DATABASE [Motel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Motel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Motel.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Motel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Motel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Motel] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Motel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Motel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Motel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Motel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Motel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Motel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Motel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Motel] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Motel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Motel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Motel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Motel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Motel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Motel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Motel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Motel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Motel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Motel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Motel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Motel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Motel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Motel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Motel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Motel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Motel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Motel] SET  MULTI_USER 
GO
ALTER DATABASE [Motel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Motel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Motel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Motel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Motel]
GO
/****** Object:  User [MtUser]    Script Date: 29.01.2023 02:14:11 ******/
CREATE USER [MtUser] FOR LOGIN [MtUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [MtUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [MtUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [MtUser]
GO
/****** Object:  Table [dbo].[AdminUsers]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUsers](
	[userName] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[Musteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[Cinsiyet] [nchar](10) NOT NULL,
	[Telefon] [nvarchar](20) NULL,
	[Mail] [nvarchar](50) NULL,
	[TC] [nvarchar](11) NULL,
	[OdaNo] [smallint] NULL,
	[Ucret] [decimal](18, 0) NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda21]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda21](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda22]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda22](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda23]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda23](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda24]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda24](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda25]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda25](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda26]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda26](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda27]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda27](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda28]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda28](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda29]    Script Date: 29.01.2023 02:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda29](
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Motel] SET  READ_WRITE 
GO
