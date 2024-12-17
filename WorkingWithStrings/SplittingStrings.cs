using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WorkingWithStrings
{
    public static class SplittingStrings
    {
        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedString(string str)
        {
            // TODO #5-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            return str.Split(':');
        }

        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            // TODO #5-2. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            string[] parts = str.Split(',');

            if (parts.Length > 2)
            {
                return new string[] { parts[0], string.Join(",", parts.Skip(1)) };
            }

            return parts;
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            // TODO #5-3. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            string[] parts = str.Split(':');

            if (parts.Length > 3)
            {
                return new string[] { parts[0], parts[1], string.Join(":", parts.Skip(2)) };
            }

            return parts;
        }

        /// <summary>
        /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            // TODO #5-4. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            string[] parts = str.Split('-', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 3)
            {
                return new string[] { parts[0], parts[1], string.Join("-", parts.Skip(2)) };
            }

            return parts;
        }

        /// <summary>
        /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            // TODO #5-5. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            char[] separators = new char[] { ',', ':' };
            string[] parts = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 4)
            {
                var firstThree = parts.Take(3).ToArray();
                var remainingParts = string.Join(",", parts.Skip(3));

                return new string[] { firstThree[0], firstThree[1], firstThree[2], remainingParts };
            }

            return parts;
        }

        /// <summary>
        /// Splits a sentence into substrings, and return an array whose elements contain only words.
        /// </summary>
        public static string[] GetOnlyWords(string str)
        {
            // TODO #5-6. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            var cleanedStr = new string(str.Where(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)).ToArray());

            return cleanedStr.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
        /// </summary>
        public static string[] GetDataFromCsvLine(string str)
        {
            // TODO #5-7. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            return str.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }
    }
}
