USE [Data]
GO

/****** Object:  Table [dbo].[OperatingPlanUpdates]    Script Date: 8/21/2022 1:31:37 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperatingPlanUpdates]') AND type in (N'U'))
DROP TABLE [dbo].[OperatingPlanUpdates]
GO

/****** Object:  Table [dbo].[OperatingPlanUpdates]    Script Date: 8/21/2022 1:31:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OperatingPlanUpdates](
	[OperatingPlanUpdatesId] [int] IDENTITY(1,1) NOT NULL,
	[OppId] [int] NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_OperatingPlanUpdates] PRIMARY KEY CLUSTERED 
(
	[OperatingPlanUpdatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

