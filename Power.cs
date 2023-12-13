using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Power
    {
        static void main()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            double number = Math.Sqrt(n);
            Console.WriteLine("square root of{0}:and {1}",n,number);
        }
    }
}
