using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Binary
    {
        static void Generate(int num)  //to string
        {
            Console.WriteLine(num.ToString() + " " + Convert.ToString(num, 2));
            int bit_count = num == 0 ? 1 : (int)Math.Ceiling(Math.Log(num + 1, 2));
            for (int i = 0; i < bit_count; i++)
            {
                int number = num ^ (1 << i);
                Console.WriteLine(number.ToString() + " " + Convert.ToString(number, 2));
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                Generate(number);
                Console.WriteLine();
            }
        }
    }

}
