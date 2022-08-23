using Challenges._Challenges;

namespace Tests._Tests {
    [TestClass]
    public class _001_TwoSumTest {

        [TestMethod]
        public void Test_001() {
            int[] inputArray = new int[] { 2, 7, 11, 15 };
            int inputTarget = 9;
            int[] expectedArray = new int[] { 0, 1 };
            CollectionAssert.AreEqual(expectedArray, _001_TwoSum.Solution(inputArray, inputTarget));
        }

        [TestMethod]
        public void Test_002() {
            int[] inputArray = new int[] { 3, 2, 4 };
            int inputTarget = 6;
            int[] expectedArray = new int[] { 1, 2 };
            CollectionAssert.AreEqual(expectedArray, _001_TwoSum.Solution(inputArray, inputTarget));
        }

        [TestMethod]
        public void Test_003() {
            int[] inputArray = new int[] { 3, 3 };
            int inputTarget = 6;
            int[] expectedArray = new int[] { 0, 1 };
            CollectionAssert.AreEqual(expectedArray, _001_TwoSum.Solution(inputArray, inputTarget));
        }
    }
}
