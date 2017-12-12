using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread firstThread = new Thread(starter);
            Thread secondThread = new Thread(starter);

            firstThread.Start();
            secondThread.Start();

            firstThread.Join();
            secondThread.Join();

            Console.Read();
        }

        public static void Counting()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Count: {0} - On thread #{1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            }
        }
    }
}
