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
                Console.WriteLine("The queue is full. You cannot enqueue more elements.");
                return;
            }
            queueArray[++rear] = value;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty. You cannot dequeue any element.");
                return -1; // Return value to indicate an error
            }
            int temp = queueArray[front++];
            return temp;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty. You cannot peek at any element.");
                return -1; // Return value to indicate an error
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
