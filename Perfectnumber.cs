using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Perfectnumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }

            }
            if (sum == num)
            {
                Console.WriteLine("\n enter the number is perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n enter the number is not perfect number");
                Console.ReadLine();
            }
        }
    }
}
