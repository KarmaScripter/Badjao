BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Actuals" 
(
	"ActualsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationName"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioActivityName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Balance"	DECIMAL NULL DEFAULT 0.0,
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"GoalCode"	TEXT(80) NULL DEFAULT 'NS',
	"GoalName"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ActualsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AccountingEvents" 
(
	"AccountingEventsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("AccountingEventsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ActivityCodes" 
(
	"ActivityId"	INTEGER NOT NULL,
	"Code"	nvarchar(80) NOT NULL COLLATE NOCASE,
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Description"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ActivityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AdministrativeRequests" 
(
	"AdministrativeRequestsId"	INTEGER NOT NULL,
	"RequestId"	int,
	"ControlTeamAnalyst"	nvarchar(255) COLLATE NOCASE,
	"RpioCode"	nvarchar(255) COLLATE NOCASE,
	"DocumentTitle"	nvarchar(255) COLLATE NOCASE,
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"FundCode"	nvarchar(255) COLLATE NOCASE,
	"BFY"	nvarchar(255) COLLATE NOCASE,
	"Status"	nvarchar(255) COLLATE NOCASE,
	"OriginalRequestDate"	datetime,
	"LastActivityDate"	datetime,
	"Duration"	float,
	"BFS"	nvarchar(255) COLLATE NOCASE,
	"Comments"	nTEXT(80) NULL DEFAULT 'NS',
	"RequestDocument"	nTEXT(80) NULL DEFAULT 'NS',
	"RequestType"	nvarchar(255) COLLATE NOCASE,
	"TypeCode"	nvarchar(255) COLLATE NOCASE,
	"Decision"	nvarchar(255) COLLATE NOCASE,
	PRIMARY KEY("AdministrativeRequestsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "WorkCodes" 
(
	"WorkCodesId"	INTEGER NOT NULL,
	"SecurityOrg"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCode"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCodeName"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCodeShortName"	TEXT(80) NULL DEFAULT 'NS',
	"ChargeType"	TEXT(80) NULL DEFAULT 'NS',
	"PreventNewUse"	TEXT(80) NULL DEFAULT 'NS',
	"ReOrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"Active"	TEXT(80) NULL DEFAULT 'NS',
	"Pay Year"	TEXT(80) NULL DEFAULT 'NS',
	"PayPeriod"	TEXT(80) NULL DEFAULT 'NS',
	"PayType"	TEXT(80) NULL DEFAULT 'NS',
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"Justification"	TEXT(80) NULL DEFAULT 'NS',
	"AllocationReason"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"ApprovedBy"	TEXT(80) NULL DEFAULT 'NS',
	"ApprovalDate"	datetime,
	"ModifiedBy"	TEXT(80) NULL DEFAULT 'NS',
	"ModifiedDate"	datetime,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"BETC"	TEXT(80) NULL DEFAULT 'NS',
	"BetcName"	TEXT(80) NULL DEFAULT 'NS',
	"CostOrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"CostOrgName"	TEXT(80) NULL DEFAULT 'NS',
	"Organization"	TEXT(80) NULL DEFAULT 'NS',
	"Organization Name"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramName"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetYear"	TEXT(80) NULL DEFAULT 'NS',
	"AllocationPercentage"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("WorkCodesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "URL" 
(
	"UrlsId"	INTEGER NOT NULL,
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Location"	TEXT(80) NULL DEFAULT 'NS',
	"Address"	nTEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("UrlsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "UnobligatedBalances" 
(
	"UnobligatedBalancesId"	INTEGER NOT NULL,
	"BudgetYear"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountNumber"	TEXT(80) NULL DEFAULT 'NS',
	"AccountName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("UnobligatedBalancesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "UnobligatedAuthority" 
(
	"UnobligatedAuthorityId"	INTEGER NOT NULL,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"BureauCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccount"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"LineName"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetYear"	DECIMAL NULL DEFAULT 0.0,
	"PriorYear"	DECIMAL NULL DEFAULT 0.0,
	"CurrentYear"	DECIMAL NULL DEFAULT 0.0,
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"BureauName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("UnobligatedAuthorityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "UnliquidatedObligations" 
(
	"UnliquidatedObligationsId"	INTEGER NOT NULL,
	"ObligationsId"	int,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"LastActivityDate"	datetime,
	"Age"	float,
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("UnliquidatedObligationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "TravelActivity" 
(
	"TravelActivityId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"FirstName"	TEXT(80) NULL DEFAULT 'NS',
	"LastName"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	"Duration"	float,
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("TravelActivityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "TransTypes" 
(
	"TransTypesId"	INTEGER NOT NULL,
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"Appropriation"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"DocType"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationBill"	TEXT(80) NULL DEFAULT 'NS',
	"ContinuingResolution"	TEXT(80) NULL DEFAULT 'NS',
	"RescissionCurrentYear"	TEXT(80) NULL DEFAULT 'NS',
	"RescissionPriorYear"	TEXT(80) NULL DEFAULT 'NS',
	"SequesterReduction"	TEXT(80) NULL DEFAULT 'NS',
	"SequesterReturn"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("TransTypesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Transfers" 
(
	"TransfersId"	INTEGER NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"DocPrefix"	TEXT(80) NULL DEFAULT 'NS',
	"DocType"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"ReprogrammingNumber"	TEXT(80) NULL DEFAULT 'NS',
	"ControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"Quarter"	TEXT(80) NULL DEFAULT 'NS',
	"Line"	TEXT(80) NULL DEFAULT 'NS',
	"Subline"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"FromTo"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Purpose"	nTEXT(80) NULL DEFAULT 'NS',
	"ExtendedPurpose"	nTEXT(80) NULL DEFAULT 'NS',
	"ResourceType"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("TransfersId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SupplementalReimburseableEstimates" 
(
	"ReimbursableEstimatesId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Estimate"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ReimbursableEstimatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SupplementalCarryoverEstimates" 
(
	"SupplementalCarryoverEstimatesID"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Estimate"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("SupplementalCarryoverEstimatesID" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SuperfundSites" 
(
	"SuperfundSitesId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"City"	TEXT(80) NULL DEFAULT 'NS',
	"State"	TEXT(80) NULL DEFAULT 'NS',
	"SSID"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"EpaSiteId"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("SuperfundSitesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StatusOfJobsActFunding" 
(
	"StatusOfJobsActFundingId"	INTEGER NOT NULL,
	"StatusOfFundsId"	int,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"LowerName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Used"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Balance"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("StatusOfJobsActFundingId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StatusOfFunds" 
(
	"StatusOfFundsId"	INTEGER NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	nvarchar(80) NOT NULL COLLATE NOCASE,
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"LowerName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Used"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("StatusOfFundsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StatusOfAppropriations" 
(
	"StatusOfAppropriationsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundName"	TEXT(80) NULL DEFAULT 'NS',
	"Availability"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCreationDate"	datetime,
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationDescription"	TEXT(80) NULL DEFAULT 'NS',
	"FundGroup"	TEXT(80) NULL DEFAULT 'NS',
	"FundGroupName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"TransType"	TEXT(80) NULL DEFAULT 'NS',
	"ActualRecoveryTransType"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"AgreementLimit"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedRecoveriesTransType"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedReimbursmentsTransType"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenseSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PostedControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PostedFlag"	TEXT(80) NULL DEFAULT 'NS',
	"RecordCarryoverAtLowerLevel"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalBudgetedAmount"	DECIMAL NULL DEFAULT 0.0,
	"ApportionmentsPosted"	DECIMAL NULL DEFAULT 0.0,
	"TotalAuthority"	DECIMAL NULL DEFAULT 0.0,
	"TotalBudgeted"	DECIMAL NULL DEFAULT 0.0,
	"TotalPostedAmount"	DECIMAL NULL DEFAULT 0.0,
	"FundsWithdrawnPriorYearsAmount"	DECIMAL NULL DEFAULT 0.0,
	"FundingInAmount"	DECIMAL NULL DEFAULT 0.0,
	"FundingOutAmount"	DECIMAL NULL DEFAULT 0.0,
	"TotalAccrualRecoveries"	DECIMAL NULL DEFAULT 0.0,
	"TotalActualReimbursements"	DECIMAL NULL DEFAULT 0.0,
	"TotalAgreementReimbursables"	DECIMAL NULL DEFAULT 0.0,
	"TotalCarriedForwardIn"	DECIMAL NULL DEFAULT 0.0,
	"TotalCarriedForwardOut"	DECIMAL NULL DEFAULT 0.0,
	"TotalCommitted"	DECIMAL NULL DEFAULT 0.0,
	"TotalEstimatedRecoveries"	DECIMAL NULL DEFAULT 0.0,
	"TotalEstimatedReimbursements"	DECIMAL NULL DEFAULT 0.0,
	"TotalExpenses"	DECIMAL NULL DEFAULT 0.0,
	"TotalExpenditureExpenses"	DECIMAL NULL DEFAULT 0.0,
	"TotalExpenseAccruals"	DECIMAL NULL DEFAULT 0.0,
	"TotalPreCommitments"	DECIMAL NULL DEFAULT 0.0,
	"UnliquidatedPreCommitments"	DECIMAL NULL DEFAULT 0.0,
	"TotalObligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"VoidedAmount"	DECIMAL NULL DEFAULT 0.0,
	"TotalUsedAmount"	DECIMAL NULL DEFAULT 0.0,
	"AvailableAmount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("StatusOfAppropriationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StateOrganizations" 
(
	"StateOrganizationsId"	INTEGER NOT NULL,
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("StateOrganizationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StateGrantObligations" 
(
	"StateGrantObligationsId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"StateCode"	TEXT(80) NULL DEFAULT 'NS',
	"StateName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("StateGrantObligationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SpendingRates" 
(
	"SpendingRatesId"	INTEGER NOT NULL,
	"OmbAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbBureauCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbBureauName"	TEXT(80) NULL DEFAULT 'NS',
	"TreausuryAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreausuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreausuryAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountTitle"	TEXT(80) NULL DEFAULT 'NS',
	"Subfunction"	TEXT(80) NULL DEFAULT 'NS',
	"Line"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"Category"	TEXT(80) NULL DEFAULT 'NS',
	"Subcategory"	TEXT(80) NULL DEFAULT 'NS',
	"SubcategoryName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"Jurisdiction"	TEXT(80) NULL DEFAULT 'NS',
	"YearOfAuthority"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAuthority"	DECIMAL NULL DEFAULT 0.0,
	"OutYear1"	DECIMAL NULL DEFAULT 0.0,
	"OutYear2"	DECIMAL NULL DEFAULT 0.0,
	"OutYear3"	DECIMAL NULL DEFAULT 0.0,
	"OutYear4"	DECIMAL NULL DEFAULT 0.0,
	"OutYear5"	DECIMAL NULL DEFAULT 0.0,
	"OutYear6"	DECIMAL NULL DEFAULT 0.0,
	"OutYear7"	DECIMAL NULL DEFAULT 0.0,
	"OutYear8"	DECIMAL NULL DEFAULT 0.0,
	"OutYear9"	DECIMAL NULL DEFAULT 0.0,
	"OutYear10"	DECIMAL NULL DEFAULT 0.0,
	"OutYear11"	DECIMAL NULL DEFAULT 0.0,
	"TotalSpendout"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("SpendingRatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SpecialAccounts" 
(
	"SpecialAccountsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"SpecialAccountFund"	TEXT(80) NULL DEFAULT 'NS',
	"SpecialAccountNumber"	TEXT(80) NULL DEFAULT 'NS',
	"SpecialAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountStatus"	TEXT(80) NULL DEFAULT 'NS',
	"NplStatusCode"	TEXT(80) NULL DEFAULT 'NS',
	"NplStatusName"	TEXT(80) NULL DEFAULT 'NS',
	"SiteId"	TEXT(80) NULL DEFAULT 'NS',
	"CerclisId"	TEXT(80) NULL DEFAULT 'NS',
	"SiteCode"	TEXT(80) NULL DEFAULT 'NS',
	"SiteName"	TEXT(80) NULL DEFAULT 'NS',
	"OperableUnit"	TEXT(80) NULL DEFAULT 'NS',
	"PipelineCode"	TEXT(80) NULL DEFAULT 'NS',
	"PipelineDescription"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"TransactionType"	TEXT(80) NULL DEFAULT 'NS',
	"TransactionTypeName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"TransactionDate"	datetime,
	"AvailableBalance"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Disbursements"	DECIMAL NULL DEFAULT 0.0,
	"UnpaidBalances"	DECIMAL NULL DEFAULT 0.0,
	"Collections"	DECIMAL NULL DEFAULT 0.0,
	"CumulativeReceipts"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("SpecialAccountsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SiteProjectCodes" 
(
	"SiteProjectCodesId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"State"	TEXT(80) NULL DEFAULT 'NS',
	"CongressionalDistrict"	TEXT(80) NULL DEFAULT 'NS',
	"EpaSiteId"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"SSID"	TEXT(80) NULL DEFAULT 'NS',
	"ActionCode"	TEXT(80) NULL DEFAULT 'NS',
	"OperableUnit"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("SiteProjectCodesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SiteActivity" 
(
	"SiteActivityId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"EpaSiteId"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"SSID"	TEXT(80) NULL DEFAULT 'NS',
	"ActionCode"	TEXT(80) NULL DEFAULT 'NS',
	"OperableUnit"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"State"	TEXT(80) NULL DEFAULT 'NS',
	"City"	TEXT(80) NULL DEFAULT 'NS',
	"CongressionalDistrict"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectType"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	"LastActivity"	datetime,
	"Requested"	DECIMAL NULL DEFAULT 0.0,
	"Accepted"	DECIMAL NULL DEFAULT 0.0,
	"Closed"	DECIMAL NULL DEFAULT 0.0,
	"Outstanding"	DECIMAL NULL DEFAULT 0.0,
	"Refunded"	DECIMAL NULL DEFAULT 0.0,
	"Reversal"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("SiteActivityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "SchemaTypes" 
(
	"SchemaTypesId"	INTEGER NOT NULL,
	"TypeName"	TEXT(80) NULL DEFAULT 'NS',
	"Database"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("SchemaTypesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ResponsibilityCenters" 
(
	"ResponsibilityCentersId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Title"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ResponsibilityCentersId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Resources" 
(
	"ResourcesId"	INTEGER NOT NULL,
	"FileName"	TEXT(80) NULL DEFAULT 'NS',
	"FileType"	TEXT(80) NULL DEFAULT 'NS',
	"FilePath"	nTEXT(80) NULL DEFAULT 'NS',
	"FileExtension"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ResourcesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ResourcePlanningOffices" 
(
	"ResourcePlanningOfficesId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ResourcePlanningOfficesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Reprogrammings" 
(
	"ReprogrammingsId"	INTEGER NOT NULL,
	"DocPrefix"	TEXT(80) NULL DEFAULT 'NS',
	"ReprogrammingNumber"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"DocType"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"FromTo"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Purpose"	nTEXT(80) NULL DEFAULT 'NS',
	"ExtendedPurpose"	nTEXT(80) NULL DEFAULT 'NS',
	"ResourceType"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ReprogrammingsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Reports" 
(
	"ReportsId"	INTEGER NOT NULL,
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Title"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ReportsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ReimbursableFunds" 
(
	"ReimbursableFundsId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"AgreeementNumber"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ReimbursableFundsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "RegionalOffices" 
(
	"RegionalOfficesId"	INTEGER NOT NULL,
	"ResourcePlanningOfficesId"	int,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("RegionalOfficesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "RegionalAuthority" 
(
	"RegionalAuthorityId"	INTEGER NOT NULL,
	"AllocationsId"	int NOT NULL,
	"StatusOfFundsId"	int NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("RegionalAuthorityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ReferenceTables" 
(
	"ReferenceTablesId"	INTEGER NOT NULL,
	"TableName"	TEXT(80) NULL DEFAULT 'NS',
	"Type"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ReferenceTablesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "RecoveryAct" (
	"RecoveryActId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("RecoveryActId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "QueryDefinitions" 
(
	"QueryDefinitionsId"	INTEGER NOT NULL,
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Type"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("QueryDefinitionsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PublicLaws" 
(
	"PublicLawsId"	INTEGER NOT NULL,
	"LawNumber"	TEXT(80) NULL DEFAULT 'NS',
	"BillTitle"	TEXT(80) NULL DEFAULT 'NS',
	"EnactedDate"	datetime,
	"Congress"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("PublicLawsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Providers" (
	"ProvidersId"	INTEGER NOT NULL,
	"ProviderName"	TEXT(80) NULL DEFAULT 'NS',
	"FileExtension"	TEXT(80) NULL DEFAULT 'NS',
	"Connection"	TEXT(80) NULL DEFAULT 'NS',
	"Properties"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProvidersId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Projects" 
(
	"ProjectsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProjectsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ProjectCostCodes" 
(
	"ProjectCostCodesId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProjectCostCodesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ProgramProjects" 
(
	"ProgramProjectsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProgramProjectsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ProgramProjectDescriptions" 
(
	"ProgramProjectDescriptionsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramTitle"	TEXT(80) NULL DEFAULT 'NS',
	"Laws"	nTEXT(80) NULL DEFAULT 'NS',
	"Description"	nTEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProgramProjectDescriptionsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ProgramFinancingSchedule" 
(
	"ProgramFinancingScheduleId"	INTEGER NOT NULL,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"LedgerAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"SectionNumber"	TEXT(80) NULL DEFAULT 'NS',
	"SectionName"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineDescription"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbFundCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountTitle"	TEXT(80) NULL DEFAULT 'NS',
	"AgencySequence"	TEXT(80) NULL DEFAULT 'NS',
	"AccountSequence"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalAmount"	DECIMAL NULL DEFAULT 0.0,
	"BudgetAmount"	DECIMAL NULL DEFAULT 0.0,
	"AgencyAmount"	DECIMAL NULL DEFAULT 0.0,
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProgramFinancingScheduleId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ProgramAreas" 
(
	"ProgramAreasId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ProgramAreasId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PayrollRequests" 
(
	"PayrollRequestsId"	INTEGER NOT NULL,
	"ControlTeamAnalyst"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentTitle"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalRequestDate"	datetime,
	"LastActivityDate"	datetime,
	"BFS"	TEXT(80) NULL DEFAULT 'NS',
	"Comments"	TEXT(80) NULL DEFAULT 'NS',
	"RequestDocument"	nTEXT(80) NULL DEFAULT 'NS',
	"Duration"	int,
	PRIMARY KEY("PayrollRequestsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PayrollCostCodes" 
(
	"PayrollCostCodesId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"SubRcCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubRcName"	TEXT(80) NULL DEFAULT 'NS',
	"HrOrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"HrOrgName"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCode"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCodeName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("PayrollCostCodesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PayrollAuthority" 
(
	"PayrollAuthorityId"	INTEGER NOT NULL,
	"AllocationsId"	int,
	"StatusOfFundsId"	int,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("PayrollAuthorityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PayrollActivity" 
(
	"PayrollActivityId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"SubRcCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubRcName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"HrOrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"HrOrgName"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCode"	TEXT(80) NULL DEFAULT 'NS',
	"WorkCodeName"	TEXT(80) NULL DEFAULT 'NS',
	"PayPeriod"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	"CheckDate"	datetime,
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Hours"	DECIMAL NULL DEFAULT 0.0,
	"BasePaid"	DECIMAL NULL DEFAULT 0.0,
	"BaseHours"	DECIMAL NULL DEFAULT 0.0,
	"Benefits"	DECIMAL NULL DEFAULT 0.0,
	"OvertimePaid"	DECIMAL NULL DEFAULT 0.0,
	"OvertimeHours"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("PayrollActivityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "PayPeriods" 
(
	"PayPeriodsId"	INTEGER NOT NULL,
	"Period"	TEXT(80) NULL DEFAULT 'NS',
	"PayPeriod"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	PRIMARY KEY("PayPeriodsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Organizations" 
(
	"OrganizationsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"PreventNewUse"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"SecurityOrg"	TEXT(80) NULL DEFAULT 'NS',
	"Usage"	TEXT(80) NULL DEFAULT 'NS',
	"UseAsCostOrg"	TEXT(80) NULL DEFAULT 'NS',
	"SubCodeRequired"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubRcCode"	TEXT(80) NULL DEFAULT 'NS',
	"Description"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("OrganizationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "OperatingPlanUpdates" 
(
	"OperatingPlanUpdatesId"	INTEGER NOT NULL,
	"OppId"	int,
	"RPIO"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityName"	TEXT(80) NULL DEFAULT 'NS',
	"DivisionName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"GoalCode"	TEXT(80) NULL DEFAULT 'NS',
	"GoalName"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("OperatingPlanUpdatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "OperatingPlans" 
(
	"OperatingPlansId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ITProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectTypeName"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectTypeCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityName"	TEXT(80) NULL DEFAULT 'NS',
	"LocalCode"	TEXT(80) NULL DEFAULT 'NS',
	"LocalCodeName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"CostAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"CostAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"GoalCode"	TEXT(80) NULL DEFAULT 'NS',
	"GoalName"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("OperatingPlansId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "OpenCommitments" 
(
	"OpenCommitmentsId"	INTEGER NOT NULL,
	"ObligationsId"	int,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"LastActivityDate"	datetime,
	"Age"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("OpenCommitmentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "OMB" 
(
	"OmbId"	INTEGER NOT NULL,
	"AccountNumber"	TEXT(80) NULL DEFAULT 'NS',
	"AccountName"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"BureauName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("OmbId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Obligations" 
(
	"ObligationsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"LastActivityDate"	datetime,
	"Age"	DECIMAL NULL DEFAULT 0.0,
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ObligationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Objectives" 
(
	"ObjectivesId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Title"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ObjectivesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ObjectClassOutlays" 
(
	"ObjectClassOutlaysId"	INTEGER NOT NULL,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbBureauCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbBureauName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationType"	TEXT(80) NULL DEFAULT 'NS',
	"DirectReimbursableTitle"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectClassGroupNumber"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectClassGroupName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"FinanceObjectClass"	nvarchar(255) COLLATE NOCASE,
	"PriorYear"	DECIMAL NULL DEFAULT 0.0,
	"CurrentYear"	DECIMAL NULL DEFAULT 0.0,
	"BudgetYear"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ObjectClassOutlaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "NationalPrograms" (
	"NationalProgramsId"	int NOT NULL,
	"Code"	nvarchar(255) NOT NULL COLLATE NOCASE,
	"Name"	nvarchar(255) COLLATE NOCASE,
	"RpioCode"	nvarchar(255) COLLATE NOCASE,
	"Title"	nvarchar(255) COLLATE NOCASE
);

CREATE TABLE IF NOT EXISTS "MonthlyOutlays" 
(
	"MonthlyOutlaysId"	INTEGER NOT NULL,
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineTitle"	TEXT(80) NULL DEFAULT 'NS',
	"TaxationCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAccount"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbBureauCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"AgencySequence"	TEXT(80) NULL DEFAULT 'NS',
	"BureauSequence"	TEXT(80) NULL DEFAULT 'NS',
	"AccountSequence"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyTitle"	TEXT(80) NULL DEFAULT 'NS',
	"BureauTitle"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"October"	DECIMAL NULL DEFAULT 0.0,
	"November"	DECIMAL NULL DEFAULT 0.0,
	"December"	DECIMAL NULL DEFAULT 0.0,
	"January"	DECIMAL NULL DEFAULT 0.0,
	"Feburary"	DECIMAL NULL DEFAULT 0.0,
	"March"	DECIMAL NULL DEFAULT 0.0,
	"April"	DECIMAL NULL DEFAULT 0.0,
	"May"	DECIMAL NULL DEFAULT 0.0,
	"June"	DECIMAL NULL DEFAULT 0.0,
	"July"	DECIMAL NULL DEFAULT 0.0,
	"August"	DECIMAL NULL DEFAULT 0.0,
	"September"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("MonthlyOutlaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "MonthlyLedgerAccountBalances" 
(
	"MonthlyLedgerAccountBalancesId"	INTEGER NOT NULL,
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"LedgerAccount"	TEXT(80) NULL DEFAULT 'NS',
	"LedgerName"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbolName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"FiscalMonth"	TEXT(80) NULL DEFAULT 'NS',
	"CreditBalance"	DECIMAL NULL DEFAULT 0.0,
	"DebitBalance"	DECIMAL NULL DEFAULT 0.0,
	"YearToDateAmount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("MonthlyLedgerAccountBalancesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Messages" 
(
	"MessagesId"	INTEGER NOT NULL,
	"Message"	TEXT(80) NULL DEFAULT 'NS',
	"Type"	TEXT(80) NULL DEFAULT 'NS',
	"Form"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("MessagesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "LedgerAccounts" 
(
	"LedgerAccountsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"AccountNumber"	TEXT(80) NULL DEFAULT 'NS',
	"AccountName"	TEXT(80) NULL DEFAULT 'NS',
	"BeginningBalance"	DECIMAL NULL DEFAULT 0.0,
	"CreditBalance"	DECIMAL NULL DEFAULT 0.0,
	"DebitBalance"	DECIMAL NULL DEFAULT 0.0,
	"ClosingAmount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("LedgerAccountsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "JobsActCarryoverEstimates" 
(
	"CarryoverEstimatesId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Estimate"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("CarryoverEstimatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "InfrastructureAccounts" 
(
	"InfrastructureAccountsId"	INTEGER NOT NULL,
	"StrategicPlan"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"GoalCode"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramDescription"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("InfrastructureAccountsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Images" 
(
	"ImagesId"	INTEGER NOT NULL,
	"FileName"	TEXT(80) NULL DEFAULT 'NS',
	"FilePath"	TEXT(80) NULL DEFAULT 'NS',
	"FileExtension"	TEXT(80) NULL DEFAULT 'NS',
	"ImageFile"	image,
	"Attachments"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ImagesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "HumanResourceOrganizations" 
(
	"HumanResourceOrganizationsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("HumanResourceOrganizationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "HeadquartersOffices" 
(
	"HeadquartersOfficesId"	INTEGER NOT NULL,
	"ResourcePlanningOfficesId"	int,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("HeadquartersOfficesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "GsPayScales" 
(
	"GsPayScalesId"	INTEGER NOT NULL,
	"LOCNAME"	TEXT(80) NULL DEFAULT 'NS',
	"GRADE"	float,
	"ANNUAL1"	float,
	"HOURLY1"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME1"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL2"	float,
	"HOURLY2"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME2"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL3"	float,
	"HOURLY3"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME3"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL4"	float,
	"HOURLY4"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME4"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL5"	float,
	"HOURLY5"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME5"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL6"	float,
	"HOURLY6"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME6"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL7"	float,
	"HOURLY7"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME7"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL8"	float,
	"HOURLY8"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME8"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL9"	float,
	"HOURLY9"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME9"	TEXT(80) NULL DEFAULT 'NS',
	"ANNUAL10"	float,
	"HOURLY10"	TEXT(80) NULL DEFAULT 'NS',
	"OVERTIME10"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("GsPayScalesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "GrowthRates" 
(
	"GrowthRatesId"	int NOT NULL,
	"RateId"	INTEGER NOT NULL,
	"DESCRIPTION"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetYearRate"	DECIMAL NULL DEFAULT 0.0,
	"OutYear1"	DECIMAL NULL DEFAULT 0.0,
	"OutYear2"	DECIMAL NULL DEFAULT 0.0,
	"OutYear3"	DECIMAL NULL DEFAULT 0.0,
	"OutYear4"	DECIMAL NULL DEFAULT 0.0,
	"OutYear5"	DECIMAL NULL DEFAULT 0.0,
	"OutYear6"	DECIMAL NULL DEFAULT 0.0,
	"OutYear7"	DECIMAL NULL DEFAULT 0.0,
	"OutYear8"	DECIMAL NULL DEFAULT 0.0,
	"OutYear9"	DECIMAL NULL DEFAULT 0.0,
	"Sort"	TEXT(80) NULL DEFAULT 'NS',
	CONSTRAINT "PK_GrowthRates" PRIMARY KEY("GrowthRatesId")
);

CREATE TABLE IF NOT EXISTS "Goals" 
(
	"GoalsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"Title"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("GoalsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FundSymbols" 
(
	"FundSymbolsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("FundSymbolsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Funds" 
(
	"FundsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"ShortName"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	"SubLevelPrefix"	TEXT(80) NULL DEFAULT 'NS',
	"ATA"	TEXT(80) NULL DEFAULT 'NS',
	"AID"	TEXT(80) NULL DEFAULT 'NS',
	"BeginningPeriodOfAvailability"	TEXT(80) NULL DEFAULT 'NS',
	"EndingPeriodOfAvailability"	TEXT(80) NULL DEFAULT 'NS',
	"A"	TEXT(80) NULL DEFAULT 'NS',
	"MAIN"	TEXT(80) NULL DEFAULT 'NS',
	"SUB"	TEXT(80) NULL DEFAULT 'NS',
	"FundCategory"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundGroup"	TEXT(80) NULL DEFAULT 'NS',
	"NoYear"	TEXT(80) NULL DEFAULT 'NS',
	"Carryover"	TEXT(80) NULL DEFAULT 'NS',
	"AllowSpendAgainstCanceled"	TEXT(80) NULL DEFAULT 'NS',
	"AllowNewSpendAgainstExpired"	TEXT(80) NULL DEFAULT 'NS',
	"CanceledYearSpendingAccount"	TEXT(80) NULL DEFAULT 'NS',
	"ApplyAtAllLevels"	TEXT(80) NULL DEFAULT 'NS',
	"BatsFund"	TEXT(80) NULL DEFAULT 'NS',
	"BatsEndDate"	TEXT(80) NULL DEFAULT 'NS',
	"BatsOptionId"	TEXT(80) NULL DEFAULT 'NS',
	"SecurityOrg"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("FundsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FiscalYearsBackUp" 
(
	"FiscalYearsBackUpId"	INTEGER NOT NULL,
	"FiscalYearsId"	int,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FirstYear"	TEXT(80) NULL DEFAULT 'NS',
	"LastYear"	TEXT(80) NULL DEFAULT 'NS',
	"ExpiringYear"	TEXT(80) NULL DEFAULT 'NS',
	"CalendarYearStartDate"	datetime,
	"FiscalYearStartDate"	datetime,
	"CalendarYearEndDate"	datetime,
	"FiscalYearEndDate"	datetime,
	"ExpirationDate"	datetime,
	"Availability"	TEXT(80) NULL DEFAULT 'NS',
	"NewYears"	datetime,
	"MartinLutherKing"	datetime,
	"Presidents"	datetime,
	"Memorial"	datetime,
	"Juneteeth"	datetime,
	"Independence"	datetime,
	"Labor"	datetime,
	"Columbus"	datetime,
	"Veterans"	datetime,
	"Thanksgiving"	datetime,
	"Christmas"	datetime,
	"WorkDays"	int,
	"WeekDays"	int,
	"WeekEnds"	int,
	PRIMARY KEY("FiscalYearsBackUpId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FiscalYears" 
(
	"FiscalYearsId"	INTEGER NOT NULL,
	"BFY"	nvarchar(80) NOT NULL COLLATE NOCASE,
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	TEXT(80) NULL DEFAULT 'NS',
	"Columbus"	datetime,
	"Veterans"	datetime,
	"Thanksgiving"	datetime,
	"Christmas"	datetime,
	"NewYears"	datetime,
	"MartinLutherKing"	datetime,
	"Washingtons"	datetime,
	"Memorial"	datetime,
	"Juneteenth"	datetime,
	"Independence"	datetime,
	"Labor"	datetime,
	"ExpiringYear"	TEXT(80) NULL DEFAULT 'NS',
	"ExpirationDate"	TEXT(80) NULL DEFAULT 'NS',
	"WorkDays"	float,
	"WeekDays"	float,
	"WeekEnds"	float,
	"EndDate"	TEXT(80) NULL DEFAULT 'NS',
	"Availability"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("FiscalYearsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FinanceObjectClasses" (
	"FinanceObjectClassesId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("FinanceObjectClassesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FederalHolidays" 
(
	"FederalHolidaysId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"Columbus"	datetime,
	"Veterans"	datetime,
	"Thanksgiving"	datetime,
	"Christmas"	datetime,
	"NewYears"	datetime,
	"MartinLutherKing"	datetime,
	"Washingtons"	datetime,
	"Memorial"	datetime,
	"Juneteenth"	datetime,
	"Independence"	datetime,
	"Labor"	datetime,
	PRIMARY KEY("FederalHolidaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Expenditures" 
(
	"ExpendituresId"	INTEGER NOT NULL,
	"ObligationsId"	int,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	nvarchar(255) COLLATE NOCASE,
	"ProcessedDate"	datetime,
	"LastActivityDate"	datetime,
	"Age"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL(18, 0) DEFAULT (0),
	PRIMARY KEY("ExpendituresId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ExecutionTables" 
(
	"ExecutionTablesId"	INTEGER NOT NULL,
	"TableName"	TEXT(80) NULL DEFAULT 'NS',
	"Type"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ExecutionTablesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Earmarks" 
(
	"EarmarksId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"StateCode"	TEXT(80) NULL DEFAULT 'NS',
	"Description"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ProjectOfficerLastName"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectOfficerFirstName"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectOfficerPhoneNumber"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectOfficerMailCode"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentDate"	datetime,
	"ObligationDate"	datetime,
	"ProjectStatus"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectOfficerComments"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("EarmarksId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Documents" 
(
	"DocumentsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Category"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"System"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("DocumentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "DocumentControlNumbers" 
(
	"DocumentControlNumbersId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentPrefix"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("DocumentControlNumbersId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Deobligations" 
(
	"DeobligationsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"ProcessedDate"	datetime,
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("DeobligationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Defactos" 
(
	"DefactosId"	int NOT NULL,
	"StatusOfFundsId"	INTEGER NOT NULL,
	"BudgetLevel"	nvarchar(255) COLLATE NOCASE,
	"BFY"	nvarchar(255) COLLATE NOCASE,
	"EFY"	nvarchar(255) COLLATE NOCASE,
	"RpioCode"	nvarchar(255) COLLATE NOCASE,
	"RpioName"	nvarchar(255) COLLATE NOCASE,
	"AhCode"	nvarchar(255) COLLATE NOCASE,
	"AhName"	nvarchar(255) COLLATE NOCASE,
	"FundCode"	nvarchar(255) COLLATE NOCASE,
	"FundName"	nvarchar(255) COLLATE NOCASE,
	"OrgCode"	nvarchar(255) COLLATE NOCASE,
	"OrgName"	nvarchar(255) COLLATE NOCASE,
	"AccountCode"	nvarchar(255) COLLATE NOCASE,
	"RcCode"	nvarchar(255) COLLATE NOCASE,
	"BocCode"	nvarchar(255) COLLATE NOCASE,
	"BocName"	nvarchar(255) COLLATE NOCASE,
	"ProgramProjectCode"	nvarchar(255) COLLATE NOCASE,
	"ProgramProjectName"	nvarchar(255) COLLATE NOCASE,
	"ProgramAreaCode"	nvarchar(255) COLLATE NOCASE,
	"ProgramAreaName"	nvarchar(255) COLLATE NOCASE,
	"RcName"	nvarchar(255) COLLATE NOCASE,
	"LowerName"	nvarchar(255) COLLATE NOCASE,
	"Amount"	money,
	"Budgeted"	money,
	"Posted"	money,
	"OpenCommitments"	money,
	"ULO"	money,
	"Expenditures"	money,
	"Obligations"	money,
	"Used"	money,
	"Available"	money,
	"NpmCode"	nvarchar(255) COLLATE NOCASE,
	"NpmName"	nvarchar(255) COLLATE NOCASE,
	CONSTRAINT "PK_Defactos" PRIMARY KEY("DefactosId")
);

CREATE TABLE IF NOT EXISTS "DataRuleDescriptions" 
(
	"DataRuleDescriptionsId"	INTEGER NOT NULL,
	"Schedule"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"RuleNumber"	TEXT(80) NULL DEFAULT 'NS',
	"RuleDescription"	nTEXT(80) NULL DEFAULT 'NS',
	"ScheduleOrder"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("DataRuleDescriptionsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CostAreas" 
(
	"CostAreasId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("CostAreasId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Contacts"
 (
	"ContactsId"	INTEGER NOT NULL,
	"FirstName"	TEXT(80) NULL DEFAULT 'NS',
	"LastName"	TEXT(80) NULL DEFAULT 'NS',
	"FullName"	TEXT(80) NULL DEFAULT 'NS',
	"Email"	TEXT(80) NULL DEFAULT 'NS',
	"RPIO"	TEXT(80) NULL DEFAULT 'NS',
	"Section"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ContactsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CongressionalReprogrammings" 
(
	"CongressionalReprogrammingsId"	INTEGER NOT NULL,
	"ReprogrammingNumber"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Description"	nvarchar(155) COLLATE NOCASE,
	"ExtendedDescription"	nTEXT(80) NULL DEFAULT 'NS',
	"FromTo"	TEXT(80) NULL DEFAULT 'NS',
	"Cycle"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("CongressionalReprogrammingsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CongressionalControls" 
(
	"CongressionalControlsId"	INTEGER NOT NULL,
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"SubProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ReprogrammingRestriction"	TEXT(80) NULL DEFAULT 'NS',
	"IncreaseRestriction"	TEXT(80) NULL DEFAULT 'NS',
	"DecreaseRestriction"	TEXT(80) NULL DEFAULT 'NS',
	"MemoRequirement"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("CongressionalControlsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CompassOutlays" 
(
	"CompassOutlaysId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"TotalObligations"	DECIMAL NULL DEFAULT 0.0,
	"UnliquidatedObligations"	DECIMAL NULL DEFAULT 0.0,
	"ObligationsPaid"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("CompassOutlaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CompassLevels" 
(
	"CompassLevelsId"	INTEGER NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccount"	TEXT(80) NULL DEFAULT 'NS',
	"PostedControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"ActualRecoveryTransType"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetDefault"	TEXT(80) NULL DEFAULT 'NS',
	"LowerChildExpenditureSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerChildExpenseSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"FteControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"AccrualSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerCommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerObligationSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerExpenditureSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerExpenseSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerPostedControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerPostedTransType"	TEXT(80) NULL DEFAULT 'NS',
	"LowerTransType"	TEXT(80) NULL DEFAULT 'NS',
	"LowerPostedFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerPreCommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"LowerRecoveriesSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"LowerRecoveriesOption"	TEXT(80) NULL DEFAULT 'NS',
	"LowerReimbursableSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"Date"	datetime,
	"TotalAuthority"	DECIMAL NULL DEFAULT 0.0,
	"OriginalAmount"	DECIMAL NULL DEFAULT 0.0,
	"CarryoverAvailabilityPercentage"	DECIMAL NULL DEFAULT 0.0,
	"CarryIn"	DECIMAL NULL DEFAULT 0.0,
	"CarryOut"	DECIMAL NULL DEFAULT 0.0,
	"FundsIn"	DECIMAL NULL DEFAULT 0.0,
	"FundsOut"	DECIMAL NULL DEFAULT 0.0,
	"RecoveriesWithdrawn"	DECIMAL NULL DEFAULT 0.0,
	"ActualRecoveries"	DECIMAL NULL DEFAULT 0.0,
	"ActualReimbursements"	DECIMAL NULL DEFAULT 0.0,
	"AgreementReimbursables"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("CompassLevelsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Changes" 
(
	"ChangesId"	INTEGER NOT NULL,
	"TableName"	TEXT(80) NULL DEFAULT 'NS',
	"FieldName"	TEXT(80) NULL DEFAULT 'NS',
	"Action"	TEXT(80) NULL DEFAULT 'NS',
	"OldValue"	TEXT(80) NULL DEFAULT 'NS',
	"NewValue"	TEXT(80) NULL DEFAULT 'NS',
	"TimeStamp"	datetime,
	"Message"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ChangesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CarryoverRequests" 
(
	"CarryoverRequestsId"	INTEGER NOT NULL,
	"ControlTeamAnalyst"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentTitle"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalRequestDate"	datetime,
	"LastActivityDate"	datetime,
	"BFS"	TEXT(80) NULL DEFAULT 'NS',
	"Comments"	nTEXT(80) NULL DEFAULT 'NS',
	"RequestDocument"	nTEXT(80) NULL DEFAULT 'NS',
	"Duration"	int,
	PRIMARY KEY("CarryoverRequestsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CarryoverApportionments" 
(
	"CarryoverApportionmentsId"	INTEGER NOT NULL,
	"BudgetAccount"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccount"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"Group"	TEXT(80) NULL DEFAULT 'NS',
	"Description"	TEXT(80) NULL DEFAULT 'NS',
	"LineName"	TEXT(80) NULL DEFAULT 'NS',
	"AuthorityType"	TEXT(80) NULL DEFAULT 'NS',
	"Request"	DECIMAL NULL DEFAULT 0.0,
	"Balance"	DECIMAL NULL DEFAULT 0.0,
	"Deobligations"	DECIMAL NULL DEFAULT 0.0,
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineSplit"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("CarryoverApportionmentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CapitalPlanningInvestmentCodes" 
(
	"CapitalPlanningInvestmentCodesId"	INTEGER NOT NULL,
	"Type"	TEXT(80) NULL DEFAULT 'NS',
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("CapitalPlanningInvestmentCodesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "BudgetOutlays" 
(
	"BudgetOutlaysId"	INTEGER NOT NULL,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccount"	TEXT(80) NULL DEFAULT 'NS',
	"Line"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineSection"	TEXT(80) NULL DEFAULT 'NS',
	"LineName"	TEXT(80) NULL DEFAULT 'NS',
	"BeaCategory"	TEXT(80) NULL DEFAULT 'NS',
	"BeaCategoryName"	TEXT(80) NULL DEFAULT 'NS',
	"LineCategory"	TEXT(80) NULL DEFAULT 'NS',
	"PriorYear"	DECIMAL NULL DEFAULT 0.0,
	"CurrentYear"	DECIMAL NULL DEFAULT 0.0,
	"BudgetYear"	DECIMAL NULL DEFAULT 0.0,
	"OutYear1"	DECIMAL NULL DEFAULT 0.0,
	"OutYear2"	DECIMAL NULL DEFAULT 0.0,
	"OutYear3"	DECIMAL NULL DEFAULT 0.0,
	"OutYear4"	DECIMAL NULL DEFAULT 0.0,
	"OutYear5"	DECIMAL NULL DEFAULT 0.0,
	"OutYear6"	DECIMAL NULL DEFAULT 0.0,
	"OutYear7"	DECIMAL NULL DEFAULT 0.0,
	"OutYear8"	DECIMAL NULL DEFAULT 0.0,
	"OutYear9"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("BudgetOutlaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "BudgetObjectClasses" 
(
	"BudgetObjectClassesId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("BudgetObjectClassesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "BudgetDocuments" 
(
	"BudgetDocumentsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentDate"	datetime,
	"LastDocumentDate"	datetime,
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableAgreementControls"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetingControls"	TEXT(80) NULL DEFAULT 'NS',
	"PostingControls"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentControls"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentControls"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationControls"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenditureControls"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenseControls"	TEXT(80) NULL DEFAULT 'NS',
	"AccrualControls"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursementControls"	TEXT(80) NULL DEFAULT 'NS',
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"CarryOut"	DECIMAL NULL DEFAULT 0.0,
	"CarryIn"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedRecoveries"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedReimbursements"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("BudgetDocumentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "BudgetControls" 
(
	"BudgetControlsId"	INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetedTransType"	TEXT(80) NULL DEFAULT 'NS',
	"PostedTransType"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedReimbursementsTransType"	TEXT(80) NULL DEFAULT 'NS',
	"SpendingAdjustmentTransType"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedRecoveriesTransType"	TEXT(80) NULL DEFAULT 'NS',
	"ActualRecoveriesTransType"	TEXT(80) NULL DEFAULT 'NS',
	"StatusReserveTransType"	TEXT(80) NULL DEFAULT 'NS',
	"ProfitLossTransType"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedReimbursementsSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedReimursementsBudgetingOption"	TEXT(80) NULL DEFAULT 'NS',
	"TrackAgreementLowerLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetEstimatedLowerLevel"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedRecoveriesSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedRecoveriesBudgetingOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveryNextLevel"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveryBudgetMismatch"	TEXT(80) NULL DEFAULT 'NS',
	"ProfitLossSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"ProfitLossBudgetOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesCarryInLowerLevel"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesCarryInLowerLevelControl"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesCarryInAmountControl"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetedControl"	TEXT(80) NULL DEFAULT 'NS',
	"PostedControl"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"AccrualSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenditureSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenseSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableAgreementSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"FteBudgetingControl"	TEXT(80) NULL DEFAULT 'NS',
	"FteSpendingControl"	TEXT(80) NULL DEFAULT 'NS',
	"TransactionTypeControl"	TEXT(80) NULL DEFAULT 'NS',
	"AuthorityDistributionControl"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("BudgetControlsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "BudgetaryResourceExecution" 
(
	"BudgetaryResourceExecutionId"	INTEGER NOT NULL,
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"LastUpdate"	DATETIME NULL,
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccount"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"STAT"	TEXT(80) NULL DEFAULT 'NS',
	"CreditIndicator"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineDescription"	TEXT(80) NULL DEFAULT 'NS',
	"SectionName"	TEXT(80) NULL DEFAULT 'NS',
	"SectionNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineType"	TEXT(80) NULL DEFAULT 'NS',
	"FinancingAccounts"	TEXT(80) NULL DEFAULT 'NS',
	"November"	DECIMAL NULL DEFAULT 0.0,
	"January"	DECIMAL NULL DEFAULT 0.0,
	"Feburary"	DECIMAL NULL DEFAULT 0.0,
	"April"	DECIMAL NULL DEFAULT 0.0,
	"May"	DECIMAL NULL DEFAULT 0.0,
	"June"	DECIMAL NULL DEFAULT 0.0,
	"August"	DECIMAL NULL DEFAULT 0.0,
	"October"	DECIMAL NULL DEFAULT 0.0,
	"Amount1"	DECIMAL NULL DEFAULT 0.0,
	"Amount2"	DECIMAL NULL DEFAULT 0.0,
	"Amount3"	DECIMAL NULL DEFAULT 0.0,
	"Amount4"	DECIMAL NULL DEFAULT 0.0,
	"Agency"	TEXT(80) NULL DEFAULT 'NS',
	"Bureau"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("BudgetaryResourceExecutionId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Appropriations"
(
	"AppropriationsId"	INTEGER NOT NULL,
	"BFY"	nvarchar(80) NOT NULL COLLATE NOCASE,
	"Title"	TEXT(80) NULL DEFAULT 'NS',
	"PublicLaw"	TEXT(80) NULL DEFAULT 'NS',
	"EnactedDate"	datetime,
	PRIMARY KEY("AppropriationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AppropriationLevelAuthority" 
(
	"AppropriationLevelAuthorityId"	INTEGER NOT NULL,
	"BudgetAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"CarryOut"	DECIMAL NULL DEFAULT 0.0,
	"CarryIn"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedReimbursements"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedRecoveries"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AppropriationLevelAuthorityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AppropriationAvailableBalances" 
(
	"AppropriationAvailableBalancesId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"Availability"	TEXT(80) NULL DEFAULT 'NS',
	"TotalAuthority"	DECIMAL NULL DEFAULT 0.0,
	"TotalUsed"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AppropriationAvailableBalancesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ApportionmentData" 
(
	"ApportionmentDataId"	INTEGER NOT NULL,
	"FiscalYear"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAppropriationFundSymbol"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAppropriationFundSymbolName"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ApportionmentAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"AvailabilityType"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"ApprovalDate"	datetime,
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"LineName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ApportionmentDataId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ApplicationTables" 
(
	"ApplicationTablesId"	INTEGER NOT NULL,
	"TableName"	TEXT(80) NULL DEFAULT 'NS',
	"Model"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("ApplicationTablesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AnnualReimbursableSurvey" 
(
	"AnnualReimbursableSurveyId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AnnualReimbursableSurveyId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AnnualReimbursableEstimates" 
(
	"AnnualReimbursableEstimatesId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Estimate"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AnnualReimbursableEstimatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Accounts" 
(
	"AccountsId"	INTEGER,
	"Code"	TEXT(80) DEFAULT 'NS',
	"GoalCode"	TEXT(80) DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) DEFAULT 'NS',
	"NpmCode"	TEXT(80) DEFAULT 'NS',
	"NpmName"	TEXT(80) DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) DEFAULT 'NS',
	"ActivityCode"	TEXT(80) DEFAULT 'NS',
	"ActivityName"	TEXT(80) DEFAULT 'NS',
	"AgencyActivity"	TEXT(80) DEFAULT 'NS',
	PRIMARY KEY("AccountsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AnnualCarryoverSurvey" 
(
	"AnnualCarryoverSurveyId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AnnualCarryoverSurveyId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AnnualCarryoverEstimates" 
(
	"AnnualCarryoverEstimatesId" INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"TreasuryAccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Estimate"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AnnualCarryoverEstimatesId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AmericanRescuePlan" 
(
	"AmericanRescuePlanId"	int NOT NULL,
	"StatusOfFundsId"	int NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"LowerName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Used"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	CONSTRAINT "AmericanRescuePlanPrimaryKey" PRIMARY KEY("AmericanRescuePlanId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AllowanceHolders" 
(
	"AllowanceHoldersId" INTEGER NOT NULL,
	"Code"	TEXT(80) NULL DEFAULT 'NS',
	"Name"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("AllowanceHoldersId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "Allocations" 
(
	"AllocationsId"	INTEGER NOT NULL,
	"StatusOfFundsId"	INTEGER NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("AllocationsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "HeadquartersAuthority" 
(
	"HeadquartersAuthorityId"	INTEGER,
	"AllocationsId"	int NOT NULL,
	"StatusOfFundsId"	int NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	CONSTRAINT "HeadquartersAuthorityStatusOfFundsForeignKey" FOREIGN KEY("StatusOfFundsId") REFERENCES "StatusOfFunds"("StatusOfFundsId") ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT "HeadquartersAuthorityAllocationsForeignKey" FOREIGN KEY("AllocationsId") REFERENCES "Allocations"("AllocationsId") ON DELETE NO ACTION ON UPDATE NO ACTION,
	PRIMARY KEY("HeadquartersAuthorityId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "FullTimeEquivalents" 
(
	"FullTimeEquivialentsId"	INTEGER NOT NULL,
	"OperatingPlansId"	INTEGER NOT NULL,
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"ITProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectTypeName"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectTypeCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityCode"	TEXT(80) NULL DEFAULT 'NS',
	"ActivityName"	TEXT(80) NULL DEFAULT 'NS',
	"LocalCode"	TEXT(80) NULL DEFAULT 'NS',
	"LocalCodeName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"CostAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"CostAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"GoalCode"	TEXT(80) NULL DEFAULT 'NS',
	"GoalName"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveCode"	TEXT(80) NULL DEFAULT 'NS',
	"ObjectiveName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("FullTimeEquivialentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "CarryoverOutlays" 
(
	"CarryoverOutlaysId"	INTEGER NOT NULL,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"LINE"	TEXT(80) NULL DEFAULT 'NS',
	"Carryover"	DECIMAL NULL DEFAULT 0.0,
	"CarryoverOutlays"	DECIMAL NULL DEFAULT 0.0,
	"Delta"	DECIMAL NULL DEFAULT 0.0,
	"AvailableBalance"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"CurrentYearAdjustment"	DECIMAL NULL DEFAULT 0.0,
	"BudgetYearAdjustment"	DECIMAL NULL DEFAULT 0.0,
	"CurrentYear"	DECIMAL NULL DEFAULT 0.0,
	"BudgetYear"	DECIMAL NULL DEFAULT 0.0,
	"OutYear1"	DECIMAL NULL DEFAULT 0.0,
	"OutYear2"	DECIMAL NULL DEFAULT 0.0,
	"OutYear3"	DECIMAL NULL DEFAULT 0.0,
	"OutYear4"	DECIMAL NULL DEFAULT 0.0,
	"OutYear5"	DECIMAL NULL DEFAULT 0.0,
	"OutYear6"	DECIMAL NULL DEFAULT 0.0,
	"OutYear7"	DECIMAL NULL DEFAULT 0.0,
	"OutYear8"	DECIMAL NULL DEFAULT 0.0,
	"OutYear9"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("CarryoverOutlaysId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "AppropriationDocuments" 
(
	"AppropriationDocumentsId"	INTEGER NOT NULL,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFund"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentNumber"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentDate"	TEXT(80) NULL DEFAULT 'NS',
	"LastDocumentDate"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetingControls"	TEXT(80) NULL DEFAULT 'NS',
	"PostingControls"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentControls"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentControls"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationControls"	TEXT(80) NULL DEFAULT 'NS',
	"AccrualControls"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenditureControls"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenseControls"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursementControls"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableAgreementControls"	TEXT(80) NULL DEFAULT 'NS',
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"CarryOut"	DECIMAL NULL DEFAULT 0.0,
	"CarryIn"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedReimbursements"	DECIMAL NULL DEFAULT 0.0,
	"EstimatedRecoveries"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("AppropriationDocumentsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "ReimbursableAgreements" 
(
	"ReimbursableAgreementsId"	INTEGER NOT NULL,
	"RPIO"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"AgreementNumber"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	datetime,
	"EndDate"	datetime,
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorCode"	TEXT(80) NULL DEFAULT 'NS',
	"VendorName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY("ReimbursableAgreementsId" AUTOINCREMENT)
);

CREATE TABLE IF NOT EXISTS "StatusOfSupplementalFunding" 
(
	"SupplementalAuthorityId"	INTEGER NOT NULL,
	"StatusOfFundsId"	INTEGER NOT NULL,
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"AhName"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramAreaName"	TEXT(80) NULL DEFAULT 'NS',
	"RcCode"	TEXT(80) NULL DEFAULT 'NS',
	"RcName"	TEXT(80) NULL DEFAULT 'NS',
	"LowerName"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	DECIMAL NULL DEFAULT 0.0,
	"Budgeted"	DECIMAL NULL DEFAULT 0.0,
	"Posted"	DECIMAL NULL DEFAULT 0.0,
	"OpenCommitments"	DECIMAL NULL DEFAULT 0.0,
	"ULO"	DECIMAL NULL DEFAULT 0.0,
	"Expenditures"	DECIMAL NULL DEFAULT 0.0,
	"Obligations"	DECIMAL NULL DEFAULT 0.0,
	"Used"	DECIMAL NULL DEFAULT 0.0,
	"Available"	DECIMAL NULL DEFAULT 0.0,
	"Balance"	DECIMAL NULL DEFAULT 0.0,
	"NpmCode"	TEXT(80) NULL DEFAULT 'NS',
	"NpmName"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("SupplementalAuthorityId" AUTOINCREMENT)
);
COMMIT;
