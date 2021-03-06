IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'ProgramDescriptions' )
BEGIN
CREATE TABLE [dbo].[ProgramDescriptions]
(
	[ProgramDescriptionsId] INT IDENTITY(1,1) NOT NULL,
	[ProgramProjectCode] VARCHAR(255) NOT NULL,
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[Laws] VARCHAR(max) NULL DEFAULT ('NOT SPECIFIED'),
	[Narrative] VARCHAR(max) NULL DEFAULT ('NOT SPECIFIED'),
	[Definition] VARCHAR(max) NULL DEFAULT ('NOT SPECIFIED'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(255) NULL DEFAULT ('NOT SPECIFIED')
);
END
