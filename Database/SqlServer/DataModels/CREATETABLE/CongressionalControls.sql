USE [Data]
GO

/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 8/21/2022 1:10:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CongressionalControls]') AND type in (N'U'))
DROP TABLE [dbo].[CongressionalControls]
GO

/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 8/21/2022 1:10:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CongressionalControls](
	[CongressionalControlsId] [int] IDENTITY(1,1) NOT NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[SubProjectCode] [nvarchar](80) NULL,
	[SubProjectName] [nvarchar](80) NULL,
	[ReprogrammingRestriction] [nvarchar](80) NULL,
	[IncreaseRestriction] [nvarchar](80) NULL,
	[DecreaseRestriction] [nvarchar](80) NULL,
	[MemoRequirement] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalControls] PRIMARY KEY CLUSTERED 
(
	[CongressionalControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

