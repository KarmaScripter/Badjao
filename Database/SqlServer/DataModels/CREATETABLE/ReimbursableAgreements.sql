USE [Data]
GO

/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 8/21/2022 1:48:26 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReimbursableAgreements]') AND type in (N'U'))
DROP TABLE [dbo].[ReimbursableAgreements]
GO

/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 8/21/2022 1:48:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ReimbursableAgreements](
	[ReimbursableAgreementsId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AgreementNumber] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ReimbursableAgreements] PRIMARY KEY CLUSTERED 
(
	[ReimbursableAgreementsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

