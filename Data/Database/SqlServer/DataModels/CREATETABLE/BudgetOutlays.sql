USE [Data]
GO

/****** Object:  Table [dbo].[BudgetOutlays]    Script Date: 8/21/2022 1:08:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetOutlays]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetOutlays]
GO

/****** Object:  Table [dbo].[BudgetOutlays]    Script Date: 8/21/2022 1:08:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BudgetOutlays](
	[BudgetOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineSection] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[BeaCategory] [nvarchar](80) NULL,
	[BeaCategoryName] [nvarchar](80) NULL,
	[LineCategory] [nvarchar](80) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BudgetOutlays] PRIMARY KEY CLUSTERED 
(
	[BudgetOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

