USE [Data]
GO

/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 8/21/2022 1:26:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectClassOutlays]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectClassOutlays]
GO

/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 8/21/2022 1:26:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ObjectClassOutlays](
	[ObjectClassOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbAgencyName] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbBureauName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ObligationType] [nvarchar](80) NULL,
	[DirectReimbursableTitle] [nvarchar](80) NULL,
	[ObjectClassGroupNumber] [nvarchar](80) NULL,
	[ObjectClassGroupName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FinanceObjectClass] [nvarchar](255) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ObjectClassOutlays] PRIMARY KEY CLUSTERED 
(
	[ObjectClassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

