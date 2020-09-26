// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;

namespace BarbezDotEu.Byte
{
    /// <summary>
    /// Byte array converter allowing for a fast enough and accurate conversion between Java and C# byte arrays.
    /// </summary>
    public class CSharpJavaByteConverter
    {
        /// <summary>
        /// Converts a C# byte array (represented as string) into a Java byte array (returned as its string representation).
        /// </summary>
        /// <param name="cSharpByteArray">The string representation of a C# byte array.</param>
        /// <returns>The string representation of a Java byte array.</returns>
        public string ConvertCSharpByteArrayToJavaByteArray(string cSharpByteArray)
        {
            var result = string.Empty;
            var toConvert = cSharpByteArray.Replace(" ", "").Split(new char[] { ',' });
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
        public string ConvertJavaByteArrayToCSharpByteArray(string javaByteArray)
        {
            var result = string.Empty;
            var toConvert = javaByteArray.Replace(" ", "").Split(new char[] { ',' });
            var converted = ConvertJavaStringArrayToCSharpByteArray(toConvert, 0);
            for (int i = 0; i < converted.Length; i++)
            {
                if (i == converted.Length - 1) result += converted[i].ToString();
                else result += converted[i] + ", ";
            }

            return result;
        }

        /// <summary>
        /// Converts a Java byte array (represented as string) into a C# byte array.
        /// </summary>
        /// <param name="javaByteArray">The string representation of a Java byte array.</param>
        /// <returns>The C# byte array.</returns>
        public byte[] ConvertJavaStringArrayToCSharpByteArray(string[] toConvert, byte threshold)
        {
            var numbers = new List<byte>();
            foreach (string s in toConvert)
            {
                if (byte.TryParse(s, out var n))
                {
                    if (n < threshold)
                        numbers.Add((byte)(n + byte.MaxValue + 1));
                    else numbers.Add(n);
                }
                else throw new ArgumentException();
            }

            return numbers.ToArray();
        }

        /// <summary>
        /// Converts a C# byte array (represented as string) into a Java byte array.
        /// </summary>
        /// <param name="cSharpByteArray">The string representation of a C# byte array.</param>
        /// <returns>The Java byte array.</returns>
        public byte[] ConvertCSharpStringArrayToJavaByteArray(string[] toConvert, byte threshold)
        {
            var numbers = new List<byte>();
            foreach (string s in toConvert)
            {
                if (byte.TryParse(s, out var n))
                {
                    if (n > threshold)
                        numbers.Add((byte)(n - byte.MaxValue + 1));
                    else numbers.Add(n);
                }
                else throw new ArgumentException();
            }

            return numbers.ToArray();
        }
    }
}
