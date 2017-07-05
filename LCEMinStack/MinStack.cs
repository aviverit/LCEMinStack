using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEMinStack
{
    public class MinStack
    {
        int min;
        List<int> stack = new List<int>();

        /** initialize your data structure here. */
        public MinStack()
        {
            min = 0;
        }

        public void Push(int x)
        {
            if (min == null || x < min || stack.Contains(x) != true)
            {
                min = x;
            }
            stack.Add(x);
        }

        public void Pop()
        {
            stack.Remove(stack.Count());
        }

        public int Top()
        {
            return stack.ElementAt(stack.Count()-1);
        }

        public int GetMin()
        {
            return min;
        }
    }
}
