USE [Data]
GO

/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 8/21/2022 1:49:56 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SiteProjectCodes]') AND type in (N'U'))
DROP TABLE [dbo].[SiteProjectCodes]
GO

/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 8/21/2022 1:49:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SiteProjectCodes](
	[SiteProjectCodesId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
 CONSTRAINT [PK_SiteProjectCodes] PRIMARY KEY CLUSTERED 
(
	[SiteProjectCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

