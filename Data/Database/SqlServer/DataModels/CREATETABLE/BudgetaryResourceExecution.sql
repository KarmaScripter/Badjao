USE [Data]
GO

/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 8/21/2022 1:07:23 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetaryResourceExecution]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetaryResourceExecution]
GO

/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 8/21/2022 1:07:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BudgetaryResourceExecution](
	[BudgetaryResourceExecutionId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[LastUpdate] [datetime] NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[STAT] [nvarchar](80) NULL,
	[CreditIndicator] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineDescription] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[LineType] [nvarchar](80) NULL,
	[FinancingAccounts] [nvarchar](80) NULL,
	[November] [decimal](18, 0) NULL,
	[January] [decimal](18, 0) NULL,
	[Feburary] [decimal](18, 0) NULL,
	[April] [decimal](18, 0) NULL,
	[May] [decimal](18, 0) NULL,
	[June] [decimal](18, 0) NULL,
	[August] [decimal](18, 0) NULL,
	[October] [decimal](18, 0) NULL,
	[Amount1] [decimal](18, 0) NULL,
	[Amount2] [decimal](18, 0) NULL,
	[Amount3] [decimal](18, 0) NULL,
	[Amount4] [decimal](18, 0) NULL,
	[Agency] [nvarchar](80) NULL,
	[Bureau] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetaryResourceExecution] PRIMARY KEY CLUSTERED 
(
	[BudgetaryResourceExecutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

