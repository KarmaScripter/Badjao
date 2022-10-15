USE [Data]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 8/21/2022 1:25:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Messages]') AND type in (N'U'))
DROP TABLE [dbo].[Messages]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 8/21/2022 1:25:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[MessagesId] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
	[Form] [nvarchar](80) NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[MessagesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

