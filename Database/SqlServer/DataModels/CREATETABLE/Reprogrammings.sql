USE [Data]
GO

/****** Object:  Table [dbo].[Reprogrammings]    Script Date: 8/21/2022 1:48:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reprogrammings]') AND type in (N'U'))
DROP TABLE [dbo].[Reprogrammings]
GO

/****** Object:  Table [dbo].[Reprogrammings]    Script Date: 8/21/2022 1:48:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reprogrammings](
	[ReprogrammingsId] [int] IDENTITY(1,1) NOT NULL,
	[DocPrefix] [nvarchar](80) NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[DocType] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[FromTo] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Purpose] [nvarchar](max) NULL,
	[ExtendedPurpose] [nvarchar](max) NULL,
	[ResourceType] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Reprogrammings] PRIMARY KEY CLUSTERED 
(
	[ReprogrammingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

