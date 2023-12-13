using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class MiltipltThreeand_Five
    {
        static void Main()
        {
            int a, b, sum = 0;
            for (int i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    Console.WriteLine(" ", i);
                    sum = sum + i;
                }
                Console.WriteLine(" The Sum of all the Multiples of 3 or 5 Below 100", sum);
                Console.Read();
            }
        }
    }
}
