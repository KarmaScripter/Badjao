USE [Data]
GO

/****** Object:  Table [dbo].[AccountingEvents]    Script Date: 8/21/2022 12:55:18 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AccountingEvents]') AND type in (N'U'))
DROP TABLE [dbo].[AccountingEvents]
GO

/****** Object:  Table [dbo].[AccountingEvents]    Script Date: 8/21/2022 12:55:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AccountingEvents](
	[AccountingEventsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [AccountingEventsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AccountingEventsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

