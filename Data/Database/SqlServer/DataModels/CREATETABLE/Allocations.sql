USE [Data]
GO

ALTER TABLE [dbo].[Allocations] DROP CONSTRAINT [AllocationsStatusOfFundsForeignKey]
GO

ALTER TABLE [dbo].[Allocations] DROP CONSTRAINT [DF_Allocations_Amount]
GO

/****** Object:  Table [dbo].[Allocations]    Script Date: 8/21/2022 12:57:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Allocations]') AND type in (N'U'))
DROP TABLE [dbo].[Allocations]
GO

/****** Object:  Table [dbo].[Allocations]    Script Date: 8/21/2022 12:57:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Allocations](
	[AllocationsId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [AllocationsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AllocationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Allocations] ADD  CONSTRAINT [DF_Allocations_Amount]  DEFAULT ((0)) FOR [Amount]
GO

ALTER TABLE [dbo].[Allocations]  WITH CHECK ADD  CONSTRAINT [AllocationsStatusOfFundsForeignKey] FOREIGN KEY([StatusOfFundsId])
REFERENCES [dbo].[StatusOfFunds] ([StatusOfFundsId])
GO

ALTER TABLE [dbo].[Allocations] CHECK CONSTRAINT [AllocationsStatusOfFundsForeignKey]
GO

