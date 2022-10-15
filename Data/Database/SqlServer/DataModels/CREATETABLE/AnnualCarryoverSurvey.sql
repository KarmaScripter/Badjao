USE [Data]
GO

/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 8/21/2022 12:58:59 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnnualCarryoverSurvey]') AND type in (N'U'))
DROP TABLE [dbo].[AnnualCarryoverSurvey]
GO

/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 8/21/2022 12:58:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AnnualCarryoverSurvey](
	[AnnualCarryoverSurveyId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [AnnualCarryoverSurveyPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AnnualCarryoverSurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

