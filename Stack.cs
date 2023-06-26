using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_stack
{
    internal class StackCustom<T>
    {
        private static int size = 100;
        private T[] arr = new T[size];
        private int top = 0;
        private int capasity = size;

        public void Push(T number)
        {
            if (isFull())
                Console.WriteLine("Stack is full");
            arr[++top] = number;
            Console.WriteLine("Number " + number + " was insert");
        }
        public T Pop()
        {
            if (isEmpty())
            {
                System.Environment.Exit(0); 
                Console.WriteLine("Stack is full");
            } 
            else Console.WriteLine("Removed " + Peek());
            return arr[--top];
        }
        public T Peek()
        {
            if (!isEmpty())
                return arr[top];
            else System.Environment.Exit(0); Console.WriteLine("ERROR"); return default(T);
        }
        public int Count() => top;
        public bool isFull() => top == capasity - 1;
        public bool isEmpty() => top == -1;
    }
}
