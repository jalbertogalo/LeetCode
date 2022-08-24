namespace Challenges._Challenges {
    public class _020_ValidParentheses {

        public static bool IsValid(string inputString) {
            Stack<char> openParentheses = new Stack<char>();

            foreach (char c in inputString) {
                switch (c) {
                    case '(':
                    case '[':
                    case '{':
                        openParentheses.Push(c);
                        break;
                    case ')':
                        if (openParentheses.Count == 0 || openParentheses.Peek() != '(') return false; else openParentheses.Pop();
                        break;
                    case ']':
                        if (openParentheses.Count == 0 || openParentheses.Peek() != '[') return false; else openParentheses.Pop();
                        break;
                    case '}':
                        if (openParentheses.Count == 0 || openParentheses.Peek() != '{') return false; else openParentheses.Pop();
                        break;
                }
            }
            return openParentheses.Count == 0 ;
        }
    }
}