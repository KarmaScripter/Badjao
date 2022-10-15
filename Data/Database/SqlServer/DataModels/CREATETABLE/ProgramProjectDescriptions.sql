USE [Data]
GO

/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 8/21/2022 1:33:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgramProjectDescriptions]') AND type in (N'U'))
DROP TABLE [dbo].[ProgramProjectDescriptions]
GO

/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 8/21/2022 1:33:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProgramProjectDescriptions](
	[ProgramProjectDescriptionsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ProgramTitle] [nvarchar](80) NULL,
	[Laws] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramProjectDescriptions] PRIMARY KEY CLUSTERED 
(
	[ProgramProjectDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

