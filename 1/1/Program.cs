using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            TryParse(number);
        }

        public static int TryParse(string number)
        {
            bool isTryParse = false;
            int Parsenumber;
            isTryParse = int.TryParse(number, out Parsenumber);
            if(isTryParse == true)
            return Parsenumber;
            else
            {
                do
                {
                    string TryNumber = Console.ReadLine();
                    isTryParse = int.TryParse(TryNumber, out Parsenumber);

                } while (isTryParse != true);
                return Parsenumber;
            }
        }
    }
}
