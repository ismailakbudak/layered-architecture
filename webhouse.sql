USE [master]
GO
/****** Object:  Database [WEBHOUSE]    Script Date: 2.12.2013 21:51:34 ******/
CREATE DATABASE [WEBHOUSE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WEBHOUSE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.ISO\MSSQL\DATA\WEBHOUSE.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WEBHOUSE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.ISO\MSSQL\DATA\WEBHOUSE_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WEBHOUSE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WEBHOUSE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WEBHOUSE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WEBHOUSE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WEBHOUSE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WEBHOUSE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WEBHOUSE] SET ARITHABORT OFF 
GO
ALTER DATABASE [WEBHOUSE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WEBHOUSE] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [WEBHOUSE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WEBHOUSE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WEBHOUSE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WEBHOUSE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WEBHOUSE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WEBHOUSE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WEBHOUSE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WEBHOUSE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WEBHOUSE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WEBHOUSE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WEBHOUSE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WEBHOUSE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WEBHOUSE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WEBHOUSE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WEBHOUSE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WEBHOUSE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WEBHOUSE] SET RECOVERY FULL 
GO
ALTER DATABASE [WEBHOUSE] SET  MULTI_USER 
GO
ALTER DATABASE [WEBHOUSE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WEBHOUSE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WEBHOUSE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WEBHOUSE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WEBHOUSE', N'ON'
GO
USE [WEBHOUSE]
GO
/****** Object:  StoredProcedure [dbo].[sp_My]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL


CREATE PROCEDURE [dbo].[sp_My]
AS
BEGIN
	SELECT * FROM CATEGORY
END

GO
/****** Object:  StoredProcedure [dbo].[sp_My2]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL


CREATE PROCEDURE [dbo].[sp_My2]
( @ParamID INT=0 )
AS
BEGIN
	SELECT * FROM CATEGORY  WHERE ID = @ParamID
END

GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](30) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COMMENTS]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMENTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SiteID] [int] NULL,
	[SenderID] [int] NULL,
	[Comment] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[Date] [nvarchar](50) NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IMAGE]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMAGE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SiteID] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Path] [nvarchar](50) NULL,
 CONSTRAINT [PK_IMAGE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SITE]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SITE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[SubCategoryID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Url] [nvarchar](100) NULL,
	[InsertDate] [nvarchar](20) NULL,
	[Status] [int] NULL,
	[Active] [int] NULL,
	[Category] [varchar](50) NULL,
	[SubCategory] [nvarchar](50) NULL,
 CONSTRAINT [PK_site] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUB_CATEGORY]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUB_CATEGORY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[SubCategory] [nvarchar](50) NULL,
 CONSTRAINT [PK_SUB_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDepo]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepo](
	[islemNo] [int] NULL,
	[BarkodNo] [int] NULL,
	[Kategori] [nvarchar](50) NULL,
	[Altkategori] [nvarchar](50) NULL,
	[UrunIsmi] [nvarchar](50) NULL,
	[Miktari] [int] NULL,
	[Gelisfiyati] [int] NULL,
	[TedarikciID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USER_GROUPS]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER_GROUPS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USERS]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[City] [nvarchar](20) NULL,
	[Gender] [nvarchar](30) NULL,
	[Job] [nvarchar](100) NULL,
	[Gsm] [nvarchar](11) NULL,
	[Birthday] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[Block] [int] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VOTE]    Script Date: 2.12.2013 21:51:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOTE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SiteID] [int] NULL,
	[VoterID] [int] NULL,
	[Value] [int] NULL,
 CONSTRAINT [PK_VOTE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF_USERS_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF_USERS_Block]  DEFAULT ((0)) FOR [Block]
GO
ALTER TABLE [dbo].[COMMENTS]  WITH CHECK ADD  CONSTRAINT [FK_COMMENTS_SITE] FOREIGN KEY([SiteID])
REFERENCES [dbo].[SITE] ([ID])
GO
ALTER TABLE [dbo].[COMMENTS] CHECK CONSTRAINT [FK_COMMENTS_SITE]
GO
ALTER TABLE [dbo].[IMAGE]  WITH CHECK ADD  CONSTRAINT [FK_IMAGE_SITE] FOREIGN KEY([SiteID])
REFERENCES [dbo].[SITE] ([ID])
GO
ALTER TABLE [dbo].[IMAGE] CHECK CONSTRAINT [FK_IMAGE_SITE]
GO
ALTER TABLE [dbo].[SITE]  WITH CHECK ADD  CONSTRAINT [FK_SITE_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[SITE] CHECK CONSTRAINT [FK_SITE_USER]
GO
ALTER TABLE [dbo].[VOTE]  WITH CHECK ADD  CONSTRAINT [FK_VOTE_SITE] FOREIGN KEY([SiteID])
REFERENCES [dbo].[SITE] ([ID])
GO
ALTER TABLE [dbo].[VOTE] CHECK CONSTRAINT [FK_VOTE_SITE]
GO
USE [master]
GO
ALTER DATABASE [WEBHOUSE] SET  READ_WRITE 
GO
