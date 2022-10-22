USE [Data]
GO

/****** Object:  Table [dbo].[AnnualReimbursableSurvey]    Script Date: 8/21/2022 12:59:49 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnnualReimbursableSurvey]') AND type in (N'U'))
DROP TABLE [dbo].[AnnualReimbursableSurvey]
GO

/****** Object:  Table [dbo].[AnnualReimbursableSurvey]    Script Date: 8/21/2022 12:59:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AnnualReimbursableSurvey](
	[AnnualReimbursableSurveyId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [AnnualReimbursableSurveyPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AnnualReimbursableSurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

