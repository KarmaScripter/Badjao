USE [Data]
GO

/****** Object:  Table [dbo].[ProgramFinancingSchedule]    Script Date: 8/21/2022 1:33:01 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgramFinancingSchedule]') AND type in (N'U'))
DROP TABLE [dbo].[ProgramFinancingSchedule]
GO

/****** Object:  Table [dbo].[ProgramFinancingSchedule]    Script Date: 8/21/2022 1:33:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProgramFinancingSchedule](
	[ProgramFinancingScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[LedgerAccountCode] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineDescription] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbFundCode] [nvarchar](80) NULL,
	[OmbAccountTitle] [nvarchar](80) NULL,
	[AgencySequence] [nvarchar](80) NULL,
	[AccountSequence] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OriginalAmount] [decimal](18, 0) NULL,
	[BudgetAmount] [decimal](18, 0) NULL,
	[AgencyAmount] [decimal](18, 0) NULL,
	[Amount] [decimal](18, 0) NULL,
	[AgencyName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramFinancingSchedule] PRIMARY KEY CLUSTERED 
(
	[ProgramFinancingScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

