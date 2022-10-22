USE [Data]
GO

/****** Object:  Table [dbo].[Images]    Script Date: 8/21/2022 1:24:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Images]') AND type in (N'U'))
DROP TABLE [dbo].[Images]
GO

/****** Object:  Table [dbo].[Images]    Script Date: 8/21/2022 1:24:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Images](
	[ImagesId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](80) NULL,
	[FilePath] [nvarchar](80) NULL,
	[FileExtension] [nvarchar](80) NULL,
	[ImageFile] [image] NULL,
	[Attachments] [nvarchar](80) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImagesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

