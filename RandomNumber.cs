using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class RandomNumber
    {
        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("some random number that are generate are");
            for(int i = 0; i < 10; i++)
            {
                Randfunc();
            }
        }
    }
}
