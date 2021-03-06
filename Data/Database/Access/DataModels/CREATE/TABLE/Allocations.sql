CREATE TABLE Allocations
(
   PrcId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyAllocations PRIMARY KEY,
   BudgetLevel TEXT(50) NULL,
   RPIO TEXT(50) NULL,
   BFY TEXT(50) NULL,
   FundCode TEXT(50) NULL,
   AhCode TEXT(50) NULL,
   OrgCode TEXT(50) NULL,
   RcCode TEXT(50) NULL,
   AccountCode TEXT(50) NULL,
   BocCode TEXT(50) NULL,
   Amount DOUBLE NOT NULL DEFAULT 0.0,
   ActivityCode TEXT(50) NULL,
   ActivityName TEXT(50) NULL,
   FundName TEXT(50) NULL,
   BocName TEXT(50) NULL,
   NpmName TEXT(50) NULL,
   Division TEXT(50) NULL,
   DivisionName TEXT(50) NULL,
   ProgramProjectCode TEXT(50) NULL,
   ProgramProjectName TEXT(100) NULL,
   ProgramAreaName TEXT(50) NULL,
   AhName TEXT(50) NULL,
   OrgName TEXT(50) NULL,
   GoalName TEXT(50) NULL,
   ObjectiveName TEXT(50) NULL
);
