USE [Data]
GO

/****** Object:  Table [dbo].[TransTypes]    Script Date: 8/21/2022 1:52:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransTypes]') AND type in (N'U'))
DROP TABLE [dbo].[TransTypes]
GO

/****** Object:  Table [dbo].[TransTypes]    Script Date: 8/21/2022 1:52:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TransTypes](
	[TransTypesId] [int] IDENTITY(1,1) NOT NULL,
	[FundCode] [nvarchar](80) NULL,
	[Appropriation] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[DocType] [nvarchar](80) NULL,
	[AppropriationBill] [nvarchar](80) NULL,
	[ContinuingResolution] [nvarchar](80) NULL,
	[RescissionCurrentYear] [nvarchar](80) NULL,
	[RescissionPriorYear] [nvarchar](80) NULL,
	[SequesterReduction] [nvarchar](80) NULL,
	[SequesterReturn] [nvarchar](80) NULL,
 CONSTRAINT [PK_TransTypes] PRIMARY KEY CLUSTERED 
(
	[TransTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

