using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            CutLetter(text);
            Console.ReadKey();
        }

        public static string CutLetter(string text)
        {

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] % 2 != 0)
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(text);
            return text;

        }
    }
}
