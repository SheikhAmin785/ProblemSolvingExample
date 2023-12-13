using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class ReverseNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int R = 0;
            while (n != 0)
            {
                R = R * 10;
                R = R + n % 10;
                n = n / 10;
            }
            Console.WriteLine("reverse of enter number is:"+R);
            Console.ReadLine();
        }
    }
}
