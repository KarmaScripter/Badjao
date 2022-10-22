USE [Data]
GO

/****** Object:  Table [dbo].[CompassLevels]    Script Date: 8/21/2022 1:10:15 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CompassLevels]') AND type in (N'U'))
DROP TABLE [dbo].[CompassLevels]
GO

/****** Object:  Table [dbo].[CompassLevels]    Script Date: 8/21/2022 1:10:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CompassLevels](
	[CompassLevelsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[PostedControlFlag] [nvarchar](80) NULL,
	[ActualRecoveryTransType] [nvarchar](80) NULL,
	[CommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[BudgetDefault] [nvarchar](80) NULL,
	[LowerChildExpenditureSpendingControlFlag] [nvarchar](80) NULL,
	[LowerChildExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[FteControlFlag] [nvarchar](80) NULL,
	[AccrualSpendingControlFlag] [nvarchar](80) NULL,
	[ObligationSpendingControlFlag] [nvarchar](80) NULL,
	[PreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerObligationSpendingControlFlag] [nvarchar](80) NULL,
	[LowerExpenditureSpendingControlFlag] [nvarchar](80) NULL,
	[LowerExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[LowerPostedControlFlag] [nvarchar](80) NULL,
	[LowerPostedTransType] [nvarchar](80) NULL,
	[LowerTransType] [nvarchar](80) NULL,
	[LowerPostedFlag] [nvarchar](80) NULL,
	[LowerPreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerRecoveriesSpendingOption] [nvarchar](80) NULL,
	[LowerRecoveriesOption] [nvarchar](80) NULL,
	[LowerReimbursableSpendingOption] [nvarchar](80) NULL,
	[Date] [datetime] NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[OriginalAmount] [decimal](18, 0) NULL,
	[CarryoverAvailabilityPercentage] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[FundsIn] [decimal](18, 0) NULL,
	[FundsOut] [decimal](18, 0) NULL,
	[RecoveriesWithdrawn] [decimal](18, 0) NULL,
	[ActualRecoveries] [decimal](18, 0) NULL,
	[ActualReimbursements] [decimal](18, 0) NULL,
	[AgreementReimbursables] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CompassLevels] PRIMARY KEY CLUSTERED 
(
	[CompassLevelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

