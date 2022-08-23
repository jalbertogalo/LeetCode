namespace Tests._Tests {
    [TestClass]
    public class _009_PalindromNumberTest {

        [TestMethod]
        public void Test_001() {
            int inputNumber = 121;
            bool expectedResult = true;
            bool userSolution = _009_PalindromeNumber.IsPalindrome(inputNumber);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_002() {
            int inputNumber = 123456789;
            bool expectedResult = false;
            bool userSolution = _009_PalindromeNumber.IsPalindrome(inputNumber);
            Assert.AreEqual(expectedResult, userSolution);
        }
    }
}
