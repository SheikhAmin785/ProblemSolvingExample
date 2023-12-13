using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class PositiveNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("this is positve number");
            }
            else if(n==0)
            {
                Console.WriteLine("this is negative number");
            }
            else 
            {
                Console.WriteLine("numver is negative");
            }
            Console.ReadLine();
        }
    }
}
