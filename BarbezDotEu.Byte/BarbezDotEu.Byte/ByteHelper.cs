// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Linq;
using System.Text;

namespace BarbezDotEu.Byte
{
    /// <summary>
    /// Helper class containing diverse static methods that can be used in any type of context.
    /// </summary>
    public static class ByteHelper
    {
        /// <summary>
        /// Creates a byte array from the string, using the 
        /// System.Text.Encoding.Default encoding unless another is specified.
        /// </summary>
        public static byte[] ToByteArray(this string input, Encoding encoding = default)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new byte[] { };

            if (encoding == default)
                encoding = Encoding.UTF8;

            return encoding.GetBytes(input);
        }

        /// <summary>
        /// Converts a "written" byte-array to an actual byte array.
        /// e.g. input string: 69CC766AEFAE05F6BE92A529E27D6AC50A0DC73EFB3631534B5E41A9311D56AB.
        /// </summary>
        /// <param name="hex">The "written" byte-array to convert.</param>
        /// <returns>The actual byte-array representation.</returns>
        /// <remarks>Based on https://stackoverflow.com/a/321404/8669939</remarks>
        public static byte[] StringToByteArray(this string hex)
        {
            // TODO: Check what can and cannot be merged with ToByteArray method above, and rename or remove accordingly if needed.
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        /// <summary>
        /// Generates a string representation of a byte array.
        /// </summary>
        /// <param name="hash">The hash to write as string.</param>
        /// <returns>A string representation of the hash.</returns>
        public static string ByteArrayToString(byte[] hash)
        {
            var stringBuilder = new StringBuilder(hash.Length * 2);
            foreach (byte @byte in hash)
                stringBuilder.Append(@byte.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}
