using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTryParse = false;
            int Parsenumber;
                do
                {
                    string TryNumber = Console.ReadLine();
                    isTryParse = int.TryParse(TryNumber, out Parsenumber);

                } while (isTryParse != true);
        }
    }
}
