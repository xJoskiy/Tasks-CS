using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beads
{
    public class Beads
    {
        public static int Calculate(int N, int red, int blue, int green, int curLen = 0, bool prevIsRed = false)
        {
            int total = 0;
            if (curLen == N)
                return 1;

            if (red > 0 && curLen % 2 == 0)
                total += Calculate(N, red - 1, blue, green, curLen + 1, true);
            if (blue > 0 && !prevIsRed)
                total += Calculate(N, red, blue - 1, green, curLen + 1);
            if (green > 0)
                total += Calculate(N, red, blue, green - 1,  curLen + 1);


            return total;
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
