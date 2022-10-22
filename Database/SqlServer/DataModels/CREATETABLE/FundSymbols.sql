USE [Data]
GO

/****** Object:  Table [dbo].[FundSymbols]    Script Date: 8/21/2022 1:22:27 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FundSymbols]') AND type in (N'U'))
DROP TABLE [dbo].[FundSymbols]
GO

/****** Object:  Table [dbo].[FundSymbols]    Script Date: 8/21/2022 1:22:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FundSymbols](
	[FundSymbolsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
 CONSTRAINT [PK_FundSymbols] PRIMARY KEY CLUSTERED 
(
	[FundSymbolsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

