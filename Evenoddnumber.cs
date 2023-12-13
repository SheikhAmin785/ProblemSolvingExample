using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Evenoddnumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }
    }
}
