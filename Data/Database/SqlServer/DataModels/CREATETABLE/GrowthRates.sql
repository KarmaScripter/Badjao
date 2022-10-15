USE [Data]
GO

/****** Object:  Table [dbo].[GrowthRates]    Script Date: 8/21/2022 1:22:45 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GrowthRates]') AND type in (N'U'))
DROP TABLE [dbo].[GrowthRates]
GO

/****** Object:  Table [dbo].[GrowthRates]    Script Date: 8/21/2022 1:22:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GrowthRates](
	[GrowthRatesId] [int] NOT NULL,
	[RateId] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPTION] [nvarchar](80) NULL,
	[BudgetYearRate] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
	[Sort] [nvarchar](80) NULL,
 CONSTRAINT [PK_GrowthRates] PRIMARY KEY CLUSTERED 
(
	[GrowthRatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

