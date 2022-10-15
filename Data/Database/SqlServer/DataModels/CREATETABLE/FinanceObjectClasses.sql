USE [Data]
GO

/****** Object:  Table [dbo].[FinanceObjectClasses]    Script Date: 8/21/2022 1:18:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FinanceObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[FinanceObjectClasses]
GO

/****** Object:  Table [dbo].[FinanceObjectClasses]    Script Date: 8/21/2022 1:18:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FinanceObjectClasses](
	[FinanceObjectClassesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
 CONSTRAINT [PK_FinanceObjectClasses] PRIMARY KEY CLUSTERED 
(
	[FinanceObjectClassesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

