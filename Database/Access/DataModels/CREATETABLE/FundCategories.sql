CREATE TABLE FundCategories 
(
	FundCategoriesId INTEGER NOT NULL UNIQUE,
	Code TEXT(80) DEFAULT NS,
	Name TEXT(80) DEFAULT NS,
	ShortName	TEXT(80) DEFAULT NS,
    CONSTRAINT FundCategoriesPrimaryKey
	    PRIMARY KEY(FundCategoriesId AUTOINCREMENT)
);