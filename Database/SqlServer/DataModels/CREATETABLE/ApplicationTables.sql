USE [Data]
GO

/****** Object:  Table [dbo].[ApplicationTables]    Script Date: 8/21/2022 1:01:05 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ApplicationTables]') AND type in (N'U'))
DROP TABLE [dbo].[ApplicationTables]
GO

/****** Object:  Table [dbo].[ApplicationTables]    Script Date: 8/21/2022 1:01:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApplicationTables](
	[ApplicationTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Model] [nvarchar](80) NULL,
 CONSTRAINT [ApplicationTablesPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ApplicationTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

