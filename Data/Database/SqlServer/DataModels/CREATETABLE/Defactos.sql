USE [Data]
GO

/****** Object:  Table [dbo].[Defactos]    Script Date: 8/21/2022 1:16:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Defactos]') AND type in (N'U'))
DROP TABLE [dbo].[Defactos]
GO

/****** Object:  Table [dbo].[Defactos]    Script Date: 8/21/2022 1:16:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Defactos](
	[DefactosId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[LowerName] [nvarchar](255) NULL,
	[Amount] [money] NULL,
	[Budgeted] [money] NULL,
	[Posted] [money] NULL,
	[OpenCommitments] [money] NULL,
	[ULO] [money] NULL,
	[Expenditures] [money] NULL,
	[Obligations] [money] NULL,
	[Used] [money] NULL,
	[Available] [money] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Defactos] PRIMARY KEY CLUSTERED 
(
	[DefactosId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

