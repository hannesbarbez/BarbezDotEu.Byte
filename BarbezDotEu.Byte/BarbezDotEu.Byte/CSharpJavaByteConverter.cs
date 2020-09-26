// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BarbezDotEu.Byte
{
    /// <summary>
    /// Byte array converter allowing for a fast enough and accurate conversion between Java and C# byte arrays.
    /// </summary>
    public static class CSharpJavaByteConverter
    {
        private static readonly Regex digitsOnly = new Regex(@"\d+", RegexOptions.Compiled);

        /// <summary>
        /// Converts a C# byte array (represented as string) into a Java byte array (returned as its string representation).
        /// </summary>
        /// <param name="cSharpByteArray">The string representation of a C# byte array.</param>
        /// <returns>The string representation of a Java byte array.</returns>
        public static string ConvertCSharpByteArrayToJavaByteArray(string cSharpByteArray)
        {
            var result = string.Empty;
            var toConvert = cSharpByteArray.Split(new char[] { ',' });
            var converted = ConvertCSharpStringArrayToJavaByteArray(toConvert, 127);
            for (int i = 0; i < converted.Length; i++)
            {
                if (i == converted.Length - 1) result += converted[i].ToString();
                else result += converted[i] + ", ";
            }

            return result;
        }

        /// <summary>
        /// Converts a Java byte array (represented as string) into a C# byte array (returned as its string representation).
        /// </summary>
        /// <param name="javaByteArray">The string representation of a Java byte array.</param>
        /// <returns>The string representation of a C# byte array.</returns>
        public static string ConvertJavaByteArrayToCSharpByteArray(string javaByteArray)
        {
            var result = string.Empty;
            var toConvert = javaByteArray.Split(new char[] { ',' });
            var converted = ConvertJavaStringArrayToCSharpByteArray(toConvert, 0);
            for (int i = 0; i < converted.Length; i++)
            {
                if (i == converted.Length - 1) result += converted[i].ToString();
                else result += converted[i] + ", ";
            }

            return result;
        }

        /// <summary>
        /// Converts a Java byte array (represented as string) into a C# byte array (returned as its int representation for consistency).
        /// </summary>
        /// <param name="javaByteArray">The string representation of a Java byte array.</param>
        /// <returns>The C# byte array as integer array.</returns>
        public static int[] ConvertJavaStringArrayToCSharpByteArray(string[] toConvert, byte threshold)
        {
            var numbers = new List<int>();
            foreach (string s in toConvert)
            {
                if (int.TryParse(s, out var n))
                {
                    if (n < threshold)
                        numbers.Add(n + (byte.MaxValue + 1));
                    else numbers.Add(n);
                }
                else throw new ArgumentException();
            }

            return numbers.ToArray();
        }

        /// <summary>
        /// Converts a C# byte array (represented as string) into a Java byte array (returned as its int representation because Java byte arrays can contain negative values).
        /// </summary>
        /// <param name="cSharpByteArray">The string representation of a C# byte array.</param>
        /// <returns>The Java byte array as integer array.</returns>
        public static int[] ConvertCSharpStringArrayToJavaByteArray(string[] toConvert, byte threshold)
        {
            var numbers = new List<int>();
            foreach (string s in toConvert)
            {
                var match = digitsOnly.Match(s);
                if (int.TryParse(match.Value, out var n))
                {
                    if (n > threshold)
                        numbers.Add(n - (byte.MaxValue +1));
                    else numbers.Add(n);
                }
                else throw new ArgumentException();
            }

            return numbers.ToArray();
        }
    }
}
