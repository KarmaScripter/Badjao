IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'Accounts' )
BEGIN
CREATE TABLE [dbo].[Accounts]
(
	[AccountsId] INT IDENTITY(1,1) NOT NULL,
	[Code] VARCHAR(80) NULL DEFAULT ('NS'),
	[GoalCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObjectiveCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityName] VARCHAR(80) NULL DEFAULT ('NS')
);
END


