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
        /// Computes a hash using <see cref="SHA256"/> and a given <see cref="Encoding"/>.
        /// </summary>
        /// <param name="toHash">The string to hash.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The result of the hash.</returns>
        /// <remarks>
        /// As an aside, this is also the equivalent of T-SQL's HASHBYTES('SHA2_256', &lt;toHash&gt;)".
        /// In that case, <paramref name="encoding"/> could correspond to your SQL Server collation.
        /// </remarks>
        public static byte[] ComputeSha256Hash(string toHash, Encoding encoding)
        {
            byte[] hashable = encoding.GetBytes(toHash);
            var hasher = SHA256.Create();
            return hasher.ComputeHash(hashable);
        }
    }
}
