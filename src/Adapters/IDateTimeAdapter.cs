using System;
using System.Collections.Generic;
using System.Globalization;

namespace Unfix
{
    /// <summary>
    /// A date time adapter
    /// </summary>
    public interface IDateTimeAdapter
    {
        /// <summary>
        /// Maximum supported date time value
        /// </summary>
        DateTime MaxValue { get; }
        /// <summary>
        /// Miniumu supported date time value
        /// </summary>
        DateTime MinValue { get; }

        /// <summary>
        /// Now
        /// </summary>
        DateTime Now { get; }
        /// <summary>
        /// Today
        /// </summary>
        DateTime Today { get; }
        /// <summary>
        /// Now (UTC)
        /// </summary>
        DateTime UtcNow { get; }
        /// <summary>
        /// Days in the <paramref name="month"/> of the specified <paramref name="year"/>
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        int DaysInMonth(int year, int month);
        /// <summary>
        /// Deserializes a 64-bit binary value and recreates an original serialized DateTime object.
        /// </summary>
        /// <param name="dateData"></param>
        /// <returns></returns>
        DateTime FromBinary(long dateData);
        /// <summary>
        /// Converts the specified Windows <paramref name="fileTime"/> to an equivalent local time.
        /// </summary>
        /// <param name="fileTime"></param>
        /// <returns></returns>
        DateTime FromFileTime(long fileTime);
        /// <summary>
        /// Converts the specified Windows <paramref name="fileTime"/> to an equivalent UTC time.
        /// </summary>
        /// <param name="fileTime"></param>
        /// <returns></returns>
        DateTime FromFileTimeUtc(long fileTime);
        /// <summary>
        /// Returns a DateTime equivalent to the specified OLE Automation Date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        DateTime FromOADate(double d);
        /// <summary>
        /// Returns whether the specified <paramref name="year"/> is a leap year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        bool IsLeapYear(int year);
        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        DateTime Parse(string s, IFormatProvider provider);
        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        DateTime Parse(string s);
        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        DateTime Parse(ReadOnlySpan<char> span, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None);
        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <returns></returns>
        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
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
        DateTime ParseExact(string s, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style);
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
        DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
        /// <summary>
        /// Converts the specified string representation <paramref name="s"/> of a date and time to its DateTime equivalent using
        /// the specified format and culture-specific format information. The format of the string representation must match the
        /// specified format exactly.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        DateTime ParseExact(string s, string format, IFormatProvider provider);
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
        DateTime ParseExact(ReadOnlySpan<char> span, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
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
        DateTime ParseExact(ReadOnlySpan<char> span, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None);
        /// <summary>
        /// Creates a new <see cref="DateTime"/> object that has the same number of ticks as the specified <paramref name="dateTime"/>, but is
        /// designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <paramref name="kind"/>
        /// value.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="kind"></param>
        /// <returns></returns>
        DateTime SpecifyKind(DateTime dateTime, DateTimeKind kind);
        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryParse(string s, out DateTime result);
        /// <summary>
        /// Converts the string representation <paramref name="s"/> of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// the conventions of the current thread culture.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryParse(ReadOnlySpan<char> span, out DateTime result);
        /// <summary>
        /// Converts a <paramref name="span"/> that contains string representation of a date and time to its DateTime equivalent by using
        /// culture-specific format information from the <paramref name="provider"/> and a formatting style.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="provider"></param>
        /// <param name="styles"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryParse(ReadOnlySpan<char> span, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
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
        bool TryParseExact(ReadOnlySpan<char> span, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
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
        bool TryParseExact(ReadOnlySpan<char> span, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
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
        bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
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
        bool TryParseExact(string s, IEnumerable<string> formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);
    }
}