IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'ReimbursableSurvey' )
BEGIN
CREATE TABLE [dbo].[ReimbursableSurvey]
(
	ReimbursableSurveyId INT IDENTITY(1,1) NOT NULL,
	BFY	 VARCHAR(80) NULL DEFAULT ('NS'),
	FundCode	 VARCHAR(80) NULL DEFAULT ('NS'),
	FundName	 VARCHAR(80) NULL DEFAULT ('NS'),
	Amount	FLOAT NULL DEFAULT (0)
);
END