USE [Data]
GO

/****** Object:  Table [dbo].[Objectives]    Script Date: 8/21/2022 1:26:41 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Objectives]') AND type in (N'U'))
DROP TABLE [dbo].[Objectives]
GO

/****** Object:  Table [dbo].[Objectives]    Script Date: 8/21/2022 1:26:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Objectives](
	[ObjectivesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_Objectives] PRIMARY KEY CLUSTERED 
(
	[ObjectivesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

