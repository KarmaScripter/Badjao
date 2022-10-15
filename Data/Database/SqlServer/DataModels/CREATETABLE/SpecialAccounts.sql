USE [Data]
GO

/****** Object:  Table [dbo].[SpecialAccounts]    Script Date: 8/21/2022 1:50:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialAccounts]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialAccounts]
GO

/****** Object:  Table [dbo].[SpecialAccounts]    Script Date: 8/21/2022 1:50:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpecialAccounts](
	[SpecialAccountsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[SpecialAccountFund] [nvarchar](80) NULL,
	[SpecialAccountNumber] [nvarchar](80) NULL,
	[SpecialAccountName] [nvarchar](80) NULL,
	[AccountStatus] [nvarchar](80) NULL,
	[NplStatusCode] [nvarchar](80) NULL,
	[NplStatusName] [nvarchar](80) NULL,
	[SiteId] [nvarchar](80) NULL,
	[CerclisId] [nvarchar](80) NULL,
	[SiteCode] [nvarchar](80) NULL,
	[SiteName] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[PipelineCode] [nvarchar](80) NULL,
	[PipelineDescription] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[TransactionType] [nvarchar](80) NULL,
	[TransactionTypeName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[TransactionDate] [datetime] NULL,
	[AvailableBalance] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Disbursements] [decimal](18, 0) NULL,
	[UnpaidBalances] [decimal](18, 0) NULL,
	[Collections] [decimal](18, 0) NULL,
	[CumulativeReceipts] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SpecialAccounts] PRIMARY KEY CLUSTERED 
(
	[SpecialAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

