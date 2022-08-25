using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests._Tests {
    [TestClass]
    public class _026_RemoveDuplicatesFromSortedArrayTest {

        [TestMethod]
        public void Test_001() {
            int[] inputArray = new int[] { 1, 1, 2 };
            int expectedResult = 2;
            int userResult = _026_RemoveDuplicatesFromSortedArray.RemoveDuplicates(inputArray);
            Assert.AreEqual(expectedResult, userResult);
            CollectionAssert.AreEqual(inputArray.Take(expectedResult).ToArray(), new int[] { 1, 2 });
        }

        [TestMethod]
        public void Test_002() {
            int[] inputArray = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int expectedResult = 5;
            int userResult = _026_RemoveDuplicatesFromSortedArray.RemoveDuplicates(inputArray);
            Assert.AreEqual(expectedResult, userResult);
        }
    }
}
