USE [Data]
GO

/****** Object:  Table [dbo].[ReferenceTables]    Script Date: 8/21/2022 1:34:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferenceTables]') AND type in (N'U'))
DROP TABLE [dbo].[ReferenceTables]
GO

/****** Object:  Table [dbo].[ReferenceTables]    Script Date: 8/21/2022 1:34:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ReferenceTables](
	[ReferenceTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_ReferenceTables] PRIMARY KEY CLUSTERED 
(
	[ReferenceTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

