using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges._Challenges {
    /* 
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     */
    public class _020_ValidParenthesis {
        public static bool IsValid(string inputArray) {
            Stack<char> stack = new Stack<char>();
            foreach (char c in inputArray) {
                switch (c) {
                    case '[':
                    case '{':
                    case '(': stack.Push(c); break;
                    case ')': if (stack.Count == 0 || stack.Peek() != '(') return false; else stack.Pop(); break;
                    case '}': if (stack.Count == 0 || stack.Peek() != '{') return false; else stack.Pop(); break;
                    case ']': if (stack.Count == 0 || stack.Peek() != '[') return false; else stack.Pop(); break;
                }
            }
            return stack.Count == 0;
        }
    }
}
