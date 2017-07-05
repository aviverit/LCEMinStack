using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEMinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack mS = new MinStack();

            mS.Push(-2);
            Console.WriteLine(mS.Top());

            mS.Push(0);
            Console.WriteLine(mS.Top());

            mS.Push(-3);
            Console.WriteLine(mS.Top());

            Console.WriteLine(mS.GetMin());

            mS.Pop();
            Console.WriteLine(mS.Top());

            Console.WriteLine(mS.GetMin());

            Console.ReadLine();
        }
    }
}
