USE [Data]
GO

/****** Object:  Table [dbo].[BudgetObjectClasses]    Script Date: 8/21/2022 1:08:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetObjectClasses]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetObjectClasses]
GO

/****** Object:  Table [dbo].[BudgetObjectClasses]    Script Date: 8/21/2022 1:08:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BudgetObjectClasses](
	[BudgetObjectClassesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetObjectClasses] PRIMARY KEY CLUSTERED 
(
	[BudgetObjectClassesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

