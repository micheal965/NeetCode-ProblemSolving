namespace Problem_Solving.NeetCode.Day_5
{
    internal class StackMethods
    {
        public class MinStack
        {
            private Stack<int> stack;

            public MinStack()
            {
                stack = new Stack<int>();
            }

            public void Push(int val) => stack.Push(val);

            public void Pop() => stack.Pop();

            public int Top() => stack.Peek();

            public int GetMin()
            {
                Stack<int> tmp = new Stack<int>();
                int min = stack.Peek();
                while (stack.Count > 0)
                {
                    int val = stack.Pop();
                    if (min > val)
                        min = val;
                    tmp.Push(val);

                }
                while (tmp.Count > 0)
                    stack.Push(tmp.Pop());

                return min;

            }

        }
    }
}
