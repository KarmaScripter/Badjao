USE [Data]
GO

/****** Object:  Table [dbo].[SpendingRates]    Script Date: 8/21/2022 1:50:15 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpendingRates]') AND type in (N'U'))
DROP TABLE [dbo].[SpendingRates]
GO

/****** Object:  Table [dbo].[SpendingRates]    Script Date: 8/21/2022 1:50:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpendingRates](
	[SpendingRatesId] [int] IDENTITY(1,1) NOT NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbAgencyName] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbBureauName] [nvarchar](80) NULL,
	[TreausuryAgencyCode] [nvarchar](80) NULL,
	[TreausuryAccountCode] [nvarchar](80) NULL,
	[TreausuryAccountName] [nvarchar](80) NULL,
	[AccountTitle] [nvarchar](80) NULL,
	[Subfunction] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[Category] [nvarchar](80) NULL,
	[Subcategory] [nvarchar](80) NULL,
	[SubcategoryName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[Jurisdiction] [nvarchar](80) NULL,
	[YearOfAuthority] [nvarchar](80) NULL,
	[BudgetAuthority] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
	[OutYear10] [decimal](18, 0) NULL,
	[OutYear11] [decimal](18, 0) NULL,
	[TotalSpendout] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SpendingRates] PRIMARY KEY CLUSTERED 
(
	[SpendingRatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

