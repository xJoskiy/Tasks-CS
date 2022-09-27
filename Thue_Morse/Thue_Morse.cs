using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thue_Morse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number of steps: ");

                int steps = int.Parse(Console.ReadLine());
                string init = "0";
                for (int i = 0; i < steps - 1; i++)
                    for (int j = 0; j < Math.Pow(2, i); j++)
                        init += init[j] == '0' ? "1" : "0";

                Console.WriteLine(init + "\n");
            }
        }

    }
}
