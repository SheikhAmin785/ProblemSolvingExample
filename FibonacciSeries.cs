using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class FibonacciSeries
    {
        static void Main()  // (0 1 1 2 3 5 8 13) f1=0 f2=1 f3=0 f3=f1+f2 f1=f2 f2=f3
        {
            int f1 = 0, f2 = 1;
            int f3 = 0;
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 0; i <= n; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
        static int Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);

        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(""+Fibonacci(i));
            }
            Console.ReadLine();
        }
    }
}

