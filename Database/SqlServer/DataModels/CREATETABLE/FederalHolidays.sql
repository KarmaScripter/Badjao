USE [Data]
GO

/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 8/21/2022 1:18:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FederalHolidays]') AND type in (N'U'))
DROP TABLE [dbo].[FederalHolidays]
GO

/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 8/21/2022 1:18:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FederalHolidays](
	[FederalHolidaysId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Columbus] [datetime] NULL,
	[Veterans] [datetime] NULL,
	[Thanksgiving] [datetime] NULL,
	[Christmas] [datetime] NULL,
	[NewYears] [datetime] NULL,
	[MartinLutherKing] [datetime] NULL,
	[Washingtons] [datetime] NULL,
	[Memorial] [datetime] NULL,
	[Juneteenth] [datetime] NULL,
	[Independence] [datetime] NULL,
	[Labor] [datetime] NULL,
 CONSTRAINT [PK_FederalHolidays] PRIMARY KEY CLUSTERED 
(
	[FederalHolidaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

