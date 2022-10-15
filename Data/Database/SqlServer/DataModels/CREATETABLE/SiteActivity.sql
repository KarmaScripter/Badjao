USE [Data]
GO

/****** Object:  Table [dbo].[SiteActivity]    Script Date: 8/21/2022 1:49:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SiteActivity]') AND type in (N'U'))
DROP TABLE [dbo].[SiteActivity]
GO

/****** Object:  Table [dbo].[SiteActivity]    Script Date: 8/21/2022 1:49:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SiteActivity](
	[SiteActivityId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[ProjectType] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[LastActivity] [datetime] NULL,
	[Requested] [decimal](18, 0) NULL,
	[Accepted] [decimal](18, 0) NULL,
	[Closed] [decimal](18, 0) NULL,
	[Outstanding] [decimal](18, 0) NULL,
	[Refunded] [decimal](18, 0) NULL,
	[Reversal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SiteActivity] PRIMARY KEY CLUSTERED 
(
	[SiteActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

