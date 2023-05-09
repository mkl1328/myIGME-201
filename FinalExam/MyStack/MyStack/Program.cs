using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(10);
            Console.WriteLine(stack.Peek());
            stack.Push(20);
            Console.WriteLine(stack.Peek());
            stack.Push(30);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }

    public class MyStack
    {
        List<int> stack = new List<int>();

        public void Push(int val)
        {
            stack.Add(val);
        }

        public int Pop()
        {
            int val = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return val;

        }

        public int Peek()
        {
            int val = stack[stack.Count - 1];
            return val;
        }
    }
}
