CREATE TABLE Accounts
(
	AccountId INTEGER NOT NULL UNIQUE CONSTRAINT PK_Accounts PRIMARY KEY AUTOINCREMENT,
	Code TEXT(255) NOT NULL,
	ActivityCode TEXT(255) NULL,
	Name TEXT(255) NULL,
	Title TEXT(255) NULL,
	ProgramAreaCode TEXT(255) NULL,
	ProgramProjectCode TEXT(255) NULL,
	GoalCode TEXT(255) NULL,
	ObjectiveCode TEXT(255) NULL
);

