
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void EmptyStackPop()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            try
            {
                stack.Pop();
            }
            catch (System.InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "Stack is empty");
            }
        }

        [TestMethod]
        public void EmptyStackPeek()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            try
            {
                stack.Peek();
            }
            catch (System.InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "Stack is empty");
            }
        }

        [TestMethod]
        public void Push()
        {
            Stack.Stack<uint> stack = new Stack.Stack<uint>();
            const int len = 5;
            for (uint i = 0; i < len; i++)
            {
                stack.Push(i);
                Assert.AreEqual((i + 1), stack.Size);
            }
        }

        [TestMethod]
        public void Sequence()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            const int len = 5;
            int[] expected = new int[len] { 0, 1, 2, 3, 4 };

            for (int i = 0; i < len; i++)
                stack.Push(i);

            for (int i = 0; i < len; i++)
                Assert.AreEqual(expected[len - i - 1], stack.Pop());

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void SequenceOverflow()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            try
            {
                const int len = 11;
                for (int i = 0; i < len; i++)
                    stack.Push(i);
            }
            catch (System.InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "Stack overflow");
            }
        }

        [TestMethod]
        public void FullPeek()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            const int len = 10;

            for (int i = 0; i < len; i++)
                stack.Push(i);

            Assert.AreEqual(len - 1, stack.Peek());
        }

        [TestMethod]
        public void PushPop()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();
            const int len = 5;

            for (int i = 0; i < len; i++)
            {
                stack.Push(i);
                stack.Pop();
            }

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void Perfomance()
        {
            Stack.Stack<int> stack = new Stack.Stack<int>();

            for (int i = 0; i < 1_000_000; i++)
            {
                stack.Push(i);
                stack.Pop();
            }
        }


    }
}
