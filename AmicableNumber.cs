using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class AmicableNumber
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for(int j = 0; j < n2; j++)
            {
                if (n2 % j == 0)
                {
                    sum2 = sum2 + j;
                }
            }
            if (n1 == sum2 && n2 == sum1)
            {
                Console.WriteLine("they are a pair of amicable number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("they are not amicable number");
                Console.ReadLine();
            }
        }
    }
}
