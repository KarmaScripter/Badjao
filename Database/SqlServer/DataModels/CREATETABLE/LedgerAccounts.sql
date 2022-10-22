USE [Data]
GO

/****** Object:  Table [dbo].[LedgerAccounts]    Script Date: 8/21/2022 1:25:23 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LedgerAccounts]') AND type in (N'U'))
DROP TABLE [dbo].[LedgerAccounts]
GO

/****** Object:  Table [dbo].[LedgerAccounts]    Script Date: 8/21/2022 1:25:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LedgerAccounts](
	[LedgerAccountsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[AccountNumber] [nvarchar](80) NULL,
	[AccountName] [nvarchar](80) NULL,
	[BeginningBalance] [decimal](18, 0) NULL,
	[CreditBalance] [decimal](18, 0) NULL,
	[DebitBalance] [decimal](18, 0) NULL,
	[ClosingAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_LedgerAccounts] PRIMARY KEY CLUSTERED 
(
	[LedgerAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

