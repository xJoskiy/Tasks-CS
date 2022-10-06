using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private T[] stack;
        private const int initSize = 10;
        private uint size;
        public Stack()
        {
            stack = new T[initSize];
            size = 0;
        }

        public void Push(T el)
        {
            if (size == 10)
                throw new InvalidOperationException("Stack overflow");
            stack[size++] = el;
        }
        public T Pop()
        {
            if (size == 0)
                throw new InvalidOperationException("Stack is empty");
            T temp = stack[size-- - 1];

            return temp;
        }
        public T Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Stack is empty");
            return stack[size - 1];
        }
        public uint GetSize()
        {
            return size;
        }
    }
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Pop();

            Console.ReadKey();
        }
    }
}
