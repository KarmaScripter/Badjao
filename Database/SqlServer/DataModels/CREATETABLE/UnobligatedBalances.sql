USE [Data]
GO

/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 8/21/2022 1:53:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnobligatedBalances]') AND type in (N'U'))
DROP TABLE [dbo].[UnobligatedBalances]
GO

/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 8/21/2022 1:53:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UnobligatedBalances](
	[UnobligatedBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AccountNumber] [nvarchar](80) NULL,
	[AccountName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_UnobligatedBalances] PRIMARY KEY CLUSTERED 
(
	[UnobligatedBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

