USE [master]
GO
/****** Object:  Database [EntityFrameworkSpecific]    Script Date: 9/22/2020 5:44:09 AM ******/
CREATE DATABASE [EntityFrameworkSpecific]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityFrameworkSpecific', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityFrameworkSpecific.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EntityFrameworkSpecific_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityFrameworkSpecific_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EntityFrameworkSpecific] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntityFrameworkSpecific].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET  MULTI_USER 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntityFrameworkSpecific] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EntityFrameworkSpecific] SET QUERY_STORE = OFF
GO
USE [EntityFrameworkSpecific]
GO
/****** Object:  Table [dbo].[Email]    Script Date: 9/22/2020 5:44:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Email](
	[EmailIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[EmailType] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[PersonId] [int] NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[EmailIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 9/22/2020 5:44:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phone]    Script Date: 9/22/2020 5:44:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phone](
	[PhoneNumberId] [int] IDENTITY(1,1) NOT NULL,
	[PhoneType] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PersonId] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[PhoneNumberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Email] ON 

INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (1, N'Home', N'jonesmary@gmail.com', 1)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (2, N'Work', N'maryjones@abc.com', 1)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (3, N'Home', N'smithy@comcast.com', 2)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (4, N'Work', N'ysmith@yahoo.com', 2)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (5, N'Home', N'lebowvin@gmail.com', 3)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (6, N'Home', N'whiteb@comcast.net', 4)
INSERT [dbo].[Email] ([EmailIdentifier], [EmailType], [EmailAddress], [PersonId]) VALUES (7, N'Work', N'whitebill@der.com', 4)
SET IDENTITY_INSERT [dbo].[Email] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName]) VALUES (1, N'Mary', N'Jones')
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName]) VALUES (2, N'Yelena', N'Smith')
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName]) VALUES (3, N'Vincent', N'Lebow')
INSERT [dbo].[Person] ([PersonId], [FirstName], [LastName]) VALUES (4, N'Bill', N'White')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Phone] ON 

INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (1, N'Office', N'555-999-1234', 2)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (2, N'Home', N'333-444-3456', 2)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (3, N'Office', N'999-222-7779', 1)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (4, N'Moblie', N'888-666-3867', 2)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (5, N'Moble', N'888-111-2222', 1)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (6, N'Home', N'123-123-1234', 3)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (7, N'Cell', N'777-098-5432', 3)
INSERT [dbo].[Phone] ([PhoneNumberId], [PhoneType], [PhoneNumber], [PersonId]) VALUES (8, N'Office', N'555-555-8888', 4)
SET IDENTITY_INSERT [dbo].[Phone] OFF
ALTER TABLE [dbo].[Email]  WITH CHECK ADD  CONSTRAINT [FK_Email_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[Email] CHECK CONSTRAINT [FK_Email_Person]
GO
ALTER TABLE [dbo].[Phone]  WITH CHECK ADD  CONSTRAINT [FK_Phone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[Phone] CHECK CONSTRAINT [FK_Phone_Person]
GO
USE [master]
GO
ALTER DATABASE [EntityFrameworkSpecific] SET  READ_WRITE 
GO
