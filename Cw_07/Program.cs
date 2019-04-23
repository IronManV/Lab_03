using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] musicBands = new string[][]
            {
                new string[] {"Anna", "Jan", "Tomasz" },
                new string[] {"Marcin", "Magda" },
                new string[] {"Monika", "Grzegorz", "Ala", "Natalia" }
            };

            for (int i = 0; i < musicBands.Length; i++)
            {
                Console.Write("Zespol nr {0}: ", i);
                for (int j = 0; j < musicBands[i].Length; j++)
                {
                    Console.Write(musicBands[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
