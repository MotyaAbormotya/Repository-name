using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_New_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            CalculatingDaysForNewYear(days, month);
            Console.ReadKey();
        }

        public static int CalculatingDaysForNewYear(int days, int month)
        {
            int daysInYear = 365;
            int daysForNewYear = daysInYear - ((30 * (month - 1)) + days + (month / 2 - 1));
            Console.WriteLine(daysForNewYear);
            return (daysForNewYear);
        }
    }
}
