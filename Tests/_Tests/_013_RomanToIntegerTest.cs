namespace Tests._Tests {
    [TestClass]
    public class _013_RomanToIntegerTest {

        [TestMethod]
        public void Test_001() {
            string inputRomanNumber = "III";
            int expectedValue = 3;

            _013_RomanToInteger romanToInteger = new _013_RomanToInteger();

            int solution = romanToInteger.RomanToInt(inputRomanNumber);
            Assert.AreEqual(expectedValue, solution);
        }

        [TestMethod]
        public void Test_002() {
            string inputRomanNumber = "IV";
            int expectedValue = 4;

            _013_RomanToInteger romanToInteger = new _013_RomanToInteger();

            int solution = romanToInteger.RomanToInt(inputRomanNumber);
            Assert.AreEqual(expectedValue, solution);
        }

        [TestMethod]
        public void Test_003() {
            string inputRomanNumber = "LX";
            int expectedValue = 60;

            _013_RomanToInteger romanToInteger = new _013_RomanToInteger();

            int solution = romanToInteger.RomanToInt(inputRomanNumber);
            Assert.AreEqual(expectedValue, solution);
        }

        [TestMethod]
        public void Test_004() {
            string inputRomanNumber = "XLIII";
            int expectedValue = 43;

            _013_RomanToInteger romanToInteger = new _013_RomanToInteger();

            int solution = romanToInteger.RomanToInt(inputRomanNumber);
            Assert.AreEqual(expectedValue, solution);
        }
    }
}
