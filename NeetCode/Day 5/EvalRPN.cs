namespace Problem_Solving.NeetCode.Day_5
{
    internal class EvalRPN
    {
        //Console.WriteLine(EvalRPN(["1", "2", "+", "3", "*", "4", "-"]));//5



        //Input: tokens = ["1", "2", "+", "3", "*", "4", "-"]

        //Output: 5

        //Explanation: ((1 + 2) * 3) - 4 = 5

        //public static int EvalRPN(string[] tokens)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    foreach (string token in tokens)
        //    {
        //        if (int.TryParse(token, out int number))
        //            stack.Push(number);
        //        else
        //        {
        //            int a, b;
        //            b = stack.Pop();
        //            a = stack.Pop();
        //            stack.Push(token switch
        //            {
        //                "+" => a + b,
        //                "-" => a - b,
        //                "/" => a / b,
        //                "*" => a * b
        //            });
        //        }
        //    }
        //    return stack.Pop();
    }
}
}
