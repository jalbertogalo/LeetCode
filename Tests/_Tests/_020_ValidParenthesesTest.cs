using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests._Tests {
    [TestClass]
    public class _020_ValidParenthesesTest {

        [TestMethod]
        public void Test_001() {
            string inputString = "()";
            bool expectedResult = true;
            bool userResult = _020_ValidParentheses.IsValid(inputString);
            Assert.AreEqual(expectedResult, userResult);
        }

        [TestMethod]
        public void Test_002() {
            string inputString = "([{}])";
            bool expectedResult = true;
            bool userResult = _020_ValidParentheses.IsValid(inputString);
            Assert.AreEqual(expectedResult, userResult);
        }

        [TestMethod]
        public void Test_003() {
            string inputString = "((()))[[[]]]{{{}}}";
            bool expectedResult = true;
            bool userResult = _020_ValidParentheses.IsValid(inputString);
            Assert.AreEqual(expectedResult, userResult);
        }

        [TestMethod]
        public void Test_004() {
            string inputString = "(}";
            bool expectedResult = false;
            bool userResult = _020_ValidParentheses.IsValid(inputString);
            Assert.AreEqual(expectedResult, userResult);
        }
    }
}
