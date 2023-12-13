using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class EvenorOdd
    {
        static void Evenorodd()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("this is even number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("this is odd number");
                Console.Read();
            }
        }
    }
}
