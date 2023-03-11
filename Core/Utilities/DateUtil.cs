using System;

namespace EtteremNG.Core.Utilities
{
    /// <summary>Contains utility functions for working with <see cref="DateTime"/> objects.</summary>
    internal class DateUtil
    {
        /// <summary>Converts a string into a <see cref="DateTime"/> object.</summary>
        /// <param name="date">A string representing the date.</param>
        /// <param name="time">A string representing the time.</param>
        /// <remarks><see cref="time"/> is optional.</remarks>
        /// <returns>A <see cref="DateTime"/> object based on the input parameters.</returns>
        public static DateTime DateTimeFromString(string date, string time = null)
        {
            var DateTimePieces = date.Split(' ');
            var datePieces = DateTimePieces[0].Split('-');
            var timePieces = time != null ? time.Split(':') : DateTimePieces[1].Split(':');

            return new DateTime(
                DateTime.Now.Year,
                Convert.ToInt32(datePieces[0]),
                Convert.ToInt32(datePieces[1]),
                Convert.ToInt32(timePieces[0]),
                Convert.ToInt32(timePieces[1]),
                0
            );
        }

        /// <summary>Converts a <see cref="DateTime"/> object into a string.</summary>
        /// <param name="date">The <see cref="DateTime"/> object to convert.</param>
        /// <param name="timeOnly">If set, the date field is ignored.</param>
        /// <returns>A <see cref="DateTime"/> object based on the input parameters.</returns>
        public static string StringFromDate(DateTime date, bool timeOnly = false)
        {
            return timeOnly ? $"{date:HH:mm}" : $"{date:MM-dd HH:mm}";
        }

        /// <summary>Returns a new <see cref="DateTime"/> with the seconds field set to zero.</summary>
        /// <param name="input">The <see cref="DateTime"/> to use.</param>
        /// <returns>A new <see cref="DateTime"/> with the seconds field set to zero.</returns>
        public static DateTime RemoveSeconds(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 00);
        }
    }
}
