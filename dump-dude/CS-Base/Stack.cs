using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class Stack
    {
        /*
        * LIFO : Last in first out
        * Insertion and deletion allow at one end only
        */
        private int[] stackArray;
        private int top;
        public Stack()
        {
            stackArray = new int[10];
            top = -1;
        }
        public Stack(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }
        public int size()
        {
            return top + 1;
        }
        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
        public void push(int item)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Over flow!");
                return;
            }
            top++;
            stackArray[top] = item;
        }
        public int pop()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            x = stackArray[top];
            top--;
            return x;

        }
        public void peek(int item)
        {
            int i = 0;
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            for (i = 0; i < stackArray.Length; i++)
            {
                if (stackArray[i] == item)
                {

                    break;
                }
            }
            if (i > 0)
            {
                Console.WriteLine("Item found in array at " + i + " position ");
                return;
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
