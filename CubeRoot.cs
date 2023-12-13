using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class CubeRoot
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double result = Math.Ceiling(Math.Pow(n, (double)1 / 3));
            Console.WriteLine("cube root"+result);
        }
    }
}
