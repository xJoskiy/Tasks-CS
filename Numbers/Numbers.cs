using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Numbers
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

        private static Hashtable numsHt = new Hashtable();

        public static void HashInit()
        {
            for (int i = 0; i < numsInt.Length; i++)
                numsHt.Add(numsInt[i], numsStr[i]);
        }
        public static void Main(string[] args)
        {
            string[] sexArr = { "male", "female" };
            string input, sex;
            int number;
            do
            {
                do
                {
                    Console.Write("Enter a natural number less than 10^9: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out number) && number >= 0 && number <= (int)Math.Pow(10, 9))
                        break;
                    else
                    {
                        Console.WriteLine("Your string is not an natural number" +
                        " or is greater than 10^9, try again\n");
                    }
                } while (true);

                do
                {
                    Console.Write("\nAnd sex, male or female: ");
                    sex = Console.ReadLine();
                    if (sexArr.Contains(sex.ToLower()))
                        break;
                    else
                        Console.WriteLine("Your string doesn't contain male/female");

                } while (true);

                Console.Write("\nIn words: ");
                Console.Write(Convert(number, sex));
                Console.WriteLine("\n");
            } while (true);
        }
        public static string Convert(int num, string sex)
        {
            StringBuilder ans = new StringBuilder();
            if (numsHt.Count == 0)
                HashInit();
            if (num == 0)
                return (string)numsHt[0];
            int exp = (int)1e6, quot = num / exp;
            if (quot != 0)
            {
                if (quot == 1)
                    ans.Append("Un Millon ");
                else
                {
                    ans.Append(ConvertPart(quot, sex));
                    ans.Append("Millones ");
                }
            }
            num %= exp; quot = num / (int)Math.Pow(10, 3);
            if (quot > 0)
            {
                ans.Append(ConvertPart(quot, sex));
                ans.Append("Mil ");
            }
            ans.Append(ConvertPart(num % (int)Math.Pow(10, 3), sex));

            return ans.ToString();
        }
        public static string ConvertPart(int num, string sex)
        {
            StringBuilder ans = new StringBuilder();
            int quot = num / 100;

            if (quot >= 1)
            {
                ans.Append(numsHt[quot * 100]);
                if (quot > 1 && quot < 10)
                    ans.Append((sex == "male" ? "os" : "as"));
                ans.Append(" ");
            }

            num %= 100; quot = num / 10;
            int remainder = num % 10;
            if (num >= 30)
            {
                ans.Append(numsHt[quot * 10] + " ");
                if (remainder != 0)
                {
                    ans.Append("y ");
                    if (remainder == 1)
                        ans.Append(sex == "male" ? "Un" : "Una" + " ");
                    else
                        ans.Append(numsHt[remainder] + " ");
                }
            }
            else if (num >= 21)
            {
                ans.Append("Veinti");
                if (num == 21)
                    ans.Append((sex == "male" ? "un" : "una") + " ");
                else
                    ans.Append(numsHt[remainder].ToString().ToLower() + " ");
            }
            else if (num != 0)
            {
                if (remainder != 1)
                    ans.Append(numsHt[num] + " ");
                else
                    ans.Append((sex == "male" ? "Un" : "Una") + " ");
            }

            return ans.ToString();
        }
    }
}