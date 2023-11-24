// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarbezDotEu.Byte.Testing.Unit
{
    [TestClass]
    public class CryptoHelperCan
    {
        [TestMethod]
        public void ProduceResultConsistentWithByteHelper()
        {
            var original = "Hannes";
            var expectedSqlLikeHashBytes = CryptoHelper.ComputeSha256Hash(original, Encoding.UTF8);

            var hashed = "388E3CC1559EAF11049F3E65223E823CF441F0D3B0C1B6BE2E41584C3A786945";
            var output = ByteHelper.StringToByteArray(hashed);
            Assert.IsTrue(Enumerable.SequenceEqual(output, expectedSqlLikeHashBytes));
        }
    }
}
