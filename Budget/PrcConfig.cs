// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using BudgetExecution.Budget;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "PrcBase"/>
    public abstract class PrcConfig : PrcBase
    {
        /// <summary>
        /// Gets the ProgramResultCodes identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId( )
        {
            try
            {
                return ID.Index > 0
                    ? ID
                    : Key.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Key.Default;
            }
        }

        /// <summary>
        /// Gets the budget level.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetLevel GetBudgetLevel( )
        {
            try
            {
                return BudgetLevel != null
                    ? new BudgetLevel( BudgetLevel.Value?.ToString( ) )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetFiscalYear GetBudgetFiscalYear( )
        {
            try
            {
                return BFY != null
                    ? new BudgetFiscalYear( BFY?.Value?.ToString( ) )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the resource planning office.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResourcePlanningOffice GetResourcePlanningOffice( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = RpioCode?.Value?.ToString( )
                };

                var _connection = new ConnectionBuilder( Source.ResourcePlanningOffices );
                var _statement = new SqlStatement( Source.ResourcePlanningOffices, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new ResourcePlanningOffice( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the allowance holder.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAllowanceHolder GetAllowanceHolder( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = AhCode?.Value?.ToString( )
                };

                var _statement = new SqlStatement( Source.AllowanceHolders, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new AllowanceHolder( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the fund.
        /// </summary>
        /// <returns>
        /// </returns>
        public IFund GetFund( )
        {
            try
            {
                return FundCode != null
                    ? new Fund( FundCode?.Value?.ToString( ) )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IOrganization GetOrganization( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{ Field.Code }" ] = OrgCode?.Value?.ToString( )
                };

                var _statement = new SqlStatement( Source.Organizations, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new Organization( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAccount GetAccount( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{ Field.Code }" ] = AccountCode?.Value?.ToString( )
                };

                var _statement = new SqlStatement( Source.Accounts, Provider.SQLite, _dictionary,
                    SQL.SELECT );

                using var _query = new Query( _statement );
                return new Account( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the budget object class.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetObjectClass GetBudgetObjectClass( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = BocCode?.Value?.ToString( )
                };

                var _statement = new SqlStatement( Source.BudgetObjectClasses, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new BudgetObjectClass( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the responsibility center.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResponsibilityCenter GetResponsibilityCenter( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{ Field.Code }" ] = RcCode?.Value?.ToString( )
                };
                
                var _statement = new SqlStatement( Source.ResponsibilityCenters, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new ResponsibilityCenter( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}