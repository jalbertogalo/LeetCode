namespace Tests._Tests {
    [TestClass]
    public class _027_RemoveElementTest {
        
        [TestMethod]
        public void Test_001() {
            int[] inputArray = new int[] { 3, 2, 2, 3 };
            int inputRemoveElement = 3;
            int expectedResult = 2;
            int[] expectedResultArray = new int[] { 2, 2 };
            int userSolution = _027_RemoveElement.RemoveElement(inputArray, inputRemoveElement);
            Assert.AreEqual(expectedResult, userSolution);
            CollectionAssert.AreEqual(inputArray.Take(expectedResult).ToArray(), expectedResultArray);
        }

        [TestMethod]
        public void Test_002() {
            int[] inputArray = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int inputRemoveElement = 2;
            int expectedResult = 5;
            int[] expectedResultArray = new int[] { 0, 1, 4, 0, 3 };
            int userSolution = _027_RemoveElement.RemoveElement(inputArray, inputRemoveElement);
            Assert.AreEqual(expectedResult, userSolution);
            CollectionAssert.AreEquivalent(inputArray.Take(expectedResult).ToArray(), expectedResultArray);
        }

    }
}
