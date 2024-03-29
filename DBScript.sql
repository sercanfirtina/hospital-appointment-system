USE [master]
GO
/****** Object:  Database [HospitalDB]    Script Date: 12.10.2019 19:48:55 ******/
CREATE DATABASE [HospitalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HospitalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HospitalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HospitalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HospitalDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HospitalDB] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HospitalDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HospitalDB', N'ON'
GO
ALTER DATABASE [HospitalDB] SET QUERY_STORE = OFF
GO
USE [HospitalDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [HospitalDB]
GO
/****** Object:  Table [dbo].[Analysises]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analysises](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateID] [int] NOT NULL,
	[AnalaysDescription] [nvarchar](150) NULL,
 CONSTRAINT [PK_Analysises] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chemists]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chemists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Mail] [nvarchar](100) NULL,
	[Password] [nvarchar](30) NULL,
	[PharmacyName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Chemists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] NOT NULL,
	[CityName] [nvarchar](60) NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dates]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DatesDate] [date] NULL,
	[TimeID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[DistrictID] [int] NOT NULL,
	[HospitalID] [int] NOT NULL,
	[PolyclinicID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[DidItCame] [bit] NULL,
 CONSTRAINT [PK_Dates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnosises]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosises](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DiagnosisDescription] [nvarchar](100) NULL,
	[DiagnosisName] [nvarchar](60) NULL,
 CONSTRAINT [PK_Diagnosises] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistrictName] [nvarchar](60) NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_Districts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorHours]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorHours](
	[DHoursID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorID] [int] NOT NULL,
	[HourID] [int] NOT NULL,
	[IsAvailable] [bit] NULL,
 CONSTRAINT [PK_DoctorHours] PRIMARY KEY CLUSTERED 
(
	[DHoursID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [nvarchar](50) NULL,
	[DoctorSurname] [nvarchar](50) NULL,
	[DoctorMail] [nvarchar](100) NOT NULL,
	[DoctorPassword] [nvarchar](30) NOT NULL,
	[HospitalPloyclinicID] [int] NOT NULL,
	[IdentificationNumber] [nvarchar](11) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HospitalPolyClinic]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HospitalPolyClinic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HospitalID] [int] NOT NULL,
	[PolyClinicID] [int] NOT NULL,
 CONSTRAINT [PK_HospitalPolyClinic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospitals]    Script Date: 12.10.2019 19:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospitals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [nvarchar](50) NULL,
	[DistrictID] [int] NOT NULL,
 CONSTRAINT [PK_Hospitals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hours]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hours](
	[HourID] [int] IDENTITY(1,1) NOT NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_Hours] PRIMARY KEY CLUSTERED 
(
	[HourID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientDiagnosis]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientDiagnosis](
	[PatientID] [int] NOT NULL,
	[DiagnosisID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdentificationNumber] [nvarchar](11) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](55) NULL,
	[Birthdate] [date] NULL,
	[mail] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[IsWomen] [bit] NULL,
	[PhoneNumber] [nvarchar](30) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polyclinics]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polyclinics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PolyclinicName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Polyclinics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescriptions]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescriptions](
	[DateID] [int] NOT NULL,
	[PrescriptionDescription] [nvarchar](100) NULL,
	[PrescriptionDate] [date] NULL,
	[PrescriptionCode] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Prescriptions] PRIMARY KEY CLUSTERED 
(
	[DateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Chemists] ON 

INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (1, N'Caro', N'Vedenyakin', N'cvedenyakin0@ow.ly', N'HLjR9Zhq8V', N'Caro Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (2, N'Dickie', N'Rennick', N'drennick1@photobucket.com', N'1aCErj', N'dickie  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (3, N'Torin', N'Costin', N'tcostin2@goodreads.com', N'gyArgWFp', N'Costin  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (4, N'Hamilton', N'Pavlovic', N'hpavlovic3@blogs.com', N'UwNghheZa', N'Pavlov  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (5, N'Almira', N'Tedridge', N'atedridge4@who.int', N'oF4gVs5', N'Almira  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (6, N'Dillie', N'Saipy', N'dsaipy5@yolasite.com', N'KjjMs1CIR6', N'Saipy  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (7, N'Ardelle', N'Stork', N'astork6@squarespace.com', N'GWPNXlgLEd3y', N'Stork  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (8, N'Kasey', N'Gresch', N'kgresch7@wix.com', N'4jTdAznzGI', N'Kasey  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (9, N'Adel', N'Toomey', N'atoomey8@shinystat.com', N'fSLOAMP', N'Adel  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (10, N'Celestina', N'Cornish', N'ccornish9@newsvine.com', N'Hdtsvz', N'Cornish  Chemistery')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (11, N'a', N'a', N'a@hotmail.com', N'a', N'a')
INSERT [dbo].[Chemists] ([Id], [Name], [Surname], [Mail], [Password], [PharmacyName]) VALUES (12, N'a', N'aed', N'da', N'ada', N'aa')
SET IDENTITY_INSERT [dbo].[Chemists] OFF
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (1, N'Adana')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (2, N'Adıyaman')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (3, N'Afyon')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (4, N'Ağrı')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (5, N'Amasya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (6, N'Ankara')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (7, N'Antalya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (8, N'Artvin')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (9, N'Aydın')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (10, N'Balıkesir')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (11, N'Bilecik')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (12, N'Bingöl')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (13, N'Bitlis')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (14, N'Bolu')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (15, N'Burdur')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (16, N'Bursa')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (17, N'Çanakkale')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (18, N'Çankırı')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (19, N'Çorum')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (20, N'Denizli')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (21, N'Diyarbakır')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (22, N'Edirne')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (23, N'Elazığ')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (24, N'Erzincan')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (25, N'Erzurum')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (26, N'Eskişehir')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (27, N'Gaziantep')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (28, N'Giresun')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (29, N'Gümüşhane')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (30, N'Hakkari')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (31, N'Hatay')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (32, N'Isparta')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (33, N'Mersin')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (34, N'İstanbul')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (35, N'İzmir')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (36, N'Kars')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (37, N'Kastamonu')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (38, N'Kayseri')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (39, N'Kırklareli')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (40, N'Kırşehir')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (41, N'Kocaeli')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (42, N'Konya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (43, N'Kütahya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (44, N'Malatya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (45, N'Manisa')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (46, N'K.Maraş')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (47, N'Mardin')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (48, N'Muğla')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (49, N'Muş')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (50, N'Nevşehir')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (51, N'Niğde')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (52, N'Ordu')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (53, N'Rize')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (54, N'Sakarya')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (55, N'Samsun')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (56, N'Siirt')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (57, N'Sinop')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (58, N'Sivas')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (59, N'Tekirdağ')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (60, N'Tokat')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (61, N'Trabzon')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (62, N'Tunceli')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (63, N'Şanlıurfa')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (64, N'Uşak')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (65, N'Van')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (66, N'Yozgat')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (67, N'Zonguldak')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (68, N'Aksaray')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (69, N'Bayburt')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (70, N'Karaman')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (71, N'Kırıkkale')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (72, N'Batman')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (73, N'Şırnak')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (74, N'Bartın')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (75, N'Ardahan')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (76, N'Iğdır')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (77, N'Yalova')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (78, N'Karabük')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (79, N'Kilis')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (80, N'Osmaniye')
INSERT [dbo].[Cities] ([Id], [CityName]) VALUES (81, N'Düzce')
SET IDENTITY_INSERT [dbo].[Dates] ON 

INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (1, 1, CAST(N'2019-10-16' AS Date), 1, 34, 1, 1, 1, 1, 1, NULL)
INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (2, 2, CAST(N'2019-10-15' AS Date), 3, 34, 2, 3, 2, 2, 1, NULL)
INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (5, 27, CAST(N'2019-10-20' AS Date), 5, 34, 3, 2, 5, 2, 1, 1)
INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (6, 4, CAST(N'2019-10-22' AS Date), 4, 34, 1, 1, 1, 1, 1, NULL)
INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (7, 1, CAST(N'2019-10-24' AS Date), 9, 34, 1, 1, 1, 1, NULL, NULL)
INSERT [dbo].[Dates] ([Id], [PatientID], [DatesDate], [TimeID], [CityID], [DistrictID], [HospitalID], [PolyclinicID], [DoctorID], [IsActive], [DidItCame]) VALUES (8, 27, CAST(N'2019-10-30' AS Date), 1, 34, 1, 1, 3, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Dates] OFF
SET IDENTITY_INSERT [dbo].[Diagnosises] ON 

INSERT [dbo].[Diagnosises] ([ID], [DiagnosisDescription], [DiagnosisName]) VALUES (1, N'Complete traumatic amputation of one unspecified lesser toe, subsequent encounter', N'Revision of Monitoring Device in Left Lung, Open Approach')
INSERT [dbo].[Diagnosises] ([ID], [DiagnosisDescription], [DiagnosisName]) VALUES (3, N'Traumatic rupture of left ear drum, sequela', N'Replacement of Coccygeal Jt with Nonaut Sub, Open Approach')
INSERT [dbo].[Diagnosises] ([ID], [DiagnosisDescription], [DiagnosisName]) VALUES (4, N'Other secondary chronic gout, unspecified knee, with tophus (tophi)', N'Removal of Synth Sub from Epididymis/Sperm Cord, Endo')
INSERT [dbo].[Diagnosises] ([ID], [DiagnosisDescription], [DiagnosisName]) VALUES (5, N'Blister (nonthermal) of unspecified external genital organs, male, initial encounter', N'Drainage of Anus, Endo')
INSERT [dbo].[Diagnosises] ([ID], [DiagnosisDescription], [DiagnosisName]) VALUES (7, N'Toxic effect of paints and dyes, not elsewhere classified, accidental (unintentional)', N'Insertion of Monitoring Electrode into POC, Open Approach')
SET IDENTITY_INSERT [dbo].[Diagnosises] OFF
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (1, N'Bakırköy', 34)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (2, N'Fatih', 34)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (3, N'Şişli', 34)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (4, N'Küçükçekmece', 34)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (5, N'Vize', 39)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (6, N'Lüleburgaz', 39)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (7, N'Pınarhisar', 39)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (9, N'Kıyıköy', 39)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (10, N'Ahmetbey', 39)
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityID]) VALUES (11, N'Babaeski', 39)
SET IDENTITY_INSERT [dbo].[Districts] OFF
SET IDENTITY_INSERT [dbo].[DoctorHours] ON 

INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (1, 1, 1, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (2, 1, 2, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (3, 1, 3, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (4, 1, 4, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (5, 1, 5, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (6, 1, 6, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (7, 1, 7, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (8, 1, 8, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (9, 1, 9, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (10, 1, 10, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (11, 1, 11, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (12, 1, 12, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (13, 1, 13, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (14, 1, 14, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (15, 2, 1, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (16, 2, 2, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (17, 2, 4, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (18, 2, 3, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (19, 2, 5, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (20, 2, 6, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (21, 2, 7, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (22, 2, 8, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (23, 2, 9, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (24, 2, 10, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (25, 2, 11, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (26, 2, 12, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (27, 2, 13, 1)
INSERT [dbo].[DoctorHours] ([DHoursID], [DoctorID], [HourID], [IsAvailable]) VALUES (28, 2, 14, 1)
SET IDENTITY_INSERT [dbo].[DoctorHours] OFF
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (1, N'Baldwin', N'Widmoor', N'bwidmoor0@meetup.com', N'OWYwHRTe', 1, N'12345125113', N'+1 (953) 134-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (2, N'Beilul', N'Baldam', N'bbaldam1@mac.com', N'7h5GF20e7pX', 5, N'44124123563', N'+1 (813) 544-4637')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (3, N'Arron', N'Favela', N'afavela2@ycombinator.com', N'9fD2hEES9Ms', 3, N'73483453834', N'+1 (813) 134-7988')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (4, N'Florian', N'Cottingham', N'fcottingham3@omniture.com', N'SV3TwH', 4, N'90457232467', N'+1 (813) 115-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (5, N'Siouxie', N'Wark', N'swark4@biblegateway.com', N'48vd5mzCc', 5, N'81924781480', N'+1 (813) 134-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (6, N'Aurelie', N'Alabastar', N'aalabastar5@bigcartel.com', N'3ZBcQWf', 6, N'12481892462', N'+1 (813) 754-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (7, N'Orsa', N'McMurthy', N'omcmurthy6@sciencedirect.com', N'T6hYiFq0Kx', 5, N'12412432378', N'+1 (813) 265-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (8, N'Marin', N'Rowatt', N'mrowatt7@nytimes.com', N'bpyTmeS5UgF', 4, N'45646564313', N'+1 (813) 263-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (9, N'Winnie', N'Pate', N'wpate8@dailymotion.com', N'VgCm7xaD', 3, N'12357858543', N'+1 (813) 984-8738')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (10, N'Graeme', N'Mandal', N'gmandal9@apple.com', N'ktNQaK', 2, N'23523523023', N'+1 (813) 134-4638')
INSERT [dbo].[Doctors] ([ID], [DoctorName], [DoctorSurname], [DoctorMail], [DoctorPassword], [HospitalPloyclinicID], [IdentificationNumber], [PhoneNumber]) VALUES (11, N'Pavel ', N'Nedved', N'pavelnedved@gmail.com', N'nedved', 1, N'34234235623', N'+1 (789) 134-4318')
SET IDENTITY_INSERT [dbo].[Doctors] OFF
SET IDENTITY_INSERT [dbo].[HospitalPolyClinic] ON 

INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (1, 1, 3)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (2, 1, 5)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (3, 2, 1)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (4, 2, 5)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (5, 3, 2)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (6, 3, 4)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (7, 4, 1)
INSERT [dbo].[HospitalPolyClinic] ([ID], [HospitalID], [PolyClinicID]) VALUES (8, 2, 4)
SET IDENTITY_INSERT [dbo].[HospitalPolyClinic] OFF
SET IDENTITY_INSERT [dbo].[Hospitals] ON 

INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (1, N'Dr.SadiKonuk', 1)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (2, N'Şişli Etfal', 3)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (3, N'Floranse Nightingale', 3)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (4, N'Bakırköy Ruh ve Sinir Hastalıkları', 1)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (5, N'Vize Devlet Hastanes', 5)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (6, N'Lüleburgaz Devlet Hastanesi', 6)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (7, N'Kıyıköy devlet Hastanesi', 9)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (9, N'Pınarhisar Devlet Hastanesi', 7)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (10, N'Ahmetbey Devlet Hastanesi', 10)
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [DistrictID]) VALUES (11, N'Babaeski Devlet Hastanesi', 11)
SET IDENTITY_INSERT [dbo].[Hospitals] OFF
SET IDENTITY_INSERT [dbo].[Hours] ON 

INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (1, CAST(N'1900-01-01T09:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (2, CAST(N'1900-01-01T09:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (3, CAST(N'1900-01-01T10:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (4, CAST(N'1900-01-01T10:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (5, CAST(N'1900-01-01T11:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (6, CAST(N'1900-01-01T11:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (7, CAST(N'1900-01-01T13:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (8, CAST(N'1900-01-01T13:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (9, CAST(N'1900-01-01T14:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (10, CAST(N'1900-01-01T14:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (11, CAST(N'1900-01-01T15:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (12, CAST(N'1900-01-01T15:30:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (13, CAST(N'1900-01-01T16:00:00.000' AS DateTime))
INSERT [dbo].[Hours] ([HourID], [Time]) VALUES (14, CAST(N'1900-01-01T16:30:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Hours] OFF
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (11, 1)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (1, 3)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (1, 4)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (2, 7)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (3, 4)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (4, 4)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (5, 3)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (6, 5)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (7, 5)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (8, 7)
INSERT [dbo].[PatientDiagnosis] ([PatientID], [DiagnosisID]) VALUES (9, 4)
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (1, N'17486514100', N'Edsel', N'Valentin', CAST(N'1965-10-25' AS Date), N'evalentin0@imdb.com', N'1JGNZze', 0, N'(18)03-3335')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (2, N'75379432555', N'Raven', N'Yanin', CAST(N'2007-07-28' AS Date), N'ryanin1@gizmodo.com', N'mnOEMgH0pF', 1, N'+1 (813) 134-4638')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (3, N'95102899968', N'Irvine', N'Wimms', CAST(N'1998-07-24' AS Date), N'iwimms2@php.net', N'V7QvPxvJnbO', 1, N'+63 (337) 523-2401')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (4, N'82227276835', N'Rosalind', N'Towsie', CAST(N'1986-10-08' AS Date), N'rtowsie3@opera.com', N'eMq1yVz', 1, N'+962 (684) 867-1434')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (5, N'67918911119', N'Kerianne', N'Deschlein', CAST(N'1975-09-01' AS Date), N'kdeschlein4@hubpages.com', N'Ek86x3g8eEwB', 1, N'+506 (411) 240-8477')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (6, N'27779121810', N'Alwin', N'Cirlos', CAST(N'1973-06-05' AS Date), N'acirlos5@friendfeed.com', N'NRlMaQZGXLY', 1, N'+372 (574) 282-9252')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (7, N'85158597882', N'Charlie', N'Matussow', CAST(N'1965-07-01' AS Date), N'cmatussow6@cnn.com', N'N8Hs0ky8n', 0, N'+63 (874) 859-6187')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (8, N'43711375899', N'Andy', N'O''Carney', CAST(N'1986-02-17' AS Date), N'aocarney7@yahoo.com', N'GE2zgoIE', 1, N'+86 (278) 737-7163')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (9, N'43545555534', N'Dasie', N'Shellard', CAST(N'1984-09-11' AS Date), N'dshellard8@statcounter.com', N'rJ0UUuqx2', 1, N'+46 (290) 417-1439')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (10, N'21003196471', N'Dael', N'Padgett', CAST(N'1985-04-17' AS Date), N'dpadgett9@parallels.com', N'itPVhnONnEga', 0, N'+7 (412) 717-3432')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (11, N'16568920632', N'Robina', N'Matthews', CAST(N'1964-08-13' AS Date), N'rmatthews0@wired.com', N'2xJjU98Mzq', 1, N'+351 (540) 564-1680')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (12, N'99908107447', N'Veradis', N'De Micoli', CAST(N'1975-03-16' AS Date), N'vdemicoli1@angelfire.com', N'j0Gl0V4EwSC', 1, N'+33 (545) 909-1887')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (13, N'85085357582', N'Claretta', N'Pieracci', CAST(N'1986-05-16' AS Date), N'cpieracci2@dell.com', N'obs5bn4MGN', 1, N'+963 (585) 114-1334')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (14, N'34994111352', N'Kata', N'Murrum', CAST(N'1992-03-21' AS Date), N'kmurrum3@fda.gov', N'hY4bFTHnj0eM', 1, N'+62 (184) 892-1059')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (15, N'67830489887', N'Jodie', N'O''Heffernan', CAST(N'1971-02-18' AS Date), N'joheffernan4@dagondesign.com', N'zNP29x', 1, N'+86 (382) 219-4525')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (16, N'14282380340', N'Markus', N'Foxten', CAST(N'1990-09-16' AS Date), N'mfoxten0@wikimedia.org', N'JRmKaIUh', 0, N'+234 (594) 113-9660')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (17, N'84884857598', N'Morey', N'Lapsley', CAST(N'1955-11-04' AS Date), N'mlapsley1@nature.com', N'A0hCQhm', 0, N'+420 (260) 515-5698')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (18, N'99353549483', N'Rustin', N'Jinkinson', CAST(N'2000-11-10' AS Date), N'rjinkinson2@qq.com', N'eSShKs', 0, N'+976 (696) 710-7524')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (19, N'17165301364', N'Torre', N'Jobe', CAST(N'1973-11-08' AS Date), N'tjobe3@google.pl', N'fuyHEKRQ2qlt', 0, N'+86 (608) 987-9365')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (20, N'16486986817', N'Horatio', N'Taffarello', CAST(N'2010-04-06' AS Date), N'htaffarello4@nytimes.com', N'0WNIGtv0V', 0, N'+998 (830) 269-5209')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (21, N'1234536367', N'Ahmet', N'Tol', CAST(N'1998-01-23' AS Date), N'ahmet@gmail.com', N'123', 0, N'+7 (412) 717-3432')
INSERT [dbo].[Patients] ([ID], [IdentificationNumber], [Name], [Surname], [Birthdate], [mail], [Password], [IsWomen], [PhoneNumber]) VALUES (27, N'1234', N'as', N'a', CAST(N'1980-02-25' AS Date), N'a', N'a', 0, N'(212)-5555565')
SET IDENTITY_INSERT [dbo].[Patients] OFF
SET IDENTITY_INSERT [dbo].[Polyclinics] ON 

INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (1, N'Mental Health')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (2, N'İnternal Diseases')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (3, N'Eye Diseases')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (4, N'Mouth and Dental Health')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (5, N'Brain and Nerve Surgery')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (6, N'Paediatric')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (7, N'Cardiovascular Diseases')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (8, N'General Surgery')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (9, N'Kulak Burun Boğaz')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (10, N'Orthopedics')
INSERT [dbo].[Polyclinics] ([Id], [PolyclinicName]) VALUES (11, N'Neurology')
SET IDENTITY_INSERT [dbo].[Polyclinics] OFF
INSERT [dbo].[Prescriptions] ([DateID], [PrescriptionDescription], [PrescriptionDate], [PrescriptionCode]) VALUES (1, N'minoset,vermidon,prozac,tarden', CAST(N'2019-12-12' AS Date), N'abc')
INSERT [dbo].[Prescriptions] ([DateID], [PrescriptionDescription], [PrescriptionDate], [PrescriptionCode]) VALUES (2, N'minoset,vermidon', CAST(N'2019-12-11' AS Date), N'cba')
ALTER TABLE [dbo].[Analysises]  WITH CHECK ADD  CONSTRAINT [FK_Analysises_Dates] FOREIGN KEY([DateID])
REFERENCES [dbo].[Dates] ([Id])
GO
ALTER TABLE [dbo].[Analysises] CHECK CONSTRAINT [FK_Analysises_Dates]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Cities] FOREIGN KEY([CityID])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Cities]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Districts] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Districts]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Doctors]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Hospitals] FOREIGN KEY([HospitalID])
REFERENCES [dbo].[Hospitals] ([Id])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Hospitals]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Hours] FOREIGN KEY([TimeID])
REFERENCES [dbo].[Hours] ([HourID])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Hours]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Patients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([ID])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Patients]
GO
ALTER TABLE [dbo].[Dates]  WITH CHECK ADD  CONSTRAINT [FK_Dates_Polyclinics] FOREIGN KEY([PolyclinicID])
REFERENCES [dbo].[Polyclinics] ([Id])
GO
ALTER TABLE [dbo].[Dates] CHECK CONSTRAINT [FK_Dates_Polyclinics]
GO
ALTER TABLE [dbo].[Districts]  WITH CHECK ADD  CONSTRAINT [FK_Districts_Cities] FOREIGN KEY([CityID])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Districts] CHECK CONSTRAINT [FK_Districts_Cities]
GO
ALTER TABLE [dbo].[DoctorHours]  WITH CHECK ADD  CONSTRAINT [FK_DoctorHours_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([ID])
GO
ALTER TABLE [dbo].[DoctorHours] CHECK CONSTRAINT [FK_DoctorHours_Doctors]
GO
ALTER TABLE [dbo].[DoctorHours]  WITH CHECK ADD  CONSTRAINT [FK_DoctorHours_Hours] FOREIGN KEY([HourID])
REFERENCES [dbo].[Hours] ([HourID])
GO
ALTER TABLE [dbo].[DoctorHours] CHECK CONSTRAINT [FK_DoctorHours_Hours]
GO
ALTER TABLE [dbo].[HospitalPolyClinic]  WITH CHECK ADD  CONSTRAINT [FK_HospitalPolyClinic_Hospitals1] FOREIGN KEY([HospitalID])
REFERENCES [dbo].[Hospitals] ([Id])
GO
ALTER TABLE [dbo].[HospitalPolyClinic] CHECK CONSTRAINT [FK_HospitalPolyClinic_Hospitals1]
GO
ALTER TABLE [dbo].[HospitalPolyClinic]  WITH CHECK ADD  CONSTRAINT [FK_HospitalPolyClinic_Polyclinics] FOREIGN KEY([PolyClinicID])
REFERENCES [dbo].[Polyclinics] ([Id])
GO
ALTER TABLE [dbo].[HospitalPolyClinic] CHECK CONSTRAINT [FK_HospitalPolyClinic_Polyclinics]
GO
ALTER TABLE [dbo].[Hospitals]  WITH CHECK ADD  CONSTRAINT [FK_Hospitals_Districts] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[Hospitals] CHECK CONSTRAINT [FK_Hospitals_Districts]
GO
ALTER TABLE [dbo].[PatientDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_PatientDiagnosis_Diagnosises1] FOREIGN KEY([DiagnosisID])
REFERENCES [dbo].[Diagnosises] ([ID])
GO
ALTER TABLE [dbo].[PatientDiagnosis] CHECK CONSTRAINT [FK_PatientDiagnosis_Diagnosises1]
GO
ALTER TABLE [dbo].[PatientDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_PatientDiagnosis_Patients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([ID])
GO
ALTER TABLE [dbo].[PatientDiagnosis] CHECK CONSTRAINT [FK_PatientDiagnosis_Patients]
GO
ALTER TABLE [dbo].[Prescriptions]  WITH CHECK ADD  CONSTRAINT [FK_Prescriptions_Dates] FOREIGN KEY([DateID])
REFERENCES [dbo].[Dates] ([Id])
GO
ALTER TABLE [dbo].[Prescriptions] CHECK CONSTRAINT [FK_Prescriptions_Dates]
GO
/****** Object:  StoredProcedure [dbo].[LoginDoctor]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LoginDoctor]
@mail nvarchar(100),
@password nvarchar(30)
as
begin 
	
	select * from Doctors where Doctors.DoctorMail =@mail and Doctors.DoctorPassword = @password;

end


GO
/****** Object:  StoredProcedure [dbo].[sp_AddDate]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddDate]
@PatID int,
@selectedDate dateTime,
@selectedTimeID int,
@selectedCityID int,
@selectedDistrictID int,
@selectedHospitalID int,
@selectedPolyclinicID int,
@selectedDoctorID int
as
begin
	insert into Dates(PatientID,CityID,DistrictID,HospitalID,PolyclinicID,DoctorID,DatesDate,TimeID) values(@PatID,@selectedCityID,@selectedDistrictID,@selectedHospitalID,@selectedPolyclinicID,@selectedDoctorID,@selectedDate,@selectedTimeID);
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BringPatient]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_BringPatient]
@id int
as
begin
	select * from PatientDiagnosis,Patients,Diagnosises,Dates,Prescriptions,Doctors,Analysises where Patients.ID=PatientDiagnosis.PatientID and PatientDiagnosis.DiagnosisID=Diagnosises.ID and Patients.ID=Dates.PatientID and Prescriptions.DateID=Dates.Id and Analysises.DateID=dates.Id and Doctors.ID=Dates.DoctorID and Patients.ID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ChemistFindMail]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_ChemistFindMail]
 
 @mail nvarchar(100)
as
begin
	select Chemists.Password from Chemists where Chemists.Mail = @mail;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_City]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_City]
as
begin
	select Cities.Id as 'CityID',Cities.CityName as 'Name' from Cities;
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_CreateChemist]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_CreateChemist]
@name nvarchar(50),
@surname nvarchar(50),
@mail nvarchar(100),
@password nvarchar(30),
@pharmacyName nvarchar(100)
as
begin
declare @isThereRecord int;
	select @isThereRecord = COUNT(Chemists.ID) from Chemists where Chemists.Mail=@mail;
	if(@isThereRecord > 0)--kayıt var
	begin
		return -1;--kayıt varsa 1 dönücek
	end
	else--kayıt yok
	begin
		insert into Chemists(Name,Surname,mail,Password,pharmacyName) values(@name,@surname,@mail,@password,@pharmacyName);
		return 1;--eleman kaydedilirse 0 geri dönücek
	end
end

GO
/****** Object:  StoredProcedure [dbo].[sp_createPatient]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_createPatient] 
@idNumber nvarchar(11),
@name nvarchar(50),
@surname nvarchar(55),
@mail nvarchar(100),
@password nvarchar(30),
@gender bit,
@phoneNumber nvarchar(30),
@birthdate date
as
begin
declare @isThereRecord int;
	select @isThereRecord = COUNT(Patients.ID) from Patients where Patients.mail=@mail;
	if(@isThereRecord > 0)--kayıt var
	begin
		return -1;--kayıt varsa 1 dönücek
	end
	else--kayıt yok
	begin
		insert into Patients(IdentificationNumber,Name,Surname,mail,Password,IsWomen,PhoneNumber,Birthdate) values(@idNumber,@name,@surname,@mail,@password,@gender,@phoneNumber,@birthdate);
		return 1;--eleman kaydedilirse 0 geri dönücek
	end
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorHour]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DoctorHour]
@mail nvarchar(100)
as 
begin
select * from Doctors,Hours where Doctors.DoctorMail=@mail
end


GO
/****** Object:  StoredProcedure [dbo].[Sp_FindChemistMail]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[Sp_FindChemistMail]
 
 @mail nvarchar(100)
as
begin
	select Chemists.Password from Chemists where Chemists.Mail = @mail;
end


GO
/****** Object:  StoredProcedure [dbo].[sp_findMail]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_findMail]
@mail nvarchar(100)
as
begin
	select Patients.Password from Patients where Patients.mail = @mail;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_FindPatientMail]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_FindPatientMail]
@mail nvarchar(100)
as
begin
	select Patients.Password from Patients where Patients.mail = @mail;
end


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrict]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetAllDistrict]
@CtyID int
as
begin
	select Districts.Id as 'DId',Districts.DistrictName as 'DName' from Districts where Districts.CityID=@CtyID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHoursOfDoctor]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllHoursOfDoctor]
@doctorsID int,
@datesDate date
as
begin
		select Hours.HourID as 'HourID' ,Hours.Time as 'time',DoctorHours.IsAvailable as 'Available' from Doctors,Hours,DoctorHours where Doctors.ID = DoctorHours.DoctorID and DoctorHours.HourID = Hours.HourID and Hours.HourID not IN (
select Hours.HourID from Dates,Doctors,Hours
 where 
	Dates.DoctorID = Doctors.ID and
	Dates.TimeID = Hours.HourID 
	 and Dates.DatesDate =@datesDate and Doctors.ID =@doctorsID) and Doctors.ID  =@doctorsID;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllPresscriptionByID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getAllPresscriptionByID]
@id int
as
begin
declare @presNumber int;
	
	select Dates.Id as 'DateID', Prescriptions.PrescriptionCode as 'Code',Prescriptions.PrescriptionDate as 'Date',Prescriptions.PrescriptionDescription as 'Description' from Dates,Patients,Prescriptions where Dates.PatientID = Patients.ID and Dates.Id = Prescriptions.DateID and Patients.ID=@id order by Date  desc;

end

GO
/****** Object:  StoredProcedure [dbo].[sp_getDateByPationID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE procedure [dbo].[sp_getDateByPationID]
  @id int 
  as
  begin
		select
			 Patients.ID as 'PID',
			 Dates.Id as 'DID',
			 Dates.DatesDate as 'DAtesDate',
			 Patients.IdentificationNumber as 'PatIdentification',
			 HospitalName as 'HosName',
			 Doctors.DoctorName as 'DocName',
			 Doctors.DoctorSurname as 'DocSurname',
			 Cities.CityName as 'CityName',
			 Districts.DistrictName as 'DistName' ,
			 Polyclinics.PolyclinicName as 'PolyName'
		from Dates,Patients,Doctors,Hospitals,Cities,Districts,Polyclinics 
		where 
			 Patients.ID = Dates.PatientID and
			 Dates.DoctorID = Doctors.ID and
			 Dates.HospitalID = Hospitals.Id and 
			 Dates.PolyclinicID = Polyclinics.Id and
			 Cities.Id=Districts.CityID and 
			 Districts.Id=Hospitals.DistrictID and 
		     Patients.ID = @id  order by DAtesDate desc;		
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_getDoctorByHospitalID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[sp_getDoctorByHospitalID]
 @hospID int
 as
 begin
	 select * from Doctors,HospitalPolyClinic,Polyclinics,Hospitals where 
		Hospitals.Id = HospitalPolyClinic.HospitalID and
		  HospitalPolyClinic.PolyClinicID = Polyclinics.Id and
			Doctors.HospitalPloyclinicID = HospitalPolyClinic.ID and Hospitals.Id=@hospID;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDoctorByPolyclinicID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[sp_GetDoctorByPolyclinicID]
 @polyClncID int
 as
 begin
	 select * from Doctors,HospitalPolyClinic,Polyclinics,Hospitals where 
		Hospitals.Id = HospitalPolyClinic.HospitalID and
		  HospitalPolyClinic.PolyClinicID = Polyclinics.Id and
			Doctors.HospitalPloyclinicID = HospitalPolyClinic.ID and Polyclinics.Id=@polyClncID;
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHospitalByDistrictID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetHospitalByDistrictID]
@distID int
as
begin
	select Hospitals.Id as 'HospID',Hospitals.HospitalName as 'HospName' from Hospitals where Hospitals.DistrictID = @distID;	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPolyclinicByHospitalID]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[sp_GetPolyclinicByHospitalID]
 @hosID int
 as
 begin
	select Polyclinics.Id as 'PolyclinicID',Polyclinics.PolyclinicName as 'PolyclicinName' from Polyclinics,HospitalPolyClinic,Hospitals 
		where Hospitals.Id = HospitalPolyClinic.HospitalID
		and HospitalPolyClinic.PolyClinicID = Polyclinics.Id and Hospitals.Id =@hosID;
 end
GO
/****** Object:  StoredProcedure [dbo].[Sp_LoginChemist]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Sp_LoginChemist]

@mail nvarchar(100),
@password nvarchar(30)
as
begin 
	
	select * from Chemists where Chemists.mail=@mail and Chemists.Password = @password;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LoginDoctor]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_LoginDoctor]
@mail nvarchar(100),
@password nvarchar(30)
as
begin 
	
	select * from Doctors where Doctors.DoctorMail =@mail and Doctors.DoctorPassword = @password;

end


GO
/****** Object:  StoredProcedure [dbo].[sp_LoginPatient]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_LoginPatient]
@mail nvarchar(100),
@password nvarchar(30)
as
begin 
	
	select * from Patients where Patients.mail =@mail and Patients.Password = @password;

end

GO
/****** Object:  StoredProcedure [dbo].[Sp_Prescriptionscode]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Prescriptionscode]
@code nvarchar(10)
as
begin
	select Patients.IdentificationNumber as 'IdentificationNumber', Prescriptions.DateID as 'DateID',Prescriptions.PrescriptionCode as 'Code',PrescriptionDescription as 'Description',Prescriptions.PrescriptionDate as 'Date' from Prescriptions,Patients,Dates where Prescriptions.DateID=Dates.Id and Dates.PatientID=Patients.ID and PrescriptionCode=@code;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePatientInformation]    Script Date: 12.10.2019 19:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UpdatePatientInformation]
@id int,
@name nvarchar(50),
@surname nvarchar(55),
@mail nvarchar(100),
@password nvarchar(30),
@phoneNumber nvarchar(30)

as
begin
	update Patients set Patients.Name=@name,Patients.Surname=@surname,Patients.mail=@mail,Patients.Password=@password,Patients.PhoneNumber=@phoneNumber where Patients.ID=@id;
end


GO
USE [master]
GO
ALTER DATABASE [HospitalDB] SET  READ_WRITE 
GO
