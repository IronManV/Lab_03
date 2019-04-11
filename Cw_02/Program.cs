using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Ttsy Bitsy Spder";
            string text2 = TrimSpaces(text1);

            Console.WriteLine("Before: "+ text1);
            Console.WriteLine("After: " + text2);
            Console.ReadKey();
        }

        static string TrimSpaces(string text)
        {
            string textWithoutSpaces = " ";

            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ' && text[i] != '\t' && text[i] != '\n')
                {
                    textWithoutSpaces += text[i];
                }
            }
        }
    }
}
