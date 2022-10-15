USE [Data]
GO

/****** Object:  Table [dbo].[CompassOutlays]    Script Date: 8/21/2022 1:10:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CompassOutlays]') AND type in (N'U'))
DROP TABLE [dbo].[CompassOutlays]
GO

/****** Object:  Table [dbo].[CompassOutlays]    Script Date: 8/21/2022 1:10:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CompassOutlays](
	[CompassOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[TotalObligations] [decimal](18, 0) NULL,
	[UnliquidatedObligations] [decimal](18, 0) NULL,
	[ObligationsPaid] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CompassOutlays] PRIMARY KEY CLUSTERED 
(
	[CompassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

