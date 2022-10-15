USE [Data]
GO

/****** Object:  Table [dbo].[MonthlyOutlays]    Script Date: 8/21/2022 1:25:57 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MonthlyOutlays]') AND type in (N'U'))
DROP TABLE [dbo].[MonthlyOutlays]
GO

/****** Object:  Table [dbo].[MonthlyOutlays]    Script Date: 8/21/2022 1:25:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MonthlyOutlays](
	[MonthlyOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineTitle] [nvarchar](80) NULL,
	[TaxationCode] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[SubAccount] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AgencySequence] [nvarchar](80) NULL,
	[BureauSequence] [nvarchar](80) NULL,
	[AccountSequence] [nvarchar](80) NULL,
	[AgencyTitle] [nvarchar](80) NULL,
	[BureauTitle] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[October] [decimal](18, 0) NULL,
	[November] [decimal](18, 0) NULL,
	[December] [decimal](18, 0) NULL,
	[January] [decimal](18, 0) NULL,
	[Feburary] [decimal](18, 0) NULL,
	[March] [decimal](18, 0) NULL,
	[April] [decimal](18, 0) NULL,
	[May] [decimal](18, 0) NULL,
	[June] [decimal](18, 0) NULL,
	[July] [decimal](18, 0) NULL,
	[August] [decimal](18, 0) NULL,
	[September] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MonthlyOutlays] PRIMARY KEY CLUSTERED 
(
	[MonthlyOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

