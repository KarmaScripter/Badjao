USE [Data]
GO

/****** Object:  Table [dbo].[AppropriationLevelAuthority]    Script Date: 8/21/2022 1:06:53 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppropriationLevelAuthority]') AND type in (N'U'))
DROP TABLE [dbo].[AppropriationLevelAuthority]
GO

/****** Object:  Table [dbo].[AppropriationLevelAuthority]    Script Date: 8/21/2022 1:06:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AppropriationLevelAuthority](
	[AppropriationLevelAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[EstimatedReimbursements] [decimal](18, 0) NULL,
	[EstimatedRecoveries] [decimal](18, 0) NULL,
 CONSTRAINT [AppropriationLevelAuthorityPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AppropriationLevelAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

