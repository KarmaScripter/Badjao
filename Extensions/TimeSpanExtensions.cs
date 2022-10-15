// // <copyright file = "TimeSpanExtensions.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines the <see cref = "TimeSpanExtensions"/> .
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Defines the AvgDaysInAYear.
        /// </summary>
        public const double AvgDaysInAYear = 365.2425d;

        /// <summary>
        /// Defines the AvgDaysInAMonth.
        /// </summary>
        public const double AvgDaysInAMonth = 30.436875d;

        /// <summary>
        /// The GetYears.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "int"/> .
        /// </returns>
        public static int GetYears( this TimeSpan timeSpan )
        {
            return (int)( timeSpan.TotalDays / AvgDaysInAYear );
        }

        /// <summary>
        /// The GetTotalYears.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "double"/> .
        /// </returns>
        public static double GetTotalYears( this TimeSpan timeSpan )
        {
            return timeSpan.TotalDays / AvgDaysInAYear;
        }

        /// <summary>
        /// The GetMonths.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "int"/> .
        /// </returns>
        public static int GetMonths( this TimeSpan timeSpan )
        {
            return (int)( timeSpan.TotalDays % AvgDaysInAYear
                / AvgDaysInAMonth );
        }

        /// <summary>
        /// The GetTotalMonths.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "double"/> .
        /// </returns>
        public static double GetTotalMonths( this TimeSpan timeSpan )
        {
            return timeSpan.TotalDays / AvgDaysInAMonth;
        }

        /// <summary>
        /// The GetWeeks.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "int"/> .
        /// </returns>
        public static int GetWeeks( this TimeSpan timeSpan )
        {
            return (int)( timeSpan.TotalDays % AvgDaysInAYear
                % AvgDaysInAMonth / 7d );
        }

        /// <summary>
        /// The GetTotalWeeks.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "double"/> .
        /// </returns>
        public static double GetTotalWeeks( this TimeSpan timeSpan )
        {
            return timeSpan.TotalDays / 7d;
        }

        /// <summary>
        /// The GetDays.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "int"/> .
        /// </returns>
        public static int GetDays( this TimeSpan timeSpan )
        {
            return (int)( timeSpan.TotalDays % 7d );
        }

        /// <summary>
        /// The GetMicroseconds.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "double"/> .
        /// </returns>
        public static double GetMicroseconds( this TimeSpan timeSpan )
        {
            return timeSpan.Ticks / 10d;
        }

        /// <summary>
        /// The GetNanoseconds.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "double"/> .
        /// </returns>
        public static double GetNanoseconds( this TimeSpan timeSpan )
        {
            return timeSpan.Ticks / 100d;
        }

        /// <summary>
        /// The Round.
        /// </summary>
        /// <param name = "timeSpan" >
        /// The timeSpan <see cref = "TimeSpan"/> .
        /// </param>
        /// <param name = "roundinginterval" >
        /// The roundingInterval <see cref = "TimeSpan"/> .
        /// </param>
        /// <param name = "roundingtype" >
        /// The roundingType <see cref = "MidpointRounding"/> .
        /// </param>
        /// <returns>
        /// The <see cref = "TimeSpan"/> .
        /// </returns>
        public static TimeSpan Round( this TimeSpan timeSpan, TimeSpan roundinginterval,
            MidpointRounding roundingtype = MidpointRounding.ToEven )
        {
            return new TimeSpan(
                Convert.ToInt64( Math.Round( timeSpan.Ticks / (double)roundinginterval.Ticks,
                    roundingtype ) ) * roundinginterval.Ticks );
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}