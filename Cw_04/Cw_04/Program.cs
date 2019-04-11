using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            long fctrl = Factorial(n);

            Console.WriteLine("the factorial of {0} rquals {1}.", n ,fctrl);
            Console.ReadKey();
        }
        static long Factorial(int n)
        {
            if (n <= 1) return 1;

            return n * Factorial(n - 1);
        }
    }
}
