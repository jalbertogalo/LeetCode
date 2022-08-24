namespace Tests._Tests {

    [TestClass]
    public class _014_LongestCommonPrefixTest {

        [TestMethod]
        public void Test_001() {
            string[] inputStringArray = new string[] { "flower", "flow", "flight" };
            string expectedResult = "fl";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_002() {
            string[] inputStringArray = new string[] { "dog", "racecar", "car" };
            string expectedResult = "";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_003() {
            string[] inputStringArray = new string[] { "a" };
            string expectedResult = "a";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_004() {
            string[] inputStringArray = new string[] { "ab", "a" };
            string expectedResult = "a";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_005() {
            string[] inputStringArray = new string[] { "reflower", "flow", "flight" };
            string expectedResult = "";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_006() {
            string[] inputStringArray = new string[] { "", "" };
            string expectedResult = "";
            string userSolution = _014_LongestCommonPrefix.LongestCommonPrefix(inputStringArray);
            Assert.AreEqual(expectedResult, userSolution);
        }
    }
}
