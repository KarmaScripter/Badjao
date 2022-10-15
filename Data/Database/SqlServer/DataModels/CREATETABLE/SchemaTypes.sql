USE [Data]
GO

/****** Object:  Table [dbo].[SchemaTypes]    Script Date: 8/21/2022 1:49:37 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SchemaTypes]') AND type in (N'U'))
DROP TABLE [dbo].[SchemaTypes]
GO

/****** Object:  Table [dbo].[SchemaTypes]    Script Date: 8/21/2022 1:49:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SchemaTypes](
	[SchemaTypesId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](80) NULL,
	[Database] [nvarchar](80) NULL,
 CONSTRAINT [PK_SchemaTypes] PRIMARY KEY CLUSTERED 
(
	[SchemaTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

