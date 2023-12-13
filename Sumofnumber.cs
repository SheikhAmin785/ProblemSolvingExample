using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Sumofnumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
