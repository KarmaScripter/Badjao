USE [Data]
GO

/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 8/21/2022 1:48:36 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReimbursableFunds]') AND type in (N'U'))
DROP TABLE [dbo].[ReimbursableFunds]
GO

/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 8/21/2022 1:48:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ReimbursableFunds](
	[ReimbursableFundsId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[AgreeementNumber] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ReimbursableFunds] PRIMARY KEY CLUSTERED 
(
	[ReimbursableFundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

