using System;

namespace Queue
{
    internal class Queue
    {
        private int maxSize;
        private int front;
        private int rear;
        private int[] queueArray;

        public Queue(int size)
        {
            maxSize = size;
            queueArray = new int[maxSize];
            front = 0;
            rear = -1;
        }

        public void Enqueue(int value)
        {
            if (rear == maxSize - 1)
            {
                Console.WriteLine("La cola está llena. No se puede encolar más elementos.");
                return;
            }
            queueArray[++rear] = value;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía. No se puede desencolar ningún elemento.");
                return -1; // Valor de retorno para indicar un error
            }
            int temp = queueArray[front++];
            return temp;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía. No se puede consultar ningún elemento.");
                return -1; // Valor de retorno para indicar un error
            }
            return queueArray[front];
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public int Size()
        {
            return rear - front + 1;
        }
    }
}
