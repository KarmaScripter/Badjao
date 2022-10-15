USE [Data]
GO

/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 8/21/2022 1:25:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobsActCarryoverEstimates]') AND type in (N'U'))
DROP TABLE [dbo].[JobsActCarryoverEstimates]
GO

/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 8/21/2022 1:25:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JobsActCarryoverEstimates](
	[CarryoverEstimatesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_JobsActCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[CarryoverEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

