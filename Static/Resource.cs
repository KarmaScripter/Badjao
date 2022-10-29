//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using static System.Configuration.ConfigurationManager;

    /// <summary>
    /// 
    /// </summary>
    public static class Resource
    {
        /// <summary>
        /// The summary
        /// </summary>
        public static string Summary = AppSettings[ "SummaryImages" ];

        /// <summary>
        /// The fund images
        /// </summary>
        public static string FundImages = AppSettings[ "FundImages" ];

        /// <summary>
        /// The databases
        /// </summary>
        public static string Databases = AppSettings[ "DatabaseImages" ];

        /// <summary>
        /// The data images
        /// </summary>
        public static string DataImages = AppSettings[ "DataImages" ];

        /// <summary>
        /// The office images
        /// </summary>
        public static string OfficeImages = AppSettings[ "OfficeImages" ];

        /// <summary>
        /// The navigation images
        /// </summary>
        public static string NavigationImages = AppSettings[ "NavigationImages" ];

        /// <summary>
        /// The codec images
        /// </summary>
        public static readonly string CodecImages = AppSettings[ "CodecImages" ];

        /// <summary>
        /// The outlay images
        /// </summary>
        public static readonly string OutlayImages = AppSettings[ "OutlayImages" ];

        /// <summary>
        /// The file images
        /// </summary>
        public static readonly string FileImages = AppSettings[ "FileImages" ];

        /// <summary>
        /// The object class images
        /// </summary>
        public static readonly string ObjectClassImages = AppSettings[ "ObjectClassImages" ];

        /// <summary>
        /// The provider images
        /// </summary>
        public static readonly string ProviderImages = AppSettings[ "ProviderImages" ];

        /// <summary>
        /// The math images
        /// </summary>
        public static readonly string MathImages = AppSettings[ "MathImages" ];

        /// <summary>
        /// The interface images
        /// </summary>
        public static readonly string InterfaceImages = AppSettings[ "InterfaceImages" ];

        /// <summary>
        /// The folder images
        /// </summary>
        public static readonly string FolderImages = AppSettings[ "FolderImages" ];

        /// <summary>
        /// The division caption
        /// </summary>
        public static readonly string DivisionCaption = AppSettings[ "DivisionCaption" ];

        /// <summary>
        /// The main form images
        /// </summary>
        public static readonly string MainFormImages = AppSettings[ "MainFormImages" ];

        /// <summary>
        /// The execution images
        /// </summary>
        public static readonly string ExecutionImages = AppSettings[ "ExecutionImages" ];

        /// <summary>
        /// The tool bar images
        /// </summary>
        public static readonly string ToolStripImages = AppSettings[ "ToolStripImages" ];

        /// <summary>
        /// The object class sources
        /// </summary>
        public static readonly Source[ ] ObjectClassSources =
        {
            Source.PayrollAuthority
        };

        /// <summary>
        /// The chart types
        /// </summary>
        public static readonly string[ ] ChartTypes = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The reference sources
        /// </summary>
        public static readonly Source[ ] ReferenceSources =
        {
            Source.Accounts,
            Source.AccountingEvents,
            Source.ActivityCodes,
            Source.AllowanceHolders,
            Source.Appropriations,
            Source.BudgetObjectClasses,
            Source.CostAreas,
            Source.FinanceObjectClasses,
            Source.Funds,
            Source.Goals,
            Source.HumanResourceOrganizations,
            Source.NationalPrograms,
            Source.Objectives,
            Source.Organizations,
            Source.ResourcePlanningOffices,
            Source.ProgramAreas,
            Source.Projects,
            Source.ProgramProjects,
            Source.Providers,
            Source.ResponsibilityCenters,
            Source.WorkCodes,
            Source.FiscalYears
        };

        /// <summary>
        /// The authority sources
        /// </summary>
        public static readonly Source[ ] AuthoritySources =
        {
            Source.Allocations,
            Source.ApportionmentData,
            Source.AppropriationDocuments,
            Source.BudgetDocuments,
            Source.BudgetControls,
            Source.CarryoverSurvey,
            Source.HeadquartersAuthority,
            Source.PayrollAuthority,
            Source.RegionalAuthority,
            Source.Reprogrammings,
            Source.ReimbursableAgreements,
            Source.ReimbursableFunds,
            Source.ReimbursableSurvey,
            Source.SuperfundSites,
            Source.SpecialAccounts,
            Source.Transfers,
            Source.UnobligatedAuthority
        };

        /// <summary>
        /// The obligation sources
        /// </summary>
        public static readonly Source[ ] ObligationSources =
        {
            Source.BudgetOutlays,
            Source.CarryoverOutlays,
            Source.MonthlyOutlays,
            Source.ProjectCostCodes,
            Source.TravelActivity,
            Source.PayrollCostCodes,
            Source.PayrollActivity,
            Source.Obligations,
            Source.Deobligations,
            Source.SiteActivity,
            Source.DocumentControlNumbers,
            Source.ProjectCostCodes,
            Source.SiteProjectCodes
        };

        /// <summary>
        /// The sources
        /// </summary>
        public static readonly string[ ] Sources = Enum.GetNames( typeof( Source ) );

        /// <summary>
        /// The providers
        /// </summary>
        public static readonly string[ ] Providers = Enum.GetNames( typeof( Provider ) );

        /// <summary>
        /// The fields
        /// </summary>
        public static readonly string[ ] Fields = Enum.GetNames( typeof( Field ) );

        /// <summary>
        /// The numerics
        /// </summary>
        public static readonly string[ ] Numerics = Enum.GetNames( typeof( Numeric ) );

        /// <summary>
        /// The primary keys
        /// </summary>
        public static readonly string[ ] PrimaryKeys = Enum.GetNames( typeof( PrimaryKey ) );

        /// <summary>
        /// The extensions
        /// </summary>
        public static readonly string[ ] Extensions = Enum.GetNames( typeof( EXT ) );

        /// <summary>
        /// The image resources
        /// </summary>
        public static readonly string[ ] ImageFolders = Enum.GetNames( typeof( ImageDirectory ) );

        /// <summary>
        /// The charts
        /// </summary>
        public static readonly string[ ] Charts = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The tools
        /// </summary>
        public static readonly string[ ] Tools = Enum.GetNames( typeof( ToolType ) );
    }
}