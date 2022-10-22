USE [Data]
GO

/****** Object:  Table [dbo].[GsPayScales]    Script Date: 8/21/2022 1:23:53 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GsPayScales]') AND type in (N'U'))
DROP TABLE [dbo].[GsPayScales]
GO

/****** Object:  Table [dbo].[GsPayScales]    Script Date: 8/21/2022 1:23:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GsPayScales](
	[GsPayScalesId] [int] IDENTITY(1,1) NOT NULL,
	[LOCNAME] [nvarchar](80) NULL,
	[GRADE] [float] NULL,
	[ANNUAL1] [float] NULL,
	[HOURLY1] [nvarchar](80) NULL,
	[OVERTIME1] [nvarchar](80) NULL,
	[ANNUAL2] [float] NULL,
	[HOURLY2] [nvarchar](80) NULL,
	[OVERTIME2] [nvarchar](80) NULL,
	[ANNUAL3] [float] NULL,
	[HOURLY3] [nvarchar](80) NULL,
	[OVERTIME3] [nvarchar](80) NULL,
	[ANNUAL4] [float] NULL,
	[HOURLY4] [nvarchar](80) NULL,
	[OVERTIME4] [nvarchar](80) NULL,
	[ANNUAL5] [float] NULL,
	[HOURLY5] [nvarchar](80) NULL,
	[OVERTIME5] [nvarchar](80) NULL,
	[ANNUAL6] [float] NULL,
	[HOURLY6] [nvarchar](80) NULL,
	[OVERTIME6] [nvarchar](80) NULL,
	[ANNUAL7] [float] NULL,
	[HOURLY7] [nvarchar](80) NULL,
	[OVERTIME7] [nvarchar](80) NULL,
	[ANNUAL8] [float] NULL,
	[HOURLY8] [nvarchar](80) NULL,
	[OVERTIME8] [nvarchar](80) NULL,
	[ANNUAL9] [float] NULL,
	[HOURLY9] [nvarchar](80) NULL,
	[OVERTIME9] [nvarchar](80) NULL,
	[ANNUAL10] [float] NULL,
	[HOURLY10] [nvarchar](80) NULL,
	[OVERTIME10] [nvarchar](80) NULL,
 CONSTRAINT [PK_GsPayScales] PRIMARY KEY CLUSTERED 
(
	[GsPayScalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

