USE [Data]
GO

/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 8/21/2022 1:25:46 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MonthlyLedgerAccountBalances]') AND type in (N'U'))
DROP TABLE [dbo].[MonthlyLedgerAccountBalances]
GO

/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 8/21/2022 1:25:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MonthlyLedgerAccountBalances](
	[MonthlyLedgerAccountBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[LedgerAccount] [nvarchar](80) NULL,
	[LedgerName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[TreasurySymbolName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalMonth] [nvarchar](80) NULL,
	[CreditBalance] [decimal](18, 0) NULL,
	[DebitBalance] [decimal](18, 0) NULL,
	[YearToDateAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MonthlyLedgerAccountBalances] PRIMARY KEY CLUSTERED 
(
	[MonthlyLedgerAccountBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

