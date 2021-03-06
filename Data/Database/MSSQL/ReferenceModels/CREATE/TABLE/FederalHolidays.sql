IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'FederalHolidays' )
BEGIN
CREATE TABLE [dbo].[FederalHolidays]
(
	[FederalHolidaysId] INT IDENTITY(1,1) NOT NULL,
	[ColumbusDay] DATETIME NULL,
	[ThanksgivingDay] DATETIME NULL,
	[ChristmasDay] DATETIME NULL,
	[NewYearsDay] DATETIME NULL,
	[MartinLutherKingDay] DATETIME NULL,
	[PresidentsDay] DATETIME NULL,
	[MemorialDay] DATETIME NULL,
	[Juneteenth] DATETIME NULL, 
	[IndependenceDay] DATETIME NULL, 
	[VeteransDay] DATETIME NULL,
	[LaborDay] DATETIME NULL
);
END