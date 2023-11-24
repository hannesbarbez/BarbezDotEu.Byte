// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarbezDotEu.Byte.Testing.Unit
{
    [TestClass]
    public class CSharpJavaByteConverterCan
    {
        private const string CSharpByteArrayString = "137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 1, 0, 0, 0, 1, 1, 3, 0, 0, 0, 37, 219, 86, 202, " +
            "0, 0, 0, 1, 115, 82, 71, 66, 0, 174, 206, 28, 233, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 3, 80, 76, 84, 69, 163, 73, 164, " +
            "140, 68, 77, 94, 0, 0, 0, 10, 73, 68, 65, 84, 24, 211, 99, 96, 0, 0, 0, 2, 0, 1, 152, 99, 108, 215, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130";

        [TestMethod]
        public void CanBiDirectionallyConvert()
        {
            var javaByteArray = CSharpJavaByteConverter.ConvertCSharpByteArrayToJavaByteArray(CSharpByteArrayString);
            Assert.IsTrue(javaByteArray.Any());

            var cSharpByteArray = CSharpJavaByteConverter.ConvertJavaByteArrayToCSharpByteArray(javaByteArray);
            Assert.IsTrue(string.Equals(cSharpByteArray, CSharpByteArrayString, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
