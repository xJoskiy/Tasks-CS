using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beads
{
    internal class Beads
    {
        private static ulong Calculate(uint N)
        {
            if (N == 1)
                return 3;
            else if (N % 2 == 0)
                return 2 * Calculate(N - 1);
            else
                return 5 * Calculate(N - 1) / 2;
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter a natural number: ");
                if (uint.TryParse(Console.ReadLine(), out uint N))
                    Console.WriteLine("Total possible beads: " + Calculate(N).ToString() + "\n");
                else
                    Console.WriteLine("Entered number is not a natural one\n");
            }
        }
    }
}
