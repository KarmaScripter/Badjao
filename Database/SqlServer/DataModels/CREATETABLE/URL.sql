USE [Data]
GO

/****** Object:  Table [dbo].[URL]    Script Date: 8/21/2022 1:53:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URL]') AND type in (N'U'))
DROP TABLE [dbo].[URL]
GO

/****** Object:  Table [dbo].[URL]    Script Date: 8/21/2022 1:53:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[URL](
	[UrlsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Location] [nvarchar](80) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_URL] PRIMARY KEY CLUSTERED 
(
	[UrlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

