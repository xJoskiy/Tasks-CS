using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beads
{
    internal class Beads
    {
        private static ulong Calculate(int N, int red, int blue, int green)
        {
            if (N == 1)
                return (ulong)(red % 1 + blue % 1 + green % 1);
            else if (N % 2 == 0)
                return 2 * Calculate(N - 1, red, blue, green);
            else
                return 5 * Calculate(N - 1, red, blue, green) / 2;
        }
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter a natural number: ");
                int red = int.Parse(Console.ReadLine());
                int blue = int.Parse(Console.ReadLine());
                int green = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int N))
                    Console.WriteLine("Total possible beads: " + Calculate(N, red, blue, green).ToString() + "\n");
                else
                    Console.WriteLine("Entered number is not a natural one\n");
            }
        }
    }
}
