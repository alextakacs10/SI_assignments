﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("Fourth");

            while (myQueue.Count > 0)
            {
                object obj = myQueue.Dequeue();
                Console.WriteLine("Dequeued item: {0}", obj);
            }

            Stack myStack = new Stack();
            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");
            myStack.Push("Fourth");

            while (myStack.Count > 0)
            {
                object obj = myStack.Pop();
                Console.WriteLine("Popped item: {0}", obj);
            }

            Console.ReadKey();
        }
    }
}
