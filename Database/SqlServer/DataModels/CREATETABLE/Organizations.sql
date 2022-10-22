USE [Data]
GO

/****** Object:  Table [dbo].[Organizations]    Script Date: 8/21/2022 1:31:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organizations]') AND type in (N'U'))
DROP TABLE [dbo].[Organizations]
GO

/****** Object:  Table [dbo].[Organizations]    Script Date: 8/21/2022 1:31:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Organizations](
	[OrganizationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[Usage] [nvarchar](80) NULL,
	[UseAsCostOrg] [nvarchar](80) NULL,
	[SubCodeRequired] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[OrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

