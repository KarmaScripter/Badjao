﻿CREATE TABLE [Allocations]
(
   [AllocationsId] INT NOT NULL IDENTITY (1,1),
   [BudgetLevel] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [RPIO] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [BFY] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [FundCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [AhCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [OrgCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [RcCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [AccountCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [BocCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [Amount] FLOAT NOT NULL DEFAULT 0.0,
   [ActivityCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [ActivityName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [FundName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [BocName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [NpmName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [Division] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [DivisionName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [ProgramProjectCode] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [ProgramProjectName] NVARCHAR(100) NOT NULL DEFAULT ('NS'),
   [ProgramAreaName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [AhName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [OrgName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [GoalName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
   [ObjectiveName] NVARCHAR(50) NOT NULL DEFAULT ('NS'),
    CONSTRAINT PK_Allocations
    PRIMARY KEY (AllocationsId) 
);
