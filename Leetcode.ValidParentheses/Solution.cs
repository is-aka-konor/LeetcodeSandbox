namespace Leetcode.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            // cut off simple cases
            var length = s.Length;
            if (length == 0) return true;
            if (length % 2 != 0) return false;
            if (s[0] == ')' || s[0] == ']' || s[0] == '}'
                || s[length - 1] == '(' || s[length - 1] == '[' || s[length - 1] == '{')
            {
                return false;
            }

            var stack = new Stack<char>(length);
            for (var i = 0; i < length; ++i)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    var top = stack.Pop();
                    if ((s[i] == ')' && top != '(')
                        || (s[i] == '}' && top != '{')
                        || (s[i] == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
