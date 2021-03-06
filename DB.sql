USE [CoreInventory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20-Nov-19 6:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Territory]    Script Date: 20-Nov-19 6:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Territory](
	[TerritoryID] [int] IDENTITY(1,1) NOT NULL,
	[TerritoryName] [varchar](50) NOT NULL,
	[Note] [varchar](100) NULL,
	[EnteredBy] [varchar](50) NOT NULL,
	[EStatus] [bit] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[TerritoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Territory] ON 

INSERT [dbo].[Territory] ([TerritoryID], [TerritoryName], [Note], [EnteredBy], [EStatus]) VALUES (1, N'Agrabad mor', N'DOE', N'Faruk', 1)
INSERT [dbo].[Territory] ([TerritoryID], [TerritoryName], [Note], [EnteredBy], [EStatus]) VALUES (2, N'TerritoryName', N'Note', N'Enterdby', 1)
SET IDENTITY_INSERT [dbo].[Territory] OFF
