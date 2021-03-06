USE [master]
GO
/****** Object:  Database [SOHTS]    Script Date: 28.12.2017 22:43:13 ******/
CREATE DATABASE [SOHTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SOHTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SOHTS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SOHTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SOHTS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SOHTS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SOHTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SOHTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SOHTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SOHTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SOHTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SOHTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SOHTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SOHTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SOHTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SOHTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SOHTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SOHTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SOHTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SOHTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SOHTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SOHTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SOHTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SOHTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SOHTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SOHTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SOHTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SOHTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SOHTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SOHTS] SET RECOVERY FULL 
GO
ALTER DATABASE [SOHTS] SET  MULTI_USER 
GO
ALTER DATABASE [SOHTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SOHTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SOHTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SOHTS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SOHTS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SOHTS', N'ON'
GO
USE [SOHTS]
GO
/****** Object:  Table [dbo].[cikis]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cikis](
	[dosyaNo] [int] NOT NULL,
	[sevkTarihi] [datetime] NOT NULL,
	[cikisTarihi] [datetime] NULL,
	[odemeSekli] [nvarchar](50) NULL,
	[toplamTutar] [nchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hasta]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hasta](
	[TC] [int] NOT NULL,
	[dosyaNo] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[dogumYeri] [nvarchar](50) NULL,
	[dogumTarihi] [datetime] NULL,
	[babaAdi] [nvarchar](50) NULL,
	[anneAdi] [nvarchar](50) NULL,
	[cinsiyet] [nchar](10) NULL,
	[kanGrubu] [nchar](10) NULL,
	[telefonNo] [nvarchar](50) NULL,
	[adres] [nvarchar](255) NULL,
	[yakiniAdres] [nvarchar](255) NULL,
	[kurumSicilNo] [nvarchar](50) NULL,
	[kurumAdi] [nvarchar](50) NULL,
	[yakinTelefonNo] [nvarchar](50) NULL,
	[yakinKurumSicilNo] [nvarchar](50) NULL,
	[yakinKurumAdi] [nvarchar](50) NULL,
	[medeniHal] [nvarchar](50) NULL,
 CONSTRAINT [PK_hasta] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[islem]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[islem](
	[islemAdi] [nvarchar](50) NULL,
	[birimFiyat] [nchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kullaniciKod] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](20) NULL,
	[soyad] [nchar](20) NULL,
	[sifre] [nchar](20) NULL,
	[yetki] [nchar](20) NULL,
	[evTelefonNo] [nchar](20) NULL,
	[cepTelefonNo] [nchar](20) NULL,
	[adres] [nvarchar](255) NULL,
	[unvan] [nchar](20) NULL,
	[isBaslamaTarih] [datetime] NULL,
	[maas] [nchar](20) NULL,
	[dogumYeri] [nchar](20) NULL,
	[anneAd] [nchar](20) NULL,
	[babaAd] [nchar](20) NULL,
	[cinsiyet] [nchar](5) NULL,
	[kanGrubu] [nchar](10) NULL,
	[medeniHal] [nchar](10) NULL,
	[dogumTarihi] [datetime] NULL,
	[TC] [int] NULL,
	[userName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[poliklinik]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[poliklinik](
	[poliklinikAdi] [nvarchar](50) NOT NULL,
	[durum] [nvarchar](5) NULL,
	[aciklama] [nvarchar](255) NULL,
 CONSTRAINT [PK_poliklinik] PRIMARY KEY CLUSTERED 
(
	[poliklinikAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sevk]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sevk](
	[sevkTarihi] [datetime] NOT NULL,
	[dosyaNo] [int] NOT NULL,
	[poliklinik] [nvarchar](50) NULL,
	[saat] [nvarchar](20) NULL,
	[yapilanIslem] [nvarchar](50) NULL,
	[doktorKod] [char](10) NULL,
	[miktar] [char](3) NULL,
	[birimFiyat] [nchar](20) NULL,
	[sira] [nchar](10) NULL,
	[toplamTutar] [nvarchar](50) NULL,
	[taburcu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 20:54:07.000' AS DateTime), N'Nakit', N'30                  ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:38:27.000' AS DateTime), N'Kredi Kartı Peşin', N'30                  ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:38:27.000' AS DateTime), N'Kredi Kartı Peşin', N'30                  ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:39:34.000' AS DateTime), N'Kredi Kartı Peşin', N'30                  ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:48:21.000' AS DateTime), N'Kredi Kartı Taksitli', N'120                 ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (2, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:52:46.000' AS DateTime), N'Kredi Kartı Taksitli', N'100                 ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (2, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-28 21:55:43.000' AS DateTime), N'Kredi Kartı Taksitli', N'0                   ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (2, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-28 21:56:29.000' AS DateTime), N'Kredi Kartı Peşin', N'0                   ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (1, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:43:19.000' AS DateTime), N'Kredi Kartı Taksitli', N'30                  ')
INSERT [dbo].[cikis] ([dosyaNo], [sevkTarihi], [cikisTarihi], [odemeSekli], [toplamTutar]) VALUES (2, CAST(N'2017-12-26 00:00:00.000' AS DateTime), CAST(N'2017-12-27 21:49:08.000' AS DateTime), N'Çek', N'80                  ')
SET IDENTITY_INSERT [dbo].[hasta] ON 

INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (1111, 2, N'ads', N'', N'asd', CAST(N'2017-12-28 17:22:34.903' AS DateTime), N'asd', N'', N'          ', N'          ', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (2222, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (13123, 10, N'', N'', N'', CAST(N'2017-12-26 22:10:36.173' AS DateTime), N'qwe', N'qwe', N'          ', N'          ', N'', N'qwe', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (44444, 11, N'asdasd', N'asdas', N'asdasd', CAST(N'2017-12-27 17:30:50.000' AS DateTime), N'asdasd', N'', N'          ', N'          ', N'', N'asdasd', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (324234, 8, N'sdfsdf', N'fdsdf', N'', CAST(N'2017-12-26 22:07:28.373' AS DateTime), N'', N'', N'          ', N'          ', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (123123123, 9, N'', N'', N'', CAST(N'2017-12-27 17:40:42.763' AS DateTime), N'', N'', N'          ', N'          ', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([TC], [dosyaNo], [ad], [soyad], [dogumYeri], [dogumTarihi], [babaAdi], [anneAdi], [cinsiyet], [kanGrubu], [telefonNo], [adres], [yakiniAdres], [kurumSicilNo], [kurumAdi], [yakinTelefonNo], [yakinKurumSicilNo], [yakinKurumAdi], [medeniHal]) VALUES (1111111111, 1, N'mUSTAFA', N'A', N'asadasd', CAST(N'2017-12-07 00:28:45.000' AS DateTime), N'asd', N'', N'Erkek     ', N'0 Rh-     ', N'055555', N'xcvsdf', N'Yok', N'555', N'yokkkk', N'rrrr', N'', N'', N'Evli')
SET IDENTITY_INSERT [dbo].[hasta] OFF
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'A', N'10                  ')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'B', N'20                  ')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'asd', N'30                  ')
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (1, N'Mustafa             ', N'Ergec               ', N'123                 ', N'true                ', N'0222222             ', N'532222222           ', N'Konyaasdasdtcrfyvgbhunjımköl', N'Doktor              ', CAST(N'2017-10-05 00:00:00.000' AS DateTime), N'3000                ', N'Balıkesir           ', N'Kamile              ', N'Hüseyin             ', N'Erkek', N'          ', N'Bekar     ', CAST(N'1900-01-01 00:00:00.000' AS DateTime), 13000, N'ergec               ')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (2, N'Deneme              ', N'asdasdasd           ', N'123                 ', N'false               ', N'123                 ', N'13123               ', N'adres deneme123', N'Doktor              ', CAST(N'2017-12-04 17:16:31.000' AS DateTime), N'22                  ', N'asd                 ', N'asd                 ', N'asd                 ', N'Erkek', N'AB Rh-    ', N'Evli      ', CAST(N'2017-10-03 17:16:31.000' AS DateTime), 123456789, N'deneme              ')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (3, NULL, NULL, NULL, N'                    ', N'0222222             ', N'0222222             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'ass')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'muty')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (5, N'asdasd              ', N'asd                 ', N'                    ', N'true                ', N'                    ', N'                    ', N'', N'                    ', CAST(N'2017-12-28 21:45:10.000' AS DateTime), N'                    ', N'asd                 ', N'asd                 ', N'sad                 ', N'     ', N'          ', N'          ', CAST(N'2017-12-28 21:45:10.000' AS DateTime), 123, N'yyy                 ')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'qqq')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'asdas')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'asdasd')
INSERT [dbo].[kullanici] ([kullaniciKod], [ad], [soyad], [sifre], [yetki], [evTelefonNo], [cepTelefonNo], [adres], [unvan], [isBaslamaTarih], [maas], [dogumYeri], [anneAd], [babaAd], [cinsiyet], [kanGrubu], [medeniHal], [dogumTarihi], [TC], [userName]) VALUES (11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'')
SET IDENTITY_INSERT [dbo].[kullanici] OFF
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'cfvgbh', N'False', N'ghnjmk')
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'Deneme x', N'True', N'asdasd')
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'Poliklinik 1', N'False', N'kadir')
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'Poliklinik 2', N'false', N'sada')
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'sda', N'False', N'kkkk')
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'ttt', NULL, NULL)
INSERT [dbo].[poliklinik] ([poliklinikAdi], [durum], [aciklama]) VALUES (N'uuu', N'True', N'mcvb')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:48:48', N'B', N'2         ', N'6  ', N'20                  ', N'3         ', N'', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'', N'16:29:49', N'', N'          ', N'0  ', N'                    ', N'          ', N'', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 2, N'sda', N'16:51:08', N'asd', N'1         ', N'4  ', N'30                  ', N'3         ', N'', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:00.000' AS DateTime), 1, N'ttt', N'16:51:56', N'B', N'1         ', N'2  ', N'20                  ', N'2         ', N'', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 11, N'Poliklinik 1', N'17:31:24', N'A', N'2         ', N'4  ', N'10                  ', N'3         ', N'40', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Deneme x', N'21:45:25', N'asd', N'1         ', N'4  ', N'30                  ', N'3         ', N'120', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'22:56:10', N'B', N'1         ', N'5  ', N'20                  ', N'2         ', N'100', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'16:06:36', N'A', N'1         ', N'6  ', N'10                  ', N'5         ', N'60', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'16:09:56', N'B', N'2         ', N'3  ', N'20                  ', N'3         ', N'60', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'16:19:50', N'B', N'1         ', N'4  ', N'20                  ', N'2         ', N'80', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'17:41:37', N'B', N'2         ', N'1  ', N'20                  ', N'2         ', N'20', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 2, N'Deneme x', N'21:57:09', N'A', N'1         ', N'1  ', N'10                  ', N'5         ', N'10', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 11, N'Poliklinik 1', N'22:20:00', N'asd', N'2         ', N'1  ', N'30                  ', N'5         ', N'30', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:21:19', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:22:12', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:22:34', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:26:14', N'A', N'2         ', N'3  ', N'10                  ', N'2         ', N'', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:26:27', N'A', N'2         ', N'5  ', N'10                  ', N'2         ', N'30', N'Hayir')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Deneme x', N'16:28:06', N'A', N'2         ', N'5  ', N'10                  ', N'2         ', N'110', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Deneme x', N'17:15:09', N'A', N'1         ', N'1  ', N'10                  ', N'1         ', N'', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Deneme x', N'17:15:48', N'A', N'1         ', N'1  ', N'10                  ', N'1         ', N'10', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Deneme x', N'17:15:58', N'A', N'1         ', N'1  ', N'10                  ', N'1         ', N'20', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 2, N'Deneme x', N'21:48:55', N'A', N'1         ', N'3  ', N'10                  ', N'3         ', N'30', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 2, N'Poliklinik 2', N'21:52:20', N'A', N'1         ', N'10 ', N'10                  ', N'6         ', N'100', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.627' AS DateTime), 0, N'', N'22:11:21', N'A', N'          ', N'0  ', N'10                  ', N'          ', N'', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Poliklinik 1', N'16:32:48', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Poliklinik 1', N'16:32:57', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'50', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Poliklinik 1', N'16:33:28', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'100', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 22:11:10.000' AS DateTime), 1, N'Poliklinik 1', N'16:33:32', N'A', N'1         ', N'5  ', N'10                  ', N'2         ', N'150', N'')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 2, N'Poliklinik 1', N'21:51:18', N'B', N'2         ', N'5  ', N'20                  ', N'6         ', N'100', N'Evet')
INSERT [dbo].[sevk] ([sevkTarihi], [dosyaNo], [poliklinik], [saat], [yapilanIslem], [doktorKod], [miktar], [birimFiyat], [sira], [toplamTutar], [taburcu]) VALUES (CAST(N'2017-12-26 00:00:00.000' AS DateTime), 1, N'Poliklinik 1', N'17:25:53', N'asd', N'1         ', N'9  ', N'30                  ', N'99        ', N'', N'Evet')
/****** Object:  StoredProcedure [dbo].[hasta_bilgileri_update]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hasta_bilgileri_update](
	@DosyaNo int,
	@Ad nvarchar(50) = "NULL",
	@Soyad nvarchar(50) = "NULL",
	@DogumYeri nvarchar(50) = "NULL",
	@DogumTarihi datetime,
	@BabaAd nvarchar(50) = "NULL",
	@AnneAd nvarchar(50) = "NULL",
	@Cinsiyet nvarchar(50) = "NULL",
	@KanGrubu nvarchar(50) = "NULL",
	@telNo nvarchar(50) = "NULL",
	@Adres nvarchar(50) = "NULL",
	@yakinAdres nvarchar(50) = "NULL",
	@KrumScilNo nvarchar(50) = "NULL",
	@KrumAd nvarchar(50) = "NULL",
	@YakinTelNo nvarchar(50) = "NULL",
	@YakinKurumSicilNo nvarchar(50) = "NULL",
	@YakinKurumAd nvarchar(50) = "NULL",
	@TC nvarchar(50) = "NULL",
	@MedeniHal nvarchar(50) = "NULL"
)
AS
BEGIN

UPDATE hasta SET ad=@Ad,soyad=@Soyad,dogumYeri=@DogumYeri,dogumTarihi=@DogumTarihi,babaAdi=@BabaAd,anneAdi=@AnneAd,
cinsiyet=@Cinsiyet,kanGrubu=@KanGrubu,telefonNo=@telNo,adres=@Adres,yakiniAdres=@yakinAdres,kurumSicilNo=@KrumScilNo,kurumAdi=@KrumAd,
yakinTelefonNo=@YakinTelNo,yakinKurumSicilNo=@YakinKurumSicilNo,yakinKurumAdi=@YakinKurumAd,TC=@TC,medeniHal=@MedeniHal
WHERE dosyaNo=@DosyaNo AND TC=@TC
END


GO
/****** Object:  StoredProcedure [dbo].[hasta_cikis_veri_kayit]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hasta_cikis_veri_kayit](
		@dosya_no int,
		@sevk_tarih datetime,
		@cikis_tarihi datetime,
		@odeme_sekli nvarchar(20) ="NULL",
		@toplam_tutar nvarchar(20) ="NULL",
		@taburcu nvarchar(20) ="Hayir"
)
AS
BEGIN

INSERT INTO dbo.cikis VALUES (@dosya_no,@sevk_tarih,@cikis_tarihi,@odeme_sekli,@toplam_tutar)
Update dbo.sevk SET taburcu=@taburcu WHERE dosyaNo=@dosya_no AND sevkTarihi=@sevk_tarih

END
GO
/****** Object:  StoredProcedure [dbo].[hasta_islemleri_secileni_sil]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hasta_islemleri_secileni_sil](
	@dosyaNo int,
	@poliklinik nvarchar(50) ,
	@saat nvarchar(20),
	@yapilanislem nvarchar(50),
	@doktorKod nvarchar(10) ,
	@miktar nvarchar(10),
	@birimFiyat nvarchar(10) ,
	@sira nvarchar(10) 
)
AS
BEGIN

DELETE FROM sevk WHERE dosyaNo=@dosyaNo AND poliklinik=@poliklinik AND saat=@saat AND yapilanIslem=@yapilanislem AND doktorKod=@doktorKod
AND miktar=@miktar AND birimFiyat=@birimFiyat and sira=@sira

END
GO
/****** Object:  StoredProcedure [dbo].[hasta_islemleri_secileni_sil_V2]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hasta_islemleri_secileni_sil_V2](
	@dosyaNo int,
	@poliklinik nvarchar(50) ,
	@saat nvarchar(20)
)
as
begin
DELETE FROM sevk WHERE dosyaNo=@dosyaNo AND poliklinik=@poliklinik AND saat=@saat
end
GO
/****** Object:  StoredProcedure [dbo].[kullanici_kullaniciSil]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[kullanici_kullaniciSil](
	@KullaniciKod nchar(40)
)
AS
BEGIN
DELETE FROM kullanici WHERE kullaniciKod=@KullaniciKod
END
GO
/****** Object:  StoredProcedure [dbo].[kullanici_tanitma_update_islem]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[kullanici_tanitma_update_islem](

 @KullaniciKod int ="NULL", 
 @TC int ="NULL",
 @DogumYeri nchar(20) ="NULL",
 @BabaAd nchar(20) ="NULL",
 @AnneAd nchar(20) ="NULL",
 @CepTel nchar(20) ="NULL",
 @EvTel nchar(20) ="NULL",
 @Ad nchar(20) ="NULL",
 @Soyad nchar(20) ="NULL",
 @Maas nchar(20) ="NULL",
 @isBaslama datetime ="NULL",
 @DogumTarihi datetime ="NULL",
 @Cinsiyet nchar(20) ="NULL",
 @MedeniHal nchar(20) ="NULL",
 @KanGrubu nchar(20) ="NULL",
 @Unvan nchar(20) ="NULL",
 @Adres nvarchar(255) ="NULL",
 @userName nchar(20) ="NULL",
 @SifreKullanici nchar(20) ="NULL",
 @yetki_durumu nchar(20)  ="NULL"
)
AS
BEGIN
UPDATE kullanici SET TC=@TC,dogumYeri=@DogumYeri,babaAd=@BabaAd,anneAd=@AnneAd,cepTelefonNo=@CepTel,evTelefonNo=@EvTel,ad=@Ad,soyad=@Soyad,
maas=@Maas,isBaslamaTarih=@isBaslama,dogumTarihi=@DogumTarihi,cinsiyet=@Cinsiyet,medeniHal=@MedeniHal,kanGrubu=@KanGrubu,
unvan=@Unvan,adres=@Adres,userName=@userName,sifre=@SifreKullanici,yetki=@yetki_durumu
WHERE kullaniciKod=@KullaniciKod
END
GO
/****** Object:  StoredProcedure [dbo].[poliklinik_sil]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[poliklinik_sil]
(
	@PoliklinikAd nvarchar(100)
)
AS
BEGIN
DELETE FROM [SOHTS].[dbo].[poliklinik] WHERE poliklinikAdi=@PoliklinikAd
END

GO
/****** Object:  StoredProcedure [dbo].[poliklinik_update]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[poliklinik_update]
(
	@Aciklama nvarchar(255),
	@Durum nvarchar(50),
	@Poliklinik nvarchar(100)
)
AS
BEGIN
UPDATE poliklinik SET poliklinikAdi= @Poliklinik, durum=@Durum,aciklama=@Aciklama WHERE poliklinikAdi=@Poliklinik
END

GO
/****** Object:  StoredProcedure [dbo].[sevk_veri_ekleme_v2]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sevk_veri_ekleme_v2](
	@sevk_tarih datetime,
	@dosyaNo int ="NULL",
	@poliklinik nvarchar(50) ="NULL",
	@saat nvarchar(20) ="NULL",
	@yapilanislem nvarchar(50) ="NULL",
	@doktorKod nvarchar(10) ="NULL",
	@miktar nvarchar(10) ="NULL",
	@birimFiyat nvarchar(10) ="NULL",
	@sira nvarchar(10) ="NULL",
	@toplamTutar nvarchar(10)="NULL",
	@taburcu nvarchar(10) ="Hayir"
)
AS
BEGIN

INSERT INTO SOHTS.dbo.sevk ( sevkTarihi,dosyaNo,poliklinik,saat,yapilanIslem,doktorKod,miktar,birimFiyat,sira,toplamTutar,taburcu ) VALUES (@sevk_tarih,@dosyaNo,@poliklinik,@saat,@yapilanislem,@doktorKod,@miktar,@birimFiyat,@sira,@toplamTutar,@taburcu);

END
GO
/****** Object:  StoredProcedure [dbo].[yeni_hasta_kayit]    Script Date: 28.12.2017 22:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[yeni_hasta_kayit](
	@Ad nvarchar(50) = "NULL",
	@Soyad nvarchar(50) = "NULL",
	@DogumYeri nvarchar(50) = "NULL",
	@DogumTarihi datetime,
	@BabaAd nvarchar(50) = "NULL",
	@AnneAd nvarchar(50) = "NULL",
	@Cinsiyet nvarchar(50) = "NULL",
	@KanGrubu nvarchar(50) = "NULL",
	@telNo nvarchar(50) = "NULL",
	@Adres nvarchar(50) = "NULL",
	@yakinAdres nvarchar(50) = "NULL",
	@KrumScilNo nvarchar(50) = "NULL",
	@KrumAd nvarchar(50) = "NULL",
	@YakinTelNo nvarchar(50) = "NULL",
	@YakinKurumSicilNo nvarchar(50) = "NULL",
	@YakinKurumAd nvarchar(50) = "NULL",
	@TC nvarchar(50) = "NULL",
	@MedeniHal nvarchar(50) = "NULL"
)
AS
BEGIN
INSERT INTO hasta (TC,ad,soyad,dogumYeri,dogumTarihi,babaAdi,anneAdi,cinsiyet,kanGrubu,telefonNo,adres,yakiniAdres,kurumSicilNo,kurumAdi,yakinTelefonNo,yakinKurumSicilNo,yakinKurumAdi,medeniHal ) VALUES (@TC,@Ad,@Soyad,@DogumYeri,@DogumTarihi,@BabaAd,@AnneAd,@Cinsiyet,@KanGrubu,@telNo,@Adres,@yakinAdres,@YakinKurumSicilNo,@KrumAd,@YakinTelNo,@YakinKurumSicilNo,@YakinKurumAd,@MedeniHal)
END
GO
USE [master]
GO
ALTER DATABASE [SOHTS] SET  READ_WRITE 
GO
