using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueMorse
{
    public class ThueMorse
    {
        public static string Generate(int N)
        {
            StringBuilder init = new StringBuilder("0");

            for (int i = 0; init.Length < N; i++)
                for (int j = 0; j < Math.Pow(2, i); j++)
                    init.Append(init[j] == '0' ? "1" : "0");

            init.Remove(N, init.Length - N);

            return init.ToString();
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                int steps;
                do
                {
                    Console.Write("Enter number of steps: ");

                    if (int.TryParse(Console.ReadLine(), out steps))
                        break;

                    Console.WriteLine("Your input is not an natural number, try again");

                } while (true);

                Console.WriteLine(Generate(steps) + "\n");
            }
        }

    }
}
