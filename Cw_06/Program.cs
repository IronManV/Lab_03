using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4,5,6},
                new int[] {7,8,9}
            };
            int supp = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    supp += jaggedArray[i][j];
                }
            }
            Console.WriteLine("Suma elementow jagged array: {0}", supp);
            Console.ReadKey();
        }
    }
}
