using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExample
{
    class ConditionalLogical
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            bool adult = age >= 18 ? true : false;
            Console.WriteLine(adult);
            Console.ReadLine();
        }
    }
}
