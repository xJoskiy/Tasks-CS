using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Matrix
    {
        public static void Rotate(int[,] arr)
        {
            int dim = arr.GetLength(0);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim / 2; j++)
                {
                    if (i != j && j != dim - i - 1)
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, dim - j - 1];
                        arr[i, dim - j - 1] = temp;
                    }
                }
            }
        }
        public static void Initialize(out int[,] arr, int dim = 3)
        {
            arr = new int[dim, dim];
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                    arr[i, j] = i * dim + j + 1;
        }
        public static void Print(int[,] arr)
        {
            int N = arr.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(arr[i, j].ToString() + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Transpose(int[,] arr)
        {
            int N = arr.GetLength(0);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < i; j++)
                {
                    if (i != j && j != N - i - 1)
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[j, i];
                        arr[j, i] = temp;
                    }
                }
        }
        public static void Main(string[] args)
        {
            int[,] arr = null;
            Console.Write("Enter dimensionality >= 3: ");
            int dim = int.Parse(Console.ReadLine());
            
            Initialize(out arr, dim);

            Print(arr);

            Transpose(arr);

            Print(arr);

            Rotate(arr);

            Print(arr);

            Console.ReadKey();
        }
    }
}
