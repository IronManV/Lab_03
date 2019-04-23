using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj dlugosc ciagu fibonacciego");
            string num = Console.ReadLine();
            Int32.TryParse(num, out int n);

            long fib = Fibonacci(n);
            Console.WriteLine(fib);
            Console.ReadKey();
        }
        static long Fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
