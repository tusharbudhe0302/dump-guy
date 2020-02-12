using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class Queue
    {
        /*
        * FIFO = First In First Out
        * Insertion allow at one end - Front
        * Deletion allow at one end - Rear
        */
        private int[] queueArray;
        private int front;
        private int rear;
        public Queue()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }
        public Queue(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }
        public bool isEmpty()
        {
            return (front == -1 || front == rear - 1);
        }
        public int size()
        {
            return rear + 1;
        }
        public bool isFull()
        {
            return (rear == queueArray.Length - 1);
        }
        public void queue(int item)
        {
            if (isFull())
            {
                Console.WriteLine("Queue Over flow!");
                return;
            }
            front = 0;
            rear++;
            queueArray[rear] = item;
        }
        public int deQueue()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            if (front == 0)
            {
                front--;
            }
            x = queueArray[rear];
            rear--;
            return x;

        }
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return queueArray[rear];
        }
    }
}
