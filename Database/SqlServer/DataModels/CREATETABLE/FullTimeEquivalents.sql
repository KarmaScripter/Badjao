USE [Data]
GO

/****** Object:  Table [dbo].[FullTimeEquivalents]    Script Date: 8/21/2022 1:22:09 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FullTimeEquivalents]') AND type in (N'U'))
DROP TABLE [dbo].[FullTimeEquivalents]
GO

/****** Object:  Table [dbo].[FullTimeEquivalents]    Script Date: 8/21/2022 1:22:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FullTimeEquivalents](
	[FullTimeEquivialentsId] [int] IDENTITY(1,1) NOT NULL,
	[OperatingPlansId] [int] NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ITProjectCode] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProjectTypeName] [nvarchar](80) NULL,
	[ProjectTypeCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[LocalCode] [nvarchar](80) NULL,
	[LocalCodeName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[CostAreaCode] [nvarchar](80) NULL,
	[CostAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_FullTimeEquivalents] PRIMARY KEY CLUSTERED 
(
	[FullTimeEquivialentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

