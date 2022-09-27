using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Numbers
    {
        private static string[] numsStr = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince",
                                 "Dieciséis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa",
                                 "Ciento", "Doscient", "Trescient", "Cuatrocient", "Quinient", "Sescient", "Setecient", "Ochocient", "Novecient",
                                 "Mil"
                                };
        private static int[] numsInt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                              15, 16, 17, 18, 19, 20, 30, 40, 50, 60, 70, 80, 90,
                              100, 200, 300, 400, 500, 600, 700, 800, 900, 1000
                            };
        private static string[] sexArr = { "Un", "Una" };
        private static Hashtable numsHt = new Hashtable();
        public Numbers()
        {
            HashInit();
            string input, sex;
            Console.WriteLine("Type 'exit' to stop the program");
            do
            {
                Console.Write("Enter the number: ");
                input = Console.ReadLine();
                Console.Write("And sex, male or female: ");
                sex = Console.ReadLine();

                if (int.TryParse(input, out int number) && number >= 0)
                {
                    Console.Write("In words: ");
                    Convert(number, sex);
                    Console.WriteLine("\n");
                }
                else
                    Console.WriteLine("Your string is not an natural number" +
                        " or is greater than 10^9, try again\n");


            } while (input != "exit");
        }
        public static void Convert(int num, string sex, int pow = 6)
        {
            int exp = (int)Math.Pow(10, pow);
            int quot = num / exp;
            int remainder = num % exp;

            if (num == 0)
            {
                Console.Write(numsHt[num] + " ");
                return;
            }
            
            switch (exp)
            {
                case 1_000_000:
                    if (quot == 1)
                        Console.Write("Un millon ");
                    else if (quot > 1)
                    {
                        Convert(quot, sex, pow - 3);
                        Console.Write("Millones ");
                    }
                    if (remainder != 0)
                        Convert(num % exp, sex, pow - 3);
                    break;

                case 1000:
                    if (quot > 1)
                        Convert(quot, sex, pow - 1);
                    if (quot >= 1)
                        Console.Write(numsHt[exp] + " ");
                    if (remainder != 0)
                        Convert(num % exp, sex, pow - 1);
                    break;

                case 100:
                    if (quot >= 1)
                        Console.Write(numsHt[quot * exp] + " ");
                    if (remainder != 0)
                        Convert(num % exp, sex, pow - 1);
                    break;

                case 10:
                    if (num >= 30)
                    {
                        Console.Write(numsHt[quot * exp] + " ");
                        if (remainder != 0)
                        {
                            Console.Write("y ");
                            if (remainder == 1)
                                Console.Write(sexArr[sex == "male" ? 0 : 1] + " ");
                            else
                                Console.Write(numsHt[remainder] + " ");
                        }
                    }
                    else if (num >= 21)
                    {
                        
                        Console.Write("Veinti");
                        if (num == 21)
                            Console.Write(sexArr[sex == "male" ? 0 : 1].ToString().ToLower() + " ");
                        else
                            Console.Write(numsHt[remainder].ToString().ToLower() + " ");
                    }
                    else
                    {
                        if (remainder != 1)
                            Console.Write(numsHt[num] + " ");
                        else
                            Console.Write(sexArr[sex == "male" ? 0 : 1] + " ");
                    }
                    break;
            }
        }
        public static void HashInit()
        {
            for (int i = 0; i < numsInt.Length; i++)
                numsHt.Add(numsInt[i], numsStr[i]);
        }
    }
}
