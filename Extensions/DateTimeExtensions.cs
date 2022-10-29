//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public static class DateTimeExtensions
    {
        /// <summary>
        /// Verifies if the object is a startDate
        /// </summary>
        /// <param name = "date" >
        /// The date.
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsDate( this object date )
        {
            try
            {
                return DateTime.TryParse( date.ToString( ), out _ );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Returns a startDate in the past by days.
        /// </summary>
        /// <param name = "days" >
        /// The days.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime DaysAgo( this int days )
        {
            try
            {
                var _timeSpan = new TimeSpan( days, 0, 0, 0 );
                return DateTime.Now.Subtract( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Returns a startDate in the future by days.
        /// </summary>
        /// <param name = "days" >
        /// The days.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime DaysFromNow( this int days )
        {
            try
            {
                var _timeSpan = new TimeSpan( days, 0, 0, 0 );
                return DateTime.Now.Add( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Returns a startDate in the past by hours.
        /// </summary>
        /// <param name = "hours" >
        /// The hours.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime HoursAgo( this int hours )
        {
            try
            {
                var _timeSpan = new TimeSpan( hours, 0, 0 );
                return DateTime.Now.Subtract( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Returns a startDate in the future by hours.
        /// </summary>
        /// <param name = "hours" >
        /// The hours.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime HoursFromNow( this int hours )
        {
            try
            {
                var _timeSpan = new TimeSpan( hours, 0, 0 );
                return DateTime.Now.Add( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Returns a startDate in the past by minutes
        /// </summary>
        /// <param name = "minutes" >
        /// The minutes.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime MinutesAgo( this int minutes )
        {
            try
            {
                var _timeSpan = new TimeSpan( 0, minutes, 0 );
                return DateTime.Now.Subtract( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Returns a startDate in the future by minutes.
        /// </summary>
        /// <param name = "minutes" >
        /// The minutes.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime MinutesFromNow( this int minutes )
        {
            try
            {
                var _timeSpan = new TimeSpan( 0, minutes, 0 );
                return DateTime.Now.Add( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets a startDate in the past according to seconds
        /// </summary>
        /// <param name = "seconds" >
        /// The seconds.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime SecondsAgo( this int seconds )
        {
            try
            {
                var _timeSpan = new TimeSpan( 0, 0, seconds );
                return DateTime.Now.Subtract( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets a startDate in the future by seconds.
        /// </summary>
        /// <param name = "seconds" >
        /// The seconds.
        /// </param>
        /// <returns>
        /// </returns>
        public static DateTime SecondsFromNow( this int seconds )
        {
            try
            {
                var _timeSpan = new TimeSpan( 0, 0, seconds );
                return DateTime.Now.Add( _timeSpan );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Checks to see if the startDate is a week day (Mon - Fri)
        /// </summary>
        /// <param name = "dateTime" >
        /// The date.
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsWeekDay( this DateTime dateTime )
        {
            try
            {
                return dateTime.DayOfWeek != DayOfWeek.Saturday
                    && dateTime.DayOfWeek != DayOfWeek.Sunday;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Checks to see if the startDate is Saturday or Sunday
        /// </summary>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsWeekEnd( this DateTime dateTime )
        {
            try
            {
                return dateTime.DayOfWeek == DayOfWeek.Saturday
                    || dateTime.DayOfWeek == DayOfWeek.Sunday;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified start date is between.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="compareTime">if set to <c>true</c> [compare time].</param>
        /// <returns>
        ///   <c>true</c> if the specified start date is between; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBetween( this DateTime dateTime, DateTime startDate, DateTime endDate,
            bool compareTime = false )
        {
            try
            {
                return compareTime
                    ? dateTime >= startDate && dateTime <= endDate
                    : dateTime.Date >= startDate.Date && dateTime.Date <= endDate.Date;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Counts the number of weekdays between two dates.
        /// </summary>
        /// <param name = "startDate" >
        /// The start time.
        /// </param>
        /// <param name = "endDate" >
        /// The end time.
        /// </param>
        /// <returns>
        /// </returns>
        public static int CountWeekDays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                var _timeSpan = endDate - startDate;
                Console.WriteLine( _timeSpan.Days );
                var _days = 0;

                for( var i = 0; i < _timeSpan.Days; i++ )
                {
                    var _dateTime = startDate.AddDays( i );

                    if( _dateTime.IsWeekDay( ) )
                    {
                        _days++;
                    }
                }

                return _days > 0
                    ? _days
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Counts the number of weekends between two dates.
        /// </summary>
        /// <param name = "startDate" >
        /// The start time.
        /// </param>
        /// <param name = "endDate" >
        /// The end time.
        /// </param>
        /// <returns>
        /// </returns>
        public static int CountWeekEnds( this DateTime startDate, DateTime endDate )
        {
            try
            {
                var _timeSpan = endDate - startDate;
                var _weekEnds = 0;

                for( var i = 0; i < _timeSpan.Days; i++ )
                {
                    var _dateTime = startDate.AddDays( i );

                    if( _dateTime.IsWeekEnd( ) )
                    {
                        _weekEnds++;
                    }
                }

                return _weekEnds > 0
                    ? _weekEnds
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Diffs the specified startDate.
        /// </summary>
        /// <param name = "startDate" >
        /// The startDate one.
        /// </param>
        /// <param name = "endDate" >
        /// The startDate two.
        /// </param>
        /// <returns>
        /// </returns>
        public static TimeSpan DateDelta( this DateTime startDate, DateTime endDate )
        {
            try
            {
                var _timeSpan = startDate.Subtract( endDate );
                return _timeSpan;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// The IsFederalHoliday
        /// </summary>
        /// <param name = "dateTime" >
        /// The startDate <see cref = "DateTime"/>
        /// </param>
        /// <returns>
        /// The <see cref = "bool"/>
        /// </returns>
        public static bool IsFederalHoliday( this DateTime dateTime )
        {
            // to ease typing
            var _nthDay = (int)Math.Ceiling( dateTime.Day / 7.0d );
            var _date = dateTime.DayOfWeek;
            var _thursday = _date == DayOfWeek.Thursday;
            var _friday = _date == DayOfWeek.Friday;
            var _monday = _date == DayOfWeek.Monday;
            var _weekend = _date == DayOfWeek.Saturday || _date == DayOfWeek.Sunday;

            switch( dateTime.Month )
            {
                // New Years Day (Jan 1, or preceding Friday/following Monday if weekend)
                case 12 when dateTime.Day == 31 && _friday:
                case 1 when dateTime.Day == 1 && !_weekend:
                case 1 when dateTime.Day == 2 && _monday:

                // MLK day (3rd monday in January)
                case 1 when _monday && _nthDay == 3:

                // President’s Day (3rd Monday in February)
                case 2 when _monday && _nthDay == 3:

                // MemorialDay Day (Last Monday in May)
                case 5 when _monday && dateTime.AddDays( 7 ).Month == 6:

                // IndependenceDay Day (July 4, or preceding Friday/following Monday if weekend)
                case 7 when dateTime.Day == 3 && _friday:
                case 7 when dateTime.Day == 4 && !_weekend:
                case 7 when dateTime.Day == 5 && _monday:

                // LaborDay Day (1st Monday in September)
                case 9 when _monday && _nthDay == 1:

                // ColumbusDay Day (2nd Monday in October)
                case 10 when _monday && _nthDay == 2:

                // Veteran’s Day (November 11, or preceding Friday/following Monday if weekend))
                case 11 when dateTime.Day == 10 && _friday:
                case 11 when dateTime.Day == 11 && !_weekend:
                case 11 when dateTime.Day == 12 && _monday:

                // ThanksgivingDay Day (4th Thursday in November)
                case 11 when _thursday && _nthDay == 4:

                // ChristmasDay Day (December 25, or preceding Friday/following Monday if weekend))
                case 12 when dateTime.Day == 24 && _friday:
                case 12 when dateTime.Day == 25 && !_weekend:
                case 12 when dateTime.Day == 26 && _monday:
                    return true;

                default:
                    return false;
            }
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