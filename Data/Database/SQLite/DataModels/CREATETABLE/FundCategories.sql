CREATE TABLE IF NOT EXISTS FundCategories 
(
    FundCategoriesId INTEGER NOT NULL UNIQUE,
    Code TEXT(80) DEFAULT NS,
    Name TEXT(80) DEFAULT NS,
    ShortName TEXT(80) DEFAULT NS,
        PRIMARY KEY(FundCategoriesId AUTOINCREMENT)
);