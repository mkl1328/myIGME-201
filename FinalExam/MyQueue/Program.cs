using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Enqueue(10);
            Console.WriteLine("Enqueue 10");
            queue.Enqueue(20);
            Console.WriteLine("Enqueue 20");
            queue.Enqueue(30);
            Console.WriteLine("Enqueue 30");
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
        }
    }

    public class MyQueue
    {
        List<int> queue = new List<int>();

        public void Enqueue(int val)
        {
            queue.Add(val);
        }

        public int Dequeue()
        {
            int val = queue[0];
            queue.RemoveAt(0);
            return val;

        }

        public int Peek()
        {
            return queue[0];
        }
    }
}
