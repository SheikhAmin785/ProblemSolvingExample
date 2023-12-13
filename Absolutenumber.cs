using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Absolutenumber
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                n = n * -1;
            }
            Console.WriteLine("absolute value"+n);
            Console.ReadLine();
        }
    }
}
