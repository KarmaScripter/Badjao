USE [Data]
GO

/****** Object:  Table [dbo].[DataRuleDescriptions]    Script Date: 8/21/2022 1:16:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataRuleDescriptions]') AND type in (N'U'))
DROP TABLE [dbo].[DataRuleDescriptions]
GO

/****** Object:  Table [dbo].[DataRuleDescriptions]    Script Date: 8/21/2022 1:16:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DataRuleDescriptions](
	[DataRuleDescriptionsId] [int] IDENTITY(1,1) NOT NULL,
	[Schedule] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[RuleNumber] [nvarchar](80) NULL,
	[RuleDescription] [nvarchar](max) NULL,
	[ScheduleOrder] [nvarchar](80) NULL,
 CONSTRAINT [PK_DataRuleDescriptions] PRIMARY KEY CLUSTERED 
(
	[DataRuleDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

