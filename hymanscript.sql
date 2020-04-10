USE [master]
GO
/****** Object:  Database [HymanComm_NotebookApp]    Script Date: 4/10/2020 11:50:28 AM ******/
CREATE DATABASE [HymanComm_NotebookApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HymanComm_NotebookApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\HymanComm_NotebookApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HymanComm_NotebookApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\HymanComm_NotebookApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HymanComm_NotebookApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HymanComm_NotebookApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET  MULTI_USER 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HymanComm_NotebookApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HymanComm_NotebookApp] SET QUERY_STORE = OFF
GO
USE [HymanComm_NotebookApp]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4/10/2020 11:50:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[Shortname_Position] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 4/10/2020 11:50:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NULL,
	[Lastname] [nvarchar](50) NULL,
	[Username] [nvarchar](200) NULL,
	[Password] [nvarchar](200) NOT NULL,
	[isActive] [bit] NULL,
	[Start_date] [date] NULL,
	[Promotion_date] [date] NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 4/10/2020 11:50:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Roles_Id] [int] NULL,
	[Users_Id] [int] NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([Roles_Id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_UserLogins] FOREIGN KEY([Users_Id])
REFERENCES [dbo].[UserLogins] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_UserLogins]
GO
USE [master]
GO
ALTER DATABASE [HymanComm_NotebookApp] SET  READ_WRITE 
GO
