USE [Data]
GO

/****** Object:  Table [dbo].[PayrollActivity]    Script Date: 8/21/2022 1:32:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PayrollActivity]') AND type in (N'U'))
DROP TABLE [dbo].[PayrollActivity]
GO

/****** Object:  Table [dbo].[PayrollActivity]    Script Date: 8/21/2022 1:32:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PayrollActivity](
	[PayrollActivityId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[SubRcName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[HrOrgCode] [nvarchar](80) NULL,
	[HrOrgName] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[CheckDate] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
	[Hours] [decimal](18, 0) NULL,
	[BasePaid] [decimal](18, 0) NULL,
	[BaseHours] [decimal](18, 0) NULL,
	[Benefits] [decimal](18, 0) NULL,
	[OvertimePaid] [decimal](18, 0) NULL,
	[OvertimeHours] [decimal](18, 0) NULL,
 CONSTRAINT [PK_PayrollActivity] PRIMARY KEY CLUSTERED 
(
	[PayrollActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

