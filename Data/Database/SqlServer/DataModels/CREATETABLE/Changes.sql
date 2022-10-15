USE [Data]
GO

/****** Object:  Table [dbo].[Changes]    Script Date: 8/21/2022 1:10:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Changes]') AND type in (N'U'))
DROP TABLE [dbo].[Changes]
GO

/****** Object:  Table [dbo].[Changes]    Script Date: 8/21/2022 1:10:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Changes](
	[ChangesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[FieldName] [nvarchar](80) NULL,
	[Action] [nvarchar](80) NULL,
	[OldValue] [nvarchar](80) NULL,
	[NewValue] [nvarchar](80) NULL,
	[TimeStamp] [datetime] NULL,
	[Message] [nvarchar](80) NULL,
 CONSTRAINT [PK_Changes] PRIMARY KEY CLUSTERED 
(
	[ChangesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

