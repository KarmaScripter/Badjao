USE [Data]
GO

/****** Object:  Table [dbo].[Earmarks]    Script Date: 8/21/2022 1:17:29 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Earmarks]') AND type in (N'U'))
DROP TABLE [dbo].[Earmarks]
GO

/****** Object:  Table [dbo].[Earmarks]    Script Date: 8/21/2022 1:17:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Earmarks](
	[EarmarksId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[StateCode] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProjectOfficerLastName] [nvarchar](80) NULL,
	[ProjectOfficerFirstName] [nvarchar](80) NULL,
	[ProjectOfficerPhoneNumber] [nvarchar](80) NULL,
	[ProjectOfficerMailCode] [nvarchar](80) NULL,
	[CommitmentDate] [datetime] NULL,
	[ObligationDate] [datetime] NULL,
	[ProjectStatus] [nvarchar](80) NULL,
	[ProjectOfficerComments] [nvarchar](80) NULL,
 CONSTRAINT [PK_Earmarks] PRIMARY KEY CLUSTERED 
(
	[EarmarksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

