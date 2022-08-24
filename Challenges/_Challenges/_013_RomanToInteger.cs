using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges._Challenges {
    /* 
     * Given a roman numeral, convert it to an integer
     */
    public class _013_RomanToInteger {
        public Dictionary<char, int> RomanNumbers { get; }

        public _013_RomanToInteger() {
            RomanNumbers = new Dictionary<char, int>();
            RomanNumbers.Add('I', 1);
            RomanNumbers.Add('V', 5);
            RomanNumbers.Add('X', 10);
            RomanNumbers.Add('L', 50);
            RomanNumbers.Add('C', 100);
            RomanNumbers.Add('D', 500);
            RomanNumbers.Add('M', 1000);
        }

        public int RomanToInt(string romanNumber) {
            int romanToInt = RomanNumbers[romanNumber[romanNumber.Length - 1]];
            for (int i = romanNumber.Length - 1; i >= 1; i--) {
                int currentPositionValue = RomanNumbers[romanNumber[i]];
                int nextPositionValue = RomanNumbers[romanNumber[i - 1]];
                romanToInt = currentPositionValue <= nextPositionValue ? romanToInt + nextPositionValue : romanToInt - nextPositionValue;
            }
            return romanToInt;
        }
    }
}
