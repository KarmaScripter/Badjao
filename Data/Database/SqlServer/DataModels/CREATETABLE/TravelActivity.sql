USE [Data]
GO

/****** Object:  Table [dbo].[TravelActivity]    Script Date: 8/21/2022 1:52:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TravelActivity]') AND type in (N'U'))
DROP TABLE [dbo].[TravelActivity]
GO

/****** Object:  Table [dbo].[TravelActivity]    Script Date: 8/21/2022 1:52:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TravelActivity](
	[TravelActivityId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[FirstName] [nvarchar](80) NULL,
	[LastName] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Duration] [float] NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Expenditures] [decimal](18, 0) NULL,
 CONSTRAINT [PK_TravelActivity] PRIMARY KEY CLUSTERED 
(
	[TravelActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

