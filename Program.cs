using System;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Element at the front of the queue: " + queue.Peek());

            Console.WriteLine("Dequeuing elements:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

    }
}
