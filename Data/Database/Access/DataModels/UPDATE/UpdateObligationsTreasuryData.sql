UPDATE Funds 
SET Funds.TreasuryAccountCode = IIF( Funds.EFY = 'NS', '68X' & Funds.Main, '68' & RIGHT(Funds.BFY, 2) & '/' & RIGHT(Funds.EFY, 2) & Funds.Main);
