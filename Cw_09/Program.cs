using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;

            Console.WriteLine("Podaj pierwszą zmienną: ");
            string str1 = Console.ReadLine();
            Int32.TryParse(str1, out var1);

            Console.WriteLine("Podaj drugą zmienną: ");
            string str2 = Console.ReadLine();
            Int32.TryParse(str2, out var2);

            if(var2 > var1)
            {
                Console.WriteLine("Druga zmienna jeste wieksza od pierwszej var2 > var1");
            }
            
            Console.ReadKey();
        }
    }
}
