USE [Data]
GO

/****** Object:  Table [dbo].[Appropriations]    Script Date: 8/21/2022 1:07:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Appropriations]') AND type in (N'U'))
DROP TABLE [dbo].[Appropriations]
GO

/****** Object:  Table [dbo].[Appropriations]    Script Date: 8/21/2022 1:07:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appropriations](
	[AppropriationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NOT NULL,
	[Title] [nvarchar](80) NULL,
	[PublicLaw] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
 CONSTRAINT [AppropriationsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

