CREATE TABLE CPIC
(
	CpicId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyCpic PRIMARY KEY,
	Code TEXT(255) NOT NULL,
	CostAreaCode TEXT(255) NULL,
	CostAreaName TEXT(255) NULL,
	ProjectCode TEXT(255) NULL,
	ProjectName TEXT(255) NULL
);
