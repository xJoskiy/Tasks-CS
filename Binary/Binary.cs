using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Binary
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int mask = 1, number = int.Parse(Console.ReadLine());
                int bit_count = number == 0 ? 1 : (int)Math.Ceiling(Math.Log(number + 1, 2));
                Console.WriteLine(number.ToString() + " " + Convert.ToString(number, 2));
                for (int i = 0; i < bit_count; i++)
                {
                    int num = number ^ (mask << i);
                    Console.WriteLine(num.ToString() + " " + Convert.ToString(num, 2));
                }
                Console.WriteLine();
            }
        }
    }

}
