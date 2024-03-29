USE [RANDEVUDB]
GO
/****** Object:  Table [dbo].[doktor]    Script Date: 1.01.2022 20:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktor](
	[DOKTORID] [int] NULL,
	[KLINIKID] [int] NULL,
	[DOKTORADSOYAD] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hasta]    Script Date: 1.01.2022 20:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hasta](
	[TC] [varchar](50) NOT NULL,
	[ADI] [varchar](30) NULL,
	[SOYADI] [varchar](30) NULL,
	[CINSIYETI] [varchar](50) NULL,
	[DOGUMYERI] [varchar](20) NULL,
	[DOGUMTARIHI] [varchar](50) NULL,
	[BABAAD] [varchar](30) NULL,
	[ANNEAD] [varchar](30) NULL,
	[CEPTEL] [varchar](30) NULL,
	[EPOSTA] [varchar](40) NULL,
	[PAROLA] [varchar](50) NULL,
 CONSTRAINT [PK_HASTA] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[iller]    Script Date: 1.01.2022 20:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[iller](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sehir] [nvarchar](255) NULL,
 CONSTRAINT [PK_iller] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[klinik]    Script Date: 1.01.2022 20:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[klinik](
	[KLINIKID] [int] NOT NULL,
	[KLINIKAD] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevular]    Script Date: 1.01.2022 20:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevular](
	[RANDAVUİD] [int] IDENTITY(1,1) NOT NULL,
	[TC] [varchar](11) NULL,
	[KLİNİKADİ] [int] NULL,
	[DOKTORADİ] [varchar](50) NULL,
	[TARİH] [varchar](50) NULL,
	[SAAT] [varchar](50) NULL,
 CONSTRAINT [PK_randavular] PRIMARY KEY CLUSTERED 
(
	[RANDAVUİD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (1, 1, N'Abdulkadir Eraslan')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (2, 1, N'Ahmet Maraba')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (3, 2, N'Furkan Aydin')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (4, 3, N'Enes Demir')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (5, 4, N'İsmail Karatay')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (6, 5, N'Fatma Maraba')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (7, 6, N'Hüseyin Osmanoğlu')
INSERT [dbo].[doktor] ([DOKTORID], [KLINIKID], [DOKTORADSOYAD]) VALUES (8, 7, N'Aleyna Demir')
GO
INSERT [dbo].[hasta] ([TC], [ADI], [SOYADI], [CINSIYETI], [DOGUMYERI], [DOGUMTARIHI], [BABAAD], [ANNEAD], [CEPTEL], [EPOSTA], [PAROLA]) VALUES (N'01234567891', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'0123')
INSERT [dbo].[hasta] ([TC], [ADI], [SOYADI], [CINSIYETI], [DOGUMYERI], [DOGUMTARIHI], [BABAAD], [ANNEAD], [CEPTEL], [EPOSTA], [PAROLA]) VALUES (N'11111111111', N'111111111', N'11111111', N'Erkek', N'111111111111', N'11.11.1111', N'11111', N'1111111', N'(111) 111-11', N'11111111', N'1111111111')
INSERT [dbo].[hasta] ([TC], [ADI], [SOYADI], [CINSIYETI], [DOGUMYERI], [DOGUMTARIHI], [BABAAD], [ANNEAD], [CEPTEL], [EPOSTA], [PAROLA]) VALUES (N'14351997650', N'Abdulkadir', N'Eraslan', N'Erkek', N'Erzurum', N'05.09.1999', N'Veyis', N'Aynur', N'(553) 915-5761', N'A@hotmail.com', N'1234')
INSERT [dbo].[hasta] ([TC], [ADI], [SOYADI], [CINSIYETI], [DOGUMYERI], [DOGUMTARIHI], [BABAAD], [ANNEAD], [CEPTEL], [EPOSTA], [PAROLA]) VALUES (N'14351997651', N'denem', N'denemee', N'Kadın', N'Hatay', N'01.02.2002', N'hasan', N'aysel', N'(554) 265-8749', N'as@gmail.com', N'1234')
GO
SET IDENTITY_INSERT [dbo].[iller] ON 

INSERT [dbo].[iller] ([id], [sehir]) VALUES (1, N'ADANA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (3, N'AFYON')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (4, N'AĞRI')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (5, N'AMASYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (6, N'ANKARA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (7, N'ANTALYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (8, N'ARTVİN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (9, N'AYDIN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (11, N'BİLECİK')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (13, N'BİTLİS')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (14, N'BOLU')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (15, N'BURDUR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (16, N'BURSA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (19, N'ÇORUM')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (22, N'EDİRNE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (25, N'ERZURUM')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (28, N'GİRESUN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (31, N'HATAY')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (32, N'ISPARTA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (33, N'İÇEL')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (35, N'İZMİR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (36, N'KARS')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (42, N'KONYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (44, N'MALATYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (45, N'MANİSA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (47, N'MARDİN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (48, N'MUĞLA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (49, N'MUŞ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (51, N'NİĞDE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (52, N'ORDU')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (53, N'RİZE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (54, N'SAKARYA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (55, N'SAMSUN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (56, N'SİİRT')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (57, N'SİNOP')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (58, N'SİVAS')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (60, N'TOKAT')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (61, N'TRABZON')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (64, N'UŞAK')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (65, N'VAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (66, N'YOZGAT')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (68, N'AKSARAY')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (69, N'BAYBURT')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (70, N'KARAMAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (72, N'BATMAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (74, N'BARTIN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (76, N'IĞDIR')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (77, N'YALOVA')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (78, N'KARABÜK')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (79, N'KİLİS')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[iller] ([id], [sehir]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[iller] OFF
GO
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (1, N'Başhekim')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (2, N'Deri Ve Zührevi Hastalıkları (Cildiye)')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (3, N'Enfeksiyon Hastalıkları')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (4, N'Fizik Tedavi Ve Rehabilitasyon')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (5, N'Genel Cerrahi')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (6, N'Göğüs Cerrahisi')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (7, N'İç Hastalıkları (Dahiliye)')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (8, N'Kadın Hastalıkları ve Doğum')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (9, N'Kalp ve Damar Cerrahisi')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (10, N'Kardiyoloji')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (11, N'Kulak Burun Boğaz Hastalıkları')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (12, N'Nöroloji')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (13, N'Ortopedi Ve Travmatoloji')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (14, N'Ruh Sağlığı Ve Hastalıkları (Psikiyatri)')
INSERT [dbo].[klinik] ([KLINIKID], [KLINIKAD]) VALUES (15, N'Üroloji')
GO
