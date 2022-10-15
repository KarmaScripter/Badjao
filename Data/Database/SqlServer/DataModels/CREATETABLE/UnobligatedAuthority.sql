USE [Data]
GO

/****** Object:  Table [dbo].[UnobligatedAuthority]    Script Date: 8/21/2022 1:53:01 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnobligatedAuthority]') AND type in (N'U'))
DROP TABLE [dbo].[UnobligatedAuthority]
GO

/****** Object:  Table [dbo].[UnobligatedAuthority]    Script Date: 8/21/2022 1:53:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UnobligatedAuthority](
	[UnobligatedAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyCode] [nvarchar](80) NULL,
	[BureauCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[BureauName] [nvarchar](80) NULL,
 CONSTRAINT [PK_UnobligatedAuthority] PRIMARY KEY CLUSTERED 
(
	[UnobligatedAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

