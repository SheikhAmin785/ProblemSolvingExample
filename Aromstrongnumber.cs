using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class Aromstrongnumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, Remainder;
            for (int i = n; i > 0; i = i / 10)
            {
                Remainder = i % 10;
                sum = sum + Remainder * Remainder * Remainder;
            }
            if (sum == n)
            {
                Console.WriteLine("enter number is armstrong number");
            }
            else
            {
                Console.WriteLine("enter the number is not armstrong number");
            }
        }
    }
}
