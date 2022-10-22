USE [Data]
GO

/****** Object:  Table [dbo].[PayPeriods]    Script Date: 8/21/2022 1:31:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PayPeriods]') AND type in (N'U'))
DROP TABLE [dbo].[PayPeriods]
GO

/****** Object:  Table [dbo].[PayPeriods]    Script Date: 8/21/2022 1:31:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PayPeriods](
	[PayPeriodsId] [int] IDENTITY(1,1) NOT NULL,
	[Period] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_PayPeriods] PRIMARY KEY CLUSTERED 
(
	[PayPeriodsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

