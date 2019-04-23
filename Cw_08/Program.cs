using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;

            Console.WriteLine("Podaj ilosc towaru: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out quantity);

            if(quantity < 10)
            {
                Console.WriteLine("5% zniżki");
            }
            else if (quantity < 50)
            {
                Console.WriteLine("10% zniżki");
            }
            else if (quantity < 100)
            {
                Console.WriteLine("15% zniżki");
            }
            else
            {
                Console.WriteLine("20% zniżki");
            }

            Console.ReadKey();
        }
    }
}
