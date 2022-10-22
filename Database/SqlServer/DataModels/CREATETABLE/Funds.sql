USE [Data]
GO

/****** Object:  Table [dbo].[Funds]    Script Date: 8/21/2022 1:22:18 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Funds]') AND type in (N'U'))
DROP TABLE [dbo].[Funds]
GO

/****** Object:  Table [dbo].[Funds]    Script Date: 8/21/2022 1:22:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Funds](
	[FundsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ShortName] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[SubLevelPrefix] [nvarchar](80) NULL,
	[ATA] [nvarchar](80) NULL,
	[AID] [nvarchar](80) NULL,
	[BeginningPeriodOfAvailability] [nvarchar](80) NULL,
	[EndingPeriodOfAvailability] [nvarchar](80) NULL,
	[A] [nvarchar](80) NULL,
	[MAIN] [nvarchar](80) NULL,
	[SUB] [nvarchar](80) NULL,
	[FundCategory] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[FundGroup] [nvarchar](80) NULL,
	[NoYear] [nvarchar](80) NULL,
	[Carryover] [nvarchar](80) NULL,
	[AllowSpendAgainstCanceled] [nvarchar](80) NULL,
	[AllowNewSpendAgainstExpired] [nvarchar](80) NULL,
	[CanceledYearSpendingAccount] [nvarchar](80) NULL,
	[ApplyAtAllLevels] [nvarchar](80) NULL,
	[BatsFund] [nvarchar](80) NULL,
	[BatsEndDate] [nvarchar](80) NULL,
	[BatsOptionId] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
 CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED 
(
	[FundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

