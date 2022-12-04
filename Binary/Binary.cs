using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    public class Binary
    {
        public static List<string> Generate(int num) 
        {
            List<string> answer = new List<string>();
            answer.Add(Convert.ToString(num, 2));
            int bit_count = num == 0 ? 1 : (int)Math.Ceiling(Math.Log(num + 1, 2));
            for (int i = 0; i < bit_count; i++)
                answer.Add(Convert.ToString(num ^ (1 << i), 2));

            return answer;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                List<string> strings = Generate(number);
                foreach(string s in strings)
                    Console.WriteLine(s);

                Console.WriteLine();
            }
        }
    }

}
