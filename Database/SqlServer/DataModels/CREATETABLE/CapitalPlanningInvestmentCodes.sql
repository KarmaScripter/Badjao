USE [Data]
GO

/****** Object:  Table [dbo].[CapitalPlanningInvestmentCodes]    Script Date: 8/21/2022 1:09:14 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CapitalPlanningInvestmentCodes]') AND type in (N'U'))
DROP TABLE [dbo].[CapitalPlanningInvestmentCodes]
GO

/****** Object:  Table [dbo].[CapitalPlanningInvestmentCodes]    Script Date: 8/21/2022 1:09:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CapitalPlanningInvestmentCodes](
	[CapitalPlanningInvestmentCodesId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_CPIC] PRIMARY KEY CLUSTERED 
(
	[CapitalPlanningInvestmentCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

