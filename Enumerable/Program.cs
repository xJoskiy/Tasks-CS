using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class Permutations : IEnumerable
    {
        StringBuilder initValue = new StringBuilder();
        public Permutations(int N)
        {
            initValue.Append('A', N);
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
