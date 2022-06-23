//taken from below. tbf i hadnt used stack before and didnt think of it..
//https://www.c-sharpcorner.com/article/valid-parentheses/#:~:text=C%20%2D%20Good%20Solution-,A%20%2D%20Question,closed%20in%20the%20correct%20order.

namespace LeetCodeTests.Easy
{
    internal class IsValid
    {
        public bool CheckIsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            var chars = s.ToCharArray();

            if (chars.Count() % 2 != 0)
                return false;

            foreach (char c in chars)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count != 0 && (char)stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count != 0 && (char)stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count != 0 && (char)stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false; // no match
                }
            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}