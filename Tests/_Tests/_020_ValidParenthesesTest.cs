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
            bool userSolution = _020_ValidParenthesis.IsValid(inputString);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_002() {
            string inputString = "(";
            bool expectedResult = false;
            bool userSolution = _020_ValidParenthesis.IsValid(inputString);
            Assert.AreEqual(expectedResult, userSolution);
        }

        [TestMethod]
        public void Test_003() {
            string inputString = ")";
            bool expectedResult = false;
            bool userSolution = _020_ValidParenthesis.IsValid(inputString);
            Assert.AreEqual(expectedResult, userSolution);
        }
    }
}
