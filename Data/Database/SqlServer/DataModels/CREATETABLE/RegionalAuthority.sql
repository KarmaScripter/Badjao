USE [Data]
GO

/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 8/21/2022 1:35:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RegionalAuthority]') AND type in (N'U'))
DROP TABLE [dbo].[RegionalAuthority]
GO

/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 8/21/2022 1:35:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RegionalAuthority](
	[RegionalAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[AllocationsId] [int] NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
 CONSTRAINT [RegionalAuthorityPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[RegionalAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

