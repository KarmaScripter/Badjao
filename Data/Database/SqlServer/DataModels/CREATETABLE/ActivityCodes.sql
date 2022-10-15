USE [Data]
GO

/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 8/21/2022 12:55:49 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActivityCodes]') AND type in (N'U'))
DROP TABLE [dbo].[ActivityCodes]
GO

/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 8/21/2022 12:55:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ActivityCodes](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [ActivityCodesPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

