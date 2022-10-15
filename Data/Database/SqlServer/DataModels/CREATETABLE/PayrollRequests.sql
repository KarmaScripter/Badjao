USE [Data]
GO

/****** Object:  Table [dbo].[PayrollRequests]    Script Date: 8/21/2022 1:32:39 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PayrollRequests]') AND type in (N'U'))
DROP TABLE [dbo].[PayrollRequests]
GO

/****** Object:  Table [dbo].[PayrollRequests]    Script Date: 8/21/2022 1:32:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PayrollRequests](
	[PayrollRequestsId] [int] IDENTITY(1,1) NOT NULL,
	[ControlTeamAnalyst] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[DocumentTitle] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[FundCode] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[OriginalRequestDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[BFS] [nvarchar](80) NULL,
	[Comments] [nvarchar](80) NULL,
	[RequestDocument] [nvarchar](max) NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_PayrollRequests] PRIMARY KEY CLUSTERED 
(
	[PayrollRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

