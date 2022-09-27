using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Numbers_Tests
    {
        static void Main(string[] args)
        {
            Numbers.HashInit();
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Numbers.Convert(i, "female");
                Console.WriteLine(" " + i.ToString());
            }

            Console.ReadKey();

            //Numbers numbers = new Numbers();    
        }
    }
}
