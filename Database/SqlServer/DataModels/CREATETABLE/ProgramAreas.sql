USE [Data]
GO

/****** Object:  Table [dbo].[ProgramAreas]    Script Date: 8/21/2022 1:32:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgramAreas]') AND type in (N'U'))
DROP TABLE [dbo].[ProgramAreas]
GO

/****** Object:  Table [dbo].[ProgramAreas]    Script Date: 8/21/2022 1:32:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProgramAreas](
	[ProgramAreasId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramAreas] PRIMARY KEY CLUSTERED 
(
	[ProgramAreasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

