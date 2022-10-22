USE [Data]
GO

/****** Object:  Table [dbo].[Resources]    Script Date: 8/21/2022 1:49:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resources]') AND type in (N'U'))
DROP TABLE [dbo].[Resources]
GO

/****** Object:  Table [dbo].[Resources]    Script Date: 8/21/2022 1:49:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Resources](
	[ResourcesId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](80) NULL,
	[FileType] [nvarchar](80) NULL,
	[FilePath] [nvarchar](max) NULL,
	[FileExtension] [nvarchar](80) NULL,
 CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED 
(
	[ResourcesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

