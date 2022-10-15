USE [Data]
GO

/****** Object:  Table [dbo].[ExecutionTables]    Script Date: 8/21/2022 1:17:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExecutionTables]') AND type in (N'U'))
DROP TABLE [dbo].[ExecutionTables]
GO

/****** Object:  Table [dbo].[ExecutionTables]    Script Date: 8/21/2022 1:17:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ExecutionTables](
	[ExecutionTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_ExecutionTables] PRIMARY KEY CLUSTERED 
(
	[ExecutionTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

