// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Security.Cryptography;
using System.Text;

namespace BarbezDotEu.Byte
{
    /// <summary>
    /// Helpers for cryptography.
    /// </summary>
    public static class CryptoHelper
    {
        /// <summary>
        /// Equivalent of T-SQL's HASHBYTES('SHA2_256', &lt;toHash&gt;)".
        /// </summary>
        /// <param name="toHash">The string to hash.</param>
        /// <returns>The result of the hash.</returns>
        public static byte[] GetTsqlLikeHashBytes(string toHash)
        {
            byte[] hashable = Encoding.Unicode.GetBytes(toHash);
            var hasher = SHA256.Create();
            return hasher.ComputeHash(hashable);
        }
    }
}
