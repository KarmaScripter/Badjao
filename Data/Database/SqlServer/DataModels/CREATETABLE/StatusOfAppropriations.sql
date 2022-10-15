USE [Data]
GO

/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 8/21/2022 1:50:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusOfAppropriations]') AND type in (N'U'))
DROP TABLE [dbo].[StatusOfAppropriations]
GO

/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 8/21/2022 1:50:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StatusOfAppropriations](
	[StatusOfAppropriationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AppropriationFundCode] [nvarchar](80) NULL,
	[AppropriationFundName] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AppropriationCreationDate] [datetime] NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[AppropriationDescription] [nvarchar](80) NULL,
	[FundGroup] [nvarchar](80) NULL,
	[FundGroupName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[TransType] [nvarchar](80) NULL,
	[ActualRecoveryTransType] [nvarchar](80) NULL,
	[CommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[AgreementLimit] [nvarchar](80) NULL,
	[EstimatedRecoveriesTransType] [nvarchar](80) NULL,
	[EstimatedReimbursmentsTransType] [nvarchar](80) NULL,
	[ExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[ObligationSpendingControlFlag] [nvarchar](80) NULL,
	[PreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[PostedControlFlag] [nvarchar](80) NULL,
	[PostedFlag] [nvarchar](80) NULL,
	[RecordCarryoverAtLowerLevel] [nvarchar](80) NULL,
	[ReimbursableSpendingOption] [nvarchar](80) NULL,
	[RecoveriesOption] [nvarchar](80) NULL,
	[RecoveriesSpendingOption] [nvarchar](80) NULL,
	[OriginalBudgetedAmount] [decimal](18, 0) NULL,
	[ApportionmentsPosted] [decimal](18, 0) NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[TotalBudgeted] [decimal](18, 0) NULL,
	[TotalPostedAmount] [decimal](18, 0) NULL,
	[FundsWithdrawnPriorYearsAmount] [decimal](18, 0) NULL,
	[FundingInAmount] [decimal](18, 0) NULL,
	[FundingOutAmount] [decimal](18, 0) NULL,
	[TotalAccrualRecoveries] [decimal](18, 0) NULL,
	[TotalActualReimbursements] [decimal](18, 0) NULL,
	[TotalAgreementReimbursables] [decimal](18, 0) NULL,
	[TotalCarriedForwardIn] [decimal](18, 0) NULL,
	[TotalCarriedForwardOut] [decimal](18, 0) NULL,
	[TotalCommitted] [decimal](18, 0) NULL,
	[TotalEstimatedRecoveries] [decimal](18, 0) NULL,
	[TotalEstimatedReimbursements] [decimal](18, 0) NULL,
	[TotalExpenses] [decimal](18, 0) NULL,
	[TotalExpenditureExpenses] [decimal](18, 0) NULL,
	[TotalExpenseAccruals] [decimal](18, 0) NULL,
	[TotalPreCommitments] [decimal](18, 0) NULL,
	[UnliquidatedPreCommitments] [decimal](18, 0) NULL,
	[TotalObligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[VoidedAmount] [decimal](18, 0) NULL,
	[TotalUsedAmount] [decimal](18, 0) NULL,
	[AvailableAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_StatusOfAppropriations] PRIMARY KEY CLUSTERED 
(
	[StatusOfAppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

