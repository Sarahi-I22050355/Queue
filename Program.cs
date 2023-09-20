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

            Console.WriteLine("Elemento en el frente de la cola: " + queue.Peek());

            Console.WriteLine("Desencolando elementos:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
