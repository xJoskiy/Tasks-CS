using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasAndDelegates
{
    class MyClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Add(int a, int b) => a + b;
    }
    internal class Program
    {
        public static int Pow(int x, int pow)
        {
            return Pow2(x, pow, 1);
        }

        public static int Pow2(int x, int pow, int acc)
        {
            if (pow == 1) return 1;
            if (pow % 2 == 0) return Pow2(x, pow / 2, 1);
            return Pow2(x, pow - 1, acc * x);
        }

        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = new Func<int, int, int>(new MyClass().Add);
            int res = myDelegate(1, 3);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
