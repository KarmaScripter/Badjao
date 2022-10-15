USE [Data]
GO

/****** Object:  Table [dbo].[WorkCodes]    Script Date: 8/21/2022 1:53:27 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkCodes]') AND type in (N'U'))
DROP TABLE [dbo].[WorkCodes]
GO

/****** Object:  Table [dbo].[WorkCodes]    Script Date: 8/21/2022 1:53:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkCodes](
	[WorkCodesId] [int] IDENTITY(1,1) NOT NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[WorkCodeShortName] [nvarchar](80) NULL,
	[ChargeType] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[ReOrgCode] [nvarchar](80) NULL,
	[Active] [nvarchar](80) NULL,
	[Pay Year] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[PayType] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[Justification] [nvarchar](80) NULL,
	[AllocationReason] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[ApprovedBy] [nvarchar](80) NULL,
	[ApprovalDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](80) NULL,
	[ModifiedDate] [datetime] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[BETC] [nvarchar](80) NULL,
	[BetcName] [nvarchar](80) NULL,
	[CostOrgCode] [nvarchar](80) NULL,
	[CostOrgName] [nvarchar](80) NULL,
	[Organization] [nvarchar](80) NULL,
	[Organization Name] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramName] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[BudgetYear] [nvarchar](80) NULL,
	[AllocationPercentage] [decimal](18, 0) NULL,
 CONSTRAINT [PK_WorkCodes] PRIMARY KEY CLUSTERED 
(
	[WorkCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

