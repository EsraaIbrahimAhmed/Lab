USE [master]
GO
/****** Object:  Database [Lab]    Script Date: 01/02/2018 04:34:13 م ******/
CREATE DATABASE [Lab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SARA\MSSQL\DATA\Lab.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Lab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SARA\MSSQL\DATA\Lab_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Lab] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lab] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lab] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lab] SET  MULTI_USER 
GO
ALTER DATABASE [Lab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lab] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Lab] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Lab]
GO
/****** Object:  Table [dbo].[analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[analysis](
	[analysis_id] [int] IDENTITY(1,1) NOT NULL,
	[name_en] [nvarchar](100) NOT NULL,
	[analysis_price] [varchar](50) NOT NULL,
	[how_to_analysis] [nvarchar](200) NULL,
	[analysis_time] [nvarchar](100) NOT NULL,
	[result] [nvarchar](100) NOT NULL,
	[notes] [nvarchar](100) NULL,
 CONSTRAINT [PK_analysis] PRIMARY KEY CLUSTERED 
(
	[analysis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contractor]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contractor](
	[contractor_id] [int] IDENTITY(1,1) NOT NULL,
	[contractor_name] [nvarchar](100) NOT NULL,
	[con_specialization] [nvarchar](100) NOT NULL,
	[contractor_address] [nvarchar](100) NOT NULL,
	[contractor_phone] [varchar](50) NOT NULL,
	[contractor_email] [nvarchar](50) NOT NULL,
	[con_discount] [varchar](50) NOT NULL,
	[sign] [int] NOT NULL,
 CONSTRAINT [PK_contractor] PRIMARY KEY CLUSTERED 
(
	[contractor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[group_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[group_analysis](
	[group_id] [int] NOT NULL,
	[analysis_id] [int] NOT NULL,
 CONSTRAINT [PK_group_analysis] PRIMARY KEY CLUSTERED 
(
	[group_id] ASC,
	[analysis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[groups]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[group_id] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [nvarchar](100) NOT NULL,
	[analysis_num] [int] NOT NULL,
 CONSTRAINT [PK_group] PRIMARY KEY CLUSTERED 
(
	[group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[normals]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[normals](
	[normal_id] [int] IDENTITY(1,1) NOT NULL,
	[analysis_id] [int] NOT NULL,
	[age_from] [int] NOT NULL,
	[unit_from] [nvarchar](50) NOT NULL,
	[age_to] [int] NOT NULL,
	[unit_to] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[normal] [nvarchar](50) NOT NULL,
	[normal_unit] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_normals] PRIMARY KEY CLUSTERED 
(
	[normal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patient](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_name] [nvarchar](100) NOT NULL,
	[patient_age] [int] NOT NULL,
	[unit] [nvarchar](50) NOT NULL,
	[patient_gender] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[patient_email] [varchar](50) NOT NULL,
	[patient_status] [nvarchar](100) NULL,
	[con_id] [int] NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[reservation_date] [date] NOT NULL,
	[patient_id] [int] NOT NULL,
	[doctor_name] [nvarchar](100) NOT NULL,
	[price] [float] NOT NULL,
	[discount] [float] NOT NULL,
	[total] [float] NOT NULL,
	[paid] [float] NOT NULL,
	[rest] [float] NOT NULL,
 CONSTRAINT [PK_reservation] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reservation_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation_analysis](
	[reservation_id] [int] NOT NULL,
	[analysis_id] [int] NOT NULL,
 CONSTRAINT [PK_reservation_analysis] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC,
	[analysis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[result]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[result](
	[result_id] [int] IDENTITY(1,1) NOT NULL,
	[reservation_id] [int] NOT NULL,
	[analysis_id] [int] NOT NULL,
	[result] [nvarchar](100) NOT NULL,
	[normal] [nvarchar](100) NOT NULL,
	[comment] [nvarchar](100) NULL,
	[other] [nvarchar](100) NULL,
 CONSTRAINT [PK_result_1] PRIMARY KEY CLUSTERED 
(
	[result_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[signature]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[signature](
	[sign] [int] IDENTITY(1,1) NOT NULL,
	[describtion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_signature] PRIMARY KEY CLUSTERED 
(
	[sign] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[srored_items]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[srored_items](
	[stored_item_id] [int] IDENTITY(1,1) NOT NULL,
	[sroted_item_name] [nvarchar](100) NOT NULL,
	[unit] [nvarchar](100) NOT NULL,
	[stored_item_price] [float] NOT NULL,
	[sup_id] [int] NOT NULL,
	[demand_limit] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_srored_items] PRIMARY KEY CLUSTERED 
(
	[stored_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[supplier]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[sup_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_name] [nvarchar](100) NOT NULL,
	[sup_specialization] [nvarchar](100) NOT NULL,
	[sup_address] [nvarchar](100) NOT NULL,
	[sup_phone] [varchar](50) NOT NULL,
	[sup_email] [nvarchar](100) NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](100) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[id_number] [int] NOT NULL,
	[user_job] [nvarchar](50) NOT NULL,
	[user_address] [nvarchar](100) NULL,
	[user_phone] [int] NULL,
	[date_of_birth] [date] NULL,
	[user_email] [nvarchar](50) NULL,
	[job] [nvarchar](50) NULL,
	[worker_wages] [int] NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[analysis] ON 

INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (19, N'sasa', N'67', N'adgy', N'dhsad', N'ddasd', N'asdas')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (20, N'ddddd', N'24', N'sdfsdf', N'fdsfsd', N'dsfsDF', N'FSDAF')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (21, N'CBC', N'33', N'XDASFa', N'safsaf', N'DFf', N'dfdFDf')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (22, N'hemo', N'44', N'fasdfEF', N'Ddd', N'sdfdsf', N'sdsw')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (23, N'ggg', N'888', N'fadfwer', N'drer', N'rerq', N'rwrqr')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (24, N'eee', N'5555', N'sdfsa', N'dfFWE', N'GRIOE', N'FEWAEFW')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (25, N'dada', N'34', N'zfwadf', N'sdfsadf', N'sdfas', N'dafsasdg')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (26, N'a', N'', N'', N'', N'', N'')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (27, N'eeeeeeeeeeeee', N'', N'', N'', N'', N'')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (28, N'eeeeeeeeeeeee', N'77', N'asweawa', N'asfwe', N'dszfsadf', N'dfsdadfa')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (29, N'eeeeeeeeeeeee', N'77', N'asweawa', N'asfwe', N'dszfsadf', N'dfsdadfa')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (30, N'hjhj', N'77', N'ohghjjhkuuh', N'knklm', N'jnbjknkj', N'lkjlkok')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (31, N'sasasasasa', N'888888888888', N'sdfsafs', N'dfsadf', N'fgerwg', N'fwaefew')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (32, N'ewewew', N'9988', N'khkjjlkjok', N'uhkjhkj', N'uuhkjhkjh', N'yuughuihiu')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (33, N'im1', N'55', N'sfsf', N'dasd', N'sadgsda', N'dsgsa')
INSERT [dbo].[analysis] ([analysis_id], [name_en], [analysis_price], [how_to_analysis], [analysis_time], [result], [notes]) VALUES (34, N'im2', N'56', N'kjAK', N'OIOP', N'LIOI', N'OO')
SET IDENTITY_INSERT [dbo].[analysis] OFF
SET IDENTITY_INSERT [dbo].[contractor] ON 

INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (1, N'شركة النيل', N'صناعية', N'الأقصر', N'345678', N'rtfghjk', N'50', 3)
INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (2, N'لابغعاخه', N'بغعلهعا', N'يغفبغفعغ', N'4576587', N'غلغعلتال', N'66', 3)
INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (3, N'hh', N'kk', N'hh', N'hh', N'ii', N'10', 3)
INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (5, N'أحمد سيد', N'جراحة', N'أرمنت', N'5467989789', N'hjhkjh', N'0', 1)
INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (6, N'تاسيصضث', N'يبصشث', N'اتنمكط', N'6789', N'غعهتنمكط', N'0', 3)
INSERT [dbo].[contractor] ([contractor_id], [contractor_name], [con_specialization], [contractor_address], [contractor_phone], [contractor_email], [con_discount], [sign]) VALUES (8, N'البرج', N'9', N'يبلاتنم', N'657890', N'ببلاتنمك', N'10', 2)
SET IDENTITY_INSERT [dbo].[contractor] OFF
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (7, 26)
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (7, 27)
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (8, 27)
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (9, 24)
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (9, 33)
INSERT [dbo].[group_analysis] ([group_id], [analysis_id]) VALUES (9, 34)
SET IDENTITY_INSERT [dbo].[groups] ON 

INSERT [dbo].[groups] ([group_id], [group_name], [analysis_num]) VALUES (7, N'liver', 7)
INSERT [dbo].[groups] ([group_id], [group_name], [analysis_num]) VALUES (8, N'kidney', 7)
INSERT [dbo].[groups] ([group_id], [group_name], [analysis_num]) VALUES (9, N'immunology', 7)
SET IDENTITY_INSERT [dbo].[groups] OFF
SET IDENTITY_INSERT [dbo].[normals] ON 

INSERT [dbo].[normals] ([normal_id], [analysis_id], [age_from], [unit_from], [age_to], [unit_to], [gender], [normal], [normal_unit]) VALUES (1, 19, 3, N'year', 6, N'year', N'male', N'33', N'ml')
INSERT [dbo].[normals] ([normal_id], [analysis_id], [age_from], [unit_from], [age_to], [unit_to], [gender], [normal], [normal_unit]) VALUES (3, 21, 3, N'year', 6, N'year', N'male', N'55', N'ml')
SET IDENTITY_INSERT [dbo].[normals] OFF
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([patient_id], [patient_name], [patient_age], [unit], [patient_gender], [address], [phone], [patient_email], [patient_status], [con_id]) VALUES (1, N'سارة سيد السعدي', 27, N'year', N'famale', N'الأقصر', N'01126847700', N'sdjuhdsufhu', N'', 1)
INSERT [dbo].[patient] ([patient_id], [patient_name], [patient_age], [unit], [patient_gender], [address], [phone], [patient_email], [patient_status], [con_id]) VALUES (2, N'أحمد محمد ', 40, N'year', N'male', N'أرمنت', N'53456678998', N'gchggkok', N'', 2)
INSERT [dbo].[patient] ([patient_id], [patient_name], [patient_age], [unit], [patient_gender], [address], [phone], [patient_email], [patient_status], [con_id]) VALUES (3, N'إسراء إبراهيم', 25, N'year', N'famale', N'البياضية', N'242342134', N'dsfgewg', N'', 3)
SET IDENTITY_INSERT [dbo].[patient] OFF
SET IDENTITY_INSERT [dbo].[reservation] ON 

INSERT [dbo].[reservation] ([reservation_id], [reservation_date], [patient_id], [doctor_name], [price], [discount], [total], [paid], [rest]) VALUES (1, CAST(N'2017-12-14' AS Date), 1, N'', 125, 50, 62.5, 62, 0.5)
INSERT [dbo].[reservation] ([reservation_id], [reservation_date], [patient_id], [doctor_name], [price], [discount], [total], [paid], [rest]) VALUES (2, CAST(N'2017-12-16' AS Date), 2, N'أحمد سيد', 50, 66, 17, 15, 2)
INSERT [dbo].[reservation] ([reservation_id], [reservation_date], [patient_id], [doctor_name], [price], [discount], [total], [paid], [rest]) VALUES (3, CAST(N'2017-12-17' AS Date), 1, N'', 20, 50, 10, 10, 0)
INSERT [dbo].[reservation] ([reservation_id], [reservation_date], [patient_id], [doctor_name], [price], [discount], [total], [paid], [rest]) VALUES (4, CAST(N'2017-12-17' AS Date), 1, N'', 55, 50, 27.5, 27, 0.5)
SET IDENTITY_INSERT [dbo].[reservation] OFF
SET IDENTITY_INSERT [dbo].[signature] ON 

INSERT [dbo].[signature] ([sign], [describtion]) VALUES (1, N'DOCTOR')
INSERT [dbo].[signature] ([sign], [describtion]) VALUES (2, N'EX_LAB')
INSERT [dbo].[signature] ([sign], [describtion]) VALUES (3, N'CONTRACTOR')
SET IDENTITY_INSERT [dbo].[signature] OFF
SET IDENTITY_INSERT [dbo].[supplier] ON 

INSERT [dbo].[supplier] ([sup_id], [sup_name], [sup_specialization], [sup_address], [sup_phone], [sup_email]) VALUES (2, N'ندى إبراهيم', N'يبلتمط', N'سيغ', N'34567890', N'ثقفغعهخحج')
SET IDENTITY_INSERT [dbo].[supplier] OFF
ALTER TABLE [dbo].[contractor]  WITH CHECK ADD  CONSTRAINT [FK_contractor_signature] FOREIGN KEY([sign])
REFERENCES [dbo].[signature] ([sign])
GO
ALTER TABLE [dbo].[contractor] CHECK CONSTRAINT [FK_contractor_signature]
GO
ALTER TABLE [dbo].[group_analysis]  WITH CHECK ADD  CONSTRAINT [FK_group_analysis_analysis] FOREIGN KEY([analysis_id])
REFERENCES [dbo].[analysis] ([analysis_id])
GO
ALTER TABLE [dbo].[group_analysis] CHECK CONSTRAINT [FK_group_analysis_analysis]
GO
ALTER TABLE [dbo].[group_analysis]  WITH CHECK ADD  CONSTRAINT [FK_group_analysis_groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[groups] ([group_id])
GO
ALTER TABLE [dbo].[group_analysis] CHECK CONSTRAINT [FK_group_analysis_groups]
GO
ALTER TABLE [dbo].[normals]  WITH CHECK ADD  CONSTRAINT [FK_normals_analysis] FOREIGN KEY([analysis_id])
REFERENCES [dbo].[analysis] ([analysis_id])
GO
ALTER TABLE [dbo].[normals] CHECK CONSTRAINT [FK_normals_analysis]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK_patient_contractor] FOREIGN KEY([con_id])
REFERENCES [dbo].[contractor] ([contractor_id])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK_patient_contractor]
GO
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_patient] FOREIGN KEY([patient_id])
REFERENCES [dbo].[patient] ([patient_id])
GO
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_patient]
GO
ALTER TABLE [dbo].[reservation_analysis]  WITH CHECK ADD  CONSTRAINT [FK_reservation_analysis_analysis] FOREIGN KEY([analysis_id])
REFERENCES [dbo].[analysis] ([analysis_id])
GO
ALTER TABLE [dbo].[reservation_analysis] CHECK CONSTRAINT [FK_reservation_analysis_analysis]
GO
ALTER TABLE [dbo].[reservation_analysis]  WITH CHECK ADD  CONSTRAINT [FK_reservation_analysis_reservation] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[reservation] ([reservation_id])
GO
ALTER TABLE [dbo].[reservation_analysis] CHECK CONSTRAINT [FK_reservation_analysis_reservation]
GO
ALTER TABLE [dbo].[result]  WITH CHECK ADD  CONSTRAINT [FK_result_analysis] FOREIGN KEY([analysis_id])
REFERENCES [dbo].[analysis] ([analysis_id])
GO
ALTER TABLE [dbo].[result] CHECK CONSTRAINT [FK_result_analysis]
GO
ALTER TABLE [dbo].[result]  WITH CHECK ADD  CONSTRAINT [FK_result_reservation1] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[reservation] ([reservation_id])
GO
ALTER TABLE [dbo].[result] CHECK CONSTRAINT [FK_result_reservation1]
GO
ALTER TABLE [dbo].[srored_items]  WITH CHECK ADD  CONSTRAINT [FK_srored_items_supplier] FOREIGN KEY([sup_id])
REFERENCES [dbo].[supplier] ([sup_id])
GO
ALTER TABLE [dbo].[srored_items] CHECK CONSTRAINT [FK_srored_items_supplier]
GO
/****** Object:  StoredProcedure [dbo].[Add_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_analysis]
(

@name_en nvarchar(100),
@analysis_price varchar(50),
@how_to_analysis nvarchar(200),
@notes nvarchar(100),
@analysis_time nvarchar(100),
@result nvarchar(100)
)
As
Begin
insert into analysis(name_en,analysis_price,how_to_analysis,analysis_time,result,notes)values (@name_en,@analysis_price,@how_to_analysis,@analysis_time,@result,@notes)
End
GO
/****** Object:  StoredProcedure [dbo].[Add_CONTRACT]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_CONTRACT]
	
	@contractor_name nvarchar(100),
	@con_specialization nvarchar(100),
	@contractor_address nvarchar(100),
	@contractor_phone varchar(100),
	@contractor_email varchar(100),
	@con_discount varchar(100),
	@sign int
AS
	insert into contractor
	( 
	contractor_name,
	con_specialization,
	contractor_address,
	contractor_phone,
	contractor_email,
	con_discount,
	sign)
	values
	(@contractor_name,@con_specialization,@contractor_address,@contractor_phone,@contractor_email,@con_discount,@sign)
	 
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Add_group]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Add_group]

(
@group_name nvarchar(100),
@analysis_num int
)

As

Begin

insert into groups(group_name,analysis_num)values(@group_name,@analysis_num)

End
GO
/****** Object:  StoredProcedure [dbo].[add_groups_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[add_groups_analysis]
(
@group_name nvarchar(100),
@analysis_id int
)
As
Begin
declare @group_id int
set @group_id = (select group_name from groups where group_name=@group_name)
insert into group_analysis (group_id,analysis_id) values (@group_name,@analysis_id)
End
GO
/****** Object:  StoredProcedure [dbo].[Add_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_normal]
(
@name_en nvarchar(100),
@age_from int,
@unit_from nvarchar(100),
@age_to int,
@unit_to nvarchar(100),
@gender nvarchar(50),
@normal nvarchar(50),
@normal_unit nvarchar(50)
)
As
Begin
declare @analysis_id int
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)
insert into normals(analysis_id,age_from,unit_from,age_to,unit_to,gender,normal,normal_unit)values (@analysis_id,@age_from,@unit_from,@age_to,@unit_to,@gender,@normal,@normal_unit)
End
GO
/****** Object:  StoredProcedure [dbo].[Add_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_patient]

    @pat_name nvarchar(100),
	@pat_phone nvarchar(100),
	@pat_address nvarchar(100),
	@pat_age int,
	@unit nvarchar(50),
	@pat_email nvarchar(100),
	@pat_gender nvarchar(10),
	@pat_stu nvarchar (100),
	@con_name nvarchar(100)

	AS
	Begin
	declare @con_id int
	set @con_id=(select contractor_id from contractor where @con_name=contractor_name)
   
	insert into patient 
	(patient_name,
	patient_age,
	unit,
	patient_gender,
	patient_status,
	patient_email,
	[address],
	phone,con_id)
	 values 
	 (@pat_name,
	 @pat_age,
	 @unit,
	 @pat_gender,
	 @pat_stu,
	 @pat_email,
	 @pat_address,
	 @pat_phone
	 ,@con_id)
	 End

GO
/****** Object:  StoredProcedure [dbo].[add_reservation]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[add_reservation]
(
@reservation_date date,
@patient_id int,
@doctor_name nvarchar(100),
@price float,
@discount float,
@total float,
@paid float,
@rest float
)
As
Begin
--declare @analysis_id int
declare @reservation_id int
insert into reservation (reservation_date,patient_id,doctor_name,price,discount,total,paid,rest) 
values (@reservation_date,@patient_id,@doctor_name,@price,@discount,@total,@paid,@rest)


--select @reservation_id=SCOPE_IDENTITY()
--set @analysis_id=(select analysis_id from analysis where name_en=@analysis_name)
--insert into reservation_analysis(reservation_id,analysis_id)
--values (@reservation_id,@analysis_id)
 
End
GO
/****** Object:  StoredProcedure [dbo].[add_reservation_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_reservation_analysis]
(
@reservation_id int,
@name_en nvarchar(100)
)
As
Begin
declare @analysis_id int
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)
insert into reservation_analysis(reservation_id,analysis_id)values (@reservation_id,@analysis_id)
End
GO
/****** Object:  StoredProcedure [dbo].[add_result]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_result]
(
@reservation_id int,
@name_en nvarchar(100),
@result nvarchar(100),
@normal nvarchar(100),
@comment nvarchar(100),
@other nvarchar(100)
      
)
As
declare @analysis_id int
Begin
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)
insert into result(reservation_id,analysis_id,result,normal,comment,other)values(@reservation_id,@analysis_id,@result,@normal,@comment,@other)

End
GO
/****** Object:  StoredProcedure [dbo].[AddingDoctor]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddingDoctor]
@Dname nvarchar(100),
@Dspecialization nvarchar(100),
@Daddress nvarchar(100),
@Dphone varchar(50),
@Demail varchar(50),
@Ddiscount varchar(50)
as 

INSERT INTO [doctor]
           ([doctor_name]
           ,[doctor_specialization]
           ,[doctor_address]
           ,[doctor_phone]
           ,[doctor_email]
           ,[doctor_discount])
     VALUES
           (@Dname,
            @Dspecialization,
            @Daddress,
            @Dphone,
            @Demail,
            @Ddiscount)



GO
/****** Object:  StoredProcedure [dbo].[AddingLab]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddingLab]
@EXLname nvarchar(100),
@EXLaddress nvarchar(100),
@EXLphone varchar(50),
@EXLemail nvarchar(100),
@EXLdiscount varchar(50)
as 

INSERT INTO [external_lab]
           ([ex_lab_name]
           ,[ex_lab_address]
           ,[ex_lab_phone]
           ,[ex_lab_email]
           ,[ex_lab_discount])
     VALUES
           (@EXLname,
            @EXLaddress,
            @EXLphone,
            @EXLemail,
            @EXLdiscount)



GO
/****** Object:  StoredProcedure [dbo].[AddSupp]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddSupp]

    
	@supp_name nvarchar(100),
	@supp_specialization  nvarchar(100),
	@supp_address nvarchar(100),
	@supp_phone varchar(50),
	@supp_email nvarchar(100)

	AS
	insert into supplier ([sup_name],[sup_specialization],[sup_address],[sup_phone],[sup_email]) 
	values (@supp_name,@supp_specialization,@supp_address,@supp_phone,@supp_email)



GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddUser]

    
	@UserName nvarchar(100),
	@Password nvarchar(50),
	@UserAddress nvarchar(100),
	@UserPhone varchar(50),
	@IdNumber int,
	@DateOfBirth date,
	@UserEmail nvarchar(50),
	@Job nvarchar(50),
	@WorkerWages int,
	@notes nvarchar(max)

	AS
	insert into [users] ([user_name],[password],[user_address],[user_phone],[id_number],
	[date_of_birth],[user_email],[job],[worker_wages],[notes]) 
	values (@UserName,@Password,@UserAddress,@UserPhone,@IdNumber,@DateOfBirth,@UserEmail,
	@Job,@WorkerWages,@notes)



GO
/****** Object:  StoredProcedure [dbo].[Delete_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_analysis]
(
@analysis_id int
)
As
Begin
delete from analysis where analysis_id=@analysis_id
End
GO
/****** Object:  StoredProcedure [dbo].[delete_contract]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_contract]
@id int
as
delete from contractor where contractor_id=@id

GO
/****** Object:  StoredProcedure [dbo].[Delete_group]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_group]
(
@group_id int
)
As
Begin
delete from groups where group_id=@group_id
End
GO
/****** Object:  StoredProcedure [dbo].[Delete_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_normal]
(
@normal_id int
)
As 
Begin
delete from normals where normal_id=@normal_id
End
GO
/****** Object:  StoredProcedure [dbo].[delete_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_patient]
@id int
as
delete from patient where patient_id=@id

GO
/****** Object:  StoredProcedure [dbo].[DeleteDoctor]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteDoctor]
@Did int
As
DELETE FROM doctor
      WHERE doctor_id = @Did




GO
/****** Object:  StoredProcedure [dbo].[DeleteExLab]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteExLab]
@EXLid int
As
DELETE FROM external_lab
      WHERE ex_lab_id = @EXLid




GO
/****** Object:  StoredProcedure [dbo].[DeleteSup]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteSup] 
@supp_id int
AS
Delete from supplier
where sup_id=@supp_id



GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteUser] 
@UserId int
AS
Delete from [users]
where user_id=@UserId



GO
/****** Object:  StoredProcedure [dbo].[edit_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[edit_patient]
	@id int,
	@name nvarchar(50),
	@phone nvarchar(50),
	@address nvarchar(50),
	@age int,
	@unit nvarchar(50),
	@email nvarchar(50)
	
AS
	update patient
	set
	[patient_name]=@name,
	[phone]=@phone,
	[address]=@address,
	patient_age=@age,
	unit=@unit,
	patient_email=@email
	where patient_id=@id
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[Get_all_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Get_all_analysis]
As
Begin
select * from analysis
End
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_con]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ALL_con]
As
Begin
select * from contractor
End


GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_doc]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ALL_doc]
(
@sign int
)

As
Begin
select [contractor_id] as 'كود الطبيب '
      ,[contractor_name]as 'اسم الطبيب'
      ,[con_specialization]as 'التخصص'
      ,[contractor_address]as 'العنوان'
      ,[contractor_phone]as 'رقم الهاتف'
      ,[contractor_email]as 'البريد الالكترونى'
      ,[con_discount]as 'نسبة الخصم'
 from contractor
where sign=@sign

End
GO
/****** Object:  StoredProcedure [dbo].[Get_all_groups]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Get_all_groups]
As
Begin
select *from groups
End
GO
/****** Object:  StoredProcedure [dbo].[Get_all_patient5]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Get_all_patient5]
AS
Begin
select * from patient
End
GO
/****** Object:  StoredProcedure [dbo].[get_doc_con]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_doc_con]
As
begin
select doctor_name,contractor_name
from doctor,contractor
End
GO
/****** Object:  StoredProcedure [dbo].[get_doc_con2]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_doc_con2]
As
begin
select doctor_name from [doctor] UNION ALL (SELECT contractor_name from [contractor] UNION ALL select ex_lab_name from external_lab )

End
GO
/****** Object:  StoredProcedure [dbo].[get_list_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_list_patient]
	
AS
	select patient.patient_id as 'كود المريض'
      ,patient.patient_name as 'اسم المريض'
      ,patient.patient_age as 'سن المريض'
      ,patient.patient_gender as 'النوع'
      ,[patient].address as 'العنوان'
      ,patient.phone as 'رقم الهاتف'
      ,patient.patient_email as 'البريدالالكترونى'
      ,patient.patient_status as 'حالة المريض'
      ,patient.contractor_id as 'كود شركة التعاقد'
      --,patient.doctor_id as'كود الطبيب المعالج'
	  ,[reservation].analysis_result as'نتيجة التحليل'
	  ,reservation.reservation_date as 'تاريخ الحجز'
	  
	  from patient,reservation 
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[GetAllCompany]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllCompany]
(
@sign int
)
As
Begin
select contractor_id as 'كود الشركة',
contractor_name as 'اسم الشركة',
con_specialization as 'النوع',
contractor_address as 'العنوان ',
contractor_phone as 'رقم الهاتف',
contractor_email as 'البريد الالكتروني ',
con_discount as ' نسبة الخصم',
sign
from contractor
where sign=@sign
End
GO
/****** Object:  StoredProcedure [dbo].[GetALLCONTRACT]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetALLCONTRACT]
	
AS
	SELECT [contractor_id] as 'كودالتعاقد'
      ,[contractor_name]as 'اسم الشركة المتعاقدة'
      ,[con_specialization]as 'لالا'
      ,[contractor_address] as 'العنوان'
      ,[contractor_phone]as 'التليفون'
      ,[contractor_email]as 'البريد الالكتروني'
      ,[con_discount] as 'الخصم %'
      
  FROM [contractor]
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[GetAllDoctors]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[GetAllDoctors]
as 
select [doctor_id] as 'كود الطبيب '
      ,[doctor_name]as 'اسم الطبيب'
      ,[doctor_specialization]as 'التخصص'
      ,[doctor_address]as 'العنوان'
      ,[doctor_phone]as 'رقم الهاتف'
      ,[doctor_email]as 'البريد الالكترونى'
      ,[doctor_discount]as 'نسبة الخصم'
  FROM [doctor]


GO
/****** Object:  StoredProcedure [dbo].[GetAllLab]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllLab]
(
@sign int
)
as 
select [contractor_id] as 'كود المعمل '
      ,[contractor_name] as 'اسم المعمل '
	  ,[con_specialization] as 'عدد الفروع'
      ,[contractor_address]as 'العنوان'
      ,[contractor_phone]as 'رقم الهاتف'
      ,[contractor_email]as 'البريد الالكترونى'
      ,[con_discount]as 'نسبة الخصم'
  FROM [contractor]
  where sign=@sign
GO
/****** Object:  StoredProcedure [dbo].[GetAllNormals]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllNormals]
as 
SELECT [normal_id] as 'الكود'
      ,[analysis].[name_en] as 'اسم التحليل'
      ,[age_from] as 'العمر من'
	  ,[unit_from] as 'الوحدة من'
      ,[age_to]as 'الى العمر'
	  ,[unit_to] as 'الوحدة إلى'
      ,[gender]as 'النوع'
      ,[normal]as 'Normal'
	  ,[normal_unit] as 'Normal Unit'

from normals ,analysis where analysis.analysis_id in (select normals.analysis_id from normals)


GO
/****** Object:  StoredProcedure [dbo].[GetAllPatients1]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllPatients1]
as 

SELECT [patient_id] as 'كود المريض'
      ,[patient_name]as 'اسم المريض'
      ,[patient_age]as 'سن المريض'
      ,[patient_gender] as 'النوع'
      ,[address]as 'العنوان'
      ,[phone]as 'رقم الهاتف'
      ,[patient_email] as 'البريدالالكترونى'
      ,[patient_status]as 'حالة المريض'
      ,[con_id]as 'كود شركة التعاقد'
      --,[doctor_id]as'كود الطبيب المعالج'
  FROM [patient]
GO
/****** Object:  StoredProcedure [dbo].[GetAnalysisPrice]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetAnalysisPrice]
as
select 
name_en 
,analysis_price 
 from analysis

GO
/****** Object:  StoredProcedure [dbo].[GetContractors]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetContractors]
as 
select * from contractor

GO
/****** Object:  StoredProcedure [dbo].[GetDiscount]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetDiscount]
@Id int 
as 
select doctor_discount
from doctor
where doctor_id=@id


GO
/****** Object:  StoredProcedure [dbo].[GetDoctor]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetDoctor]
as
select * from doctor

GO
/****** Object:  StoredProcedure [dbo].[GetELab]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetELab]
as 
select * from external_lab

GO
/****** Object:  StoredProcedure [dbo].[Search_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_analysis]
(
@name_en nvarchar(100)
)
As
Begin
declare @analysis_id int
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)
select analysis.analysis_id,analysis.name_en,analysis.analysis_price,analysis.how_to_analysis,analysis.analysis_time,analysis.result,analysis.notes,groups.group_name from analysis,group_analysis,groups
where analysis.analysis_id=@analysis_id
And group_analysis.analysis_id=analysis.analysis_id
And group_analysis.group_id=groups.group_id
 
End
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CONTRACT]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_CONTRACT]
@crtierion nvarchar(50)
as
select [contractor_id] as 'كود المتعاقد'
      ,[contractor_name]as 'اسم الشركة المتعاقدة'
      ,[con_specialization]as 'التخصص'
      ,[contractor_address] as 'العنوان'
      ,[contractor_phone]as 'التليفون'
      ,[contractor_email]as 'البريدالالكتروني'
      ,[con_discount] as 'الخصم%'
      
from contractor
where [contractor_name] like  '%'+ @crtierion +'%'

GO
/****** Object:  StoredProcedure [dbo].[Search_group]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Search_group]
(
@group_name nvarchar(100)
)
As
Begin
select * from groups where group_name=@group_name

End
GO
/****** Object:  StoredProcedure [dbo].[Search_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_normal]
(
@name_en nvarchar(100)
)
As
Begin
declare @analysis_id int
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)

SELECT [normal_id] as 'الكود'
      ,[analysis].[name_en] as 'اسم التحليل'
      ,[age_from] as 'العمر من'
      ,[age_to]as 'الى العمر'
      ,[gender]as 'النوع'
      ,[normal]as 'Normal'

from normals ,analysis
where [analysis].[analysis_id]=@analysis_id
End





GO
/****** Object:  StoredProcedure [dbo].[SEARCH_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCH_patient]
@crtierion nvarchar(50)
as
select [patient_id] as 'كود المريض'
      ,[patient_name]as 'اسم المريض'
      ,[patient_age]as 'سن المريض'
      ,[patient_gender] as 'النوع'
      ,[address]as 'العنوان'
      ,[phone]as 'رقم الهاتف'
      ,[patient_email] as 'البريدالالكترونى'
      ,[patient_status]as 'حالة المريض'
      ,[contractor_id]as 'كود شركة التعاقد'
      ,[doctor_id]as'كود الطبيب المعالج'
from patient
where [patient_name] like  '%'+ @crtierion +'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchCompanyByName]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchCompanyByName]
@name nvarchar (100)
as 
select [contractor_id] as 'الكود'
      ,[contractor_name]as 'الاسم'
      ,[con_specialization]as 'التخصص'
      ,[contractor_address]as 'العنوان'
      ,[contractor_phone]as 'رقم الهاتف'
      ,[contractor_email]as 'البريد الالكترونى'
      ,[con_discount]as 'نسبة الخصم'
  FROM [contractor]
where contractor_name like '%'+@name+'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchContractBySpecialization]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchContractBySpecialization]
@specialization nvarchar (100)
as 
select [contractor_id] as 'الكود'
      ,[contractor_name]as 'الاسم'
      ,[Con_specialization]as 'التخصص'
      ,[contractor_address]as 'العنوان'
      ,[contractor_phone]as 'رقم الهاتف'
      ,[contractor_email]as 'البريد الالكترونى'
      ,[con_discount]as 'نسبة الخصم'
  FROM [contractor]
where Con_specialization like '%'+@specialization+'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchDoctorByName]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchDoctorByName]
@Dname nvarchar (100)
as 
select [doctor_id] as 'كود الطبيب '
      ,[doctor_name]as 'اسم الطبيب'
      ,[doctor_specialization]as 'التخصص'
      ,[doctor_address]as 'العنوان'
      ,[doctor_phone]as 'رقم الهاتف'
      ,[doctor_email]as 'البريد الالكترونى'
      ,[doctor_discount]as 'نسبة الخصم'
  FROM [doctor]
where doctor_name like '%'+@Dname+'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchDoctorBySpecialization]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchDoctorBySpecialization]
@Dspecialization nvarchar (100)
as 
select [doctor_id] as 'كود الطبيب '
      ,[doctor_name]as 'اسم الطبيب'
      ,[doctor_specialization]as 'التخصص'
      ,[doctor_address]as 'العنوان'
      ,[doctor_phone]as 'رقم الهاتف'
      ,[doctor_email]as 'البريد الالكترونى'
      ,[doctor_discount]as 'نسبة الخصم'
  FROM [doctor]
where doctor_specialization like '%'+@Dspecialization+'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchExLabByName]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchExLabByName]
@contractor_name nvarchar (100)
as 
select [contractor_id] as 'كود المعمل '
      ,[contractor_name]as 'اسم المعمل '
	  ,[con_specialization]as'عدد الفروع'
      ,[contractor_address]as 'العنوان'
      ,[contractor_phone]as 'رقم الهاتف'
      ,[contractor_email]as 'البريد الالكترونى'
      ,[con_discount]as 'نسبة الخصم'
  FROM [contractor]
  where contractor_name like '%'+@contractor_name+'%'

GO
/****** Object:  StoredProcedure [dbo].[select_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_analysis]
(
@name_en nvarchar(100),
@group_name nvarchar(100)
)
As
Begin
select group_name,name_en,analysis_price from analysis,groups
where name_en=@name_en and groups.group_id=analysis.group_id and groups.group_name=@group_name
End
GO
/****** Object:  StoredProcedure [dbo].[select_analysis_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_analysis_normal]
(
@analysis_id int,
@age int,
@unit nvarchar(100),
@gender nvarchar(100)
)
As
Begin
select normal from normals where analysis_id=@analysis_id And unit_to=@unit and age_from<=@age and age_to>=@age and gender=@gender
End
GO
/****** Object:  StoredProcedure [dbo].[select_analysis_normal2]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_analysis_normal2]
(
@reservation_id int
)
AS
Begin
--declare @analysis_id int
--set @analysis_id=(select analysis_id from reservation_analysis where reservation_id=@reservation_id)
--select normal from normals,patient,reservation,reservation_analysis where normals.analysis_id in (select analysis_id from reservation_analysis where reservation_id=@reservation_id)
--And patient.patient_id=reservation.patient_id
--And patient.patient_gender=normals.gender
--And patient.unit=normals.unit_to
--And normals.age_from<=patient_age
--and normals.age_to>=patient_age
select group_name,name_en,normal from analysis,groups,normals,patient where analysis.analysis_id in (select analysis_id from reservation_analysis where reservation_id=@reservation_id)
And groups.group_id=analysis.group_id
And analysis.analysis_id=normals.analysis_id
And patient.patient_id in (select patient_id from reservation where reservation_id=@reservation_id)
And patient.patient_gender=normals.gender
And normals.unit_to=patient.unit
And normals.age_from<=patient_age
and normals.age_to>=patient_age
End
GO
/****** Object:  StoredProcedure [dbo].[select_analysis_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_analysis_patient]
(
@reservation_id int
)
As
Begin
--declare @contractor_name nvarchar(100)
--set @contractor_name=(select contractor_name from contractor where reservation.reservation_id=@reservation_id And reservation.patient_id=patient.patient_id)
--select reservation_date,cotra
 --from patient,reservation
 /*,analysis,reservation_analysis,groups,normals,contractor*/
declare @patient_id int
--declare @con_id int
--declare @analysis_id int
--declare @group_id int

set @patient_id=(select patient_id from reservation where reservation_id=@reservation_id)
--select con from patient,reservation
--set @con_id=(select con_id from patient where patient_id=@patient_id)
--set @analysis_id=(select analysis_id from reservation_analysis where )
--set @group_id=(select group_id from groups)
select contractor_name,patient_age,patient_gender,reservation_date,doctor_name from patient,contractor,reservation where contractor.contractor_id=patient.con_id And patient.patient_id=@patient_id And patient.patient_id=@patient_id and reservation_id=@reservation_id



End

GO
/****** Object:  StoredProcedure [dbo].[select_group]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_group]
(
@group_name nvarchar(100)
)
As
Begin
declare @group_id int
set @group_id=(select group_id from groups where group_name=@group_name)
select * from analysis,groups,group_analysis where groups.group_id=@group_id
And analysis.analysis_id=group_analysis.analysis_id
And group_analysis.group_id=groups.group_id
End
GO
/****** Object:  StoredProcedure [dbo].[select_group_analysis_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_group_analysis_normal]
(
@group_name nvarchar(100),
@reservation_id int
)
As
Begin
select group_name,name_en,normal,normal_unit from analysis,groups,normals,patient where analysis.analysis_id in (select analysis_id from reservation_analysis where reservation_id=@reservation_id)
And groups.group_id=analysis.group_id
And analysis.analysis_id=normals.analysis_id
And patient.patient_id in (select patient_id from reservation where reservation_id=@reservation_id)
And patient.patient_gender=normals.gender
And normals.unit_to=patient.unit
And normals.age_from<=patient_age
and normals.age_to>=patient_age
and group_name=@group_name
End
GO
/****** Object:  StoredProcedure [dbo].[select_group_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_group_patient]
(
@reservation_id int
)
As 
Begin

--set @group_id=(select group_id from groups where )
select distinct group_name from groups,analysis where analysis.analysis_id in (select analysis_id from reservation_analysis where reservation_id=@reservation_id)
And groups.group_id=analysis.group_id
End
GO
/****** Object:  StoredProcedure [dbo].[select_patient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_patient]
(
@patient_name nvarchar(100)
)
As
Begin
select patient_id,contractor_name,con_discount from patient,contractor where patient_name=@patient_name And contractor.contractor_id=patient.con_id
End


GO
/****** Object:  StoredProcedure [dbo].[select_patient_reservation]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_patient_reservation]
(

@patient_name nvarchar(100)
)
As
Begin
declare @patient_id int
set @patient_id=(select patient_id from patient where patient_name=@patient_name)
select patient_name,reservation_id from reservation,patient where patient.patient_id=@patient_id And reservation.patient_id=@patient_id
End
GO
/****** Object:  StoredProcedure [dbo].[SelectSup]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectSup]
	
AS

SELECT [sup_id]as 'كودالمورد'
      ,[sup_name]as'اسم المورد'
      ,[sup_specialization]as 'تخصص المورد'
      ,[sup_address]as 'العنوان'
      ,[sup_phone]as'رقم الهاتف'
      ,[sup_email]as'البريد الالكترونى'
  FROM [supplier]






GO
/****** Object:  StoredProcedure [dbo].[SelectUser]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectUser]
	
AS

SELECT [user_id]as 'كودالمورد'
      ,[user_name]as'اسم المورد'
      ,[password]as 'الرقم السرى'
      ,[user_address]as 'العنوان'
      ,[user_phone]as'رقم الهاتف'
      ,[id_number]as'الرقم القومي'
	  ,[date_of_birth]as 'تاريخ الميلاد'
      ,[user_email]as'البريد الالكترونى'
      ,[user_job]as 'اللقب الوظيفي'
      ,[user_job]as'الوظيفة'
      ,[worker_wages]as 'اجر العامل'
      ,[notes]as'رقم الهاتف'
  FROM [users]








GO
/****** Object:  StoredProcedure [dbo].[Update_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_analysis]
(
@analysis_id int,
@name_en nvarchar(100),
@analysis_price varchar(50),
@how_to_analysis nvarchar(200),
@analysis_time nvarchar(100),
@result nvarchar(100),
@notes nvarchar(100)
)
As
Begin
update analysis set name_en=@name_en,analysis_price=@analysis_price,how_to_analysis=@how_to_analysis,analysis_time=@analysis_time,result=@result,notes=@notes
where analysis_id=@analysis_id
End
GO
/****** Object:  StoredProcedure [dbo].[UpDate_CONTRACT]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpDate_CONTRACT]
    @contractor_id int,
	@contractor_name nvarchar(100),
	@con_specialization nvarchar(100),
	@contractor_address nvarchar(100),
	@contractor_phone varchar(50),
	@contractor_email nvarchar(50),
	@con_discount varchar(100)
AS
	update contractor
	set
	contractor_name=@contractor_name,
	con_specialization=@con_specialization,
	contractor_address =@contractor_address,
	contractor_phone =@contractor_phone,
	contractor_email =@contractor_email,
	con_discount =@con_discount
	where contractor_id=@contractor_id
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Update_group]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_group]
(
@group_id int,
@group_name nvarchar(100),
@analysis_num int
)
As
Begin
Update groups set group_name=@group_name, analysis_num=@analysis_num
where group_id=@group_id
End
GO
/****** Object:  StoredProcedure [dbo].[Update_groups_analysis]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_groups_analysis]
(
@group_name nvarchar(100),
@analysis_id int
)
As
Begin
declare @group_id int
set @group_id = (select group_id from groups where group_name=@group_name)
delete from group_analysis
where analysis_id=@analysis_id
insert into group_analysis (group_id,analysis_id) values (@group_id,@analysis_id)
End
GO
/****** Object:  StoredProcedure [dbo].[Update_normal]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_normal]
(
@normal_id int,
@name_en nvarchar(100),
@age_from int,
@unit_from nvarchar(100),
@age_to int,
@unit_to nvarchar(100),
@gender nvarchar(50),
@normal nvarchar(50),
@unit nvarchar(50)
)
As
Begin
declare @analysis_id int
set @analysis_id=(select analysis_id from analysis where name_en=@name_en)
update normals set analysis_id=@analysis_id,age_from=@age_from,unit_from=@unit_from,age_to=@age_to,unit_to=@unit_to,gender=@gender,normal=@normal,normal_unit=@unit
where normal_id=@normal_id
End
GO
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePatient]
	@id int,
	@name nvarchar(50),
	@phone nvarchar(50),
	@address nvarchar(50),
	@age nvarchar(50),
	@email nvarchar(50)
	
AS
	update patient
	set
	patient_name=@name,
	phone=@phone,
	[address]=@address,
	patient_age=@age,
	patient_email=@email
	where patient_id=@id

GO
/****** Object:  StoredProcedure [dbo].[UpDateSupp]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpDateSupp]
    @supp_id int,
	@supp_name nvarchar(100),
	@supp_specialization  nvarchar(100),
	@supp_address nvarchar(100),
	@supp_phone nvarchar(50),
	@supp_email nvarchar(100)

	
AS
	update supplier
	set
	[sup_name]=@supp_name,
	[sup_specialization]=@supp_specialization,
	[sup_address]=@supp_address,
	[sup_phone]=@supp_phone,
	[sup_email]=@supp_email
	where [sup_id]=@supp_id



GO
/****** Object:  StoredProcedure [dbo].[UpDateUser]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpDateUser]
    @UserId int,
	@UserName nvarchar(100),
	@Password nvarchar(50),
	@UserAddress nvarchar(100),
	@UserPhone varchar(50),
	@IdNumber int,
	@DateOfBirth date,
	@UserEmail nvarchar(50),
	
	@Job nvarchar(50),
	@WorkerWages int,
	@notes nvarchar(max)

	
AS
	update [users]
	set
	[user_name]=@UserName,
	[password]=@Password,
	[user_address]=@UserAddress,
	[user_phone]=@UserPhone,
	[id_number]=@IdNumber,
	[date_of_birth]= @DateOfBirth,
	[user_email] = @UserEmail,
	
	[job] = @Job,
	[worker_wages] = @WorkerWages,
	[notes] = @notes
	where [user_id]=@UserId



GO
/****** Object:  StoredProcedure [dbo].[UpdatingDoctor]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatingDoctor]
@Did int,
@Dname nvarchar(100),
@Dspecialization nvarchar(100),
@Daddress nvarchar(100),
@Dphone varchar(50),
@Demail varchar(50),
@Ddiscount varchar(50)
as 
UPDATE [doctor]
   SET [doctor_name] = @Dname,
       [doctor_specialization] = @Dspecialization,
       [doctor_address] =@Daddress,
       [doctor_phone] = @Dphone,
       [doctor_email] = @Demail,
       [doctor_discount] = @Ddiscount
 WHERE doctor_id=@Did




GO
/****** Object:  StoredProcedure [dbo].[UpdatingExLab]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatingExLab]
@EXLid int,
@EXLname nvarchar(100),
@EXLaddress nvarchar(100),
@EXLphone varchar(50),
@EXLemail nvarchar(100),
@EXLdiscount varchar(50)
as 
UPDATE [external_lab]
   SET [ex_lab_name] = @EXLname,
       [ex_lab_address] =@EXLaddress,
       [ex_lab_phone] = @EXLphone,
       [ex_lab_email] = @EXLemail,
       [ex_lab_discount] = @EXLdiscount
 WHERE ex_lab_id=@EXLid




GO
/****** Object:  StoredProcedure [dbo].[UserLogIn]    Script Date: 01/02/2018 04:34:14 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UserLogIn]
@ID int,
@Pwd nvarchar(50),
@Ujob  nvarchar(50)
as 
select *from users
where @ID=id_number and @Pwd=[password] and @Ujob=user_job

GO
USE [master]
GO
ALTER DATABASE [Lab] SET  READ_WRITE 
GO
