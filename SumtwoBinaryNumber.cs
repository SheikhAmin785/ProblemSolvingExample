using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class SumtwoBinaryNumber
    {
        static void Main()
        {
            int i = 0;
            int rem = 0;
            int[] sum = new int[100];
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            while (b1 != 0 || b2 != 0)
            {
                sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
                rem = (b1 % 10 + b2 % 10 + rem) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;

            }
            if (rem != 0)
            {
                sum[i++] = rem;
                --i;
                Console.WriteLine("sum of two binary number");
                while (i >= 0)
                {
                    Console.WriteLine("{0}",sum[i--]);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
