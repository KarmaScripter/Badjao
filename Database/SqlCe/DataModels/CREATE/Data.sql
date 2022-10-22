BEGIN 
CREATE TABLE [URL] 
(
  [UrlsId] int IDENTITY (35,1) NOT NULL
, [Name] nvarchar(80) NULL
, [Location] nvarchar(80) NULL
, [Address] ntext NULL
);

CREATE TABLE [UnobligatedBalances] (
  [UnobligatedBalancesId] int IDENTITY (35334,1) NOT NULL
, [BudgetYear] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [AccountNumber] nvarchar(80) NULL
, [AccountName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [UnobligatedAuthority] (
  [UnobligatedAuthorityId] int IDENTITY (49,1) NOT NULL
, [ReportYear] nvarchar(80) NULL
, [AgencyCode] nvarchar(80) NULL
, [BureauCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [OmbAccount] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [LineName] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [BudgetYear] numeric(18,0) NULL
, [PriorYear] numeric(18,0) NULL
, [CurrentYear] numeric(18,0) NULL
, [AgencyName] nvarchar(80) NULL
, [BureauName] nvarchar(80) NULL
);

CREATE TABLE [UnliquidatedObligations] (
  [UnliquidatedObligationsId] int IDENTITY (82357,1) NOT NULL
, [ObligationsId] int NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [LastActivityDate] datetime NULL
, [Age] float NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [TravelActivity] (
  [TravelActivityId] int IDENTITY (2,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [FirstName] nvarchar(80) NULL
, [LastName] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
, [Duration] float NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [Obligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
);

CREATE TABLE [TransTypes] (
  [TransTypesId] int IDENTITY (97,1) NOT NULL
, [FundCode] nvarchar(80) NULL
, [Appropriation] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [DocType] nvarchar(80) NULL
, [AppropriationBill] nvarchar(80) NULL
, [ContinuingResolution] nvarchar(80) NULL
, [RescissionCurrentYear] nvarchar(80) NULL
, [RescissionPriorYear] nvarchar(80) NULL
, [SequesterReduction] nvarchar(80) NULL
, [SequesterReturn] nvarchar(80) NULL
);

CREATE TABLE [Transfers] (
  [TransfersId] int IDENTITY (2,1) NOT NULL
, [BudgetLevel] nvarchar(80) NULL
, [DocPrefix] nvarchar(80) NULL
, [DocType] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [ReprogrammingNumber] nvarchar(80) NULL
, [ControlNumber] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [Quarter] nvarchar(80) NULL
, [Line] nvarchar(80) NULL
, [Subline] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [FromTo] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Purpose] ntext NULL
, [ExtendedPurpose] ntext NULL
, [ResourceType] nvarchar(80) NULL
);

CREATE TABLE [SupplementalReimburseableEstimates] (
  [ReimbursableEstimatesId] int IDENTITY (2,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Estimate] numeric(18,0) NULL
);

CREATE TABLE [SupplementalCarryoverEstimates] (
  [SupplementalCarryoverEstimatesID] int IDENTITY (765,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Estimate] numeric(18,0) NULL
);

CREATE TABLE [SuperfundSites] (
  [SuperfundSitesId] int IDENTITY (13718,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [City] nvarchar(80) NULL
, [State] nvarchar(80) NULL
, [SSID] nvarchar(80) NULL
, [SiteProjectName] nvarchar(80) NULL
, [EpaSiteId] nvarchar(80) NULL
);

CREATE TABLE [StatusOfJobsActFunding] (
  [StatusOfJobsActFundingId] int IDENTITY (50369,1) NOT NULL
, [StatusOfFundsId] int NULL
, [BudgetLevel] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [LowerName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Used] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Balance] numeric(18,0) NULL
);

CREATE TABLE [StatusOfFunds] (
  [StatusOfFundsId] int IDENTITY (16413,1) NOT NULL
, [BudgetLevel] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NOT NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [LowerName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Used] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [StatusOfSupplementalFunding] (
  [SupplementalAuthorityId] int IDENTITY (15013,1) NOT NULL
, [StatusOfFundsId] int NULL
, [BudgetLevel] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [LowerName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Used] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Balance] numeric(18,0) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [StatusOfAppropriations] (
  [StatusOfAppropriationsId] int IDENTITY (51123,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [AppropriationFundCode] nvarchar(80) NULL
, [AppropriationFundName] nvarchar(80) NULL
, [Availability] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [AppropriationCreationDate] datetime NULL
, [AppropriationCode] nvarchar(80) NULL
, [SubAppropriationCode] nvarchar(80) NULL
, [AppropriationDescription] nvarchar(80) NULL
, [FundGroup] nvarchar(80) NULL
, [FundGroupName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [TransType] nvarchar(80) NULL
, [ActualRecoveryTransType] nvarchar(80) NULL
, [CommitmentSpendingControlFlag] nvarchar(80) NULL
, [AgreementLimit] nvarchar(80) NULL
, [EstimatedRecoveriesTransType] nvarchar(80) NULL
, [EstimatedReimbursmentsTransType] nvarchar(80) NULL
, [ExpenseSpendingControlFlag] nvarchar(80) NULL
, [ObligationSpendingControlFlag] nvarchar(80) NULL
, [PreCommitmentSpendingControlFlag] nvarchar(80) NULL
, [PostedControlFlag] nvarchar(80) NULL
, [PostedFlag] nvarchar(80) NULL
, [RecordCarryoverAtLowerLevel] nvarchar(80) NULL
, [ReimbursableSpendinption] nvarchar(80) NULL
, [RecoveriesOption] nvarchar(80) NULL
, [RecoveriesSpendinption] nvarchar(80) NULL
, [OriginalBudgetedAmount] numeric(18,0) NULL
, [ApportionmentsPosted] numeric(18,0) NULL
, [TotalAuthority] numeric(18,0) NULL
, [TotalBudgeted] numeric(18,0) NULL
, [TotalPostedAmount] numeric(18,0) NULL
, [FundsWithdrawnPriorYearsAmount] numeric(18,0) NULL
, [FundingInAmount] numeric(18,0) NULL
, [FundinutAmount] numeric(18,0) NULL
, [TotalAccrualRecoveries] numeric(18,0) NULL
, [TotalActualReimbursements] numeric(18,0) NULL
, [TotalAgreementReimbursables] numeric(18,0) NULL
, [TotalCarriedForwardIn] numeric(18,0) NULL
, [TotalCarriedForwardOut] numeric(18,0) NULL
, [TotalCommitted] numeric(18,0) NULL
, [TotalEstimatedRecoveries] numeric(18,0) NULL
, [TotalEstimatedReimbursements] numeric(18,0) NULL
, [TotalExpenses] numeric(18,0) NULL
, [TotalExpenditureExpenses] numeric(18,0) NULL
, [TotalExpenseAccruals] numeric(18,0) NULL
, [TotalPreCommitments] numeric(18,0) NULL
, [UnliquidatedPreCommitments] numeric(18,0) NULL
, [TotalObligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [VoidedAmount] numeric(18,0) NULL
, [TotalUsedAmount] numeric(18,0) NULL
, [AvailableAmount] numeric(18,0) NULL
);

CREATE TABLE [StateOrganizations] (
  [StateOrganizationsId] int IDENTITY (150,1) NOT NULL
, [Name] nvarchar(80) NULL
, [Code] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
);

CREATE TABLE [StateGrantObligations] (
  [StateGrantObligationsId] int IDENTITY (12833,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [StateCode] nvarchar(80) NULL
, [StateName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [SpendingRates] (
  [SpendingRatesId] int IDENTITY (107,1) NOT NULL
, [OmbAgencyCode] nvarchar(80) NULL
, [OmbAgencyName] nvarchar(80) NULL
, [OmbBureauCode] nvarchar(80) NULL
, [OmbBureauName] nvarchar(80) NULL
, [TreausuryAgencyCode] nvarchar(80) NULL
, [TreausuryAccountCode] nvarchar(80) NULL
, [TreausuryAccountName] nvarchar(80) NULL
, [AccountTitle] nvarchar(80) NULL
, [Subfunction] nvarchar(80) NULL
, [Line] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [Catery] nvarchar(80) NULL
, [Subcatery] nvarchar(80) NULL
, [SubcateryName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [Jurisdiction] nvarchar(80) NULL
, [YearOfAuthority] nvarchar(80) NULL
, [BudgetAuthority] numeric(18,0) NULL
, [OutYear1] numeric(18,0) NULL
, [OutYear2] numeric(18,0) NULL
, [OutYear3] numeric(18,0) NULL
, [OutYear4] numeric(18,0) NULL
, [OutYear5] numeric(18,0) NULL
, [OutYear6] numeric(18,0) NULL
, [OutYear7] numeric(18,0) NULL
, [OutYear8] numeric(18,0) NULL
, [OutYear9] numeric(18,0) NULL
, [OutYear10] numeric(18,0) NULL
, [OutYear11] numeric(18,0) NULL
, [TotalSpendout] numeric(18,0) NULL
);

CREATE TABLE [SpecialAccounts] (
  [SpecialAccountsId] int IDENTITY (957754,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [SpecialAccountFund] nvarchar(80) NULL
, [SpecialAccountNumber] nvarchar(80) NULL
, [SpecialAccountName] nvarchar(80) NULL
, [AccountStatus] nvarchar(80) NULL
, [NplStatusCode] nvarchar(80) NULL
, [NplStatusName] nvarchar(80) NULL
, [SiteId] nvarchar(80) NULL
, [CerclisId] nvarchar(80) NULL
, [SiteCode] nvarchar(80) NULL
, [SiteName] nvarchar(80) NULL
, [OperableUnit] nvarchar(80) NULL
, [PipelineCode] nvarchar(80) NULL
, [PipelineDescription] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [TransactionType] nvarchar(80) NULL
, [TransactionTypeName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [TransactionDate] datetime NULL
, [AvailableBalance] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Disbursements] numeric(18,0) NULL
, [UnpaidBalances] numeric(18,0) NULL
, [Collections] numeric(18,0) NULL
, [CumulativeReceipts] numeric(18,0) NULL
);

CREATE TABLE [SiteProjectCodes] (
  [SiteProjectCodesId] int IDENTITY (8988,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [State] nvarchar(80) NULL
, [CongressionalDistrict] nvarchar(80) NULL
, [EpaSiteId] nvarchar(80) NULL
, [SiteProjectName] nvarchar(80) NULL
, [SiteProjectCode] nvarchar(80) NULL
, [SSID] nvarchar(80) NULL
, [ActionCode] nvarchar(80) NULL
, [OperableUnit] nvarchar(80) NULL
);

CREATE TABLE [SiteActivity] (
  [SiteActivityId] int IDENTITY (266266,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [EpaSiteId] nvarchar(80) NULL
, [SiteProjectCode] nvarchar(80) NULL
, [SSID] nvarchar(80) NULL
, [ActionCode] nvarchar(80) NULL
, [OperableUnit] nvarchar(80) NULL
, [SiteProjectName] nvarchar(80) NULL
, [State] nvarchar(80) NULL
, [City] nvarchar(80) NULL
, [CongressionalDistrict] nvarchar(80) NULL
, [ProjectType] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
, [LastActivity] datetime NULL
, [Requested] numeric(18,0) NULL
, [Accepted] numeric(18,0) NULL
, [Closed] numeric(18,0) NULL
, [Outstanding] numeric(18,0) NULL
, [Refunded] numeric(18,0) NULL
, [Reversal] numeric(18,0) NULL
);

CREATE TABLE [SchemaTypes] (
  [SchemaTypesId] int IDENTITY (46,1) NOT NULL
, [TypeName] nvarchar(80) NULL
, [Database] nvarchar(80) NULL
);

CREATE TABLE [ResponsibilityCenters] (
  [ResponsibilityCentersId] int IDENTITY (1314,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [Title] nvarchar(80) NULL
);

CREATE TABLE [Resources] (
  [ResourcesId] int IDENTITY (78,1) NOT NULL
, [FileName] nvarchar(80) NULL
, [FileType] nvarchar(80) NULL
, [FilePath] ntext NULL
, [FileExtension] nvarchar(80) NULL
);

CREATE TABLE [ResourcePlanninffices] (
  [ResourcePlanninfficesId] int IDENTITY (36,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [Reprogrammings] (
  [ReprogrammingsId] int IDENTITY (538644,1) NOT NULL
, [DocPrefix] nvarchar(80) NULL
, [ReprogrammingNumber] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [DocType] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [FromTo] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Purpose] ntext NULL
, [ExtendedPurpose] ntext NULL
, [ResourceType] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [Reports] (
  [ReportsId] int IDENTITY (55,1) NOT NULL
, [Name] nvarchar(80) NULL
, [Title] nvarchar(80) NULL
);

CREATE TABLE [ReimbursableFunds] (
  [ReimbursableFundsId] int IDENTITY (871310,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [AgreeementNumber] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
);

CREATE TABLE [ReimbursableAgreements] (
  [ReimbursableAgreementsId] int IDENTITY (143691,1) NOT NULL
, [RPIO] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [AgreementNumber] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [SiteProjectCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
);

CREATE TABLE [RegionalOffices] (
  [RegionalOfficesId] int IDENTITY (11,1) NOT NULL
, [ResourcePlanninfficesId] int NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [RegionalAuthority] (
  [RegionalAuthorityId] int IDENTITY (743134,1) NOT NULL
, [AllocationsId] int NOT NULL
, [StatusOfFundsId] int NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [ReferenceTables] (
  [ReferenceTablesId] int IDENTITY (401,1) NOT NULL
, [TableName] nvarchar(80) NULL
, [Type] nvarchar(80) NULL
);

CREATE TABLE [RecoveryAct] (
  [RecoveryActId] int IDENTITY (464,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [QueryDefinitions] (
  [QueryDefinitionsId] int IDENTITY (9987,1) NOT NULL
, [Name] nvarchar(80) NULL
, [Type] nvarchar(80) NULL
);

CREATE TABLE [PublicLaws] (
  [PublicLawsId] int IDENTITY (5302,1) NOT NULL
, [LawNumber] nvarchar(80) NULL
, [BillTitle] nvarchar(80) NULL
, [EnactedDate] datetime NULL
, [Congress] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
);

CREATE TABLE [Providers] (
  [ProvidersId] int IDENTITY (10,1) NOT NULL
, [ProviderName] nvarchar(80) NULL
, [FileExtension] nvarchar(80) NULL
, [Connection] nvarchar(80) NULL
, [Properties] nvarchar(80) NULL
);

CREATE TABLE [Projects] (
  [ProjectsId] int IDENTITY (148,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [ProjectCostCodes] (
  [ProjectCostCodesId] int IDENTITY (400176,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
);

CREATE TABLE [ProgramProjects] (
  [ProgramProjectsId] int IDENTITY (192,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
);

CREATE TABLE [ProgramProjectDescriptions] (
  [ProgramProjectDescriptionsId] int IDENTITY (192,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [ProgramTitle] nvarchar(80) NULL
, [Laws] ntext NULL
, [Description] ntext NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
);

CREATE TABLE [ProgramFinancingSchedule] (
  [ProgramFinancingScheduleId] int IDENTITY (27245,1) NOT NULL
, [ReportYear] nvarchar(80) NULL
, [TreasuryAgencyCode] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [LedgerAccountCode] nvarchar(80) NULL
, [SectionNumber] nvarchar(80) NULL
, [SectionName] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [LineDescription] nvarchar(80) NULL
, [OmbAgencyCode] nvarchar(80) NULL
, [OmbFundCode] nvarchar(80) NULL
, [OmbAccountTitle] nvarchar(80) NULL
, [AgencySequence] nvarchar(80) NULL
, [AccountSequence] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OriginalAmount] numeric(18,0) NULL
, [BudgetAmount] numeric(18,0) NULL
, [AgencyAmount] numeric(18,0) NULL
, [Amount] numeric(18,0) NULL
, [AgencyName] nvarchar(80) NULL
);

CREATE TABLE [ProgramAreas] (
  [ProgramAreasId] int IDENTITY (32,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [PayrollRequests] (
  [PayrollRequestsId] int IDENTITY (16,1) NOT NULL
, [ControlTeamAnalyst] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [DocumentTitle] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [FundCode] nvarchar(80) NULL
, [Status] nvarchar(80) NULL
, [OriginalRequestDate] datetime NULL
, [LastActivityDate] datetime NULL
, [BFS] nvarchar(80) NULL
, [Comments] nvarchar(80) NULL
, [RequestDocument] ntext NULL
, [Duration] int NULL
);

CREATE TABLE [PayrollCostCodes] (
  [PayrollCostCodesId] int IDENTITY (21503,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [SubRcCode] nvarchar(80) NULL
, [SubRcName] nvarchar(80) NULL
, [HrOrgCode] nvarchar(80) NULL
, [HrOrgName] nvarchar(80) NULL
, [WorkCode] nvarchar(80) NULL
, [WorkCodeName] nvarchar(80) NULL
);

CREATE TABLE [PayrollAuthority] (
  [PayrollAuthorityId] int IDENTITY (83105,1) NOT NULL
, [AllocationsId] int NULL
, [StatusOfFundsId] int NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [PayrollActivity] (
  [PayrollActivityId] int IDENTITY (2,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [SubRcCode] nvarchar(80) NULL
, [SubRcName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [HrOrgCode] nvarchar(80) NULL
, [HrOrgName] nvarchar(80) NULL
, [WorkCode] nvarchar(80) NULL
, [WorkCodeName] nvarchar(80) NULL
, [PayPeriod] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
, [CheckDate] datetime NULL
, [Amount] numeric(18,0) NULL
, [Hours] numeric(18,0) NULL
, [BasePaid] numeric(18,0) NULL
, [BaseHours] numeric(18,0) NULL
, [Benefits] numeric(18,0) NULL
, [OvertimePaid] numeric(18,0) NULL
, [OvertimeHours] numeric(18,0) NULL
);

CREATE TABLE [PayPeriods] (
  [PayPeriodsId] int IDENTITY (203,1) NOT NULL
, [Period] nvarchar(80) NULL
, [PayPeriod] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
);

CREATE TABLE [Organizations] (
  [OrganizationsId] int IDENTITY (2,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [Code] nvarchar(80) NULL
, [PreventNewUse] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [Status] nvarchar(80) NULL
, [SecurityOrg] nvarchar(80) NULL
, [Usage] nvarchar(80) NULL
, [UseAsCostOrg] nvarchar(80) NULL
, [SubCodeRequired] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [SubRcCode] nvarchar(80) NULL
, [Description] nvarchar(80) NULL
);

CREATE TABLE [OperatingPlanUpdates] (
  [OperatingPlanUpdatesId] int IDENTITY (2,1) NOT NULL
, [OppId] int NULL
, [RPIO] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [NpmCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [ActivityName] nvarchar(80) NULL
, [DivisionName] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [alName] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [ObjectiveName] nvarchar(80) NULL
);

CREATE TABLE [OperatingPlans] (
  [OperatingPlansId] int IDENTITY (303121,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ITProjectCode] nvarchar(80) NULL
, [ProjectCode] nvarchar(80) NULL
, [ProjectName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [ProjectTypeName] nvarchar(80) NULL
, [ProjectTypeCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [ActivityName] nvarchar(80) NULL
, [LocalCode] nvarchar(80) NULL
, [LocalCodeName] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [CostAreaCode] nvarchar(80) NULL
, [CostAreaName] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [alName] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [ObjectiveName] nvarchar(80) NULL
);

CREATE TABLE [OpenCommitments] (
  [OpenCommitmentsId] int IDENTITY (69561,1) NOT NULL
, [ObligationsId] int NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [LastActivityDate] datetime NULL
, [Age] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [OMB] (
  [OmbId] int IDENTITY (55,1) NOT NULL
, [AccountNumber] nvarchar(80) NULL
, [AccountName] nvarchar(80) NULL
, [AgencyName] nvarchar(80) NULL
, [BureauName] nvarchar(80) NULL
);

CREATE TABLE [Obligations] (
  [ObligationsId] int IDENTITY (2,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [LastActivityDate] datetime NULL
, [Age] numeric(18,0) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
);

CREATE TABLE [Objectives] (
  [ObjectivesId] int IDENTITY (11,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [Title] nvarchar(80) NULL
);

CREATE TABLE [ObjectClassOutlays] (
  [ObjectClassOutlaysId] int IDENTITY (148,1) NOT NULL
, [ReportYear] nvarchar(80) NULL
, [OmbAgencyCode] nvarchar(80) NULL
, [OmbAgencyName] nvarchar(80) NULL
, [OmbBureauCode] nvarchar(80) NULL
, [OmbBureauName] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [ObligationType] nvarchar(80) NULL
, [DirectReimbursableTitle] nvarchar(80) NULL
, [ObjectClassGroupNumber] nvarchar(80) NULL
, [ObjectClassGroupName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [FinanceObjectClass] nvarchar(255) NULL
, [PriorYear] numeric(18,0) NULL
, [CurrentYear] numeric(18,0) NULL
, [BudgetYear] numeric(18,0) NULL
);

CREATE TABLE [NationalPrograms] (
  [NationalProgramsId] int NOT NULL
, [Code] nvarchar(255) NOT NULL
, [Name] nvarchar(255) NULL
, [RpioCode] nvarchar(255) NULL
, [Title] nvarchar(255) NULL
);

CREATE TABLE [MonthlyOutlays] (
  [MonthlyOutlaysId] int IDENTITY (1305,1) NOT NULL
, [FiscalYear] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [LineTitle] nvarchar(80) NULL
, [TaxationCode] nvarchar(80) NULL
, [TreasuryAgencyCode] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [SubAccount] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [OmbAgencyCode] nvarchar(80) NULL
, [OmbBureauCode] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [AgencySequence] nvarchar(80) NULL
, [BureauSequence] nvarchar(80) NULL
, [AccountSequence] nvarchar(80) NULL
, [AgencyTitle] nvarchar(80) NULL
, [BureauTitle] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [TreasuryAccountName] nvarchar(80) NULL
, [October] numeric(18,0) NULL
, [November] numeric(18,0) NULL
, [December] numeric(18,0) NULL
, [January] numeric(18,0) NULL
, [Feburary] numeric(18,0) NULL
, [March] numeric(18,0) NULL
, [April] numeric(18,0) NULL
, [May] numeric(18,0) NULL
, [June] numeric(18,0) NULL
, [July] numeric(18,0) NULL
, [August] numeric(18,0) NULL
, [September] numeric(18,0) NULL
);

CREATE TABLE [MonthlyLedgerAccountBalances] (
  [MonthlyLedgerAccountBalancesId] int IDENTITY (109254,1) NOT NULL
, [FiscalYear] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [LedgerAccount] nvarchar(80) NULL
, [LedgerName] nvarchar(80) NULL
, [ApportionmentAccountCode] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [TreasurySymbolName] nvarchar(80) NULL
, [BudgetAccountCode] nvarchar(80) NULL
, [BudgetAccountName] nvarchar(80) NULL
, [FiscalMonth] nvarchar(80) NULL
, [CreditBalance] numeric(18,0) NULL
, [DebitBalance] numeric(18,0) NULL
, [YearToDateAmount] numeric(18,0) NULL
);

CREATE TABLE [Messages] (
  [MessagesId] int IDENTITY (14,1) NOT NULL
, [Message] nvarchar(80) NULL
, [Type] nvarchar(80) NULL
, [Form] nvarchar(80) NULL
);

CREATE TABLE [LedgerAccounts] (
  [LedgerAccountsId] int IDENTITY (388702,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [AccountNumber] nvarchar(80) NULL
, [AccountName] nvarchar(80) NULL
, [BeginningBalance] numeric(18,0) NULL
, [CreditBalance] numeric(18,0) NULL
, [DebitBalance] numeric(18,0) NULL
, [ClosingAmount] numeric(18,0) NULL
);

CREATE TABLE [JobsActCarryoverEstimates] (
  [CarryoverEstimatesId] int IDENTITY (162,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Estimate] numeric(18,0) NULL
);

CREATE TABLE [InfrastructureAccounts] (
  [InfrastructureAccountsId] int IDENTITY (121,1) NOT NULL
, [StrategicPlan] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [ActivityName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [ProgramName] nvarchar(80) NULL
, [ProgramDescription] nvarchar(80) NULL
);

CREATE TABLE [Images] (
  [ImagesId] int IDENTITY (159,1) NOT NULL
, [FileName] nvarchar(80) NULL
, [FilePath] nvarchar(80) NULL
, [FileExtension] nvarchar(80) NULL
, [ImageFile] image NULL
, [Attachments] nvarchar(80) NULL
);

CREATE TABLE [HumanResourceOrganizations] (
  [HumanResourceOrganizationsId] int IDENTITY (885,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [HeadquartersOffices] (
  [HeadquartersOfficesId] int IDENTITY (14,1) NOT NULL
, [ResourcePlanninfficesId] int NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [GsPayScales] (
  [GsPayScalesId] int IDENTITY (826,1) NOT NULL
, [LOCNAME] nvarchar(80) NULL
, [GRADE] float NULL
, [ANNUAL1] float NULL
, [HOURLY1] nvarchar(80) NULL
, [OVERTIME1] nvarchar(80) NULL
, [ANNUAL2] float NULL
, [HOURLY2] nvarchar(80) NULL
, [OVERTIME2] nvarchar(80) NULL
, [ANNUAL3] float NULL
, [HOURLY3] nvarchar(80) NULL
, [OVERTIME3] nvarchar(80) NULL
, [ANNUAL4] float NULL
, [HOURLY4] nvarchar(80) NULL
, [OVERTIME4] nvarchar(80) NULL
, [ANNUAL5] float NULL
, [HOURLY5] nvarchar(80) NULL
, [OVERTIME5] nvarchar(80) NULL
, [ANNUAL6] float NULL
, [HOURLY6] nvarchar(80) NULL
, [OVERTIME6] nvarchar(80) NULL
, [ANNUAL7] float NULL
, [HOURLY7] nvarchar(80) NULL
, [OVERTIME7] nvarchar(80) NULL
, [ANNUAL8] float NULL
, [HOURLY8] nvarchar(80) NULL
, [OVERTIME8] nvarchar(80) NULL
, [ANNUAL9] float NULL
, [HOURLY9] nvarchar(80) NULL
, [OVERTIME9] nvarchar(80) NULL
, [ANNUAL10] float NULL
, [HOURLY10] nvarchar(80) NULL
, [OVERTIME10] nvarchar(80) NULL
);

CREATE TABLE [GrowthRates] (
  [GrowthRatesId] int NOT NULL
, [RateId] int IDENTITY (25,1) NOT NULL
, [DESCRIPTION] nvarchar(80) NULL
, [BudgetYearRate] numeric(18,0) NULL
, [OutYear1] numeric(18,0) NULL
, [OutYear2] numeric(18,0) NULL
, [OutYear3] numeric(18,0) NULL
, [OutYear4] numeric(18,0) NULL
, [OutYear5] numeric(18,0) NULL
, [OutYear6] numeric(18,0) NULL
, [OutYear7] numeric(18,0) NULL
, [OutYear8] numeric(18,0) NULL
, [OutYear9] numeric(18,0) NULL
, [Sort] nvarchar(80) NULL
);

CREATE TABLE [als] (
  [alsId] int IDENTITY (7,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [Title] nvarchar(80) NULL
);

CREATE TABLE [FundSymbols] (
  [FundSymbolsId] int IDENTITY (14550,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [TreasuryAccountName] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [ApportionmentAccountCode] nvarchar(80) NULL
);

CREATE TABLE [Funds] (
  [FundsId] int IDENTITY (10884,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [ShortName] nvarchar(80) NULL
, [Status] nvarchar(80) NULL
, [StartDate] datetime NULL
, [EndDate] datetime NULL
, [SubLevelPrefix] nvarchar(80) NULL
, [ATA] nvarchar(80) NULL
, [AID] nvarchar(80) NULL
, [BeginningPeriodOfAvailability] nvarchar(80) NULL
, [EndingPeriodOfAvailability] nvarchar(80) NULL
, [A] nvarchar(80) NULL
, [MAIN] nvarchar(80) NULL
, [SUB] nvarchar(80) NULL
, [FundCatery] nvarchar(80) NULL
, [AppropriationCode] nvarchar(80) NULL
, [SubAppropriationCode] nvarchar(80) NULL
, [FundGroup] nvarchar(80) NULL
, [NoYear] nvarchar(80) NULL
, [Carryover] nvarchar(80) NULL
, [AllowSpendAgainstCanceled] nvarchar(80) NULL
, [AllowNewSpendAgainstExpired] nvarchar(80) NULL
, [CanceledYearSpendingAccount] nvarchar(80) NULL
, [ApplyAtAllLevels] nvarchar(80) NULL
, [BatsFund] nvarchar(80) NULL
, [BatsEndDate] nvarchar(80) NULL
, [BatsOptionId] nvarchar(80) NULL
, [SecurityOrg] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [TreasuryAccountName] nvarchar(80) NULL
, [ApportionmentAccountCode] nvarchar(80) NULL
);

CREATE TABLE [FullTimeEquivalents] (
  [FullTimeEquivialentsId] int IDENTITY (14572,1) NOT NULL
, [OperatingPlansId] int NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ITProjectCode] nvarchar(80) NULL
, [ProjectCode] nvarchar(80) NULL
, [ProjectName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [ProjectTypeName] nvarchar(80) NULL
, [ProjectTypeCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [ActivityName] nvarchar(80) NULL
, [LocalCode] nvarchar(80) NULL
, [LocalCodeName] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [CostAreaCode] nvarchar(80) NULL
, [CostAreaName] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [alName] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [ObjectiveName] nvarchar(80) NULL
);

CREATE TABLE [FiscalYearsBackUp] (
  [FiscalYearsBackUpId] int IDENTITY (28,1) NOT NULL
, [FiscalYearsId] int NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FirstYear] nvarchar(80) NULL
, [LastYear] nvarchar(80) NULL
, [ExpiringYear] nvarchar(80) NULL
, [CalendarYearStartDate] datetime NULL
, [FiscalYearStartDate] datetime NULL
, [CalendarYearEndDate] datetime NULL
, [FiscalYearEndDate] datetime NULL
, [ExpirationDate] datetime NULL
, [Availability] nvarchar(80) NULL
, [NewYears] datetime NULL
, [MartinLutherKing] datetime NULL
, [Presidents] datetime NULL
, [Memorial] datetime NULL
, [Juneteeth] datetime NULL
, [Independence] datetime NULL
, [Labor] datetime NULL
, [Columbus] datetime NULL
, [Veterans] datetime NULL
, [Thanksgiving] datetime NULL
, [Christmas] datetime NULL
, [WorkDays] int NULL
, [WeekDays] int NULL
, [WeekEnds] int NULL
);

CREATE TABLE [FiscalYears] (
  [FiscalYearsId] int IDENTITY (117,1) NOT NULL
, [BFY] nvarchar(80) NOT NULL
, [EFY] nvarchar(80) NULL
, [StartDate] nvarchar(80) NULL
, [Columbus] datetime NULL
, [Veterans] datetime NULL
, [Thanksgiving] datetime NULL
, [Christmas] datetime NULL
, [NewYears] datetime NULL
, [MartinLutherKing] datetime NULL
, [Washingtons] datetime NULL
, [Memorial] datetime NULL
, [Juneteenth] datetime NULL
, [Independence] datetime NULL
, [Labor] datetime NULL
, [ExpiringYear] nvarchar(80) NULL
, [ExpirationDate] nvarchar(80) NULL
, [WorkDays] float NULL
, [WeekDays] float NULL
, [WeekEnds] float NULL
, [EndDate] nvarchar(80) NULL
, [Availability] nvarchar(80) NULL
);

CREATE TABLE [FinanceObjectClasses] (
  [FinanceObjectClassesId] int IDENTITY (486,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
);

CREATE TABLE [FederalHolidays] (
  [FederalHolidaysId] int IDENTITY (15,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [Columbus] datetime NULL
, [Veterans] datetime NULL
, [Thanksgiving] datetime NULL
, [Christmas] datetime NULL
, [NewYears] datetime NULL
, [MartinLutherKing] datetime NULL
, [Washingtons] datetime NULL
, [Memorial] datetime NULL
, [Juneteenth] datetime NULL
, [Independence] datetime NULL
, [Labor] datetime NULL
);

CREATE TABLE [Expenditures] (
  [ExpendituresId] int IDENTITY (272085,1) NOT NULL
, [ObligationsId] int NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(255) NULL
, [ProcessedDate] datetime NULL
, [LastActivityDate] datetime NULL
, [Age] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [VendorCode] nvarchar(80) NULL
, [VendorName] nvarchar(80) NULL
, [Amount] numeric(18,0) DEFAULT (0) NULL
);

CREATE TABLE [ExecutionTables] (
  [ExecutionTablesId] int IDENTITY (571,1) NOT NULL
, [TableName] nvarchar(80) NULL
, [Type] nvarchar(80) NULL
);

CREATE TABLE [Earmarks] (
  [EarmarksId] int IDENTITY (492,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [StateCode] nvarchar(80) NULL
, [Description] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ProjectOfficerLastName] nvarchar(80) NULL
, [ProjectOfficerFirstName] nvarchar(80) NULL
, [ProjectOfficerPhoneNumber] nvarchar(80) NULL
, [ProjectOfficerMailCode] nvarchar(80) NULL
, [CommitmentDate] datetime NULL
, [ObligationDate] datetime NULL
, [ProjectStatus] nvarchar(80) NULL
, [ProjectOfficerComments] nvarchar(80) NULL
);

CREATE TABLE [Documents] (
  [DocumentsId] int IDENTITY (188,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Catery] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [System] nvarchar(80) NULL
);

CREATE TABLE [DocumentControlNumbers] (
  [DocumentControlNumbersId] int IDENTITY (481758,1) NOT NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentPrefix] nvarchar(80) NULL
, [DocumentControlNumber] nvarchar(80) NULL
);

CREATE TABLE [Deobligations] (
  [DeobligationsId] int IDENTITY (2673710,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [OmbAccountName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [FocCode] nvarchar(80) NULL
, [FocName] nvarchar(80) NULL
, [ProcessedDate] datetime NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [Defactos] (
  [DefactosId] int NOT NULL
, [StatusOfFundsId] int IDENTITY (16381,1) NOT NULL
, [BudgetLevel] nvarchar(255) NULL
, [BFY] nvarchar(255) NULL
, [EFY] nvarchar(255) NULL
, [RpioCode] nvarchar(255) NULL
, [RpioName] nvarchar(255) NULL
, [AhCode] nvarchar(255) NULL
, [AhName] nvarchar(255) NULL
, [FundCode] nvarchar(255) NULL
, [FundName] nvarchar(255) NULL
, [OrgCode] nvarchar(255) NULL
, [OrgName] nvarchar(255) NULL
, [AccountCode] nvarchar(255) NULL
, [RcCode] nvarchar(255) NULL
, [BocCode] nvarchar(255) NULL
, [BocName] nvarchar(255) NULL
, [ProgramProjectCode] nvarchar(255) NULL
, [ProgramProjectName] nvarchar(255) NULL
, [ProgramAreaCode] nvarchar(255) NULL
, [ProgramAreaName] nvarchar(255) NULL
, [RcName] nvarchar(255) NULL
, [LowerName] nvarchar(255) NULL
, [Amount] money NULL
, [Budgeted] money NULL
, [Posted] money NULL
, [OpenCommitments] money NULL
, [ULO] money NULL
, [Expenditures] money NULL
, [Obligations] money NULL
, [Used] money NULL
, [Available] money NULL
, [NpmCode] nvarchar(255) NULL
, [NpmName] nvarchar(255) NULL
);

CREATE TABLE [DataRuleDescriptions] (
  [DataRuleDescriptionsId] int IDENTITY (1177,1) NOT NULL
, [Schedule] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [RuleNumber] nvarchar(80) NULL
, [RuleDescription] ntext NULL
, [ScheduleOrder] nvarchar(80) NULL
);

CREATE TABLE [CostAreas] (
  [CostAreasId] int IDENTITY (40,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [Contacts] (
  [ContactsId] int IDENTITY (13,1) NOT NULL
, [FirstName] nvarchar(80) NULL
, [LastName] nvarchar(80) NULL
, [FullName] nvarchar(80) NULL
, [Email] nvarchar(80) NULL
, [RPIO] nvarchar(80) NULL
, [Section] nvarchar(80) NULL
);

CREATE TABLE [CongressionalReprogrammings] (
  [CongressionalReprogrammingsId] int IDENTITY (2,1) NOT NULL
, [ReprogrammingNumber] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Description] nvarchar(155) NULL
, [ExtendedDescription] ntext NULL
, [FromTo] nvarchar(80) NULL
, [Cycle] nvarchar(80) NULL
);

CREATE TABLE [CongressionalControls] (
  [CongressionalControlsId] int IDENTITY (187,1) NOT NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [SubProjectCode] nvarchar(80) NULL
, [SubProjectName] nvarchar(80) NULL
, [ReprogrammingRestriction] nvarchar(80) NULL
, [IncreaseRestriction] nvarchar(80) NULL
, [DecreaseRestriction] nvarchar(80) NULL
, [MemoRequirement] nvarchar(80) NULL
);

CREATE TABLE [CompassOutlays] (
  [CompassOutlaysId] int IDENTITY (3204,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AppropriationCode] nvarchar(80) NULL
, [AppropriationName] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [TotalObligations] numeric(18,0) NULL
, [UnliquidatedObligations] numeric(18,0) NULL
, [ObligationsPaid] numeric(18,0) NULL
);

CREATE TABLE [CompassLevels] (
  [CompassLevelsId] int IDENTITY (252402,1) NOT NULL
, [BudgetLevel] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AppropriationCode] nvarchar(80) NULL
, [SubAppropriationCode] nvarchar(80) NULL
, [AppropriationName] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccount] nvarchar(80) NULL
, [PostedControlFlag] nvarchar(80) NULL
, [ActualRecoveryTransType] nvarchar(80) NULL
, [CommitmentSpendingControlFlag] nvarchar(80) NULL
, [BudgetDefault] nvarchar(80) NULL
, [LowerChildExpenditureSpendingControlFlag] nvarchar(80) NULL
, [LowerChildExpenseSpendingControlFlag] nvarchar(80) NULL
, [FteControlFlag] nvarchar(80) NULL
, [AccrualSpendingControlFlag] nvarchar(80) NULL
, [ObligationSpendingControlFlag] nvarchar(80) NULL
, [PreCommitmentSpendingControlFlag] nvarchar(80) NULL
, [LowerCommitmentSpendingControlFlag] nvarchar(80) NULL
, [LowerObligationSpendingControlFlag] nvarchar(80) NULL
, [LowerExpenditureSpendingControlFlag] nvarchar(80) NULL
, [LowerExpenseSpendingControlFlag] nvarchar(80) NULL
, [LowerPostedControlFlag] nvarchar(80) NULL
, [LowerPostedTransType] nvarchar(80) NULL
, [LowerTransType] nvarchar(80) NULL
, [LowerPostedFlag] nvarchar(80) NULL
, [LowerPreCommitmentSpendingControlFlag] nvarchar(80) NULL
, [LowerRecoveriesSpendinption] nvarchar(80) NULL
, [LowerRecoveriesOption] nvarchar(80) NULL
, [LowerReimbursableSpendinption] nvarchar(80) NULL
, [Date] datetime NULL
, [TotalAuthority] numeric(18,0) NULL
, [OriginalAmount] numeric(18,0) NULL
, [CarryoverAvailabilityPercentage] numeric(18,0) NULL
, [CarryIn] numeric(18,0) NULL
, [CarryOut] numeric(18,0) NULL
, [FundsIn] numeric(18,0) NULL
, [FundsOut] numeric(18,0) NULL
, [RecoveriesWithdrawn] numeric(18,0) NULL
, [ActualRecoveries] numeric(18,0) NULL
, [ActualReimbursements] numeric(18,0) NULL
, [AgreementReimbursables] numeric(18,0) NULL
);

CREATE TABLE [Changes] (
  [ChangesId] int IDENTITY (4194,1) NOT NULL
, [TableName] nvarchar(80) NULL
, [FieldName] nvarchar(80) NULL
, [Action] nvarchar(80) NULL
, [OldValue] nvarchar(80) NULL
, [NewValue] nvarchar(80) NULL
, [TimeStamp] datetime NULL
, [Message] nvarchar(80) NULL
);

CREATE TABLE [CarryoverRequests] (
  [CarryoverRequestsId] int IDENTITY (13,1) NOT NULL
, [ControlTeamAnalyst] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [DocumentTitle] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [FundCode] nvarchar(80) NULL
, [Status] nvarchar(80) NULL
, [OriginalRequestDate] datetime NULL
, [LastActivityDate] datetime NULL
, [BFS] nvarchar(80) NULL
, [Comments] ntext NULL
, [RequestDocument] ntext NULL
, [Duration] int NULL
);

CREATE TABLE [CarryoverApportionments] (
  [CarryoverApportionmentsId] int IDENTITY (99,1) NOT NULL
, [BudgetAccount] nvarchar(80) NULL
, [TreasuryAccount] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [Group] nvarchar(80) NULL
, [Description] nvarchar(80) NULL
, [LineName] nvarchar(80) NULL
, [AuthorityType] nvarchar(80) NULL
, [Request] numeric(18,0) NULL
, [Balance] numeric(18,0) NULL
, [Deobligations] numeric(18,0) NULL
, [Amount] numeric(18,0) NULL
, [LineNumber] nvarchar(80) NULL
, [LineSplit] nvarchar(80) NULL
, [ApportionmentAccountCode] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [TreasuryAccountName] nvarchar(80) NULL
, [BudgetAccountCode] nvarchar(80) NULL
, [BudgetAccountName] nvarchar(80) NULL
);

CREATE TABLE [CapitalPlanningInvestmentCodes] (
  [CapitalPlanningInvestmentCodesId] int IDENTITY (672,1) NOT NULL
, [Type] nvarchar(80) NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [BudgetOutlays] (
  [BudgetOutlaysId] int IDENTITY (279,1) NOT NULL
, [ReportYear] nvarchar(80) NULL
, [AgencyName] nvarchar(80) NULL
, [OmbAccount] nvarchar(80) NULL
, [Line] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [LineSection] nvarchar(80) NULL
, [LineName] nvarchar(80) NULL
, [BeaCatery] nvarchar(80) NULL
, [BeaCateryName] nvarchar(80) NULL
, [LineCatery] nvarchar(80) NULL
, [PriorYear] numeric(18,0) NULL
, [CurrentYear] numeric(18,0) NULL
, [BudgetYear] numeric(18,0) NULL
, [OutYear1] numeric(18,0) NULL
, [OutYear2] numeric(18,0) NULL
, [OutYear3] numeric(18,0) NULL
, [OutYear4] numeric(18,0) NULL
, [OutYear5] numeric(18,0) NULL
, [OutYear6] numeric(18,0) NULL
, [OutYear7] numeric(18,0) NULL
, [OutYear8] numeric(18,0) NULL
, [OutYear9] numeric(18,0) NULL
);

CREATE TABLE [BudgetObjectClasses] (
  [BudgetObjectClassesId] int IDENTITY (18,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [BudgetDocuments] (
  [BudgetDocumentsId] int IDENTITY (1796157,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [DocumentDate] datetime NULL
, [LastDocumentDate] datetime NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ReimbursableAgreementControls] nvarchar(80) NULL
, [BudgetingControls] nvarchar(80) NULL
, [PostingControls] nvarchar(80) NULL
, [PreCommitmentControls] nvarchar(80) NULL
, [CommitmentControls] nvarchar(80) NULL
, [ObligationControls] nvarchar(80) NULL
, [ExpenditureControls] nvarchar(80) NULL
, [ExpenseControls] nvarchar(80) NULL
, [AccrualControls] nvarchar(80) NULL
, [ReimbursementControls] nvarchar(80) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [CarryOut] numeric(18,0) NULL
, [CarryIn] numeric(18,0) NULL
, [EstimatedRecoveries] numeric(18,0) NULL
, [EstimatedReimbursements] numeric(18,0) NULL
);

CREATE TABLE [BudgetControls] (
  [BudgetControlsId] int IDENTITY (1486,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
, [BudgetedTransType] nvarchar(80) NULL
, [PostedTransType] nvarchar(80) NULL
, [EstimatedReimbursementsTransType] nvarchar(80) NULL
, [SpendingAdjustmentTransType] nvarchar(80) NULL
, [EstimatedRecoveriesTransType] nvarchar(80) NULL
, [ActualRecoveriesTransType] nvarchar(80) NULL
, [StatusReserveTransType] nvarchar(80) NULL
, [ProfitLossTransType] nvarchar(80) NULL
, [EstimatedReimbursementsSpendinption] nvarchar(80) NULL
, [EstimatedReimursementsBudgetinption] nvarchar(80) NULL
, [TrackAgreementLowerLevel] nvarchar(80) NULL
, [BudgetEstimatedLowerLevel] nvarchar(80) NULL
, [EstimatedRecoveriesSpendinption] nvarchar(80) NULL
, [EstimatedRecoveriesBudgetinption] nvarchar(80) NULL
, [RecoveryNextLevel] nvarchar(80) NULL
, [RecoveryBudgetMismatch] nvarchar(80) NULL
, [ProfitLossSpendinption] nvarchar(80) NULL
, [ProfitLossBudgetOption] nvarchar(80) NULL
, [RecoveriesCarryInLowerLevel] nvarchar(80) NULL
, [RecoveriesCarryInLowerLevelControl] nvarchar(80) NULL
, [RecoveriesCarryInAmountControl] nvarchar(80) NULL
, [BudgetedControl] nvarchar(80) NULL
, [PostedControl] nvarchar(80) NULL
, [PreCommitmentSpendingControl] nvarchar(80) NULL
, [CommitmentSpendingControl] nvarchar(80) NULL
, [ObligationSpendingControl] nvarchar(80) NULL
, [AccrualSpendingControl] nvarchar(80) NULL
, [ExpenditureSpendingControl] nvarchar(80) NULL
, [ExpenseSpendingControl] nvarchar(80) NULL
, [ReimbursableSpendingControl] nvarchar(80) NULL
, [ReimbursableAgreementSpendingControl] nvarchar(80) NULL
, [FteBudgetingControl] nvarchar(80) NULL
, [FteSpendingControl] nvarchar(80) NULL
, [TransactionTypeControl] nvarchar(80) NULL
, [AuthorityDistributionControl] nvarchar(80) NULL
);

CREATE TABLE [BudgetaryResourceExecution] (
  [BudgetaryResourceExecutionId] int IDENTITY (14806,1) NOT NULL
, [FiscalYear] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [LastUpdate] datetime NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccount] nvarchar(80) NULL
, [TreasuryAgencyCode] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [STAT] nvarchar(80) NULL
, [CreditIndicator] nvarchar(80) NULL
, [LineNumber] nvarchar(80) NULL
, [LineDescription] nvarchar(80) NULL
, [SectionName] nvarchar(80) NULL
, [SectionNumber] nvarchar(80) NULL
, [LineType] nvarchar(80) NULL
, [FinancingAccounts] nvarchar(80) NULL
, [November] numeric(18,0) NULL
, [January] numeric(18,0) NULL
, [Feburary] numeric(18,0) NULL
, [April] numeric(18,0) NULL
, [May] numeric(18,0) NULL
, [June] numeric(18,0) NULL
, [August] numeric(18,0) NULL
, [October] numeric(18,0) NULL
, [Amount1] numeric(18,0) NULL
, [Amount2] numeric(18,0) NULL
, [Amount3] numeric(18,0) NULL
, [Amount4] numeric(18,0) NULL
, [Agency] nvarchar(80) NULL
, [Bureau] nvarchar(80) NULL
);

CREATE TABLE [Appropriations] (
  [AppropriationsId] int IDENTITY (11,1) NOT NULL
, [BFY] nvarchar(80) NOT NULL
, [Title] nvarchar(80) NULL
, [PublicLaw] nvarchar(80) NULL
, [EnactedDate] datetime NULL
);

CREATE TABLE [AppropriationLevelAuthority] (
  [AppropriationLevelAuthorityId] int IDENTITY (939,1) NOT NULL
, [BudgetAccountCode] nvarchar(80) NULL
, [BudgetAccountName] nvarchar(80) NULL
, [FiscalYear] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [CarryOut] numeric(18,0) NULL
, [CarryIn] numeric(18,0) NULL
, [EstimatedReimbursements] numeric(18,0) NULL
, [EstimatedRecoveries] numeric(18,0) NULL
);

CREATE TABLE [AppropriationDocuments] (
  [AppropriationDocumentsId] int IDENTITY (2345,1) NOT NULL
, [FiscalYear] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AppropriationFund] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [DocumentType] nvarchar(80) NULL
, [DocumentNumber] nvarchar(80) NULL
, [DocumentDate] datetime NULL
, [LastDocumentDate] datetime NULL
, [BudgetLevel] nvarchar(80) NULL
, [BudgetingControls] nvarchar(80) NULL
, [PostingControls] nvarchar(80) NULL
, [PreCommitmentControls] nvarchar(80) NULL
, [CommitmentControls] nvarchar(80) NULL
, [ObligationControls] nvarchar(80) NULL
, [AccrualControls] nvarchar(80) NULL
, [ExpenditureControls] nvarchar(80) NULL
, [ExpenseControls] nvarchar(80) NULL
, [ReimbursementControls] nvarchar(80) NULL
, [ReimbursableAgreementControls] nvarchar(80) NULL
, [Budgeted] numeric(18,0) DEFAULT (0) NULL
, [Posted] numeric(18,0) DEFAULT (0) NULL
, [CarryOut] numeric(18,0) DEFAULT (0) NULL
, [CarryIn] numeric(18,0) DEFAULT (0) NULL
, [EstimatedReimbur0sements] numeric(18,0) DEFAULT (0) NULL
, [EstimatedRecoveries] numeric(18,0) DEFAULT (0) NULL
);

CREATE TABLE [AppropriationAvailableBalances] (
  [AppropriationAvailableBalancesId] int IDENTITY (1299,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AppropriationFundCode] nvarchar(80) NULL
, [AppropriationFundName] nvarchar(80) NULL
, [TreasurySymbol] nvarchar(80) NULL
, [OmbAccountCode] nvarchar(80) NULL
, [Availability] nvarchar(80) NULL
, [TotalAuthority] numeric(18,0) NULL
, [TotalUsed] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
);

CREATE TABLE [ApportionmentData] (
  [ApportionmentDataId] int IDENTITY (2080,1) NOT NULL
, [FiscalYear] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [TreasuryAppropriationFundSymbol] nvarchar(80) NULL
, [TreasuryAppropriationFundSymbolName] nvarchar(80) NULL
, [ApportionmentAccountCode] nvarchar(80) NULL
, [ApportionmentAccountName] nvarchar(80) NULL
, [AvailabilityType] nvarchar(80) NULL
, [BudgetAccountCode] nvarchar(80) NULL
, [BudgetAccountName] nvarchar(80) NULL
, [ApprovalDate] datetime NULL
, [LineNumber] nvarchar(80) NULL
, [LineName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [ApplicationTables] (
  [ApplicationTablesId] int IDENTITY (1869,1) NOT NULL
, [TableName] nvarchar(80) NULL
, [Model] nvarchar(80) NULL
);

CREATE TABLE [AnnualReimbursableSurvey] (
  [AnnualReimbursableSurveyId] int IDENTITY (2,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [AnnualReimbursableEstimates] (
  [AnnualReimbursableEstimatesId] int IDENTITY (796,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Estimate] numeric(18,0) NULL
);

CREATE TABLE [AnnualCarryoverSurvey] (
  [AnnualCarryoverSurveyId] int IDENTITY (300,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
);

CREATE TABLE [AnnualCarryoverEstimates] (
  [AnnualCarryoverEstimatesId] int IDENTITY (6758,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [TreasuryAccountCode] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [Estimate] numeric(18,0) NULL
);

CREATE TABLE [AmericanRescuePlan] (
  [AmericanRescuePlanId] int NOT NULL
, [StatusOfFundsId] int NOT NULL
, [BudgetLevel] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [LowerName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [Budgeted] numeric(18,0) NULL
, [Posted] numeric(18,0) NULL
, [OpenCommitments] numeric(18,0) NULL
, [ULO] numeric(18,0) NULL
, [Expenditures] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Used] numeric(18,0) NULL
, [Available] numeric(18,0) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [AllowanceHolders] (
  [AllowanceHoldersId] int IDENTITY (6126,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);

CREATE TABLE [Allocations] (
  [AllocationsId] int IDENTITY (82051,1) NOT NULL
, [StatusOfFundsId] int NOT NULL
, [BudgetLevel] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [Amount] numeric(18,0) DEFAULT (0) NOT NULL
, [RpioName] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
);

CREATE TABLE [HeadquartersAuthority] (
  [HeadquartersAuthorityId] int IDENTITY (358600,1) NOT NULL
, [AllocationsId] int NOT NULL
, [StatusOfFundsId] int NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [BudgetLevel] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [RcCode] nvarchar(80) NULL
, [RcName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [Amount] numeric(18,0) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
);

CREATE TABLE [AdministrativeRequests] (
  [AdministrativeRequestsId] int IDENTITY (28,1) NOT NULL
, [RequestId] int NULL
, [ControlTeamAnalyst] nvarchar(255) NULL
, [RpioCode] nvarchar(255) NULL
, [DocumentTitle] nvarchar(255) NULL
, [Amount] numeric(18,0) NULL
, [FundCode] nvarchar(255) NULL
, [BFY] nvarchar(255) NULL
, [Status] nvarchar(255) NULL
, [OriginalRequestDate] datetime NULL
, [LastActivityDate] datetime NULL
, [Duration] float NULL
, [BFS] nvarchar(255) NULL
, [Comments] ntext NULL
, [RequestDocument] ntext NULL
, [RequestType] nvarchar(255) NULL
, [TypeCode] nvarchar(255) NULL
, [Decision] nvarchar(255) NULL
);

CREATE TABLE [Actuals] (
  [ActualsId] int IDENTITY (13334,1) NOT NULL
, [BFY] nvarchar(80) NULL
, [EFY] nvarchar(80) NULL
, [RpioCode] nvarchar(80) NULL
, [RpioName] nvarchar(80) NULL
, [AhCode] nvarchar(80) NULL
, [AhName] nvarchar(80) NULL
, [FundCode] nvarchar(80) NULL
, [FundName] nvarchar(80) NULL
, [AppropriationCode] nvarchar(80) NULL
, [AppropriationName] nvarchar(80) NULL
, [SubAppropriationCode] nvarchar(80) NULL
, [SubAppropriationName] nvarchar(80) NULL
, [OrgCode] nvarchar(80) NULL
, [OrgName] nvarchar(80) NULL
, [AccountCode] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [RpioActivityCode] nvarchar(80) NULL
, [RpioActivityName] nvarchar(80) NULL
, [BocCode] nvarchar(80) NULL
, [BocName] nvarchar(80) NULL
, [ULO] numeric(18,0) NULL
, [Obligations] numeric(18,0) NULL
, [Balance] numeric(18,0) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [alName] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [ObjectiveName] nvarchar(80) NULL
);

CREATE TABLE [ActivityCodes] (
  [ActivityId] int IDENTITY (607,1) NOT NULL
, [Code] nvarchar(80) NOT NULL
, [Name] nvarchar(80) NULL
, [Description] nvarchar(80) NULL
);

CREATE TABLE [Accounts] (
  [AccountsId] int IDENTITY (64047,1) NOT NULL
, [Code] nvarchar(80) NULL
, [alCode] nvarchar(80) NULL
, [ObjectiveCode] nvarchar(80) NULL
, [NpmCode] nvarchar(80) NULL
, [NpmName] nvarchar(80) NULL
, [ProgramProjectCode] nvarchar(80) NULL
, [ProgramProjectName] nvarchar(80) NULL
, [ProgramAreaCode] nvarchar(80) NULL
, [ProgramAreaName] nvarchar(80) NULL
, [ActivityCode] nvarchar(80) NULL
, [ActivityName] nvarchar(80) NULL
, [AgencyActivity] nvarchar(80) NULL
);

CREATE TABLE [AccountingEvents] (
  [AccountingEventsId] int IDENTITY (208,1) NOT NULL
, [Code] nvarchar(80) NULL
, [Name] nvarchar(80) NULL
);
