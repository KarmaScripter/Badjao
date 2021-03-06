CREATE TABLE FiscalYears
(
	FiscalYearId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
	BFY NVARCHAR(255) NOT NULL,
	EFY NVARCHAR(255) NULL,
	FirstYear NVARCHAR(255) NULL,
	LastYear NVARCHAR(255) NULL,
	ExpiringYear NVARCHAR(255) NULL,
	StartDate DATETIME NULL,
	EndDate DATETIME NULL,
	Availability NVARCHAR(255) NULL,
	Columbus DATETIME NULL,
	Thanksgiving DATETIME NULL,
	Christmas DATETIME NULL,
	NewYears DATETIME NULL,
	MartinLutherKing DATETIME NULL,
	Presidents DATETIME NULL,
	Memorial DATETIME NULL,
	Veterans DATETIME NULL,
	Labor DATETIME NULL,
	WorkDays FLOAT NULL,
	WeekDays FLOAT NULL,
	WeekEnds FLOAT NULL
);

