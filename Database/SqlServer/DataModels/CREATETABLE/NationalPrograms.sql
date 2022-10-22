USE [Data]
GO

/****** Object:  Table [dbo].[NationalPrograms]    Script Date: 8/21/2022 1:26:17 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NationalPrograms]') AND type in (N'U'))
DROP TABLE [dbo].[NationalPrograms]
GO

/****** Object:  Table [dbo].[NationalPrograms]    Script Date: 8/21/2022 1:26:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NationalPrograms](
	[NationalProgramsId] [int] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL
) ON [PRIMARY]
GO

