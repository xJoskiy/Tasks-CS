using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class Permutations : IEnumerable<string>
    {
        private int count;

        public Permutations(int N) => count = N;

        public IEnumerator<string> GetEnumerator() => new PermutationsEnum(count);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public class PermutationsEnum : IEnumerator<string>
        {
            int count;

            public PermutationsEnum(int N) { count = N; Init(); }

            public StringBuilder Current;

            object IEnumerator.Current => Current.ToString();

            string IEnumerator<string>.Current => Current.ToString();

            public bool MoveNext() => Add(count - 1);

            public void Reset() => Init();

            private void Init()
            {
                Current = new StringBuilder();
                Current.Append('A', count - 1);
                Current.Append('@');
            }
            private bool Add(int i)
            {
                if (i == -1)
                    return false;
                if (Current[i] != 'Z')
                {
                    Current[i] = (char)(Current[i] + 1);
                    return true;
                }
                else
                {
                    Current[i] = 'A';
                    return Add(i - 1);
                }
            }

            public void Dispose() { }
        }
    }
    public class Enumerable
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the size of sequence: ");
                int size = int.Parse(Console.ReadLine());

                Permutations permutation = new Permutations(size);

                foreach (var item in permutation)
                    Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }


}
