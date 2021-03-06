CREATE TABLE FiscalYears
(
	FiscalYearId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyFiscalYears PRIMARY KEY AUTOINCREMENT,
	BFY TEXT(255) NOT NULL,
	EFY TEXT(255) NULL,
	FirstYear TEXT(255) NULL,
	LastYear TEXT(255) NULL,
	ExpiringYear TEXT(255) NULL,
	StartDate DATETIME NULL,
	EndDate DATETIME NULL,
	Availability TEXT(255) NULL,
	Columbus DATETIME NULL,
	Thanksgiving DATETIME NULL,
	Christmas DATETIME NULL,
	NewYears DATETIME NULL,
	MartinLutherKing DATETIME NULL,
	Presidents DATETIME NULL,
	Memorial DATETIME NULL,
	Veterans DATETIME NULL,
	Labor DATETIME NULL,
	WorkDays DOUBLE NULL,
	WeekDays DOUBLE NULL,
	WeekEnds DOUBLE NULL
);

