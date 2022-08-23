using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges._Challenges {
    public class _009_PalindromeNumber {
        /* 
         * Given an integer x, return true if x is palindrome integer.
         * An integer is a palindrome when it reads the same backward as forward.
        */
        public static bool IsPalindrome(int number) {
            string numberString = number.ToString();
            string isPalindrome = "";
            for (int i = numberString.Length - 1; i >= 0; i--) {
                isPalindrome += numberString[i];
            }
            return isPalindrome == numberString;
        }
    }
}
