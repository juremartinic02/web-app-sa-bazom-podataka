USE [MojaPrvaBaza]
GO
/****** Object:  Table [dbo].[Zivotinje]    Script Date: 6/27/2020 11:24:04 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Zivotinje]') AND type in (N'U'))
DROP TABLE [dbo].[Zivotinje]
GO
/****** Object:  Table [dbo].[Osobe]    Script Date: 6/27/2020 11:24:04 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Osobe]') AND type in (N'U'))
DROP TABLE [dbo].[Osobe]
GO
/****** Object:  Table [dbo].[Osobe]    Script Date: 6/27/2020 11:24:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Osobe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](100) NOT NULL,
	[Prezime] [nvarchar](200) NOT NULL,
	[Godiste] [int] NULL,
	[Tezina] [decimal](5, 2) NULL,
	[Visina] [int] NULL,
 CONSTRAINT [PK_Osobe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zivotinje]    Script Date: 6/27/2020 11:24:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zivotinje](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Vrsta] [nvarchar](50) NOT NULL,
	[Pasmina] [nvarchar](50) NULL,
	[Tezina] [decimal](5, 2) NULL,
 CONSTRAINT [PK_Zivotinje] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
