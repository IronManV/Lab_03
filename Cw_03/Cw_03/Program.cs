using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "i feel it in my fingers";
            int counted = CountWords(text);

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Words count: " + counted);

            Console.ReadKey();
        }
        static int CountWords(string text)
        {
            string[] textAsArray = text.Split(' ');
            return textAsArray.Length;
        }
    }
}
