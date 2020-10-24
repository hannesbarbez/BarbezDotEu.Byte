// Copyright (c) Hannes Barbez. All rights reserved.

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
    }
}
