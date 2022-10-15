USE [Data]
GO

/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 8/21/2022 1:17:09 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DocumentControlNumbers]') AND type in (N'U'))
DROP TABLE [dbo].[DocumentControlNumbers]
GO

/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 8/21/2022 1:17:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DocumentControlNumbers](
	[DocumentControlNumbersId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentPrefix] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
 CONSTRAINT [PK_DocumentControlNumbers] PRIMARY KEY CLUSTERED 
(
	[DocumentControlNumbersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

