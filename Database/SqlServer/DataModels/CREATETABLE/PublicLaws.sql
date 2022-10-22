USE [Data]
GO

/****** Object:  Table [dbo].[PublicLaws]    Script Date: 8/21/2022 1:34:30 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PublicLaws]') AND type in (N'U'))
DROP TABLE [dbo].[PublicLaws]
GO

/****** Object:  Table [dbo].[PublicLaws]    Script Date: 8/21/2022 1:34:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PublicLaws](
	[PublicLawsId] [int] IDENTITY(1,1) NOT NULL,
	[LawNumber] [nvarchar](80) NULL,
	[BillTitle] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
	[Congress] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
 CONSTRAINT [PK_PublicLaws] PRIMARY KEY CLUSTERED 
(
	[PublicLawsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

