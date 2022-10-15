USE [Data]
GO

/****** Object:  Table [dbo].[Documents]    Script Date: 8/21/2022 1:17:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Documents]') AND type in (N'U'))
DROP TABLE [dbo].[Documents]
GO

/****** Object:  Table [dbo].[Documents]    Script Date: 8/21/2022 1:17:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Documents](
	[DocumentsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Category] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[System] [nvarchar](80) NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[DocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

