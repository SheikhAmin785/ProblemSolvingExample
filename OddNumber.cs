using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class OddNumber
    {
        static void Main()
        {
            IEnumerable<int> odd = Enumerable.Range(20, 30).Where(x => x % 2 != 0);

            foreach(int n in odd)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

        }
    }
}
