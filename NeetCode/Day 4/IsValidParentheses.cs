namespace Problem_Solving.NeetCode.Day_4
{
    internal class IsValidParentheses
    {

        //IsValid("(])");

        //public static bool IsValid(string s)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        //        {
        //            stack.Push(s[i]);
        //        }
        //        else
        //        {
        //            if (stack.Count == 0) return false;

        //            char top = stack.Pop();
        //            if ((top == '(' && s[i] != ')') ||
        //                (top == '{' && s[i] != '}') ||
        //                (top == '[' && s[i] != ']'))
        //                return false;
        //        }
        //    }
        //    return stack.Count == 0;
    }
}
//}
