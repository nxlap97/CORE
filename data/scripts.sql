USE [master]
GO
CREATE DATABASE [CORE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CORE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CORE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CORE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CORE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CORE] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CORE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CORE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CORE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CORE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CORE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CORE] SET ARITHABORT OFF 
GO
ALTER DATABASE [CORE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CORE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CORE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CORE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CORE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CORE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CORE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CORE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CORE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CORE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CORE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CORE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CORE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CORE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CORE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CORE] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [CORE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CORE] SET RECOVERY FULL 
GO
ALTER DATABASE [CORE] SET  MULTI_USER 
GO
ALTER DATABASE [CORE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CORE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CORE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CORE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CORE] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CORE', N'ON'
GO
ALTER DATABASE [CORE] SET QUERY_STORE = OFF
GO
USE [CORE]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BlogCategories](
	[Id] [nvarchar](128) NOT NULL,
	[BlogId] [nvarchar](max) NULL,
	[CategoryId] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Blogs](
	[Id] [varchar](128) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[ImageId] [nvarchar](max) NULL,
	[ViewCount] [int] NOT NULL,
	[Alias] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[ShowAtHome] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Categories](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[ParentId] [nvarchar](max) NULL,
	[Alias] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[IConCss] [nvarchar](max) NULL,
	[IsPageUrl] [bit] NOT NULL,
	[ShowAtHome] [bit] NOT NULL,
	[Url] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Customers](
	[Id] [nvarchar](128) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[HashPassword] [nvarchar](max) NULL,
	[Key] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Token] [nvarchar](128) NULL,
	[TExpired] [datetime2](7) NULL,
	[IPAddress] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MDocuments](
	[Id] [nvarchar](128) NOT NULL,
	[FileName] [nvarchar](max) NULL,
	[FileUrl] [nvarchar](max) NULL,
	[Size] [bigint] NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL,
	[Extension] [nvarchar](max) NULL,
	[FileNameDefault] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Pricings](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[ImageId] [nvarchar](max) NULL,
	[ViewCount] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Settings](
	[Id] [nvarchar](128) NOT NULL,
	[CODE] [nvarchar](250) NOT NULL,
	[HTMLContent] [nvarchar](max) NULL,
	[FileId] [nvarchar](max) NULL,
	[Show] [bit] NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](128) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Published] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201224164519_initDb', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201224165943_changeEntity', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201226160015_add-documents', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201226180923_add-users', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201226181259_update_change_fields', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201227041033_add-parentId-fields', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201229164126_add-pricing-table', N'5.0.1')
INSERT [__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230171220_add-table-settings', N'5.0.1')
GO
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'0917eb72-ff59-44b2-9d2e-1286e26fd63a', N'6454b7b5-9c2c-4cac-8125-fb9b70dd5a41', N'2', NULL, NULL, NULL, CAST(N'2020-12-27T11:00:08.4109356' AS DateTime2), NULL, NULL, 0)
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'61a6dc58-372c-495f-a81f-066117f79342', N'c309b5ad-3b04-40d8-9b5e-88157bb6a4b3', N'2', NULL, NULL, NULL, CAST(N'2020-12-27T03:48:13.8184302' AS DateTime2), NULL, NULL, 0)
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'8d2d6cc5-1279-4e40-a39a-56237d39e881', N'90955832-8a01-42f4-b1ee-e3b0112c562c', N'1', NULL, NULL, NULL, CAST(N'2020-12-27T08:09:00.5601073' AS DateTime2), NULL, NULL, 0)
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'dd2d7866-8b80-4761-86e8-87633b968284', N'4b1e2d0a-51f5-4d65-8a8e-63cfb2b73fc6', N'2', NULL, NULL, NULL, CAST(N'2020-12-27T08:02:26.1674270' AS DateTime2), NULL, NULL, 0)
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'e1ebc5ba-e98d-4549-9efb-daec72ddc230', N'37467d9d-8dd1-4b83-8127-41e23a80b7ea', N'2', NULL, NULL, NULL, CAST(N'2020-12-27T08:06:58.9572852' AS DateTime2), NULL, NULL, 0)
INSERT [BlogCategories] ([Id], [BlogId], [CategoryId], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'fd65c2b6-0c4e-4233-8200-778063ae99b2', N'397167ab-8a44-4952-9663-d6e311465184', N'3', NULL, NULL, NULL, CAST(N'2020-12-27T03:48:53.2271961' AS DateTime2), NULL, NULL, 0)
GO
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'37467d9d-8dd1-4b83-8127-41e23a80b7ea', N'bài viết 2', N'<p>dsdsd</p>
', N'dsdsdsd', NULL, NULL, NULL, CAST(N'2020-12-27T08:08:01.5760087' AS DateTime2), 0, NULL, CAST(N'2020-12-27T08:06:58.9320413' AS DateTime2), N'189e5f53-1485-4ea2-95ef-52371f27eab5', 0, NULL, 0, 0)
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'397167ab-8a44-4952-9663-d6e311465184', N'bài viết 12332', N'<p>fdfdfd</p>

<p>&nbsp;</p>

<p>f</p>

<p><span style="color:#2980b9">djfdiojfodkdf</span></p>

<p>&nbsp;</p>

<p><span style="font-size:11px"><span style="color:#2c3e50"><span style="background-color:#2ecc71">fd434433</span></span></span></p>
', N'mô tả ngắn 111434', NULL, NULL, NULL, NULL, 1, NULL, CAST(N'2020-12-27T03:48:52.9937631' AS DateTime2), N'0c9592f6-cc52-4742-8928-521e1425c7d2', 0, NULL, 0, 0)
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'4b1e2d0a-51f5-4d65-8a8e-63cfb2b73fc6', N'1', N'<p>111</p>
', N'1', NULL, CAST(N'2020-12-27T08:02:26.1483721' AS DateTime2), NULL, CAST(N'2020-12-27T08:02:34.4834640' AS DateTime2), 1, NULL, NULL, N'7aaef1ef-e787-401f-ac81-67aa31810cc4', 0, NULL, 0, 0)
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'6454b7b5-9c2c-4cac-8125-fb9b70dd5a41', N'1', N'<p>fdffd</p>
', N'mô tả ngắn', NULL, CAST(N'2020-12-27T11:00:08.3973967' AS DateTime2), NULL, CAST(N'2020-12-27T11:00:18.4057250' AS DateTime2), 1, NULL, NULL, N'a5c4206e-769c-49fe-816d-c7a0909f8292', 0, NULL, 0, 0)
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'90955832-8a01-42f4-b1ee-e3b0112c562c', N'dddf', N'<p>fdfd</p>
', N'fddf', NULL, CAST(N'2020-12-27T08:09:00.5462422' AS DateTime2), NULL, CAST(N'2020-12-27T08:09:04.3081713' AS DateTime2), 1, NULL, NULL, N'960ad280-cc02-4ea5-893b-615df90e1767', 0, NULL, 0, 0)
INSERT [Blogs] ([Id], [Name], [Description], [ShortDescription], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ImageId], [ViewCount], [Alias], [DisplayOrder], [ShowAtHome]) VALUES (N'c309b5ad-3b04-40d8-9b5e-88157bb6a4b3', N'bài viết 5', N'<p>dsds</p>
', N'', NULL, NULL, NULL, NULL, 0, NULL, CAST(N'2020-12-27T03:48:13.6983486' AS DateTime2), N'7931c630-2041-450a-bfb6-c51f4cf888f0', 0, NULL, 0, 0)
GO
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'1', N'danh muc 1', 1, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 0, NULL, 0, 0, NULL)
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'2', N'danh muc 2', 0, NULL, NULL, NULL, CAST(N'2020-12-29T22:13:14.1172601' AS DateTime2), 0, NULL, CAST(N'2020-12-29T21:48:39.4972946' AS DateTime2), NULL, NULL, 0, NULL, 0, 0, NULL)
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'3', N'danh muc 3', 1, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 0, NULL, 0, 0, NULL)
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'47427bc5-4395-4a0e-a4b9-44bc0d54df42', N'bài viết 4', 0, NULL, CAST(N'2020-12-29T21:52:06.0427033' AS DateTime2), NULL, NULL, 1, NULL, NULL, NULL, NULL, 0, NULL, 0, 0, NULL)
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'77bc4c9c-e621-4066-a7c5-d9ca04542ea9', N'dssds', 0, NULL, CAST(N'2020-12-29T22:47:12.9284655' AS DateTime2), NULL, NULL, 0, NULL, CAST(N'2020-12-29T22:47:18.2721219' AS DateTime2), NULL, NULL, 0, NULL, 0, 0, NULL)
INSERT [Categories] ([Id], [Name], [Type], [CreatedBy], [CreatedDate], [DeletedBy], [DeletedDate], [Published], [UpdatedBy], [UpdatedDate], [ParentId], [Alias], [DisplayOrder], [IConCss], [IsPageUrl], [ShowAtHome], [Url]) VALUES (N'9341a3e0-3c92-4124-9566-845c99fc8d95', N'bài viết t5', 0, NULL, NULL, NULL, NULL, 0, NULL, CAST(N'2020-12-29T22:45:07.3719839' AS DateTime2), NULL, NULL, 0, NULL, 0, 0, NULL)
GO
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'01dcc167-b1cf-4cc2-a850-ae8c7ad5fa08', N'01dcc167-b1cf-4cc2-a850-ae8c7ad5fa08.gif', N'/Upload/Images/01dcc167-b1cf-4cc2-a850-ae8c7ad5fa08.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:17:33.3797349' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'06ea983c-16ff-4cfd-8b0b-11c943e4d3d1', N'06ea983c-16ff-4cfd-8b0b-11c943e4d3d1.gif', N'/Upload/Images/06ea983c-16ff-4cfd-8b0b-11c943e4d3d1.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:06:08.0466021' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'0c9592f6-cc52-4742-8928-521e1425c7d2', N'0c9592f6-cc52-4742-8928-521e1425c7d2.gif', N'/Upload/Images/0c9592f6-cc52-4742-8928-521e1425c7d2.gif', 344982, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:40:12.6727027' AS DateTime2), NULL, NULL, 1, N'.gif', N'69881391_2400805160166036_2629794890359242752_n.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'15a3a872-e75d-464e-9f6b-6c3f9379d6a0', N'15a3a872-e75d-464e-9f6b-6c3f9379d6a0.gif', N'/Upload/Images/15a3a872-e75d-464e-9f6b-6c3f9379d6a0.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:04:54.5956675' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'189e5f53-1485-4ea2-95ef-52371f27eab5', N'189e5f53-1485-4ea2-95ef-52371f27eab5.jpg', N'/Upload/Images/189e5f53-1485-4ea2-95ef-52371f27eab5.jpg', 30794, 0, NULL, NULL, NULL, CAST(N'2020-12-27T08:06:46.4554317' AS DateTime2), NULL, NULL, 1, N'.jpg', N'sticker.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'26794622-b0ef-4c56-91cc-38502a93cd37', N'26794622-b0ef-4c56-91cc-38502a93cd37.gif', N'/Upload/Images/26794622-b0ef-4c56-91cc-38502a93cd37.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:26:51.9866143' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'2cd65edb-8955-4d28-b7d5-d2a192388b14', N'69881391_2400805160166036_2629794890359242752_n.gif', N'D:\Project\CORE\CORE.Website\wwwroot/Upload/Images/69881391_2400805160166036_2629794890359242752_n.gif', 344982, 0, NULL, NULL, NULL, CAST(N'2020-12-27T02:55:38.0673699' AS DateTime2), NULL, NULL, 1, N'.gif', N'69881391_2400805160166036_2629794890359242752_n.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'342d83d9-a82b-47a2-a0d3-913fe67d8b8f', N'342d83d9-a82b-47a2-a0d3-913fe67d8b8f.jpg', N'/Upload/Images/342d83d9-a82b-47a2-a0d3-913fe67d8b8f.jpg', 30794, 0, NULL, NULL, NULL, CAST(N'2020-12-29T23:56:18.6048831' AS DateTime2), NULL, NULL, 1, N'.jpg', N'sticker.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'4124480a-c950-43b1-bf2e-51f6e092a6bd', N'4124480a-c950-43b1-bf2e-51f6e092a6bd.gif', N'/Upload/Images/4124480a-c950-43b1-bf2e-51f6e092a6bd.gif', 344982, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:15:45.6144505' AS DateTime2), NULL, NULL, 1, N'.gif', N'69881391_2400805160166036_2629794890359242752_n.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'6a8f6e73-eac8-420d-9206-da06986a024d', N'6a8f6e73-eac8-420d-9206-da06986a024d.gif', N'/Upload/Images/6a8f6e73-eac8-420d-9206-da06986a024d.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:31:21.9741713' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'7931c630-2041-450a-bfb6-c51f4cf888f0', N'7931c630-2041-450a-bfb6-c51f4cf888f0.gif', N'/Upload/Images/7931c630-2041-450a-bfb6-c51f4cf888f0.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:47:34.1645019' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'7aaef1ef-e787-401f-ac81-67aa31810cc4', N'7aaef1ef-e787-401f-ac81-67aa31810cc4.jpg', N'/Upload/Images/7aaef1ef-e787-401f-ac81-67aa31810cc4.jpg', 17422, 0, NULL, NULL, NULL, CAST(N'2020-12-27T08:02:12.5187393' AS DateTime2), NULL, NULL, 1, N'.jpg', N'126946774_702017750724257_265936581052483126_n.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'8fa6d1f2-d5ea-4ebd-b13a-fbdbf4b3e570', N'8fa6d1f2-d5ea-4ebd-b13a-fbdbf4b3e570.gif', N'/Upload/Images/8fa6d1f2-d5ea-4ebd-b13a-fbdbf4b3e570.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:23:16.2123819' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'960ad280-cc02-4ea5-893b-615df90e1767', N'960ad280-cc02-4ea5-893b-615df90e1767.jpg', N'/Upload/Images/960ad280-cc02-4ea5-893b-615df90e1767.jpg', 96320, 0, NULL, NULL, NULL, CAST(N'2020-12-27T08:08:56.3827894' AS DateTime2), NULL, NULL, 1, N'.jpg', N'photo_2020-12-13_17-18-04.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'962e1f44-29dc-4ff8-b1b9-98e5032e7700', N'962e1f44-29dc-4ff8-b1b9-98e5032e7700.jpg', N'/Upload/Images/962e1f44-29dc-4ff8-b1b9-98e5032e7700.jpg', 196623, 0, NULL, NULL, NULL, CAST(N'2020-12-27T10:59:57.8763655' AS DateTime2), NULL, NULL, 1, N'.jpg', N'photo_2020-12-04_17-44-47.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'99a1e873-40ea-4a0f-8360-9021d67e2a64', N'99a1e873-40ea-4a0f-8360-9021d67e2a64.jpg', N'/Upload/Images/99a1e873-40ea-4a0f-8360-9021d67e2a64.jpg', 30794, 0, NULL, NULL, NULL, CAST(N'2020-12-29T23:48:59.3874255' AS DateTime2), NULL, NULL, 1, N'.jpg', N'sticker.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'a5c4206e-769c-49fe-816d-c7a0909f8292', N'a5c4206e-769c-49fe-816d-c7a0909f8292.jpg', N'/Upload/Images/a5c4206e-769c-49fe-816d-c7a0909f8292.jpg', 96320, 0, NULL, NULL, NULL, CAST(N'2020-12-27T11:00:01.7959028' AS DateTime2), NULL, NULL, 1, N'.jpg', N'photo_2020-12-13_17-18-04.jpg')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'b5c4fef2-64b5-4e1f-9f9f-e6213976b3c5', N'b5c4fef2-64b5-4e1f-9f9f-e6213976b3c5.gif', N'/Upload/Images/b5c4fef2-64b5-4e1f-9f9f-e6213976b3c5.gif', 344982, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:32:37.1494558' AS DateTime2), NULL, NULL, 1, N'.gif', N'69881391_2400805160166036_2629794890359242752_n.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'c1a8dd46-f78c-4bb8-bbaa-fc56ceb423a4', N'c1a8dd46-f78c-4bb8-bbaa-fc56ceb423a4.gif', N'/Upload/Images/c1a8dd46-f78c-4bb8-bbaa-fc56ceb423a4.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:27:56.3634030' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'c53f9e38-51e0-4303-abd2-f923e41eb865', N'c53f9e38-51e0-4303-abd2-f923e41eb865.gif', N'/Upload/Images/c53f9e38-51e0-4303-abd2-f923e41eb865.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:39:33.9873753' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'd381412e-6823-4ce0-9d11-c59585cee139', N'd381412e-6823-4ce0-9d11-c59585cee139.gif', N'/Upload/Images/d381412e-6823-4ce0-9d11-c59585cee139.gif', 788315, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:18:27.5478271' AS DateTime2), NULL, NULL, 1, N'.gif', N'ezgif-6-8ad22e548dc2.gif')
INSERT [MDocuments] ([Id], [FileName], [FileUrl], [Size], [Type], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published], [Extension], [FileNameDefault]) VALUES (N'fc10659f-e59b-4817-921d-42850c4b50fc', N'fc10659f-e59b-4817-921d-42850c4b50fc.gif', N'/Upload/Images/fc10659f-e59b-4817-921d-42850c4b50fc.gif', 344982, 0, NULL, NULL, NULL, CAST(N'2020-12-27T03:12:54.1626350' AS DateTime2), NULL, NULL, 1, N'.gif', N'69881391_2400805160166036_2629794890359242752_n.gif')
GO
INSERT [Pricings] ([Id], [Name], [ImageId], [ViewCount], [Description], [ShortDescription], [CreatedBy], [UpdatedBy], [DeletedBy], [CreatedDate], [UpdatedDate], [DeletedDate], [Published]) VALUES (N'42e8c8b6-cbac-4450-8cda-6639afa3f18a', N'bảng giá 1', N'342d83d9-a82b-47a2-a0d3-913fe67d8b8f', 0, N'<p>ds</p>
', N'dsds', NULL, NULL, NULL, CAST(N'2020-12-29T23:56:25.7158229' AS DateTime2), CAST(N'2020-12-30T00:01:15.1068756' AS DateTime2), CAST(N'2020-12-30T00:01:24.4625197' AS DateTime2), 0)
GO
USE [master]
GO
ALTER DATABASE [CORE] SET  READ_WRITE 
GO
