CREATE TABLE CPIC
(
	ID INT NOT NULL IDENTITY (1,1),
	Code NVARCHAR(255) NOT NULL,
	CostAreaCode NVARCHAR(255) NULL,
	CostAreaName NVARCHAR(255) NULL,
	ProjectCode NVARCHAR(255) NULL,
	ProjectName NVARCHAR(255) NULL
);