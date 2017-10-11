using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MergeEqualItemsTest()
        {
            var charArray1 = new[] {'a', 'b', 'c'};
            var charArray2 = new[] {'1', '2', '3'};

            var expectedMergedArray = new[] {'a', '1', 'b', '2', 'c', '3'};
            var actualMergedArray = MergeArray.Merge(charArray1, charArray2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [TestMethod]
        public void MergeUnequalItemsTest()
        {
            var charArray1 = new[] {'a', 'b'};
            var charArray2 = new[] {'1', '2', '3', '4'};

            var expectedMergedArray = new[] {'a', '1', 'b', '2', '3', '4'};
            var actualMergedArray = MergeArray.Merge(charArray1, charArray2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [TestMethod]
        public void MergeLargeEqualItemsTest()
        {
            var charArray1 = new[] { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
            var charArray2 = new[] { '4', '2', '3', '/', 'e', '8', 'v', 'x' };

            var expectedMergedArray = new[]
                {'f', '4', '5', '2', 'c', '3', 'q', '/', '9', 'e', '-', '8', 't', 'v', '1', 'x'};

            var actualMergedArray = MergeArray.Merge(charArray1, charArray2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [TestMethod]
        public void MergeLargeUnequalItemsTest()
        {
            var charArray1 = new[] { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
            var charArray2 = new[] { '4', '2', '3' };

            var expectedMergedArray = new[]
                {'f', '4', '5', '2', 'c', '3', 'q', '9', '-', 't', '1'};

            var actualMergedArray = MergeArray.Merge(charArray1, charArray2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }
    }
}
