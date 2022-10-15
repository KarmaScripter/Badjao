USE [Data]
GO

/****** Object:  Table [dbo].[Reports]    Script Date: 8/21/2022 1:48:45 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reports]') AND type in (N'U'))
DROP TABLE [dbo].[Reports]
GO

/****** Object:  Table [dbo].[Reports]    Script Date: 8/21/2022 1:48:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reports](
	[ReportsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[ReportsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

