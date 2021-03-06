IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'SiteActivity' )
BEGIN
CREATE TABLE [dbo].[SiteActivity]
(
	[SiteActivityId] INT IDENTITY(1,1) NOT NULL,
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[EpaSiteId] VARCHAR(80) NULL DEFAULT ('NS'),
	[SiteProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[SSID] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActionCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OperableUnit] VARCHAR(80) NULL DEFAULT ('NS'),
	[SiteProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[State] VARCHAR(80) NULL DEFAULT ('NS'),
	[City] VARCHAR(80) NULL DEFAULT ('NS'),
	[CongressionalDistrict] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProjectType] VARCHAR(80) NULL DEFAULT ('NS'),
	[StartDate] VARCHAR(80) NULL DEFAULT ('NS'),
	[LastActivity] VARCHAR(80) NULL DEFAULT ('NS'),
	[EndDate] VARCHAR(80) NULL DEFAULT ('NS'),
	[Requested] FLOAT NULL DEFAULT 0,
	[Accepted] FLOAT NULL DEFAULT 0,
	[Closed] FLOAT NULL DEFAULT 0,
	[Outstanding] FLOAT NULL DEFAULT 0,
	[Refunded] FLOAT NULL DEFAULT 0,
	[Reversal] FLOAT NULL DEFAULT 0
);
END
