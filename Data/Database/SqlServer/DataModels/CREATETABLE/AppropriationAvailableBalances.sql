USE [Data]
GO

/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 8/21/2022 1:01:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppropriationAvailableBalances]') AND type in (N'U'))
DROP TABLE [dbo].[AppropriationAvailableBalances]
GO

/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 8/21/2022 1:01:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AppropriationAvailableBalances](
	[AppropriationAvailableBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AppropriationFundCode] [nvarchar](80) NULL,
	[AppropriationFundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[TotalUsed] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
 CONSTRAINT [AppropriationAvailableBalancesPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AppropriationAvailableBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

