using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
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
                if (char.IsLetter(text[i]) == true)
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