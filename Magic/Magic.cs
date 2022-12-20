
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    public class Magic
    {
        public static bool isMagic(int[,] list)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < 9; i++)
                tempList.Add(list[i / 3, i % 3]);

            if (!new HashSet<int>(tempList).SetEquals(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }))
                return false;

            if (list[1, 1] != 5)
                return false;


            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                    sum += list[i, j] + list[i, j];

                if (sum != 30)
                    return false;
            }

            return true;
        }

        static void PrintAs2D(int[,] list)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(list[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        public static int[,] Generate(int number, int first, int second)
        {
            int[,] list = new int[3, 3];

            list[0, 0] = first;
            list[0, 1] = second;
            list[0, 2] = 15 - first - second;
            list[1, 0] = 20 - 2 * first - second;
            list[1, 1] = number;
            list[1, 2] = 2 * first + second - 10;
            list[2, 0] = first + second - 5;
            list[2, 1] = 10 - second;
            list[2, 2] = 10 - first;

            return list;
        }
        
        public static List<int[,]> GetAllMagics(int number)
        {
            int[,] list;
            List<int[,]> magicSquares = new List<int[,]>();
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    if (isMagic(list = Generate(number, i, j)))
                        magicSquares.Add(list);
            return magicSquares;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to generate magic square: ");
            int number = int.Parse(Console.ReadLine());
            List<int[,]> magicSquares = GetAllMagics(number);

            if (magicSquares.Count > 0)
                for (int i = 0; i < magicSquares.Count; i++)
                    PrintAs2D(magicSquares[i]);
            else
                Console.WriteLine("There are no such magic squares");

            Console.ReadKey();
        }
    }
}
