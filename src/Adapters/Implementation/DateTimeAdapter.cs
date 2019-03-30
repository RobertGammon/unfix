using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Unfix.Implementation
{
    /// <summary>
    /// An adapter that delegates to <see cref="System.DateTime"/> 
    /// </summary>
    public class DateTimeAdapter : IDateTimeAdapter
    {
        /// <summary>
        /// Maximum supported date time value
        /// </summary>
        public DateTime MaxValue
        {
            get
            {
                return DateTime.MaxValue;
            }
        }

        /// <summary>
        /// Miniumu supported date time value
        /// </summary>
        public DateTime MinValue
        {
            get
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Now
        /// </summary>
        public DateTime Now { get { return DateTime.Now; } }

        /// <summary>
        /// Today
        /// </summary>
        public DateTime Today { get { return DateTime.Today; } }

        /// <summary>
        /// Now (UTC)
        /// </summary>
        public DateTime UtcNow { get { return DateTime.UtcNow; } }

        /// <summary>
        /// Days in the <paramref name="month"/> of the specified <paramref name="year"/>
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        /// <summary>
        /// Deserializes a 64-bit binary value and recreates an original serialized DateTime object.
        /// </summary>
        /// <param name="dateData"></param>
        /// <returns></returns>
        public DateTime FromBinary(long dateData)
        {
            return DateTime.FromBinary(dateData);
        }

        /// <summary>
        /// Converts the specified Windows <paramref name="fileTime"/> to an equivalent local time.
        /// </summary>
        /// <param name="fileTime"></param>
        /// <returns></returns>
        public DateTime FromFileTime(long fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }

        /// <summary>
        /// Converts the specified Windows <paramref name="fileTime"/> to an equivalent UTC time.
        /// </summary>
        /// <param name="fileTime"></param>
        /// <returns></returns>
        public DateTime FromFileTimeUtc(long fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }

        /// <summary>
        /// Returns a DateTime equivalent to the specified OLE Automation Date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DateTime FromOADate(double d)
        {
            return DateTime.FromOADate(d);
        }

        /// <summary>
        /// Returns whether the specified <paramref name="year"/> is a leap year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public DateTime Parse(string s, IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }

        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DateTime Parse(string s)
        {
            return DateTime.Parse(s);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        public DateTime Parse(ReadOnlySpan<char> span, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.Parse(span, provider, styles);
        }

        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.Parse(s, provider, styles);
        }

        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified <paramref name="formats"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match at least one of the specified formats exactly or an exception
        /// is thrown.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="formats"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public DateTime ParseExact(string s, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats.ToArray(), provider, style);
        }

        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified <paramref name="format"/>, culture-specific format information, and style. The format of the string
        /// representation must match the specified format exactly or an exception is thrown.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }

        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified format and culture-specific format information. The format of the string representation must match the
        /// specified format exactly.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public DateTime ParseExact(string s, string format, IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the specified <paramref name="formats"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match at least one of the specified formats exactly or an exception
        /// is thrown.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="formats"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public DateTime ParseExact(ReadOnlySpan<char> span, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(span, formats.ToArray(), provider, style);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the specified <paramref name="format"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match at least one of the specified formats exactly or an exception
        /// is thrown.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public DateTime ParseExact(ReadOnlySpan<char> span, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
        {
            return DateTime.ParseExact(span, format, provider, style);
        }

        /// <summary>
        /// Creates a new <see cref="DateTime"/> object that has the same number of ticks as the specified <paramref name="dateTime"/>, but is
        /// designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <paramref name="kind"/>
        /// value.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="kind"></param>
        /// <returns></returns>
        public DateTime SpecifyKind(DateTime dateTime, DateTimeKind kind)
        {
            return DateTime.SpecifyKind(dateTime, kind);
        }

        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParse(string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }

        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParse(ReadOnlySpan<char> span, out DateTime result)
        {
            return DateTime.TryParse(span, out result);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParse(ReadOnlySpan<char> span, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            return DateTime.TryParse(span, provider, styles, out result);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the specified <paramref name="format"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match at least one of the specified formats exactly.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParseExact(ReadOnlySpan<char> span, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(span, format, provider, style, out result);
        }

        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the specified <paramref name="formats"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="formats"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParseExact(ReadOnlySpan<char> span, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(span, formats.ToArray(), provider, style, out result);
        }

        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified <paramref name="format"/>, culture-specific format information, and style. The format of the string
        /// representation must match the specified format exactly.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }

        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified <paramref name="formats"/>, culture-specific format information from the <paramref name="provider"/>,
        /// and style. The format of the string representation must match at least one of the specified formats exactly.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="formats"></param>
        /// <param name="provider"></param>
        /// <param name="style"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryParseExact(string s, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            return DateTime.TryParseExact(s, formats.ToArray(), provider, style, out result);
        }
    }
}
