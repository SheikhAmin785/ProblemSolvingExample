using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class LagestofTwonumbers
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

      
            if (a>b)
            {
                Console.WriteLine("{0} is the greatest number",a);
            }
            else
            {
                Console.WriteLine("{0}is the greatest number",b);
            }
        }
    }
}
