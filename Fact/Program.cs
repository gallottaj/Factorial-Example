using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer. I will calculate the factorial and show you my thought process.");
            int startingNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(startingNumber));
            Console.ReadLine();
        }
        static int factorial (int x)
        {
            Console.WriteLine("X = " + x);
            if (x == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("Calculating factorial for " + x + " * factorial ( " + (x - 1) + ")");
                return x * factorial(x - 1);
            }
        }
    }
}
