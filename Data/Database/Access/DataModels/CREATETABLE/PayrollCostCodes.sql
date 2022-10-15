CREATE TABLE PayrollCostCodes 
(
    PayrollCostCodesId AUTOINCREMENT NOT NULL UNIQUE,
    RpioCode TEXT(80) NULL DEFAULT NS,
    AhCode TEXT(80) NULL DEFAULT NS,
    BFY TEXT(80) NULL DEFAULT NS,
    RcCode TEXT(80) NULL  DEFAULT NS,
    RcName TEXT(80) NULL DEFAULT NS,
    WorkCode TEXT(80) NULL DEFAULT NS,
    WorkCodeName TEXT(80) NULL DEFAULT NS,
    HrOrgCode TEXT(80) NULL DEFAULT NS,
    HrOrgName TEXT(80) NULL DEFAULT NS,
    CONSTRAINT PayrollCostCodesPrimaryKey 
        PRIMARY KEY(PayrollCostCodesId)
);