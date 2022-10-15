USE [Data]
GO

/****** Object:  Table [dbo].[Obligations]    Script Date: 8/21/2022 1:31:05 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obligations]') AND type in (N'U'))
DROP TABLE [dbo].[Obligations]
GO

/****** Object:  Table [dbo].[Obligations]    Script Date: 8/21/2022 1:31:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Obligations](
	[ObligationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [decimal](18, 0) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Expenditures] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Obligations] PRIMARY KEY CLUSTERED 
(
	[ObligationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

