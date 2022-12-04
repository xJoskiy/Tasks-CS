using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private T[] stack;
        private const int initSize = 10;
        public uint Size { get; private set; }
        public bool IsEmpty => Size == 0;

        public Stack()
        {
            stack = new T[initSize];
            Size = 0;
        }

        public void Push(T el)
        {
            if (Size == 10)
                throw new InvalidOperationException("Stack overflow");
            stack[Size++] = el;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T temp = stack[Size-- - 1];

            return temp;
        }
        public T Peek()
        {
            if (Size == 0)
                throw new InvalidOperationException("Stack is empty");
            return stack[Size - 1];
        }
    }
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.ReadKey();
        }
    }
}
