USE [Data]
GO

/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 8/21/2022 1:08:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetDocuments]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetDocuments]
GO

/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 8/21/2022 1:08:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BudgetDocuments](
	[BudgetDocumentsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[DocumentDate] [datetime] NULL,
	[LastDocumentDate] [datetime] NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ReimbursableAgreementControls] [nvarchar](80) NULL,
	[BudgetingControls] [nvarchar](80) NULL,
	[PostingControls] [nvarchar](80) NULL,
	[PreCommitmentControls] [nvarchar](80) NULL,
	[CommitmentControls] [nvarchar](80) NULL,
	[ObligationControls] [nvarchar](80) NULL,
	[ExpenditureControls] [nvarchar](80) NULL,
	[ExpenseControls] [nvarchar](80) NULL,
	[AccrualControls] [nvarchar](80) NULL,
	[ReimbursementControls] [nvarchar](80) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[EstimatedRecoveries] [decimal](18, 0) NULL,
	[EstimatedReimbursements] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BudgetDocuments] PRIMARY KEY CLUSTERED 
(
	[BudgetDocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

