using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEMinStack
{
    public class MinStack //: IComparable<MinStack>
    {
        int min;
        int minCheck = 0;
        Stack<int> stack = new Stack<int>();

        /** initialize your data structure here. */
        public MinStack()
        {
            //min = 0;
        }

        public void Push(int x)
        {
            if (minCheck == 0 || x < min || stack.Contains(x) != true)
            {
                min = x;
                minCheck = 1;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }
}
