USE [Data]
GO

/****** Object:  Table [dbo].[Actuals]    Script Date: 8/21/2022 12:55:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Actuals]') AND type in (N'U'))
DROP TABLE [dbo].[Actuals]
GO

/****** Object:  Table [dbo].[Actuals]    Script Date: 8/21/2022 12:55:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Actuals](
	[ActualsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RpioActivityCode] [nvarchar](80) NULL,
	[RpioActivityName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Balance] [decimal](18, 0) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [ActualsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ActualsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

